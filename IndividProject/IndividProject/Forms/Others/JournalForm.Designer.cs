namespace IndividProject.Forms.Others
{
	partial class JournalForm
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
			this.dataGridViewJournalShow = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournalShow)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExit.Location = new System.Drawing.Point(12, 12);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(93, 31);
			this.buttonExit.TabIndex = 10;
			this.buttonExit.Text = "Закрыть";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// dataGridViewJournalShow
			// 
			this.dataGridViewJournalShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewJournalShow.Location = new System.Drawing.Point(12, 49);
			this.dataGridViewJournalShow.Name = "dataGridViewJournalShow";
			this.dataGridViewJournalShow.ReadOnly = true;
			this.dataGridViewJournalShow.Size = new System.Drawing.Size(710, 340);
			this.dataGridViewJournalShow.TabIndex = 11;
			// 
			// JournalForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(734, 415);
			this.Controls.Add(this.dataGridViewJournalShow);
			this.Controls.Add(this.buttonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "JournalForm";
			this.Text = "JournalForm";
			this.Load += new System.EventHandler(this.JournalForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournalShow)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.DataGridView dataGridViewJournalShow;
	}
}