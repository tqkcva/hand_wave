using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace HandWave
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			SerialPortComboBox.DropDown += new EventHandler(port_UserDrop);
			WorkingTimeListBox.Click += WorkingTimeListBox_Click;
			RemoveButton.Enabled = false;
            GetButton.Enabled = false;
            SetButton.Enabled = false;
		}

		private void WorkingTimeListBox_Click(object sender, EventArgs e)
		{
			if (WorkingTimeListBox.SelectedIndex < WorkingTimeListBox.Items.Count)
			{
				RemoveButton.Enabled = true;
			}
		}

		private void port_UserDrop(object sender, EventArgs e)
		{
            SerialPortComboBox.Items.Clear();
			foreach (string s in SerialPort.GetPortNames())
			{
                SerialPortComboBox.Items.Add(s);
			}
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			WorkingTimeListBox.Items.Add(From_dateTimePicker.Value);
			WorkingTimeListBox.Items.Add(To_dateTimePicker.Value);
		}

        private void SerialConnectButton_Click(object sender, EventArgs e)
        {

        }

        private void SetButton_Click(object sender, EventArgs e)
        {

        }

        private void GetButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
