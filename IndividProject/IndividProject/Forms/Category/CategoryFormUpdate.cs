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
	public partial class CategoryFormUpdate : Form
	{
		LombardContext db = new LombardContext();

		public CategoryFormUpdate()
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

		private void CategoryFormUpdate_Load(object sender, EventArgs e)
		{
			updateDataGridView();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			int indexRow = dataGridViewShowCategory.CurrentCell.RowIndex;

			int id = Convert.ToInt32(dataGridViewShowCategory.Rows[indexRow].Cells[0].Value);

			Category category = db.Categories.Find(id);

			UpdateCategory editCategory = new UpdateCategory();

			editCategory.textBoxName.Text = category.Name; // что бы поля были видны в свойствах нужно было поменять private на internal
			editCategory.textBoxDiscription.Text = category.Discription;
			DialogResult result = editCategory.ShowDialog(this); // в свойствах DialogRisult надо указать ОК 

			if (result == DialogResult.Cancel)
				return;
			
			category.Name = editCategory.textBoxName.Text;
			category.Discription = editCategory.textBoxDiscription.Text;

			db.SaveChanges();
			updateDataGridView(); // обновляем грид
			MessageBox.Show("Объект изменён");
		}
	}
}
