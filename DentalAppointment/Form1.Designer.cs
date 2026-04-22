namespace DentalAppointment
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
            fullNametxt = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            doctorCbo = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // fullNametxt
            // 
            fullNametxt.Location = new Point(271, 52);
            fullNametxt.Name = "fullNametxt";
            fullNametxt.Size = new Size(200, 23);
            fullNametxt.TabIndex = 0;
            fullNametxt.Text = "LastName, FistName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 55);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(271, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 92);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Phone Number";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(271, 221);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 135);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Doctor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 212);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 7;
            label4.Text = "Appointment and Date";
            // 
            // doctorCbo
            // 
            doctorCbo.DropDownStyle = ComboBoxStyle.DropDownList;
            doctorCbo.FormattingEnabled = true;
            doctorCbo.Location = new Point(261, 135);
            doctorCbo.Name = "doctorCbo";
            doctorCbo.Size = new Size(121, 23);
            doctorCbo.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(271, 278);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(272, 373);
            button1.Name = "button1";
            button1.Size = new Size(120, 65);
            button1.TabIndex = 10;
            button1.Text = "Confirm Appointment";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 286);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 11;
            label5.Text = "Office and Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(159, 320);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 12;
            label6.Text = "Reason of visit";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(271, 312);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 45);
            textBox3.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 450);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(doctorCbo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(fullNametxt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fullNametxt;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private ComboBox doctorCbo;
        private ComboBox comboBox2;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
    }
}
