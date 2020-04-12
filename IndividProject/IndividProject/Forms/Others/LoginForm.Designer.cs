namespace IndividProject
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.buttonAutorize = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLogin.Location = new System.Drawing.Point(208, 167);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(184, 24);
			this.textBoxLogin.TabIndex = 0;
			this.textBoxLogin.Enter += new System.EventHandler(this.loginTextBox);
			this.textBoxLogin.Leave += new System.EventHandler(this.loginTextBoxLeave);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPassword.Location = new System.Drawing.Point(208, 207);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(184, 24);
			this.textBoxPassword.TabIndex = 1;
			this.textBoxPassword.Enter += new System.EventHandler(this.passwordTextBox);
			this.textBoxPassword.Leave += new System.EventHandler(this.passwordTextBoxLeave);
			// 
			// buttonAutorize
			// 
			this.buttonAutorize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAutorize.Location = new System.Drawing.Point(208, 244);
			this.buttonAutorize.Name = "buttonAutorize";
			this.buttonAutorize.Size = new System.Drawing.Size(184, 37);
			this.buttonAutorize.TabIndex = 2;
			this.buttonAutorize.Text = "Авторизоваться";
			this.buttonAutorize.UseVisualStyleBackColor = true;
			this.buttonAutorize.Click += new System.EventHandler(this.buttonAutorize_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.Info;
			this.label1.Location = new System.Drawing.Point(34, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(536, 91);
			this.label1.TabIndex = 3;
			this.label1.Text = "LOMBARDINI";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSeaGreen;
			this.ClientSize = new System.Drawing.Size(594, 313);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAutorize);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxLogin);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Button buttonAutorize;
		private System.Windows.Forms.Label label1;
	}
}