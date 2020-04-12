namespace IndividProject.Forms
{
	partial class UpdateOrder
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
			this.dateTimePickerDateTake = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerDateGive = new System.Windows.Forms.DateTimePicker();
			this.textBoxComission = new System.Windows.Forms.TextBox();
			this.textBoxSumma = new System.Windows.Forms.TextBox();
			this.textBoxDiscriptionOrder = new System.Windows.Forms.TextBox();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewAddClient = new System.Windows.Forms.DataGridView();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonChange = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddClient)).BeginInit();
			this.SuspendLayout();
			// 
			// dateTimePickerDateTake
			// 
			this.dateTimePickerDateTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDateTake.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDateTake.Location = new System.Drawing.Point(237, 293);
			this.dateTimePickerDateTake.Name = "dateTimePickerDateTake";
			this.dateTimePickerDateTake.Size = new System.Drawing.Size(140, 24);
			this.dateTimePickerDateTake.TabIndex = 20;
			this.dateTimePickerDateTake.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
			// 
			// dateTimePickerDateGive
			// 
			this.dateTimePickerDateGive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDateGive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDateGive.Location = new System.Drawing.Point(237, 229);
			this.dateTimePickerDateGive.Name = "dateTimePickerDateGive";
			this.dateTimePickerDateGive.Size = new System.Drawing.Size(140, 24);
			this.dateTimePickerDateGive.TabIndex = 19;
			this.dateTimePickerDateGive.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
			// 
			// textBoxComission
			// 
			this.textBoxComission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxComission.Location = new System.Drawing.Point(421, 328);
			this.textBoxComission.Name = "textBoxComission";
			this.textBoxComission.Size = new System.Drawing.Size(261, 24);
			this.textBoxComission.TabIndex = 18;
			// 
			// textBoxSumma
			// 
			this.textBoxSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSumma.Location = new System.Drawing.Point(421, 280);
			this.textBoxSumma.Name = "textBoxSumma";
			this.textBoxSumma.Size = new System.Drawing.Size(261, 24);
			this.textBoxSumma.TabIndex = 17;
			this.textBoxSumma.TextChanged += new System.EventHandler(this.textBoxSumma_TextChanged);
			// 
			// textBoxDiscriptionOrder
			// 
			this.textBoxDiscriptionOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDiscriptionOrder.Location = new System.Drawing.Point(421, 229);
			this.textBoxDiscriptionOrder.Name = "textBoxDiscriptionOrder";
			this.textBoxDiscriptionOrder.Size = new System.Drawing.Size(261, 24);
			this.textBoxDiscriptionOrder.TabIndex = 16;
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Location = new System.Drawing.Point(47, 228);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(143, 26);
			this.comboBoxCategory.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(329, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 25);
			this.label2.TabIndex = 14;
			this.label2.Text = "Клиенты";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(62, 200);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 25);
			this.label1.TabIndex = 13;
			this.label1.Text = "Категории";
			// 
			// dataGridViewAddClient
			// 
			this.dataGridViewAddClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAddClient.Location = new System.Drawing.Point(47, 49);
			this.dataGridViewAddClient.Name = "dataGridViewAddClient";
			this.dataGridViewAddClient.ReadOnly = true;
			this.dataGridViewAddClient.Size = new System.Drawing.Size(635, 139);
			this.dataGridViewAddClient.TabIndex = 12;
			this.dataGridViewAddClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddClient_CellClick);
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExit.Location = new System.Drawing.Point(12, 12);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(93, 31);
			this.buttonExit.TabIndex = 21;
			this.buttonExit.Text = "Закрыть";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonChange
			// 
			this.buttonChange.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonChange.Location = new System.Drawing.Point(227, 358);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(254, 31);
			this.buttonChange.TabIndex = 22;
			this.buttonChange.Text = "Сохранить";
			this.buttonChange.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(234, 272);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 18);
			this.label7.TabIndex = 27;
			this.label7.Text = "Дата возврата";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(234, 205);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 18);
			this.label6.TabIndex = 26;
			this.label6.Text = "Дата сдачи";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(418, 307);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(245, 18);
			this.label5.TabIndex = 25;
			this.label5.Text = "Введите комиссионные предмета";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(418, 256);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(172, 18);
			this.label4.TabIndex = 24;
			this.label4.Text = "Введите цену предмета";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(418, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(206, 18);
			this.label3.TabIndex = 23;
			this.label3.Text = "Введите описание предмета";
			// 
			// UpdateOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(735, 401);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonChange);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.dateTimePickerDateTake);
			this.Controls.Add(this.dateTimePickerDateGive);
			this.Controls.Add(this.textBoxComission);
			this.Controls.Add(this.textBoxSumma);
			this.Controls.Add(this.textBoxDiscriptionOrder);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewAddClient);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UpdateOrder";
			this.Text = "UpdateOrder";
			this.Load += new System.EventHandler(this.UpdateOrder_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdateOrder_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddClient)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonExit;
		internal System.Windows.Forms.DateTimePicker dateTimePickerDateTake;
		internal System.Windows.Forms.DateTimePicker dateTimePickerDateGive;
		internal System.Windows.Forms.TextBox textBoxComission;
		internal System.Windows.Forms.TextBox textBoxSumma;
		internal System.Windows.Forms.TextBox textBoxDiscriptionOrder;
		internal System.Windows.Forms.ComboBox comboBoxCategory;
		internal System.Windows.Forms.DataGridView dataGridViewAddClient;
		private System.Windows.Forms.Button buttonChange;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
	}
}