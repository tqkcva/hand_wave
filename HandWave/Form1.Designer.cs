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
            this.From_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.To_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.WorkingTimeListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SerialPortComboBox = new System.Windows.Forms.ComboBox();
            this.SerialBaudrateComboBox = new System.Windows.Forms.ComboBox();
            this.SerialConnectButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // From_dateTimePicker
            // 
            this.From_dateTimePicker.Location = new System.Drawing.Point(53, 25);
            this.From_dateTimePicker.Name = "From_dateTimePicker";
            this.From_dateTimePicker.Size = new System.Drawing.Size(200, 20);
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
            this.To_dateTimePicker.Location = new System.Drawing.Point(53, 51);
            this.To_dateTimePicker.Name = "To_dateTimePicker";
            this.To_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.To_dateTimePicker.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(53, 104);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(164, 104);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // WorkingTimeListBox
            // 
            this.WorkingTimeListBox.FormattingEnabled = true;
            this.WorkingTimeListBox.Location = new System.Drawing.Point(259, 19);
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
            this.groupBox1.Size = new System.Drawing.Size(459, 145);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Working time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SerialConnectButton);
            this.groupBox2.Controls.Add(this.SerialBaudrateComboBox);
            this.groupBox2.Controls.Add(this.SerialPortComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(477, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 145);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Setting";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Baudrate";
            // 
            // SerialPortComboBox
            // 
            this.SerialPortComboBox.FormattingEnabled = true;
            this.SerialPortComboBox.Location = new System.Drawing.Point(78, 19);
            this.SerialPortComboBox.Name = "SerialPortComboBox";
            this.SerialPortComboBox.Size = new System.Drawing.Size(121, 21);
            this.SerialPortComboBox.TabIndex = 2;
            // 
            // SerialBaudrateComboBox
            // 
            this.SerialBaudrateComboBox.FormattingEnabled = true;
            this.SerialBaudrateComboBox.Location = new System.Drawing.Point(78, 46);
            this.SerialBaudrateComboBox.Name = "SerialBaudrateComboBox";
            this.SerialBaudrateComboBox.Size = new System.Drawing.Size(121, 21);
            this.SerialBaudrateComboBox.TabIndex = 3;
            // 
            // SerialConnectButton
            // 
            this.SerialConnectButton.Location = new System.Drawing.Point(215, 44);
            this.SerialConnectButton.Name = "SerialConnectButton";
            this.SerialConnectButton.Size = new System.Drawing.Size(75, 23);
            this.SerialConnectButton.TabIndex = 4;
            this.SerialConnectButton.Text = "Connect";
            this.SerialConnectButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 173);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 212);
            this.MinimumSize = new System.Drawing.Size(816, 212);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hand Wave";
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
    }
}

