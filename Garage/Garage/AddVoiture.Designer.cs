namespace Garage
{
    partial class AddVoiture
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(23, 660);
            panel1.Name = "panel1";
            panel1.Size = new Size(1466, 156);
            panel1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(149, 130);
            label1.Name = "label1";
            label1.Size = new Size(138, 45);
            label1.TabIndex = 1;
            label1.Text = "Anee : ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(527, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(588, 57);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(527, 384);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(588, 57);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(149, 468);
            label2.Name = "label2";
            label2.Size = new Size(136, 45);
            label2.TabIndex = 3;
            label2.Text = "Type : ";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(527, 468);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(588, 57);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(149, 373);
            label3.Name = "label3";
            label3.Size = new Size(178, 45);
            label3.TabIndex = 5;
            label3.Text = "Marque : ";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(527, 312);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(588, 57);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(149, 301);
            label4.Name = "label4";
            label4.Size = new Size(181, 45);
            label4.TabIndex = 7;
            label4.Text = "Couleur : ";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(527, 223);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(588, 57);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(149, 222);
            label5.Name = "label5";
            label5.Size = new Size(311, 45);
            label5.TabIndex = 9;
            label5.Text = "Immatriculation : ";
            // 
            // AddVoiture
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 828);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "AddVoiture";
            Text = "AddVoiture";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
    }
}