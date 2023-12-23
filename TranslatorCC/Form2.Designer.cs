namespace TranslatorCC
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Chislo = new System.Windows.Forms.TextBox();
            this.Kolvo = new System.Windows.Forms.TextBox();
            this.CC = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(51, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сколько знаков после запятой будет у получившегояся числа?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите СС в которую нужно перевести число";
            // 
            // Chislo
            // 
            this.Chislo.Location = new System.Drawing.Point(51, 138);
            this.Chislo.Name = "Chislo";
            this.Chislo.Size = new System.Drawing.Size(356, 23);
            this.Chislo.TabIndex = 4;
            // 
            // Kolvo
            // 
            this.Kolvo.Location = new System.Drawing.Point(51, 182);
            this.Kolvo.Name = "Kolvo";
            this.Kolvo.Size = new System.Drawing.Size(356, 23);
            this.Kolvo.TabIndex = 5;
            // 
            // CC
            // 
            this.CC.Location = new System.Drawing.Point(51, 232);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(356, 23);
            this.CC.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(173, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Перевести";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(51, 290);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(356, 23);
            this.Answer.TabIndex = 8;
            this.Answer.Text = "Ответ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.Kolvo);
            this.Controls.Add(this.Chislo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "TranslatorCC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_Closed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Chislo;
        private TextBox Kolvo;
        private TextBox CC;
        private Button button2;
        private TextBox Answer;
    }
}