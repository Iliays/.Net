using IndividProject.DataModel;
using IndividProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividProject
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void buttonAutorize_Click(object sender, EventArgs e)
		{
			using (var context = new LombardContext())
			{
				var query = context.Users.Where(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);

				if (textBoxLogin.Text == "Admin" && textBoxPassword.Text == "Admin")
				{
					Admin.admin = true;
					MainForm first = new MainForm();
					first.Show();
					this.Hide();
				}
				else if (query.ToList().Count > 0)
				{
					Admin.admin = false;
					MainForm first = new MainForm();
					first.Show();
					this.Hide();
				}
				//else
				//{
				//	TBError.Text = "Вы ввели логин/пароль неправильно";
				//	TBError.Visible = true;
				//}
			}
		}

		private void loginTextBox(object sender, EventArgs e)
		{
			if (textBoxLogin.Text == "Логин")
			{
				textBoxLogin.Text = "";
			}
		}

		private void loginTextBoxLeave(object sender, EventArgs e)
		{
			if (textBoxLogin.Text == "")
			{
				textBoxLogin.Text = "Логин";
			}
		}

		private void passwordTextBox(object sender, EventArgs e)
		{
			if (textBoxPassword.Text == "Пароль")
			{
				textBoxPassword.Text = "";
			}
		}

		private void passwordTextBoxLeave(object sender, EventArgs e)
		{
			if (textBoxPassword.Text == "")
			{
				textBoxPassword.Text = "Пароль";
			}
		}
	}
}
