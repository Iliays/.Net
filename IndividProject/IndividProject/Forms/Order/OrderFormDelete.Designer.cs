namespace IndividProject.Forms
{
	partial class OrderFormDelete
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
			this.dataGridViewShowOrder = new System.Windows.Forms.DataGridView();
			this.buttonDeleteOrder = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowOrder)).BeginInit();
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
			// dataGridViewShowOrder
			// 
			this.dataGridViewShowOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewShowOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewShowOrder.Location = new System.Drawing.Point(31, 65);
			this.dataGridViewShowOrder.Name = "dataGridViewShowOrder";
			this.dataGridViewShowOrder.ReadOnly = true;
			this.dataGridViewShowOrder.Size = new System.Drawing.Size(672, 268);
			this.dataGridViewShowOrder.TabIndex = 8;
			// 
			// buttonDeleteOrder
			// 
			this.buttonDeleteOrder.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDeleteOrder.Location = new System.Drawing.Point(282, 350);
			this.buttonDeleteOrder.Name = "buttonDeleteOrder";
			this.buttonDeleteOrder.Size = new System.Drawing.Size(138, 42);
			this.buttonDeleteOrder.TabIndex = 9;
			this.buttonDeleteOrder.Text = "Удалить";
			this.buttonDeleteOrder.UseVisualStyleBackColor = false;
			this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
			// 
			// OrderFormDelete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(734, 415);
			this.Controls.Add(this.buttonDeleteOrder);
			this.Controls.Add(this.dataGridViewShowOrder);
			this.Controls.Add(this.buttonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "OrderFormDelete";
			this.Text = "OrderFormDelete";
			this.Load += new System.EventHandler(this.OrderFormDelete_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowOrder)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.DataGridView dataGridViewShowOrder;
		private System.Windows.Forms.Button buttonDeleteOrder;
	}
}