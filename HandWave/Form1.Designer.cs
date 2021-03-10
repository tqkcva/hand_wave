namespace HandWave
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.From_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.To_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.WorkingTimeListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SerialConnectButton = new System.Windows.Forms.Button();
            this.SerialBaudrateComboBox = new System.Windows.Forms.ComboBox();
            this.SerialPortComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DelayTime_textBox = new System.Windows.Forms.TextBox();
            this.NumOfWave_textBox = new System.Windows.Forms.TextBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.FwSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // From_dateTimePicker
            // 
            this.From_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.From_dateTimePicker.Location = new System.Drawing.Point(53, 25);
            this.From_dateTimePicker.Name = "From_dateTimePicker";
            this.From_dateTimePicker.ShowUpDown = true;
            this.From_dateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.From_dateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // To_dateTimePicker
            // 
            this.To_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.To_dateTimePicker.Location = new System.Drawing.Point(53, 51);
            this.To_dateTimePicker.Name = "To_dateTimePicker";
            this.To_dateTimePicker.ShowUpDown = true;
            this.To_dateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.To_dateTimePicker.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(6, 104);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(90, 104);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // WorkingTimeListBox
            // 
            this.WorkingTimeListBox.FormattingEnabled = true;
            this.WorkingTimeListBox.Location = new System.Drawing.Point(171, 19);
            this.WorkingTimeListBox.Name = "WorkingTimeListBox";
            this.WorkingTimeListBox.ScrollAlwaysVisible = true;
            this.WorkingTimeListBox.Size = new System.Drawing.Size(194, 108);
            this.WorkingTimeListBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WorkingTimeListBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RemoveButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.From_dateTimePicker);
            this.groupBox1.Controls.Add(this.To_dateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 145);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Working time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GetButton);
            this.groupBox2.Controls.Add(this.SetButton);
            this.groupBox2.Controls.Add(this.NumOfWave_textBox);
            this.groupBox2.Controls.Add(this.DelayTime_textBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SerialConnectButton);
            this.groupBox2.Controls.Add(this.SerialBaudrateComboBox);
            this.groupBox2.Controls.Add(this.SerialPortComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(390, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 145);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Setting";
            // 
            // SerialConnectButton
            // 
            this.SerialConnectButton.Location = new System.Drawing.Point(201, 17);
            this.SerialConnectButton.Name = "SerialConnectButton";
            this.SerialConnectButton.Size = new System.Drawing.Size(75, 23);
            this.SerialConnectButton.TabIndex = 4;
            this.SerialConnectButton.Text = "Connect";
            this.SerialConnectButton.UseVisualStyleBackColor = true;
            this.SerialConnectButton.Click += new System.EventHandler(this.SerialConnectButton_Click);
            // 
            // SerialBaudrateComboBox
            // 
            this.SerialBaudrateComboBox.FormattingEnabled = true;
            this.SerialBaudrateComboBox.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.SerialBaudrateComboBox.Location = new System.Drawing.Point(89, 46);
            this.SerialBaudrateComboBox.Name = "SerialBaudrateComboBox";
            this.SerialBaudrateComboBox.Size = new System.Drawing.Size(90, 21);
            this.SerialBaudrateComboBox.TabIndex = 3;
            // 
            // SerialPortComboBox
            // 
            this.SerialPortComboBox.FormattingEnabled = true;
            this.SerialPortComboBox.Location = new System.Drawing.Point(89, 19);
            this.SerialPortComboBox.Name = "SerialPortComboBox";
            this.SerialPortComboBox.Size = new System.Drawing.Size(90, 21);
            this.SerialPortComboBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Baudrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Num of Wave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Delay Time Ms";
            // 
            // DelayTime_textBox
            // 
            this.DelayTime_textBox.Location = new System.Drawing.Point(89, 106);
            this.DelayTime_textBox.Name = "DelayTime_textBox";
            this.DelayTime_textBox.Size = new System.Drawing.Size(90, 20);
            this.DelayTime_textBox.TabIndex = 7;
            // 
            // NumOfWave_textBox
            // 
            this.NumOfWave_textBox.Location = new System.Drawing.Point(89, 77);
            this.NumOfWave_textBox.Name = "NumOfWave_textBox";
            this.NumOfWave_textBox.Size = new System.Drawing.Size(90, 20);
            this.NumOfWave_textBox.TabIndex = 8;
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(201, 75);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(75, 23);
            this.SetButton.TabIndex = 9;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(201, 104);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(75, 23);
            this.GetButton.TabIndex = 10;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // FwSerialPort
            // 
            this.FwSerialPort.BaudRate = 115200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(690, 167);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(706, 206);
            this.MinimumSize = new System.Drawing.Size(706, 206);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hand Wave";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker From_dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker To_dateTimePicker;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ListBox WorkingTimeListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SerialConnectButton;
        private System.Windows.Forms.ComboBox SerialBaudrateComboBox;
        private System.Windows.Forms.ComboBox SerialPortComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.TextBox NumOfWave_textBox;
        private System.Windows.Forms.TextBox DelayTime_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort FwSerialPort;
    }
}

