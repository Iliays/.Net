namespace IndividProject
{
	partial class CategoryFormAdd
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonAddCategory = new System.Windows.Forms.Button();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxDiscription = new System.Windows.Forms.TextBox();
			this.dataGridViewShowCategory = new System.Windows.Forms.DataGridView();
			this.buttonExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCategory)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAddCategory
			// 
			this.buttonAddCategory.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAddCategory.Location = new System.Drawing.Point(33, 207);
			this.buttonAddCategory.Name = "buttonAddCategory";
			this.buttonAddCategory.Size = new System.Drawing.Size(138, 42);
			this.buttonAddCategory.TabIndex = 0;
			this.buttonAddCategory.Text = "Добавить";
			this.buttonAddCategory.UseVisualStyleBackColor = false;
			this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxName.Location = new System.Drawing.Point(33, 114);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(138, 24);
			this.textBoxName.TabIndex = 1;
			// 
			// textBoxDiscription
			// 
			this.textBoxDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDiscription.Location = new System.Drawing.Point(33, 169);
			this.textBoxDiscription.Name = "textBoxDiscription";
			this.textBoxDiscription.Size = new System.Drawing.Size(138, 24);
			this.textBoxDiscription.TabIndex = 2;
			// 
			// dataGridViewShowCategory
			// 
			this.dataGridViewShowCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewShowCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewShowCategory.Location = new System.Drawing.Point(214, 28);
			this.dataGridViewShowCategory.Name = "dataGridViewShowCategory";
			this.dataGridViewShowCategory.ReadOnly = true;
			this.dataGridViewShowCategory.Size = new System.Drawing.Size(494, 356);
			this.dataGridViewShowCategory.TabIndex = 3;
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonExit.Location = new System.Drawing.Point(12, 12);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(93, 31);
			this.buttonExit.TabIndex = 4;
			this.buttonExit.Text = "Закрыть";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(30, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 18);
			this.label1.TabIndex = 5;
			this.label1.Text = "Введите название";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(30, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "Введите описание";
			// 
			// CategoryFormAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(734, 415);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.dataGridViewShowCategory);
			this.Controls.Add(this.textBoxDiscription);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.buttonAddCategory);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CategoryFormAdd";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.CategoryForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCategory)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAddCategory;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxDiscription;
		private System.Windows.Forms.DataGridView dataGridViewShowCategory;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

