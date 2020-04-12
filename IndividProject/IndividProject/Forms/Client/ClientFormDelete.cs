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
	public partial class ClientFormDelete : Form
	{
		LombardContext db = new LombardContext();
		public ClientFormDelete()
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

		private void ClientFormDelete_Load(object sender, EventArgs e)
		{
			updateDataGridView();
		}

		private void buttonDeleteClient_Click(object sender, EventArgs e)
		{
			if (dataGridViewShowClient.SelectedRows.Count > 0)
			{
				int index = dataGridViewShowClient.SelectedRows[0].Index;
				int id = 0;
				bool converted = Int32.TryParse(dataGridViewShowClient[0, index].Value.ToString(), out id);
				if (converted == false)
					return;
				Client client = db.Clients.Find(id);
				db.Clients.Remove(client);
				db.SaveChanges();

				MessageBox.Show("Обьект удален");
				updateDataGridView();
			}
		}
	}
}
