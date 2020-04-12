namespace IndividProject.Forms
{
	partial class ClientFormDelete
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
			this.dataGridViewShowClient = new System.Windows.Forms.DataGridView();
			this.buttonDeleteClient = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowClient)).BeginInit();
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
			// dataGridViewShowClient
			// 
			this.dataGridViewShowClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewShowClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewShowClient.Location = new System.Drawing.Point(32, 61);
			this.dataGridViewShowClient.Name = "dataGridViewShowClient";
			this.dataGridViewShowClient.ReadOnly = true;
			this.dataGridViewShowClient.Size = new System.Drawing.Size(672, 268);
			this.dataGridViewShowClient.TabIndex = 7;
			// 
			// buttonDeleteClient
			// 
			this.buttonDeleteClient.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDeleteClient.Location = new System.Drawing.Point(294, 350);
			this.buttonDeleteClient.Name = "buttonDeleteClient";
			this.buttonDeleteClient.Size = new System.Drawing.Size(138, 42);
			this.buttonDeleteClient.TabIndex = 8;
			this.buttonDeleteClient.Text = "Удалить";
			this.buttonDeleteClient.UseVisualStyleBackColor = false;
			this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
			// 
			// ClientFormDelete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(734, 415);
			this.Controls.Add(this.buttonDeleteClient);
			this.Controls.Add(this.dataGridViewShowClient);
			this.Controls.Add(this.buttonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ClientFormDelete";
			this.Text = "ClientFormDelete";
			this.Load += new System.EventHandler(this.ClientFormDelete_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowClient)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.DataGridView dataGridViewShowClient;
		private System.Windows.Forms.Button buttonDeleteClient;
	}
}