using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Desktop511
{
    public partial class Form1 : Form
    {
        public int con = 0;
        public Form1()
        {
            InitializeComponent();
            foreach (Control c in group12CA.Controls)
            {
                (c as Button).Image = Properties.Resources.;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupIntitialize(false);
        }
        private void groupIntitialize(bool checkOn)
        {
            if(checkOn == false)
            {
                foreach(Control c in group12CA.Controls)
                {
                    if(c is Button)
                    {
                        (c as Button).Enabled = false;
                    }
                }
                foreach (Control c in group12CB.Controls)
                {
                    if (c is Button)
                    {
                        (c as Button).Enabled = false;
                    }
                }
                Btn_Disconnect.Enabled = false;
                Btn_Connect.Enabled = true;
            }
            else if (checkOn == true)
            {
                foreach (Control c in group12CA.Controls)
                {
                    if (c is Button)
                    {
                        (c as Button).Enabled = true;
                    }
                }
                foreach (Control c in group12CB.Controls)
                {
                    if (c is Button)
                    {
                        (c as Button).Enabled = true;
                    }
                }
                Btn_Disconnect.Enabled = true;
                Btn_Connect.Enabled = false;
            }
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                connect();
                MessageBox.Show("Connection Successful!");
                con = 1;
            }
            catch
            {
                serialPort.close();
                MessageBox.Show("Port Unavailable!");
            }
        }

        private void connect()
        {
            SerialPort serialPort = new SerialPort();
            serialPort.Open();
        }

        private void Btn_LoadPorts_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            MessageBox.Show("1");
        }

        private void comboBox_connection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
