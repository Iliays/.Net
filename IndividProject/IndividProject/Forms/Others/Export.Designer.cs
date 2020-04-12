namespace IndividProject.Forms
{
	partial class Export
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
			this.buttonExit = new System.Windows.Forms.Button();
			this.dataGridViewAddClient = new System.Windows.Forms.DataGridView();
			this.dateTimePickerDateGive = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonExportData = new System.Windows.Forms.Button();
			this.comboBoxCat = new System.Windows.Forms.ComboBox();
			this.checkBoxDate = new System.Windows.Forms.CheckBox();
			this.buttonImport = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddClient)).BeginInit();
			this.SuspendLayout();
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
			// dataGridViewAddClient
			// 
			this.dataGridViewAddClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAddClient.Location = new System.Drawing.Point(12, 49);
			this.dataGridViewAddClient.Name = "dataGridViewAddClient";
			this.dataGridViewAddClient.ReadOnly = true;
			this.dataGridViewAddClient.Size = new System.Drawing.Size(710, 179);
			this.dataGridViewAddClient.TabIndex = 10;
			this.dataGridViewAddClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddClient_CellClick);
			// 
			// dateTimePickerDateGive
			// 
			this.dateTimePickerDateGive.Enabled = false;
			this.dateTimePickerDateGive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDateGive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDateGive.Location = new System.Drawing.Point(275, 282);
			this.dateTimePickerDateGive.Name = "dateTimePickerDateGive";
			this.dateTimePickerDateGive.Size = new System.Drawing.Size(143, 27);
			this.dateTimePickerDateGive.TabIndex = 11;
			this.dateTimePickerDateGive.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(62, 249);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 25);
			this.label1.TabIndex = 12;
			this.label1.Text = "Категории";
			// 
			// buttonExportData
			// 
			this.buttonExportData.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonExportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExportData.Location = new System.Drawing.Point(46, 338);
			this.buttonExportData.Name = "buttonExportData";
			this.buttonExportData.Size = new System.Drawing.Size(274, 36);
			this.buttonExportData.TabIndex = 14;
			this.buttonExportData.Text = "Экспорт";
			this.buttonExportData.UseVisualStyleBackColor = false;
			this.buttonExportData.Click += new System.EventHandler(this.buttonExportData_Click);
			// 
			// comboBoxCat
			// 
			this.comboBoxCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxCat.FormattingEnabled = true;
			this.comboBoxCat.Location = new System.Drawing.Point(46, 281);
			this.comboBoxCat.Name = "comboBoxCat";
			this.comboBoxCat.Size = new System.Drawing.Size(151, 28);
			this.comboBoxCat.TabIndex = 15;
			// 
			// checkBoxDate
			// 
			this.checkBoxDate.AutoSize = true;
			this.checkBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxDate.Location = new System.Drawing.Point(275, 254);
			this.checkBoxDate.Name = "checkBoxDate";
			this.checkBoxDate.Size = new System.Drawing.Size(288, 22);
			this.checkBoxDate.TabIndex = 16;
			this.checkBoxDate.Text = "Если хотите от определенного числа";
			this.checkBoxDate.UseVisualStyleBackColor = true;
			this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
			// 
			// buttonImport
			// 
			this.buttonImport.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonImport.Location = new System.Drawing.Point(426, 338);
			this.buttonImport.Name = "buttonImport";
			this.buttonImport.Size = new System.Drawing.Size(274, 36);
			this.buttonImport.TabIndex = 17;
			this.buttonImport.Text = "Импорт";
			this.buttonImport.UseVisualStyleBackColor = false;
			this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
			// 
			// Export
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(734, 415);
			this.Controls.Add(this.buttonImport);
			this.Controls.Add(this.checkBoxDate);
			this.Controls.Add(this.comboBoxCat);
			this.Controls.Add(this.buttonExportData);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePickerDateGive);
			this.Controls.Add(this.dataGridViewAddClient);
			this.Controls.Add(this.buttonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Export";
			this.Text = "Export";
			this.Load += new System.EventHandler(this.Export_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddClient)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.DataGridView dataGridViewAddClient;
		private System.Windows.Forms.DateTimePicker dateTimePickerDateGive;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonExportData;
		private System.Windows.Forms.ComboBox comboBoxCat;
		private System.Windows.Forms.CheckBox checkBoxDate;
		private System.Windows.Forms.Button buttonImport;
	}
}