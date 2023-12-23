namespace TranslatorCC
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Chislo = new System.Windows.Forms.TextBox();
            this.CC_default = new System.Windows.Forms.TextBox();
            this.CC_to_tr = new System.Windows.Forms.TextBox();
            this.Kolvo = new System.Windows.Forms.TextBox();
            this.Answer = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(69, 42);
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
            this.label1.Location = new System.Drawing.Point(69, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите СС";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите СС в которую нужно перевести число";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Сколько знаков после запятой будет у получившегося числа?";
            // 
            // Chislo
            // 
            this.Chislo.Location = new System.Drawing.Point(69, 86);
            this.Chislo.Name = "Chislo";
            this.Chislo.Size = new System.Drawing.Size(350, 23);
            this.Chislo.TabIndex = 5;
            // 
            // CC_default
            // 
            this.CC_default.Location = new System.Drawing.Point(69, 129);
            this.CC_default.Name = "CC_default";
            this.CC_default.Size = new System.Drawing.Size(350, 23);
            this.CC_default.TabIndex = 6;
            // 
            // CC_to_tr
            // 
            this.CC_to_tr.Location = new System.Drawing.Point(69, 173);
            this.CC_to_tr.Name = "CC_to_tr";
            this.CC_to_tr.Size = new System.Drawing.Size(350, 23);
            this.CC_to_tr.TabIndex = 7;
            // 
            // Kolvo
            // 
            this.Kolvo.Location = new System.Drawing.Point(69, 217);
            this.Kolvo.Name = "Kolvo";
            this.Kolvo.Size = new System.Drawing.Size(350, 23);
            this.Kolvo.TabIndex = 8;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(69, 275);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(350, 23);
            this.Answer.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(197, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Перевести";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(446, 432);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Kolvo);
            this.Controls.Add(this.CC_to_tr);
            this.Controls.Add(this.CC_default);
            this.Controls.Add(this.Chislo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "TranslatorCC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Chislo;
        private TextBox CC_default;
        private TextBox CC_to_tr;
        private TextBox Kolvo;
        private TextBox Answer;
        private Button button2;
    }
}