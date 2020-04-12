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
	public partial class UpdateOrder : Form
	{
		public int clientid;

		public bool Modified { get; set; }

		public string originalText;
		public UpdateOrder()
		{
			InitializeComponent();
		}

		private void updateDataGridView()
		{
			originalText = textBoxSumma.Text;

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
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dataGridViewAddClient_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int indexRow = dataGridViewAddClient.CurrentCell.RowIndex;

			clientid = Convert.ToInt32(dataGridViewAddClient.Rows[indexRow].Cells[0].Value);
		}

		private void UpdateOrder_Load(object sender, EventArgs e)
		{
			updateDataGridView();
		}

		private void UpdateOrder_MouseDown(object sender, MouseEventArgs e)
		{
			base.Capture = false;
			Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}

		public void textBoxSumma_TextChanged(object sender, EventArgs e)
		{
			if (originalText != textBoxSumma.Text)
			{
				textBoxSumma.Modified = true;
			}
			else
				textBoxSumma.Modified = false;
		}
	}
}
