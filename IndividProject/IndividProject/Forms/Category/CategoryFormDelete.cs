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

namespace IndividProject.Forms
{
	public partial class CategoryFormDelete : Form
	{
		LombardContext db = new LombardContext();
		public CategoryFormDelete()
		{
			InitializeComponent();
		}

		private void updateDataGridView()
		{
			dataGridViewShowCategory.Rows.Clear();
			dataGridViewShowCategory.SelectAll();
			dataGridViewShowCategory.ClearSelection();
			dataGridViewShowCategory.Columns.Clear();

			dataGridViewShowCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewShowCategory.Columns.Add("Column1", "Номер");
			dataGridViewShowCategory.Columns.Add("Column2", "Название");
			dataGridViewShowCategory.Columns.Add("Column3", "Описание");


			using (var context = new LombardContext())
			{
				var allCat = from query in context.Categories
							 select new
							 {
								 CategoryId = query.CategoryId,
								 Name = query.Name,
								 Discription = query.Discription
							 };

				foreach (var el in allCat.ToList())
				{
					dataGridViewShowCategory.Rows.Add(el.CategoryId, el.Name, el.Discription);
				}
			}

			dataGridViewShowCategory.AllowUserToAddRows = false;
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CategoryFormDelete_Load(object sender, EventArgs e)
		{
			updateDataGridView();
		}

		private void buttonDeleteCategory_Click(object sender, EventArgs e)
		{
			if (dataGridViewShowCategory.SelectedRows.Count > 0)
			{
				int index = dataGridViewShowCategory.SelectedRows[0].Index;
				int id = 0;
				bool converted = Int32.TryParse(dataGridViewShowCategory[0, index].Value.ToString(), out id);
				if (converted == false)
					return;
				Category category = db.Categories.Find(id);
				db.Categories.Remove(category);
				db.SaveChanges();

				MessageBox.Show("Обьект удален");
				updateDataGridView();
			}
		}
	}
}
