namespace IndividProject.Forms
{
	partial class ThirdQuery
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
			this.dataGridViewShowQuery = new System.Windows.Forms.DataGridView();
			this.dateTimePickerDateTake = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerDateGive = new System.Windows.Forms.DateTimePicker();
			this.buttonUpload = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowQuery)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExit.Location = new System.Drawing.Point(12, 12);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(93, 31);
			this.buttonExit.TabIndex = 8;
			this.buttonExit.Text = "Закрыть";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// dataGridViewShowQuery
			// 
			this.dataGridViewShowQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewShowQuery.Location = new System.Drawing.Point(12, 67);
			this.dataGridViewShowQuery.Name = "dataGridViewShowQuery";
			this.dataGridViewShowQuery.ReadOnly = true;
			this.dataGridViewShowQuery.Size = new System.Drawing.Size(710, 228);
			this.dataGridViewShowQuery.TabIndex = 14;
			// 
			// dateTimePickerDateTake
			// 
			this.dateTimePickerDateTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDateTake.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDateTake.Location = new System.Drawing.Point(404, 330);
			this.dateTimePickerDateTake.Name = "dateTimePickerDateTake";
			this.dateTimePickerDateTake.Size = new System.Drawing.Size(124, 27);
			this.dateTimePickerDateTake.TabIndex = 16;
			this.dateTimePickerDateTake.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
			// 
			// dateTimePickerDateGive
			// 
			this.dateTimePickerDateGive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDateGive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDateGive.Location = new System.Drawing.Point(191, 330);
			this.dateTimePickerDateGive.Name = "dateTimePickerDateGive";
			this.dateTimePickerDateGive.Size = new System.Drawing.Size(125, 27);
			this.dateTimePickerDateGive.TabIndex = 15;
			this.dateTimePickerDateGive.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
			// 
			// buttonUpload
			// 
			this.buttonUpload.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonUpload.Location = new System.Drawing.Point(246, 372);
			this.buttonUpload.Name = "buttonUpload";
			this.buttonUpload.Size = new System.Drawing.Size(237, 31);
			this.buttonUpload.TabIndex = 17;
			this.buttonUpload.Text = "Выгрузить";
			this.buttonUpload.UseVisualStyleBackColor = false;
			this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(198, 302);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 25);
			this.label1.TabIndex = 18;
			this.label1.Text = "С какого";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(409, 302);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 25);
			this.label2.TabIndex = 19;
			this.label2.Text = "По какое";
			// 
			// ThirdQuery
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(734, 415);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonUpload);
			this.Controls.Add(this.dateTimePickerDateTake);
			this.Controls.Add(this.dateTimePickerDateGive);
			this.Controls.Add(this.dataGridViewShowQuery);
			this.Controls.Add(this.buttonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ThirdQuery";
			this.Text = "ThirdQuery";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowQuery)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.DataGridView dataGridViewShowQuery;
		private System.Windows.Forms.DateTimePicker dateTimePickerDateTake;
		private System.Windows.Forms.DateTimePicker dateTimePickerDateGive;
		private System.Windows.Forms.Button buttonUpload;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}