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
	public partial class ClientFormUpdate : Form
	{
		LombardContext db = new LombardContext();
		public ClientFormUpdate()
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

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			int indexRow = dataGridViewShowClient.CurrentCell.RowIndex;

			int id = Convert.ToInt32(dataGridViewShowClient.Rows[indexRow].Cells[0].Value);

			Client client = db.Clients.Find(id);

			UpdateClient editClient = new UpdateClient();

			editClient.textBoxSurname.Text = client.Surname;
			editClient.textBoxName.Text = client.Name; // что бы поля были видны в свойствах нужно было поменять private на internal
			editClient.textBoxPatronimic.Text = client.Patronimic;
			editClient.textBoxNumber.Text = client.Number.ToString();
			editClient.textBoxSeria.Text = client.Seria.ToString();
			editClient.dateTimePickerDatePas.Text = client.DatePas.ToString();
			DialogResult result = editClient.ShowDialog(this); // в свойствах DialogRisult надо указать ОК 

			if (result == DialogResult.Cancel)
				return;

			client.Surname = editClient.textBoxSurname.Text;
			client.Name = editClient.textBoxName.Text;
			client.Patronimic = editClient.textBoxPatronimic.Text;
			client.Number = Convert.ToInt32(editClient.textBoxNumber.Text);
			client.Seria = Convert.ToInt32(editClient.textBoxSeria.Text);
			client.DatePas = DateTime.Parse(editClient.dateTimePickerDatePas.Text);

			db.SaveChanges();
			updateDataGridView(); // обновляем грид
			MessageBox.Show("Объект изменён");
		}

		private void ClientFormUpdate_Load(object sender, EventArgs e)
		{
			updateDataGridView();
		}
	}
}
