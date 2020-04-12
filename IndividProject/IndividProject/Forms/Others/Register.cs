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
	public partial class Register : Form
	{
		public Register()
		{
			InitializeComponent();
		}

		public void addUser()
		{
			using (var context = new LombardContext())
			{
				var query = context.Users.Where(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);

				var user = new User()
				{
					Login = textBoxLogin.Text,
					Password = textBoxPassword.Text
				};

				if (query.ToList().Count < 1)
				{
					context.Users.Add(user);
					context.SaveChanges();
					MessageBox.Show("Пользователь успешно добавлен");
					this.Close();
				}

				else if (query.ToList().Count > 0)
				{
					MessageBox.Show("Логин или пароль уже есть в базе данных");
				}

				textBoxLogin.Clear();
				textBoxPassword.Clear();
				
			}
		}

		private void buttonRegister_Click(object sender, EventArgs e)
		{
			addUser();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
