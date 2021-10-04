namespace GetPi
{
    partial class FormMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.countRect = new System.Windows.Forms.Label();
            this.countCircle = new System.Windows.Forms.Label();
            this.pi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // countRect
            // 
            this.countRect.AutoSize = true;
            this.countRect.Location = new System.Drawing.Point(440, 500);
            this.countRect.Name = "countRect";
            this.countRect.Size = new System.Drawing.Size(13, 13);
            this.countRect.TabIndex = 1;
            this.countRect.Text = "0";
            // 
            // countCircle
            // 
            this.countCircle.AutoSize = true;
            this.countCircle.Location = new System.Drawing.Point(96, 500);
            this.countCircle.Name = "countCircle";
            this.countCircle.Size = new System.Drawing.Size(13, 13);
            this.countCircle.TabIndex = 2;
            this.countCircle.Text = "0";
            // 
            // pi
            // 
            this.pi.AutoSize = true;
            this.pi.Location = new System.Drawing.Point(301, 13);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(13, 13);
            this.pi.TabIndex = 3;
            this.pi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pi =";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pi);
            this.Controls.Add(this.countCircle);
            this.Controls.Add(this.countRect);
            this.Controls.Add(this.button1);
            this.Name = "FormMain";
            this.Text = "Calculation Pi";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label countRect;
        private System.Windows.Forms.Label countCircle;
        private System.Windows.Forms.Label pi;
        private System.Windows.Forms.Label label1;
    }
}

