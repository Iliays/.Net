namespace IndividProject.Forms
{
	partial class UpdateClient
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
			this.dateTimePickerDatePas = new System.Windows.Forms.DateTimePicker();
			this.textBoxSeria = new System.Windows.Forms.TextBox();
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.textBoxPatronimic = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxSurname = new System.Windows.Forms.TextBox();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonChange = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dateTimePickerDatePas
			// 
			this.dateTimePickerDatePas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDatePas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDatePas.Location = new System.Drawing.Point(132, 276);
			this.dateTimePickerDatePas.Name = "dateTimePickerDatePas";
			this.dateTimePickerDatePas.Size = new System.Drawing.Size(140, 24);
			this.dateTimePickerDatePas.TabIndex = 15;
			this.dateTimePickerDatePas.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
			// 
			// textBoxSeria
			// 
			this.textBoxSeria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSeria.Location = new System.Drawing.Point(132, 225);
			this.textBoxSeria.MaxLength = 4;
			this.textBoxSeria.Name = "textBoxSeria";
			this.textBoxSeria.Size = new System.Drawing.Size(140, 24);
			this.textBoxSeria.TabIndex = 14;
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxNumber.Location = new System.Drawing.Point(132, 177);
			this.textBoxNumber.MaxLength = 6;
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(140, 24);
			this.textBoxNumber.TabIndex = 13;
			// 
			// textBoxPatronimic
			// 
			this.textBoxPatronimic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPatronimic.Location = new System.Drawing.Point(132, 126);
			this.textBoxPatronimic.Name = "textBoxPatronimic";
			this.textBoxPatronimic.Size = new System.Drawing.Size(140, 24);
			this.textBoxPatronimic.TabIndex = 12;
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxName.Location = new System.Drawing.Point(133, 78);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(140, 24);
			this.textBoxName.TabIndex = 11;
			this.textBoxName.Text = "\r\n";
			// 
			// textBoxSurname
			// 
			this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSurname.Location = new System.Drawing.Point(132, 30);
			this.textBoxSurname.Name = "textBoxSurname";
			this.textBoxSurname.Size = new System.Drawing.Size(140, 24);
			this.textBoxSurname.TabIndex = 10;
			this.textBoxSurname.Text = "\r\n";
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExit.Location = new System.Drawing.Point(12, 12);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(93, 31);
			this.buttonExit.TabIndex = 9;
			this.buttonExit.Text = "Закрыть";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonChange
			// 
			this.buttonChange.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonChange.Location = new System.Drawing.Point(132, 306);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(140, 31);
			this.buttonChange.TabIndex = 17;
			this.buttonChange.Text = "Сохранить";
			this.buttonChange.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(130, 252);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(157, 18);
			this.label6.TabIndex = 23;
			this.label6.Text = "Введите дату выдачи";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(131, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(181, 18);
			this.label5.TabIndex = 22;
			this.label5.Text = "Введите серию паспорта";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(130, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(182, 18);
			this.label4.TabIndex = 21;
			this.label4.Text = "Введите номер паспорта";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(134, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 18);
			this.label3.TabIndex = 20;
			this.label3.Text = "Введите отчество";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(134, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 18);
			this.label2.TabIndex = 19;
			this.label2.Text = "Введите имя";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(130, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 18);
			this.label1.TabIndex = 18;
			this.label1.Text = "Введите фамилию";
			// 
			// UpdateClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 360);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonChange);
			this.Controls.Add(this.dateTimePickerDatePas);
			this.Controls.Add(this.textBoxSeria);
			this.Controls.Add(this.textBoxNumber);
			this.Controls.Add(this.textBoxPatronimic);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxSurname);
			this.Controls.Add(this.buttonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UpdateClient";
			this.Text = "UpdateClient";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonExit;
		internal System.Windows.Forms.DateTimePicker dateTimePickerDatePas;
		internal System.Windows.Forms.TextBox textBoxSeria;
		internal System.Windows.Forms.TextBox textBoxNumber;
		internal System.Windows.Forms.TextBox textBoxPatronimic;
		internal System.Windows.Forms.TextBox textBoxName;
		internal System.Windows.Forms.TextBox textBoxSurname;
		private System.Windows.Forms.Button buttonChange;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}