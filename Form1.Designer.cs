namespace AbstractFabric
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
            this.buttonArcher = new System.Windows.Forms.Button();
            this.buttonWarrior = new System.Windows.Forms.Button();
            this.buttonMage = new System.Windows.Forms.Button();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonArcher
            // 
            this.buttonArcher.Location = new System.Drawing.Point(78, 166);
            this.buttonArcher.Name = "buttonArcher";
            this.buttonArcher.Size = new System.Drawing.Size(140, 23);
            this.buttonArcher.TabIndex = 0;
            this.buttonArcher.Text = "buttonArcher";
            this.buttonArcher.UseVisualStyleBackColor = true;
            this.buttonArcher.Click += new System.EventHandler(this.buttonArcher_Click);
            // 
            // buttonWarrior
            // 
            this.buttonWarrior.Location = new System.Drawing.Point(301, 166);
            this.buttonWarrior.Name = "buttonWarrior";
            this.buttonWarrior.Size = new System.Drawing.Size(129, 23);
            this.buttonWarrior.TabIndex = 1;
            this.buttonWarrior.Text = "buttonWarrior";
            this.buttonWarrior.UseVisualStyleBackColor = true;
            this.buttonWarrior.Click += new System.EventHandler(this.buttonWarrior_Click);
            // 
            // buttonMage
            // 
            this.buttonMage.Location = new System.Drawing.Point(545, 166);
            this.buttonMage.Name = "buttonMage";
            this.buttonMage.Size = new System.Drawing.Size(105, 23);
            this.buttonMage.TabIndex = 2;
            this.buttonMage.Text = "buttonMage";
            this.buttonMage.UseVisualStyleBackColor = true;
            this.buttonMage.Click += new System.EventHandler(this.buttonMage_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(78, 50);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(400, 20);
            this.textBoxInfo.TabIndex = 3;
            this.textBoxInfo.TextChanged += new System.EventHandler(this.textBoxInfo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.buttonMage);
            this.Controls.Add(this.buttonWarrior);
            this.Controls.Add(this.buttonArcher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArcher;
        private System.Windows.Forms.Button buttonWarrior;
        private System.Windows.Forms.Button buttonMage;
        private System.Windows.Forms.TextBox textBoxInfo;
    }
}

