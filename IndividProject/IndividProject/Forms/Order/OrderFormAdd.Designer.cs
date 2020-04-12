namespace IndividProject.Forms
{
	partial class OrderFormAdd
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
			this.buttonAddOrder = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.textBoxDiscriptionOrder = new System.Windows.Forms.TextBox();
			this.textBoxSumma = new System.Windows.Forms.TextBox();
			this.textBoxComission = new System.Windows.Forms.TextBox();
			this.dateTimePickerDateGive = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerDateTake = new System.Windows.Forms.DateTimePicker();
			this.buttonShowDataGridView = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddClient)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAddClient
			// 
			this.dataGridViewAddClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAddClient.Location = new System.Drawing.Point(53, 49);
			this.dataGridViewAddClient.Name = "dataGridViewAddClient";
			this.dataGridViewAddClient.ReadOnly = true;
			this.dataGridViewAddClient.Size = new System.Drawing.Size(635, 139);
			this.dataGridViewAddClient.TabIndex = 1;
			this.dataGridViewAddClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddClient_CellContentClick);
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExit.Location = new System.Drawing.Point(12, 12);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(93, 31);
			this.buttonExit.TabIndex = 2;
			this.buttonExit.Text = "Закрыть";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonAddOrder
			// 
			this.buttonAddOrder.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAddOrder.Location = new System.Drawing.Point(243, 363);
			this.buttonAddOrder.Name = "buttonAddOrder";
			this.buttonAddOrder.Size = new System.Drawing.Size(274, 36);
			this.buttonAddOrder.TabIndex = 3;
			this.buttonAddOrder.Text = "Добавить";
			this.buttonAddOrder.UseVisualStyleBackColor = false;
			this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(68, 200);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Категории";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(335, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "Клиенты";
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Location = new System.Drawing.Point(53, 228);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(143, 26);
			this.comboBoxCategory.TabIndex = 6;
			// 
			// textBoxDiscriptionOrder
			// 
			this.textBoxDiscriptionOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDiscriptionOrder.Location = new System.Drawing.Point(427, 228);
			this.textBoxDiscriptionOrder.Name = "textBoxDiscriptionOrder";
			this.textBoxDiscriptionOrder.Size = new System.Drawing.Size(261, 24);
			this.textBoxDiscriptionOrder.TabIndex = 7;
			// 
			// textBoxSumma
			// 
			this.textBoxSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSumma.Location = new System.Drawing.Point(427, 281);
			this.textBoxSumma.Name = "textBoxSumma";
			this.textBoxSumma.Size = new System.Drawing.Size(261, 24);
			this.textBoxSumma.TabIndex = 8;
			// 
			// textBoxComission
			// 
			this.textBoxComission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxComission.Location = new System.Drawing.Point(427, 333);
			this.textBoxComission.Name = "textBoxComission";
			this.textBoxComission.Size = new System.Drawing.Size(261, 24);
			this.textBoxComission.TabIndex = 9;
			// 
			// dateTimePickerDateGive
			// 
			this.dateTimePickerDateGive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDateGive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDateGive.Location = new System.Drawing.Point(243, 229);
			this.dateTimePickerDateGive.Name = "dateTimePickerDateGive";
			this.dateTimePickerDateGive.Size = new System.Drawing.Size(140, 24);
			this.dateTimePickerDateGive.TabIndex = 10;
			this.dateTimePickerDateGive.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
			this.dateTimePickerDateGive.ValueChanged += new System.EventHandler(this.dateTimePickerDateGive_ValueChanged);
			// 
			// dateTimePickerDateTake
			// 
			this.dateTimePickerDateTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDateTake.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDateTake.Location = new System.Drawing.Point(243, 293);
			this.dateTimePickerDateTake.Name = "dateTimePickerDateTake";
			this.dateTimePickerDateTake.Size = new System.Drawing.Size(140, 24);
			this.dateTimePickerDateTake.TabIndex = 11;
			this.dateTimePickerDateTake.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
			this.dateTimePickerDateTake.ValueChanged += new System.EventHandler(this.dateTimePickerDateTake_ValueChanged);
			// 
			// buttonShowDataGridView
			// 
			this.buttonShowDataGridView.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonShowDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonShowDataGridView.Location = new System.Drawing.Point(53, 368);
			this.buttonShowDataGridView.Name = "buttonShowDataGridView";
			this.buttonShowDataGridView.Size = new System.Drawing.Size(143, 31);
			this.buttonShowDataGridView.TabIndex = 12;
			this.buttonShowDataGridView.Text = "Посмотреть";
			this.buttonShowDataGridView.UseVisualStyleBackColor = false;
			this.buttonShowDataGridView.Click += new System.EventHandler(this.buttonShowDataGridView_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(437, 205);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(206, 18);
			this.label3.TabIndex = 13;
			this.label3.Text = "Введите описание предмета";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(437, 255);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(172, 18);
			this.label4.TabIndex = 14;
			this.label4.Text = "Введите цену предмета";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(437, 308);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(245, 18);
			this.label5.TabIndex = 15;
			this.label5.Text = "Введите комиссионные предмета";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(248, 208);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 18);
			this.label6.TabIndex = 16;
			this.label6.Text = "Дата сдачи";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(248, 272);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 18);
			this.label7.TabIndex = 17;
			this.label7.Text = "Дата возврата";
			// 
			// OrderFormAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(734, 415);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonShowDataGridView);
			this.Controls.Add(this.dateTimePickerDateTake);
			this.Controls.Add(this.dateTimePickerDateGive);
			this.Controls.Add(this.textBoxComission);
			this.Controls.Add(this.textBoxSumma);
			this.Controls.Add(this.textBoxDiscriptionOrder);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAddOrder);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.dataGridViewAddClient);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "OrderFormAdd";
			this.Text = "OrderFormAdd";
			this.Load += new System.EventHandler(this.OrderFormAdd_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddClient)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridViewAddClient;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonAddOrder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxCategory;
		private System.Windows.Forms.TextBox textBoxDiscriptionOrder;
		private System.Windows.Forms.TextBox textBoxSumma;
		private System.Windows.Forms.TextBox textBoxComission;
		private System.Windows.Forms.DateTimePicker dateTimePickerDateGive;
		private System.Windows.Forms.DateTimePicker dateTimePickerDateTake;
		private System.Windows.Forms.Button buttonShowDataGridView;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}