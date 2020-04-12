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
	public partial class OrderFormDelete : Form
	{
		LombardContext db = new LombardContext();
		public OrderFormDelete()
		{
			InitializeComponent();
		}

		private void updateDataGridView()
		{
			dataGridViewShowOrder.Rows.Clear();
			dataGridViewShowOrder.SelectAll();
			dataGridViewShowOrder.ClearSelection();
			dataGridViewShowOrder.Columns.Clear();

			dataGridViewShowOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewShowOrder.Columns.Add("Column1", "Номер");
			dataGridViewShowOrder.Columns.Add("Column2", "Категория");
			dataGridViewShowOrder.Columns.Add("Column3", "Клиент");
			dataGridViewShowOrder.Columns.Add("Column4", "Описание");
			dataGridViewShowOrder.Columns.Add("Column5", "Дата сдачи");
			dataGridViewShowOrder.Columns.Add("Column6", "Дата возврата");
			dataGridViewShowOrder.Columns.Add("Column7", "Сумма");
			dataGridViewShowOrder.Columns.Add("Column8", "Коммисионные");


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
					dataGridViewShowOrder.Rows.Add(el.OrderId, el.CategoryId, el.ClientId, el.DiscriptionOrder, el.DateGive.ToShortDateString(), el.DateTake.ToShortDateString(), el.Summa, el.Comission);
				}
			}

			dataGridViewShowOrder.AllowUserToAddRows = false;
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OrderFormDelete_Load(object sender, EventArgs e)
		{
			updateDataGridView();
		}

		private void buttonDeleteOrder_Click(object sender, EventArgs e)
		{
			if (dataGridViewShowOrder.SelectedRows.Count > 0)
			{
				int index = dataGridViewShowOrder.SelectedRows[0].Index;
				int id = 0;
				bool converted = Int32.TryParse(dataGridViewShowOrder[0, index].Value.ToString(), out id);
				if (converted == false)
					return;
				Order order = db.Orders.Find(id);
				db.Orders.Remove(order);
				db.SaveChanges();

				MessageBox.Show("Обьект удален");
				updateDataGridView();
			}
		}
	}
}
