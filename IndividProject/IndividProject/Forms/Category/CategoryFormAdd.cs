using IndividProject.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividProject
{
	public partial class CategoryFormAdd : Form
	{
		public CategoryFormAdd()
		{
			InitializeComponent();
		}

		public void addCategory()
		{
			using (var context = new LombardContext())
			{
				var category = new Category()
				{
					Name = textBoxName.Text,
					Discription = textBoxDiscription.Text
				};
				context.Categories.Add(category);
				context.SaveChanges();
				textBoxName.Clear();
				textBoxDiscription.Clear();
			}
		}

		private void buttonAddCategory_Click(object sender, EventArgs e)
		{
			addCategory();
			updateDataGridView();
		}

		private void updateDataGridView()
		{
			dataGridViewShowCategory.Rows.Clear();
			dataGridViewShowCategory.SelectAll();
			dataGridViewShowCategory.ClearSelection();
			dataGridViewShowCategory.Columns.Clear();

			dataGridViewShowCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewShowCategory.Columns.Add("Column1", "Название");
			dataGridViewShowCategory.Columns.Add("Column2", "Описание");


			using (var context = new LombardContext())
			{
				var allCat = from query in context.Categories
							 select new
							 {
								 Name = query.Name,
								 Discription = query.Discription
							 };

				foreach (var el in allCat.ToList())
				{
					dataGridViewShowCategory.Rows.Add(el.Name, el.Discription);
				}
			}

			dataGridViewShowCategory.AllowUserToAddRows = false;
		}

		private void CategoryForm_Load(object sender, EventArgs e)
		{
			updateDataGridView();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
