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

namespace IndividProject.Forms.Others
{
	public partial class JournalForm : Form
	{
		public JournalForm()
		{
			InitializeComponent();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void updateDataGridView()
		{
			dataGridViewJournalShow.Rows.Clear();
			dataGridViewJournalShow.SelectAll();
			dataGridViewJournalShow.ClearSelection();
			dataGridViewJournalShow.Columns.Clear();

			dataGridViewJournalShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewJournalShow.Columns.Add("Column1", "Код");
			dataGridViewJournalShow.Columns.Add("Column2", "Цена");


			using (var context = new LombardContext())
			{
				var allJournals = from query in context.Journals
								select new
								{
									OrderId = query.Order,
									Summa = query.Summa
								};

				foreach (var el in allJournals.ToList())
				{
					dataGridViewJournalShow.Rows.Add(el.OrderId, el.Summa);
				}
			}

			dataGridViewJournalShow.AllowUserToAddRows = false;
		}

		private void JournalForm_Load(object sender, EventArgs e)
		{
			updateDataGridView();
		}
	}
}
