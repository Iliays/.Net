namespace IndividProject.Forms
{
	partial class ClientFormAdd
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
			this.dataGridViewAddClient = new System.Windows.Forms.DataGridView();
			this.buttonExit = new System.Windows.Forms.Button();
			this.textBoxSurname = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.textBoxPatronimic = new System.Windows.Forms.TextBox();
			this.textBoxSeria = new System.Windows.Forms.TextBox();
			this.dateTimePickerDatePas = new System.Windows.Forms.DateTimePicker();
			this.buttonAddClient = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddClient)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAddClient
			// 
			this.dataGridViewAddClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAddClient.Location = new System.Drawing.Point(210, 12);
			this.dataGridViewAddClient.Name = "dataGridViewAddClient";
			this.dataGridViewAddClient.ReadOnly = true;
			this.dataGridViewAddClient.Size = new System.Drawing.Size(512, 391);
			this.dataGridViewAddClient.TabIndex = 0;
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExit.Location = new System.Drawing.Point(12, 12);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(93, 31);
			this.buttonExit.TabIndex = 1;
			this.buttonExit.Text = "Закрыть";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// textBoxSurname
			// 
			this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSurname.Location = new System.Drawing.Point(12, 71);
			this.textBoxSurname.Name = "textBoxSurname";
			this.textBoxSurname.Size = new System.Drawing.Size(181, 24);
			this.textBoxSurname.TabIndex = 2;
			this.textBoxSurname.Text = "\r\n";
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxName.Location = new System.Drawing.Point(12, 115);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(181, 24);
			this.textBoxName.TabIndex = 3;
			this.textBoxName.Text = "\r\n";
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxNumber.Location = new System.Drawing.Point(12, 206);
			this.textBoxNumber.MaxLength = 6;
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(181, 24);
			this.textBoxNumber.TabIndex = 5;
			// 
			// textBoxPatronimic
			// 
			this.textBoxPatronimic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPatronimic.Location = new System.Drawing.Point(12, 162);
			this.textBoxPatronimic.Name = "textBoxPatronimic";
			this.textBoxPatronimic.Size = new System.Drawing.Size(181, 24);
			this.textBoxPatronimic.TabIndex = 4;
			// 
			// textBoxSeria
			// 
			this.textBoxSeria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSeria.Location = new System.Drawing.Point(12, 248);
			this.textBoxSeria.MaxLength = 4;
			this.textBoxSeria.Name = "textBoxSeria";
			this.textBoxSeria.Size = new System.Drawing.Size(181, 24);
			this.textBoxSeria.TabIndex = 6;
			// 
			// dateTimePickerDatePas
			// 
			this.dateTimePickerDatePas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDatePas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDatePas.Location = new System.Drawing.Point(12, 295);
			this.dateTimePickerDatePas.Name = "dateTimePickerDatePas";
			this.dateTimePickerDatePas.Size = new System.Drawing.Size(181, 24);
			this.dateTimePickerDatePas.TabIndex = 7;
			this.dateTimePickerDatePas.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
			this.dateTimePickerDatePas.ValueChanged += new System.EventHandler(this.dateTimePickerDatePas_ValueChanged);
			// 
			// buttonAddClient
			// 
			this.buttonAddClient.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAddClient.Location = new System.Drawing.Point(12, 334);
			this.buttonAddClient.Name = "buttonAddClient";
			this.buttonAddClient.Size = new System.Drawing.Size(181, 38);
			this.buttonAddClient.TabIndex = 8;
			this.buttonAddClient.Text = "Добавить";
			this.buttonAddClient.UseVisualStyleBackColor = false;
			this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 18);
			this.label1.TabIndex = 9;
			this.label1.Text = "Введите фамилию";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 18);
			this.label2.TabIndex = 10;
			this.label2.Text = "Введите имя";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 18);
			this.label3.TabIndex = 11;
			this.label3.Text = "Введите отчество";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(182, 18);
			this.label4.TabIndex = 12;
			this.label4.Text = "Введите номер паспорта";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 227);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(181, 18);
			this.label5.TabIndex = 13;
			this.label5.Text = "Введите серию паспорта";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 274);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(157, 18);
			this.label6.TabIndex = 14;
			this.label6.Text = "Введите дату выдачи";
			// 
			// ClientFormAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(734, 415);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAddClient);
			this.Controls.Add(this.dateTimePickerDatePas);
			this.Controls.Add(this.textBoxSeria);
			this.Controls.Add(this.textBoxNumber);
			this.Controls.Add(this.textBoxPatronimic);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxSurname);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.dataGridViewAddClient);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ClientFormAdd";
			this.Text = "ClientFormAdd";
			this.Load += new System.EventHandler(this.ClientFormAdd_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddClient)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewAddClient;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.TextBox textBoxSurname;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxNumber;
		private System.Windows.Forms.TextBox textBoxPatronimic;
		private System.Windows.Forms.TextBox textBoxSeria;
		private System.Windows.Forms.DateTimePicker dateTimePickerDatePas;
		private System.Windows.Forms.Button buttonAddClient;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}