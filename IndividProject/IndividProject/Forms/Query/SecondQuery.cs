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
	public partial class SecondQuery : Form
	{
		private int clientid;
		public SecondQuery()
		{
			InitializeComponent();
		}

		private void updateDataGridView()
		{
			dataGridViewShowClient.Rows.Clear();
			dataGridViewShowClient.SelectAll();
			dataGridViewShowClient.ClearSelection();
			dataGridViewShowClient.Columns.Clear();

			dataGridViewShowClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewShowClient.Columns.Add("Column1", "Код");
			dataGridViewShowClient.Columns.Add("Column2", "Фамилия");
			dataGridViewShowClient.Columns.Add("Column3", "Имя");
			dataGridViewShowClient.Columns.Add("Column4", "Отчество");
			dataGridViewShowClient.Columns.Add("Column5", "Номер паспорта");
			dataGridViewShowClient.Columns.Add("Column6", "Серия паспорта");
			dataGridViewShowClient.Columns.Add("Column7", "Дата выдачи");


			using (var context = new LombardContext())
			{
				var allClient = from query in context.Clients
								select new
								{
									ClientId = query.ClientId,
									Surname = query.Surname,
									Name = query.Name,
									Patronimic = query.Patronimic,
									Number = query.Number,
									Seria = query.Seria,
									DatePas = query.DatePas
								};

				foreach (var el in allClient.ToList())
				{
					dataGridViewShowClient.Rows.Add(el.ClientId, el.Surname, el.Name, el.Patronimic, el.Number, el.Seria, el.DatePas.ToShortDateString());
				}
			}

			dataGridViewShowClient.AllowUserToAddRows = false;
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
				var queryFirst = from order in context.Orders
								 from category in context.Categories
								 from client in context.Clients
								 where order.ClientId == clientid && order.ClientId == client.ClientId && order.CategoryId == category.CategoryId
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

		private void SecondQuery_Load(object sender, EventArgs e)
		{
			updateDataGridView();
		}

		private void dataGridViewShowClient_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int indexRow = dataGridViewShowClient.CurrentCell.RowIndex;

			clientid = Convert.ToInt32(dataGridViewShowClient.Rows[indexRow].Cells[0].Value);
		}
	}
}
