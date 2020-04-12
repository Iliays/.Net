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
	public partial class FirstQuery : Form
	{
		public FirstQuery()
		{
			InitializeComponent();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonUpload_Click(object sender, EventArgs e)
		{
			dataGridViewShowQuery.Rows.Clear();
			dataGridViewShowQuery.SelectAll();
			dataGridViewShowQuery.ClearSelection();
			dataGridViewShowQuery.Columns.Clear();

			dataGridViewShowQuery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewShowQuery.Columns.Add("Column1", "Название категории");
			dataGridViewShowQuery.Columns.Add("Column2", "Фамилия клиента");
			dataGridViewShowQuery.Columns.Add("Column3", "Имя клиента");
			dataGridViewShowQuery.Columns.Add("Column4", "Отчество клиента");
			dataGridViewShowQuery.Columns.Add("Column5", "Описание");
			dataGridViewShowQuery.Columns.Add("Column6", "Дата сдачи");
			dataGridViewShowQuery.Columns.Add("Column7", "Дата возврата");
			dataGridViewShowQuery.Columns.Add("Column8", "Сумма");
			dataGridViewShowQuery.Columns.Add("Column9", "Коммисионные");

			using (var context = new LombardContext())
			{
				var query = context.Categories.Where(x => x.Name == comboBoxCategory.SelectedItem.ToString());
				int id = 0;
				foreach (var x in query.ToList())
				{
					id = x.CategoryId;
				}

				var queryFirst = from order in context.Orders
							from category in context.Categories
							from client in context.Clients
							where order.CategoryId == id && order.ClientId == client.ClientId && order.CategoryId == category.CategoryId
							select new
							{
								categoryName = category.Name,
								Surname = client.Surname,
								Name = client.Name,
								Patronimic = client.Patronimic,
								DiscriptionOrder = order.DiscriptionOrder,
								DateGive = order.DateGive,
								DateTake = order.DateTake,
								Summa = order.Summa,
								Comission = order.Comission
							};

				foreach (var el in queryFirst.ToList())
				{
					dataGridViewShowQuery.Rows.Add(el.categoryName, el.Surname, el.Name, el.Patronimic, el.DiscriptionOrder, el.DateGive.ToShortDateString(), el.DateTake.ToShortDateString(), el.Summa, el.Comission);
				}
			}
			dataGridViewShowQuery.AllowUserToAddRows = false;
		}

		private void FirstQuery_Load(object sender, EventArgs e)
		{
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
					comboBoxCategory.Items.Add(el.Name);
				}
			}
		}
	}
}
