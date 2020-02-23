namespace WindowsFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_raschot = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_raschot
            // 
            this.btn_raschot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_raschot.Location = new System.Drawing.Point(266, 184);
            this.btn_raschot.Name = "btn_raschot";
            this.btn_raschot.Size = new System.Drawing.Size(216, 58);
            this.btn_raschot.TabIndex = 1;
            this.btn_raschot.Text = "Рассчитать!";
            this.btn_raschot.UseVisualStyleBackColor = true;
            this.btn_raschot.Click += new System.EventHandler(this.btn_raschot_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(278, 276);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(203, 20);
            this.txt_result.TabIndex = 2;
            this.txt_result.TextChanged += new System.EventHandler(this.txt_result_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 323);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_raschot);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Count";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_raschot;
        private System.Windows.Forms.TextBox txt_result;
    }
}

