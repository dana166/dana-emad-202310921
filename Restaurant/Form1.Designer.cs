namespace Restaurant
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
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label10 = new Label();
            label9 = new Label();
            button1 = new Button();
            label8 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 0;
            label1.Text = "Restaurant";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(33, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 114);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Waitar Information";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 29);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 29);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 74);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 1;
            label3.Text = "Waiter's name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 30);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 0;
            label2.Text = "Table number:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(33, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(337, 207);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu Items";
            // 
            // comboBox4
            // 
            comboBox4.AutoCompleteCustomSource.AddRange(new string[] { "Apple Pie", "", "Sundae", "", "Carror Calo", "", "Mud Vie", "", "Apple Crisp" });
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(152, 148);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(163, 29);
            comboBox4.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteCustomSource.AddRange(new string[] { "Seafood Alfredo ", "", "Chicken Alfredo", "", "Chicken Picara", "", "Turkey Club", "", "Tabster Pie", "", "Prime Rib", "", "Shrimp Scampi", "", "Turker Dinner", "", "Stuffed chicken", " ", "Brulled Chicken" });
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { " " });
            comboBox3.Location = new Point(152, 105);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(163, 29);
            comboBox3.TabIndex = 10;
            comboBox3.Tag = "";
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteCustomSource.AddRange(new string[] { "Buttalo Wings", "", "Buitalo Fingers", "", "Potato Sleins", "", "Nachos", "", "Mushroom Caps", "", "Shrimp Cocktail", "", "Chips and Salse" });
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(152, 64);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 29);
            comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(152, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 29);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 36);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 2;
            label4.Text = "Beverage:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F);
            label5.Location = new Point(31, 73);
            label5.Name = "label5";
            label5.Size = new Size(57, 13);
            label5.TabIndex = 3;
            label5.Text = "Appetizen:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 113);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 4;
            label6.Text = "Main course:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 156);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 5;
            label7.Text = "Dessert:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(78, 496);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 6;
            label10.Text = "Total:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(78, 464);
            label9.Name = "label9";
            label9.Size = new Size(25, 15);
            label9.TabIndex = 5;
            label9.Text = "Tax:";
            // 
            // button1
            // 
            button1.Location = new Point(206, 557);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 7;
            button1.Text = "Calu Bill";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(70, 432);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 4;
            label8.Text = "Subtotal:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ScrollBar;
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(185, 429);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(137, 23);
            textBox3.TabIndex = 4;
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ScrollBar;
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(185, 461);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(137, 23);
            textBox4.TabIndex = 5;
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ScrollBar;
            textBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(185, 496);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(137, 23);
            textBox5.TabIndex = 6;
            textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // button2
            // 
            button2.Location = new Point(31, 557);
            button2.Name = "button2";
            button2.Size = new Size(116, 23);
            button2.TabIndex = 8;
            button2.Text = "Clear Bill";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 661);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label10;
        private Label label9;
        private Button button1;
        private Label label8;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button2;
    }
}
