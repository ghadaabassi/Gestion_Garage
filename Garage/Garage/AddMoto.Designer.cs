namespace Garage
{
    partial class AddMoto
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
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(533, 230);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(588, 57);
            textBox5.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(152, 236);
            label5.Name = "label5";
            label5.Size = new Size(311, 45);
            label5.TabIndex = 20;
            label5.Text = "Immatriculation : ";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(533, 337);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(588, 57);
            textBox4.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(152, 359);
            label4.Name = "label4";
            label4.Size = new Size(249, 45);
            label4.TabIndex = 18;
            label4.Text = "Vitesse Max : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(155, 470);
            label3.Name = "label3";
            label3.Size = new Size(186, 45);
            label3.TabIndex = 16;
            label3.Text = "Cylindre : ";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(533, 458);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(588, 57);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(155, 458);
            label2.Name = "label2";
            label2.Size = new Size(0, 45);
            label2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(533, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(588, 57);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(155, 120);
            label1.Name = "label1";
            label1.Size = new Size(138, 45);
            label1.TabIndex = 12;
            label1.Text = "Anee : ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(29, 650);
            panel1.Name = "panel1";
            panel1.Size = new Size(1466, 156);
            panel1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1155, 48);
            button1.Name = "button1";
            button1.Size = new Size(273, 92);
            button1.TabIndex = 0;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddMoto
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1524, 821);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "AddMoto";
            Text = "AddMoto";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private Button button1;
    }
}