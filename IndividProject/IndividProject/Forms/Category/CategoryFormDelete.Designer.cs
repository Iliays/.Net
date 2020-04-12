namespace IndividProject.Forms
{
	partial class CategoryFormDelete
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
			this.dataGridViewShowCategory = new System.Windows.Forms.DataGridView();
			this.buttonDeleteCategory = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCategory)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExit.Location = new System.Drawing.Point(12, 12);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(93, 31);
			this.buttonExit.TabIndex = 5;
			this.buttonExit.Text = "Закрыть";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// dataGridViewShowCategory
			// 
			this.dataGridViewShowCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewShowCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewShowCategory.Location = new System.Drawing.Point(35, 60);
			this.dataGridViewShowCategory.Name = "dataGridViewShowCategory";
			this.dataGridViewShowCategory.ReadOnly = true;
			this.dataGridViewShowCategory.Size = new System.Drawing.Size(672, 268);
			this.dataGridViewShowCategory.TabIndex = 6;
			// 
			// buttonDeleteCategory
			// 
			this.buttonDeleteCategory.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDeleteCategory.Location = new System.Drawing.Point(289, 334);
			this.buttonDeleteCategory.Name = "buttonDeleteCategory";
			this.buttonDeleteCategory.Size = new System.Drawing.Size(138, 42);
			this.buttonDeleteCategory.TabIndex = 7;
			this.buttonDeleteCategory.Text = "Удалить";
			this.buttonDeleteCategory.UseVisualStyleBackColor = false;
			this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
			// 
			// CategoryFormDelete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(734, 415);
			this.Controls.Add(this.buttonDeleteCategory);
			this.Controls.Add(this.dataGridViewShowCategory);
			this.Controls.Add(this.buttonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CategoryFormDelete";
			this.Text = "CategoryFormDelete";
			this.Load += new System.EventHandler(this.CategoryFormDelete_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCategory)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.DataGridView dataGridViewShowCategory;
		private System.Windows.Forms.Button buttonDeleteCategory;
	}
}