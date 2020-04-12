namespace IndividProject.Forms
{
	partial class ForthQuery
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
			this.buttonUpload = new System.Windows.Forms.Button();
			this.dataGridViewShowQuery = new System.Windows.Forms.DataGridView();
			this.textBoxMoney = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
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
			// buttonUpload
			// 
			this.buttonUpload.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonUpload.Location = new System.Drawing.Point(250, 370);
			this.buttonUpload.Name = "buttonUpload";
			this.buttonUpload.Size = new System.Drawing.Size(237, 31);
			this.buttonUpload.TabIndex = 11;
			this.buttonUpload.Text = "Выгрузить";
			this.buttonUpload.UseVisualStyleBackColor = false;
			this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
			// 
			// dataGridViewShowQuery
			// 
			this.dataGridViewShowQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewShowQuery.Location = new System.Drawing.Point(12, 62);
			this.dataGridViewShowQuery.Name = "dataGridViewShowQuery";
			this.dataGridViewShowQuery.ReadOnly = true;
			this.dataGridViewShowQuery.Size = new System.Drawing.Size(710, 228);
			this.dataGridViewShowQuery.TabIndex = 10;
			// 
			// textBoxMoney
			// 
			this.textBoxMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxMoney.Location = new System.Drawing.Point(250, 324);
			this.textBoxMoney.Name = "textBoxMoney";
			this.textBoxMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBoxMoney.Size = new System.Drawing.Size(237, 30);
			this.textBoxMoney.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(254, 293);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 25);
			this.label1.TabIndex = 17;
			this.label1.Text = "Введите цену";
			// 
			// ForthQuery
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(734, 415);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxMoney);
			this.Controls.Add(this.buttonUpload);
			this.Controls.Add(this.dataGridViewShowQuery);
			this.Controls.Add(this.buttonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ForthQuery";
			this.Text = "ForthQuery";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowQuery)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonUpload;
		private System.Windows.Forms.DataGridView dataGridViewShowQuery;
		private System.Windows.Forms.TextBox textBoxMoney;
		private System.Windows.Forms.Label label1;
	}
}