namespace IndividProject.Forms
{
	partial class UpdateCategory
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
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxDiscription = new System.Windows.Forms.TextBox();
			this.buttonChange = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(98, 87);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(164, 20);
			this.textBoxName.TabIndex = 0;
			// 
			// textBoxDiscription
			// 
			this.textBoxDiscription.Location = new System.Drawing.Point(98, 132);
			this.textBoxDiscription.Name = "textBoxDiscription";
			this.textBoxDiscription.Size = new System.Drawing.Size(164, 20);
			this.textBoxDiscription.TabIndex = 1;
			// 
			// buttonChange
			// 
			this.buttonChange.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonChange.Location = new System.Drawing.Point(98, 173);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(164, 31);
			this.buttonChange.TabIndex = 2;
			this.buttonChange.Text = "Сохранить";
			this.buttonChange.UseVisualStyleBackColor = true;
			// 
			// buttonExit
			// 
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExit.Location = new System.Drawing.Point(12, 12);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(93, 29);
			this.buttonExit.TabIndex = 3;
			this.buttonExit.Text = "Закрыть";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(95, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 18);
			this.label2.TabIndex = 8;
			this.label2.Text = "Введите описание";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(96, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 18);
			this.label1.TabIndex = 7;
			this.label1.Text = "Введите название";
			// 
			// UpdateCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 272);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonChange);
			this.Controls.Add(this.textBoxDiscription);
			this.Controls.Add(this.textBoxName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UpdateCategory";
			this.Text = "MainUpdate";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.TextBox textBoxName;
		internal System.Windows.Forms.TextBox textBoxDiscription;
		private System.Windows.Forms.Button buttonChange;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}