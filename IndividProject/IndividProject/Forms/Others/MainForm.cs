using IndividProject.Forms.Others;
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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			customizeDesing();
		}

		private void customizeDesing()
		{
			panelAddSubmenu.Visible = false;
			panelUpdateSubmenu.Visible = false;
			panelDeleteSubmenu.Visible = false;
			panelQuerySubmenu.Visible = false;
		}

		private void hideSubMenu()
		{
			if (panelAddSubmenu.Visible == true)
				panelAddSubmenu.Visible = false;
			if (panelUpdateSubmenu.Visible == true)
				panelUpdateSubmenu.Visible = false;
			if (panelDeleteSubmenu.Visible == true)
				panelDeleteSubmenu.Visible = false;
			if (panelQuerySubmenu.Visible == true)
				panelQuerySubmenu.Visible = false;
		}

		private void showSubMenu(Panel subMenu)
		{
			if(subMenu.Visible == false)
			{
				hideSubMenu();
				subMenu.Visible = true;
			}
			else
				subMenu.Visible = false;
		}

		private void buttonAddData_Click(object sender, EventArgs e)
		{
			showSubMenu(panelAddSubmenu);
		}
		#region AddSubMenu

		private void buttonAddCategory_Click(object sender, EventArgs e)
		{
			openCildForm(new CategoryFormAdd());
			//..
			//Code
			//..
			hideSubMenu();
		}

		private void buttonAddClient_Click(object sender, EventArgs e)
		{
			openCildForm(new ClientFormAdd());
			//..
			//Code
			//..
			hideSubMenu();
		}

		private void buttonAddOrder_Click(object sender, EventArgs e)
		{
			openCildForm(new OrderFormAdd());
			//..
			//Code
			//..
			hideSubMenu();
		}
		#endregion

		private void buttonUpdateData_Click(object sender, EventArgs e)
		{
			showSubMenu(panelUpdateSubmenu);
		}
		#region UpdateSubMenu

		private void buttonUpdateCategory_Click(object sender, EventArgs e)
		{
			openCildForm(new CategoryFormUpdate());
			//..
			//Code
			//..
			hideSubMenu();
		}

		private void buttonUpdateClient_Click(object sender, EventArgs e)
		{
			openCildForm(new ClientFormUpdate());
			//..
			//Code
			//..
			hideSubMenu();
		}

		private void buttonUpdateOrder_Click(object sender, EventArgs e)
		{
			openCildForm(new OrderFormUpdate());
			//..
			//Code
			//..
			hideSubMenu();
		}
		#endregion

		private void buttonDeleteData_Click(object sender, EventArgs e)
		{
			showSubMenu(panelDeleteSubmenu);
		}

		#region DeleteSubMenu
		private void buttonDeleteCategory_Click(object sender, EventArgs e)
		{
			openCildForm(new CategoryFormDelete());
			//..
			//Code
			//..
			hideSubMenu();
		}

		private void buttonDeleteClient_Click(object sender, EventArgs e)
		{
			openCildForm(new ClientFormDelete());
			//..
			//Code
			//..
			hideSubMenu();
		}

		private void buttonDeleteOrder_Click(object sender, EventArgs e)
		{
			openCildForm(new OrderFormDelete());
			//..
			//Code
			//..
			hideSubMenu();
		}
		#endregion

		private Form activeForm = null;
		private void openCildForm(Form childForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void buttonRegister_Click(object sender, EventArgs e)
		{
			openCildForm(new Register());
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if (Admin.admin == false)
			{
				buttonDeleteData.Visible = false;
				buttonRegister.Visible = false;
			}
		}

		private void buttonFiveQuery_Click(object sender, EventArgs e)
		{
			showSubMenu(panelQuerySubmenu);
		}

		#region QuerySubMenu
		private void buttonFirstQuery_Click(object sender, EventArgs e)
		{
			openCildForm(new FirstQuery());
			//..
			//Code
			//..
			hideSubMenu();
		}

		private void buttonSecondQuery_Click(object sender, EventArgs e)
		{
			openCildForm(new SecondQuery());
			//..
			//Code
			//..
			hideSubMenu();
		}

		private void buttonThirdQuery_Click(object sender, EventArgs e)
		{
			openCildForm(new ThirdQuery());
			//..
			//Code
			//..
			hideSubMenu();
		}

		private void buttonForthQuery_Click(object sender, EventArgs e)
		{
			openCildForm(new ForthQuery());
			//..
			//Code
			//..
			hideSubMenu();
		}

		private void buttonFifthQuery_Click(object sender, EventArgs e)
		{
			openCildForm(new FifthQuery());
			//..
			//Code
			//..
			hideSubMenu();
		}
		#endregion

		private void buttonImport_Click(object sender, EventArgs e)
		{
			openCildForm(new Export());
		}

		private void buttonJournalShow_Click(object sender, EventArgs e)
		{
			openCildForm(new JournalForm());
		}
	}
}
