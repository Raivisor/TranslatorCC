namespace TranslatorCC
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Chislo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CC = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(87, 75);
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
            this.label1.Location = new System.Drawing.Point(87, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите число";
            // 
            // Chislo
            // 
            this.Chislo.Location = new System.Drawing.Point(87, 119);
            this.Chislo.Name = "Chislo";
            this.Chislo.Size = new System.Drawing.Size(268, 23);
            this.Chislo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите СС в которую нужно перевести число";
            // 
            // CC
            // 
            this.CC.Location = new System.Drawing.Point(87, 163);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(268, 23);
            this.CC.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(177, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Перевести";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(87, 221);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(268, 23);
            this.Answer.TabIndex = 6;
            this.Answer.Text = "Ответ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Chislo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "TranslatorCC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox Chislo;
        private Label label2;
        private TextBox CC;
        private Button button2;
        private TextBox Answer;
    }
}