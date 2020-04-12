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
	public partial class OrderFormAdd : Form
	{
		private int clientid;

		public OrderFormAdd()
		{
			InitializeComponent();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void updateDataGridView()
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

			dataGridViewAddClient.Rows.Clear();
			dataGridViewAddClient.SelectAll();
			dataGridViewAddClient.ClearSelection();
			dataGridViewAddClient.Columns.Clear();

			dataGridViewAddClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewAddClient.Columns.Add("Column1", "Код");
			dataGridViewAddClient.Columns.Add("Column2", "Фамилия");
			dataGridViewAddClient.Columns.Add("Column3", "Имя");
			dataGridViewAddClient.Columns.Add("Column4", "Отчество");
			dataGridViewAddClient.Columns.Add("Column5", "Номер паспорта");
			dataGridViewAddClient.Columns.Add("Column6", "Серия паспорта");
			dataGridViewAddClient.Columns.Add("Column7", "Дата выдачи");


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
					dataGridViewAddClient.Rows.Add(el.ClientId, el.Surname, el.Name, el.Patronimic, el.Number, el.Seria, el.DatePas.ToShortDateString());
				}
			}

			dataGridViewAddClient.AllowUserToAddRows = false;
		}

		private void OrderFormAdd_Load(object sender, EventArgs e)
		{
			dateTimePickerDateGive.Value = DateTime.Today;
			dateTimePickerDateTake.Value = DateTime.Today;
			updateDataGridView();
		}

		private void dataGridViewAddClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int indexRow = dataGridViewAddClient.CurrentCell.RowIndex;

			clientid = Convert.ToInt32(dataGridViewAddClient.Rows[indexRow].Cells[0].Value);
		}

		private void dateTimePickerDateGive_ValueChanged(object sender, EventArgs e)
		{
			if (DateTime.Today > dateTimePickerDateGive.Value)
			{
				MessageBox.Show("Даты ранее не могут быть выбраны", "Ошибка");
				dateTimePickerDateGive.Value = DateTime.Today;
			}
			else
			{
				dateTimePickerDateTake.Value = dateTimePickerDateGive.Value;
			}
		}

		private void dateTimePickerDateTake_ValueChanged(object sender, EventArgs e)
		{
			if (dateTimePickerDateGive.Value > dateTimePickerDateTake.Value)
			{
				MessageBox.Show("Дата возврата товара не может \nбыть раньше даты сдачи товара", "Ошибка");
				dateTimePickerDateTake.Value = dateTimePickerDateGive.Value;
			}
		}

		private void buttonAddOrder_Click(object sender, EventArgs e)
		{
			using (var context = new LombardContext())
			{
				var query = context.Categories.Where(x => x.Name == comboBoxCategory.SelectedItem.ToString());
				int id = 0;
				foreach (var x in query.ToList())
				{
					id = x.CategoryId;
				}
				
				var order = new Order()
				{
					CategoryId = id,
					ClientId = clientid,
					DiscriptionOrder = textBoxDiscriptionOrder.Text,
					DateGive = dateTimePickerDateGive.Value,
					DateTake = dateTimePickerDateTake.Value,
					Summa = int.Parse(textBoxSumma.Text.ToString()),
					Comission = int.Parse(textBoxComission.Text.ToString())
				};
				context.Orders.Add(order);
				context.SaveChanges();

				var journal = new Journal()
				{
					Order = order.OrderId,
					Summa = int.Parse(textBoxSumma.Text.ToString())
				};
				context.Journals.Add(journal);
				context.SaveChanges();

				textBoxDiscriptionOrder.Clear();
				textBoxSumma.Clear();
				textBoxComission.Clear();
				MessageBox.Show("Запись успешно добавлена");
			}
		}

		private void buttonShowDataGridView_Click(object sender, EventArgs e)
		{
			ShowOrdersForm newForm = new ShowOrdersForm();
			newForm.Show();
		}
	}
}
