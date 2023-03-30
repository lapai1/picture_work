namespace WindowsFormsApplication1 {
	partial class Form1 {
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picFrom = new System.Windows.Forms.PictureBox();
            this.picTo = new System.Windows.Forms.PictureBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTo)).BeginInit();
            this.SuspendLayout();
            // 
            // picFrom
            // 
            this.picFrom.Image = ((System.Drawing.Image)(resources.GetObject("picFrom.Image")));
            this.picFrom.Location = new System.Drawing.Point(12, 12);
            this.picFrom.Name = "picFrom";
            this.picFrom.Size = new System.Drawing.Size(265, 418);
            this.picFrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFrom.TabIndex = 0;
            this.picFrom.TabStop = false;
            this.picFrom.Click += new System.EventHandler(this.picFrom_Click);
            // 
            // picTo
            // 
            this.picTo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picTo.Image = ((System.Drawing.Image)(resources.GetObject("picTo.Image")));
            this.picTo.InitialImage = null;
            this.picTo.Location = new System.Drawing.Point(450, 12);
            this.picTo.Name = "picTo";
            this.picTo.Size = new System.Drawing.Size(257, 418);
            this.picTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTo.TabIndex = 1;
            this.picTo.TabStop = false;
            this.picTo.Click += new System.EventHandler(this.picTo_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(283, 12);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(161, 40);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Сделать мозаику";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выбор картинки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(505, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите размер чипов \"x * x\".          x =";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 497);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(728, 546);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.picTo);
            this.Controls.Add(this.picFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picFrom;
		private System.Windows.Forms.PictureBox picTo;
		private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

