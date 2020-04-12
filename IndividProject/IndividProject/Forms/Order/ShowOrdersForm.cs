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
	public partial class ShowOrdersForm : Form
	{
		public ShowOrdersForm()
		{
			InitializeComponent();
		}

		private void updateDataGridView()
		{
			dataGridViewAddOrder.Rows.Clear();
			dataGridViewAddOrder.SelectAll();
			dataGridViewAddOrder.ClearSelection();
			dataGridViewAddOrder.Columns.Clear();

			dataGridViewAddOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewAddOrder.Columns.Add("Column1", "Номер");
			dataGridViewAddOrder.Columns.Add("Column2", "Категория");
			dataGridViewAddOrder.Columns.Add("Column3", "Клиент");
			dataGridViewAddOrder.Columns.Add("Column4", "Описание");
			dataGridViewAddOrder.Columns.Add("Column5", "Дата сдачи");
			dataGridViewAddOrder.Columns.Add("Column6", "Дата возврата");
			dataGridViewAddOrder.Columns.Add("Column7", "Сумма");
			dataGridViewAddOrder.Columns.Add("Column8", "Коммисионные");


			using (var context = new LombardContext())
			{
				var allOrder = from query in context.Orders
								select new
								{
									OrderId = query.OrderId,
									CategoryId = query.CategoryId,
									ClientId = query.ClientId,
									DiscriptionOrder = query.DiscriptionOrder,
									DateGive = query.DateGive,
									DateTake = query.DateTake,
									Summa = query.Summa,
									Comission = query.Comission
								};

				foreach (var el in allOrder.ToList())
				{
					dataGridViewAddOrder.Rows.Add(el.OrderId, el.CategoryId, el.ClientId, el.DiscriptionOrder, el.DateGive.ToShortDateString(), el.DateTake.ToShortDateString(), el.Summa, el.Comission);
				}
			}

			dataGridViewAddOrder.AllowUserToAddRows = false;
		}

		private void ShowOrdersForm_Load(object sender, EventArgs e)
		{
			updateDataGridView();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
