﻿namespace IndividProject.Forms
{
	partial class FirstQuery
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
			this.dataGridViewShowQuery = new System.Windows.Forms.DataGridView();
			this.buttonExit = new System.Windows.Forms.Button();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.buttonUpload = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowQuery)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewShowQuery
			// 
			this.dataGridViewShowQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewShowQuery.Location = new System.Drawing.Point(12, 57);
			this.dataGridViewShowQuery.Name = "dataGridViewShowQuery";
			this.dataGridViewShowQuery.ReadOnly = true;
			this.dataGridViewShowQuery.Size = new System.Drawing.Size(710, 217);
			this.dataGridViewShowQuery.TabIndex = 2;
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExit.Location = new System.Drawing.Point(12, 12);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(93, 31);
			this.buttonExit.TabIndex = 7;
			this.buttonExit.Text = "Закрыть";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Location = new System.Drawing.Point(250, 302);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(237, 28);
			this.comboBoxCategory.TabIndex = 8;
			// 
			// buttonUpload
			// 
			this.buttonUpload.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonUpload.Location = new System.Drawing.Point(250, 346);
			this.buttonUpload.Name = "buttonUpload";
			this.buttonUpload.Size = new System.Drawing.Size(237, 31);
			this.buttonUpload.TabIndex = 9;
			this.buttonUpload.Text = "Выгрузить";
			this.buttonUpload.UseVisualStyleBackColor = false;
			this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(313, 274);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 25);
			this.label1.TabIndex = 19;
			this.label1.Text = "Категории";
			// 
			// FirstQuery
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(734, 415);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonUpload);
			this.Controls.Add(this.comboBoxCategory);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.dataGridViewShowQuery);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FirstQuery";
			this.Text = "FirstQuery";
			this.Load += new System.EventHandler(this.FirstQuery_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowQuery)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewShowQuery;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.ComboBox comboBoxCategory;
		private System.Windows.Forms.Button buttonUpload;
		private System.Windows.Forms.Label label1;
	}
}