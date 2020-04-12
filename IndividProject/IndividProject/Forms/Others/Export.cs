using IndividProject.ClassXML;
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
using System.Xml.Linq;

namespace IndividProject.Forms
{
	public partial class Export : Form
	{
		private int clientid;

		public Export()
		{
			InitializeComponent();
            comboBoxCat.Items.Add("All");
            comboBoxCat.Text = "All";
            comboBoxCat.DropDownStyle = ComboBoxStyle.DropDownList;
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
                    comboBoxCat.Items.Add(el.Name);
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

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Export_Load(object sender, EventArgs e)
		{
			updateDataGridView();
		}

		private void buttonExportData_Click(object sender, EventArgs e)
		{
            using (var context = new LombardContext())
            {
                var clients = context.Clients.ToList();

                var wasCategory = new List<string>();

                var wasOrder = new List<OrderTest>();

                var wasJournal = new List<JournalTest>();

                string categoryname = "";

                if (clientid > 0)
                {
                    clients = context.Clients.Where(x => x.ClientId == clientid).ToList();
                }

                int key = 0;
                XDocument doc = new XDocument(new XElement("CLIENT"));
                for (int i = 0; i < clients.Count(); i++)
                {
                    wasCategory.Clear();


                    doc.Element("CLIENT").Add(
                        new XElement("Client",
                        new XElement("surname", clients[i].Surname.Trim()),
                        new XElement("name", clients[i].Name.Trim()),
                        new XElement("patronimic", clients[i].Patronimic.Trim()),
                        new XElement("number", clients[i].Number.ToString().Trim()),
                        new XElement("seria", clients[i].Seria.ToString().Trim()),
                        new XElement("datePas", clients[i].DatePas.ToString("dd.MM.yyyy").Trim())
                        )
                    );

                    var orders = context.Orders.ToList();

                    if(dateTimePickerDateGive.Value != null && checkBoxDate.Checked == true)
                    {
                        DateTime dateGive = dateTimePickerDateGive.Value;
                        orders = context.Orders.Where(x => x.DateGive <= dateGive).ToList();
                    }

                    foreach (var order in orders)
                    {
                        if (clients[i].ClientId == order.ClientId)
                        {
                            var categories = context.Categories.ToList();

                            if (comboBoxCat.SelectedItem.ToString() == "All")
                            {
                            }
                            else
                            {
                                categories = context.Categories.Where(x => x.Name == comboBoxCat.SelectedItem.ToString()).ToList();
                            }

                            foreach (var category in categories)
                            {
                                bool check = false;

                                foreach (var s in wasCategory)
                                {
                                    if (category.Name.ToString() == s)
                                    {
                                        check = true;
                                    }
                                    categoryname = categories.Where(x => x.CategoryId == category.CategoryId).Select(x => x.Name).First().Trim().ToString();
                                }

                                wasCategory.Add(category.Name);

                                if(check == false)
                                {
                                    var CategoryXml = new XElement("Category",
                                    new XElement("name", category.Name.Trim()),
                                    new XElement("discription", category.Discription.Trim())
                                    );

                                    var ourClient = doc.Descendants("Client")
                                    .Where(x => x.Element("name")
                                    .Value.Equals(clients[i].Name.Trim())).FirstOrDefault();

                                    

                                    if (ourClient != null)
                                    {
                                        if (!ourClient.Elements("CLIENT").Any())
                                            ourClient.Add(new XElement("CLIENT"));

                                        bool duplicateClient = false;
                                        foreach (var elem in ourClient.Element("CLIENT").Elements("Category"))
                                        {
                                            duplicateClient = XNode.DeepEquals(elem, CategoryXml);
                                            if (duplicateClient)
                                                break;
                                        }

                                        if (!duplicateClient)
                                        {
                                            ourClient.Add(CategoryXml);
                                        }
                                    }
                                }
                                

                                if (clients[i].ClientId == order.ClientId)
                                {

                                    bool checkOrder = false;
                                    bool let = false;

                                    int clientid2 = clients[i].ClientId;
                                    DateTime DateTake = order.DateTake;
                                    DateTime DateGive = order.DateGive;
                                    decimal Summa = Convert.ToDecimal(order.Summa);
                                    decimal Comission = Convert.ToDecimal(order.Comission);

                                    foreach (var s in wasOrder)
                                    {
                                        var querys = context.Orders.Where(x => x.ClientId == clientid2 && x.CategoryId == category.CategoryId && x.DiscriptionOrder == order.DiscriptionOrder && x.DateGive == DateGive && x.DateTake == DateTake && x.Summa == Summa && x.Comission == Comission);

                                        if (querys.ToList().Count() < 1)
                                        {
                                            checkOrder = true;
                                        }

                                        if (clientid2 == s.ClientId && category.CategoryId == s.CategoryId && order.DiscriptionOrder == s.DiscriptionOrder && DateGive == s.DateGive && DateTake == s.DateTake && Summa == s.Summa && Comission == s.Comission)
                                        {
                                            checkOrder = true;
                                        }
                                    }

                                    var query2 = context.Orders.Where(x => x.ClientId == clientid2 && x.CategoryId == category.CategoryId && x.DiscriptionOrder == order.DiscriptionOrder && x.DateGive == DateGive && x.DateTake == DateTake && x.Summa == Summa && x.Comission == Comission);

                                    if (query2.ToList().Count() > 0)
                                    {
                                        let = true;
                                    }

                                    if (checkOrder == false && let == true)
                                    {
                                        categoryname = categories.Where(x => x.CategoryId == category.CategoryId).Select(x => x.Name).First().Trim().ToString();
                                        wasOrder.Add(new OrderTest(clientid2, category.CategoryId, order.DiscriptionOrder, DateGive, DateTake, Summa, Comission));
                                        var OrderXml = new XElement("Order",
                                            new XElement("name", category.Name.Trim()),
                                            new XElement("number", clients[i].Number.ToString().Trim()),
                                            new XElement("seria", clients[i].Seria.ToString().Trim()),
                                            new XElement("discriptionOrder", order.DiscriptionOrder.Trim()),
                                            new XElement("dateGive", order.DateGive.ToString("dd.MM.yyyy").Trim()),
                                            new XElement("dateTake", order.DateTake.ToString("dd.MM.yyyy").Trim()),
                                            new XElement("summa", order.Summa.ToString().Trim()),
                                            new XElement("comission", order.Comission.ToString().Trim())
                                            );

                                        var ourOrder = doc.Descendants("Client")
                                            .Where(x => x.Element("name")
                                            .Value.Equals(clients[i].Name.Trim())).FirstOrDefault().Descendants("Category")
                                            .Where(x => x.Element("name")
                                            .Value.Equals(categoryname)).FirstOrDefault();

                                        if (ourOrder != null)
                                        {
                                            ourOrder.Add(OrderXml);
                                        }

                                        var journals = context.Journals.ToList();

                                        foreach(var journal in journals)
                                        {
                                            if(journal.Order == order.OrderId)
                                            {
                                                bool checkes = false;

                                                foreach (var s in wasJournal)
                                                {
                                                    if (s.Order == journal.Order && s.Summa == journal.Summa && s.Name == category.Name && s.Number == clients[i].Number && s.Seria == clients[i].Seria)
                                                    {
                                                        checkes = true;
                                                    }
                                                }

                                                var queryJournal = context.Journals.Where(x => x.Order == journal.Order && x.Summa == journal.Summa);

                                                if(queryJournal.ToList().Count() < 0)
                                                {
                                                    checkes = true;
                                                }

                                                if(checkes == false)
                                                {
                                                    wasJournal.Add(new JournalTest(journal.Order, journal.Summa, category.Name, clients[i].Number, clients[i].Seria));

                                                    var JournalXml = new XElement("Journal",
                                                    new XElement("name", category.Name.Trim()),
                                                    new XElement("number", clients[i].Number.ToString().Trim()),
                                                    new XElement("seria", clients[i].Seria.ToString().Trim()),
                                                    new XElement("summa", journal.Summa.ToString().Trim()),
                                                    new XElement("discriptionOrder", order.DiscriptionOrder.ToString().Trim()),
                                                    new XElement("dateGive", order.DateGive.ToString("dd.MM.yyyy").Trim()),
                                                    new XElement("dateTake", order.DateTake.ToString("dd.MM.yyyy").Trim())
                                                    );

                                                    var orderName = clients[i].Number.ToString();

                                                    var ourJournal = doc.Descendants("Client")
                                                    .Where(x => x.Element("name")
                                                    .Value.Equals(clients[i].Name.Trim())).FirstOrDefault().Descendants("Category")
                                                    .Where(x => x.Element("name")
                                                    .Value.Equals(categoryname)).FirstOrDefault().Descendants("Order")
                                                    .Where(x => x.Element("number")
                                                    .Value.Equals(orderName)).FirstOrDefault();

                                                    if (ourJournal != null)
                                                    {
                                                        ourJournal.Add(JournalXml);
                                                    }
                                                }                                               
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    key++;
                }
                string filePath = @"export.xml";
                doc.Save(filePath);

                MessageBox.Show("Экспорт завершен !");
            }
        }

		private void dataGridViewAddClient_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int indexRow = dataGridViewAddClient.CurrentCell.RowIndex;

			clientid = Convert.ToInt32(dataGridViewAddClient.Rows[indexRow].Cells[0].Value);
		}

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxDate.Checked == true)
            {
                dateTimePickerDateGive.Enabled = true;
            }
            else
            {
                dateTimePickerDateGive.Enabled = false;
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            XmlSerialization<CLIENT> xmlSerialization = new XmlSerialization<CLIENT>();

            CLIENT cl = new CLIENT(); // путь к файлу

            string filePath = @"import.xml";

            cl = (CLIENT)xmlSerialization.ReadData(filePath, cl); //дерсериализация 

            for (int i = 0; i < cl.Client.Count; i++)
            {
                string clientName = cl.Client[i].Name;
                string clientSurname = cl.Client[i].Surname;
                string clientPatronimic = cl.Client[i].Patronimic;
                string clientNumber = cl.Client[i].Number;
                string clientSeria = cl.Client[i].Seria;
                string clientDatePas = cl.Client[i].DatePas;

                //добавление
                using (var context = new LombardContext())
                {
                    int number = Convert.ToInt32(clientNumber);
                    int seria = Convert.ToInt32(clientSeria);
                    DateTime datePas = DateTime.Parse(clientDatePas);
                    var query = context.Clients.Where(x => x.Name == clientName && x.Surname == clientSurname && x.Patronimic == clientPatronimic && x.Number == number && x.Seria == seria && x.DatePas == datePas);

                    var clients = new Client()
                    {
                        Name = clientName.ToString(),
                        Surname = clientSurname.ToString(),
                        Patronimic = clientPatronimic.ToString(),
                        Number = number,
                        Seria = seria,
                        DatePas = datePas
                    };

                    if (query.ToList().Count < 1)
                    {
                        context.Clients.Add(clients);
                        context.SaveChanges();
                    }


                }

                for (int j = 0; j < cl.Client[i].Category.Count; j++)
                {
                    string categoryname = cl.Client[i].Category[j].Name;
                    string categorydisc = cl.Client[i].Category[j].Discription;


                    using (var context = new LombardContext())
                    {
                        var category = context.Categories.Where(x => x.Name == categoryname && x.Discription == categorydisc);

                        var categorys = new Category()
                        {
                            Name = categoryname,
                            Discription = categorydisc
                        };

                        if (category.ToList().Count < 1)
                        {
                            context.Categories.Add(categorys);
                            context.SaveChanges();
                        }

                    }

                    for (int y = 0; y < cl.Client[i].Category[j].Order.Count; y++)
                    {
                        string orderdisc = cl.Client[i].Category[j].Order[y].DiscriptionOrder;
                        string orderdategive = cl.Client[i].Category[j].Order[y].DateGive;
                        string orderdatetake = cl.Client[i].Category[j].Order[y].DateTake;
                        string ordersumma = cl.Client[i].Category[j].Order[y].Summa;
                        string ordercomission = cl.Client[i].Category[j].Order[y].Comission;

                        using (var context = new LombardContext())
                        {
                            int number = Convert.ToInt32(clientNumber);
                            int seria = Convert.ToInt32(clientSeria);
                            DateTime datePas = DateTime.Parse(clientDatePas);

                            var categoryid = context.Categories.Where(x => x.Name == categoryname && x.Discription == categorydisc).Select(x => x.CategoryId).First();
                            var clientid = context.Clients.Where(x => x.Name == clientName && x.Surname == clientSurname && x.Patronimic == clientPatronimic && x.Number == number && x.Seria == seria && x.DatePas == datePas).Select(x => x.ClientId).First();

                            DateTime dateGive = DateTime.Parse(orderdategive);
                            DateTime dateTake = DateTime.Parse(orderdatetake);
                            decimal summa = Convert.ToDecimal(ordersumma);
                            decimal comission = Convert.ToDecimal(ordercomission);

                            var query = context.Orders.Where(x => x.CategoryId == categoryid && x.ClientId == clientid && x.DiscriptionOrder == orderdisc && x.DateGive == dateGive && x.DateTake == dateTake && x.Summa == summa && x.Comission == comission);

                            var order = new Order()
                            {
                                CategoryId = categoryid,
                                ClientId = clientid,
                                DiscriptionOrder = orderdisc,
                                DateGive = dateGive,
                                DateTake = dateTake,
                                Summa = summa,
                                Comission = comission
                            };

                            if (query.ToList().Count < 1)
                            {
                                context.Orders.Add(order);
                                context.SaveChanges();
                            }
                        }

                        for (int m = 0; m < cl.Client[i].Category[j].Order[y].Journal.Count; m++)
                        {

                            using (var context = new LombardContext())
                            {
                                int number = Convert.ToInt32(cl.Client[i].Number);
                                int seria = Convert.ToInt32(cl.Client[i].Seria);

                                DateTime dateGive = DateTime.Parse(cl.Client[i].Category[j].Order[y].DateGive);
                                DateTime dateTake = DateTime.Parse(cl.Client[i].Category[j].Order[y].DateTake);
                                decimal summa = Convert.ToDecimal(cl.Client[i].Category[j].Order[y].Summa);
                                decimal summa2 = Convert.ToDecimal(cl.Client[i].Category[j].Order[y].Journal[m].Summa);
                                decimal comission = Convert.ToDecimal(cl.Client[i].Category[j].Order[y].Comission);

                                var getClientid = context.Clients.Where(x => x.Number == number && x.Seria == seria).Select(x => x.ClientId).First();
                                string categoryname2 = cl.Client[i].Category[j].Name;
                                string discriptionname2 = cl.Client[i].Category[j].Discription;

                                var getCategoryId = context.Categories.Where(x => x.Name == categoryname2 && x.Discription == discriptionname2).Select(x => x.CategoryId).First();
                                var getOrderId = context.Orders.Where(x => x.CategoryId == getCategoryId && x.ClientId == getClientid && x.DiscriptionOrder == orderdisc && x.DateGive == dateGive && x.DateTake == dateTake && x.Summa == summa && x.Comission == comission).Select(x => x.OrderId).First();
                                

                                var journal = new Journal()
                                {
                                    Order = getOrderId,
                                    Summa = summa2
                                };

                                context.Journals.Add(journal);
                                context.SaveChanges();
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Импорт завершён");
        }
    }
}
