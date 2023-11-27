namespace Garage
{
    partial class MonGarage
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
            label1 = new Label();
            panel2 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel3 = new Panel();
            button3 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(595, 63);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(873, 134);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(219, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(361, 67);
            label1.TabIndex = 0;
            label1.Text = "Mon Garage";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(53, 63);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(513, 134);
            panel2.TabIndex = 1;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(323, 36);
            radioButton2.Margin = new Padding(2, 3, 2, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(149, 54);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Moto";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(58, 36);
            radioButton1.Margin = new Padding(2, 3, 2, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(177, 54);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Voiture";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(53, 651);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(658, 134);
            panel3.TabIndex = 2;
            // 
            // button3
            // 
            button3.Font = new Font("SimSun", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(323, 33);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(289, 79);
            button3.TabIndex = 6;
            button3.Text = "Supprimer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("SimSun", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(39, 33);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(245, 79);
            button2.TabIndex = 5;
            button2.Text = "Ajouter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(58, 235);
            listView1.Margin = new Padding(2, 3, 2, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(601, 392);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("SimSun", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(913, 683);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(447, 79);
            button1.TabIndex = 4;
            button1.Text = "Caracteristques";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(699, 260);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(296, 46);
            label2.TabIndex = 5;
            label2.Text = "Immatriculation :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(699, 376);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 46);
            label3.TabIndex = 6;
            label3.Text = "Annee :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(699, 487);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 46);
            label4.TabIndex = 7;
            label4.Text = "Type :";
            label4.Click += label4_Click;
            // 
            // MonGarage
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 894);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "MonGarage";
            Text = "MonGarage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private ListView listView1;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}