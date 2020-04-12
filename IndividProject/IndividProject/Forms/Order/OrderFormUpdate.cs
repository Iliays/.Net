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
	public partial class OrderFormUpdate : Form
	{
		LombardContext db = new LombardContext();

		public OrderFormUpdate()
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

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OrderFormUpdate_Load(object sender, EventArgs e)
		{
			updateDataGridView();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{

			int indexRow = dataGridViewAddOrder.CurrentCell.RowIndex;

			int id = Convert.ToInt32(dataGridViewAddOrder.Rows[indexRow].Cells[0].Value);

			Order order = db.Orders.Find(id);

			UpdateOrder editOrder = new UpdateOrder();

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
					editOrder.comboBoxCategory.Items.Add(el.Name);
				}

				var orderGetName = context.Categories.Where(x => x.CategoryId == order.CategoryId);

				string name;
				foreach (var x in orderGetName.ToList())
				{
					name = x.Name;
					editOrder.comboBoxCategory.Text = name.ToString();
				}

				editOrder.clientid = order.ClientId;
				editOrder.textBoxDiscriptionOrder.Text = order.DiscriptionOrder;
				editOrder.dateTimePickerDateGive.Text = order.DateGive.ToString();
				editOrder.dateTimePickerDateTake.Text = order.DateTake.ToString();
				editOrder.textBoxSumma.Text = Convert.ToString(order.Summa); // что бы поля были видны в свойствах нужно было поменять private на internal
				editOrder.textBoxComission.Text = Convert.ToString(order.Comission);


				DialogResult result = editOrder.ShowDialog(this); // в свойствах DialogRisult надо указать ОК 

				if (result == DialogResult.Cancel)
					return;

				var getId = context.Categories.Where(x => x.Name == editOrder.comboBoxCategory.SelectedItem.ToString());

				foreach(var x in getId.ToList())
				{
					order.CategoryId = x.CategoryId;
				}

				editOrder.textBoxSumma_TextChanged(editOrder.originalText, e);
				if (editOrder.textBoxSumma.Modified == true)
				{
					using (var context2 = new LombardContext())
					{
						var journal = new Journal()
						{
							Order = order.OrderId,
							Summa = Convert.ToDecimal(editOrder.textBoxSumma.Text)
						};
						context2.Journals.Add(journal);
						context2.SaveChanges();
					}
				}

				order.ClientId = editOrder.clientid;
				order.DiscriptionOrder = editOrder.textBoxDiscriptionOrder.Text;
				order.DateGive = DateTime.Parse(editOrder.dateTimePickerDateGive.Text);
				order.DateTake = DateTime.Parse(editOrder.dateTimePickerDateTake.Text);
				order.Summa = Convert.ToDecimal(editOrder.textBoxSumma.Text);
				order.Comission = Convert.ToDecimal(editOrder.textBoxComission.Text);
			}

			db.SaveChanges();
			updateDataGridView(); // обновляем грид
			MessageBox.Show("Объект изменён");
		}
	}
}
