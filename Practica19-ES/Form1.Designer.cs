namespace Practica19_ES
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label1.Location = new Point(68, 74);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "cal1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label2.Location = new Point(68, 110);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "cal2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label3.Location = new Point(68, 148);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "cal3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label4.Location = new Point(68, 183);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "cal4";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 145);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(131, 180);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold);
            label5.Location = new Point(43, 9);
            label5.Name = "label5";
            label5.Size = new Size(348, 45);
            label5.TabIndex = 8;
            label5.Text = "Programa que pide las calificaciones y da el promedio.\r\n Si es menor a 6 el promedio entonces\r\n esta reprobado el alumno";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(131, 234);
            button1.Name = "button1";
            button1.Size = new Size(82, 23);
            button1.TabIndex = 9;
            button1.Text = "Promedio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(406, 303);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
    }
}
