namespace IndividProject.Forms
{
	partial class ShowOrdersForm
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
			this.dataGridViewAddOrder = new System.Windows.Forms.DataGridView();
			this.buttonExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddOrder)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAddOrder
			// 
			this.dataGridViewAddOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAddOrder.Location = new System.Drawing.Point(12, 49);
			this.dataGridViewAddOrder.Name = "dataGridViewAddOrder";
			this.dataGridViewAddOrder.ReadOnly = true;
			this.dataGridViewAddOrder.Size = new System.Drawing.Size(790, 316);
			this.dataGridViewAddOrder.TabIndex = 1;
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExit.Location = new System.Drawing.Point(12, 12);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(93, 31);
			this.buttonExit.TabIndex = 3;
			this.buttonExit.Text = "Закрыть";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// ShowOrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 390);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.dataGridViewAddOrder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ShowOrdersForm";
			this.Text = "ShowOrdersForm";
			this.Load += new System.EventHandler(this.ShowOrdersForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddOrder)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewAddOrder;
		private System.Windows.Forms.Button buttonExit;
	}
}