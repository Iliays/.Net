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
	public partial class ClientFormAdd : Form
	{
		public ClientFormAdd()
		{
			InitializeComponent();
		}

		public void addClient()
		{
			using (var context = new LombardContext())
			{
				var client = new Client()
				{
					Surname = textBoxSurname.Text,
					Name = textBoxName.Text,
					Patronimic = textBoxPatronimic.Text,
					Number = int.Parse(textBoxNumber.Text.ToString()),
					Seria = int.Parse(textBoxSeria.Text.ToString()),
					DatePas = dateTimePickerDatePas.Value
				};
				context.Clients.Add(client);
				context.SaveChanges();
			}
			textBoxSurname.Clear();
			textBoxName.Clear();
			textBoxPatronimic.Clear();
			textBoxNumber.Clear();
			textBoxSeria.Clear();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void updateDataGridView()
		{
			dataGridViewAddClient.Rows.Clear();
			dataGridViewAddClient.SelectAll();
			dataGridViewAddClient.ClearSelection();
			dataGridViewAddClient.Columns.Clear();

			dataGridViewAddClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewAddClient.Columns.Add("Column1", "Фамилия");
			dataGridViewAddClient.Columns.Add("Column2", "Имя");
			dataGridViewAddClient.Columns.Add("Column3", "Отчество");
			dataGridViewAddClient.Columns.Add("Column4", "Номер паспорта");
			dataGridViewAddClient.Columns.Add("Column5", "Серия паспорта");
			dataGridViewAddClient.Columns.Add("Column6", "Дата выдачи");


			using (var context = new LombardContext())
			{
				var allClient = from query in context.Clients
							 select new
							 {
								 Surname = query.Surname,
								 Name = query.Name,
								 Patronimic = query.Patronimic,
								 Number = query.Number,
								 Seria = query.Seria,
								 DatePas = query.DatePas
							 };

				foreach (var el in allClient.ToList())
				{
					dataGridViewAddClient.Rows.Add(el.Surname, el.Name, el.Patronimic, el.Number, el.Seria, el.DatePas.ToShortDateString());
				}
			}

			dataGridViewAddClient.AllowUserToAddRows = false;
		}

		private void buttonAddClient_Click(object sender, EventArgs e)
		{
			addClient();
			updateDataGridView();
		}

		private void ClientFormAdd_Load(object sender, EventArgs e)
		{
			updateDataGridView();
		}

		private void dateTimePickerDatePas_ValueChanged(object sender, EventArgs e)
		{
			if (DateTime.Today < dateTimePickerDatePas.Value)
			{
				MessageBox.Show("Даты позже сегодняшней не могут быть выбраны", "Ошибка");
				dateTimePickerDatePas.Value = DateTime.Today;
			}
		}
	}
}
