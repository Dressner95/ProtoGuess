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
using System.Diagnostics;

namespace ProtoGuess
{
    public partial class Form1 : Form
    {
        private SerialPort portToUse;
        Dictionary<string, float> ESP01 = new Dictionary<string, float>();
        Dictionary<string, float> ESP02 = new Dictionary<string, float>();
        Dictionary<string, float> ESP03 = new Dictionary<string, float>();
        Dictionary<string, float> ESP04 = new Dictionary<string, float>();

        public Form1()
        {
            InitializeComponent();
            ESP01.Add("Chairs",0);

            ESP01.Add("237-01", 0);
            ESP01.Add("237-02", 0);
            ESP01.Add("237-03", 0);

            ESP01.Add("238-01", 0);
            ESP01.Add("238-02", 0);
            ESP01.Add("238-03", 95);

            ESP01.Add("203", 0);

            ESP01.Add("239-01", 89);
            ESP01.Add("239-02", 90);

            ESP01.Add("240-01", 90.8f);
            ESP01.Add("240-02", 86.8f);

            ESP01.Add("241-01", 85.8f);
            ESP01.Add("241-02", 84.2f);
            ESP01.Add("241-03", 85.8f);

            ESP01.Add("242-01", 86.6f);
            ESP01.Add("242-02", 85.4f);
            ESP01.Add("242-03", 92f);

            ESP01.Add("Elevator", 0f);

            //ESP02
            ESP02.Add("Chairs", 75.2f);

            ESP02.Add("237-01", 80f);
            ESP02.Add("237-02", 84.4f);
            ESP02.Add("237-03", 82.6f);

            ESP02.Add("238-01", 89f);
            ESP02.Add("238-02", 95.8f);
            ESP02.Add("238-03", 90.4f);

            ESP02.Add("203", 0);

            ESP02.Add("239-01", 0);
            ESP02.Add("239-02", 0);

            ESP02.Add("240-01", 0f);
            ESP02.Add("240-02", 0f);

            ESP02.Add("241-01", 0f);
            ESP02.Add("241-02", 0f);
            ESP02.Add("241-03", 0f);

            ESP02.Add("242-01", 0f);
            ESP02.Add("242-02", 0f);
            ESP02.Add("242-03", 0f);

            ESP02.Add("Elevator", 87.2f);

            //ESP03
            ESP03.Add("Chairs", 78.4f);

            ESP03.Add("237-01", 75.3f);
            ESP03.Add("237-02", 74.8f);
            ESP03.Add("237-03", 69f);

            ESP03.Add("238-01", 72.8f);
            ESP03.Add("238-02", 72.2f);
            ESP03.Add("238-03", 73.8f);

            ESP03.Add("203", 67.4f);

            ESP03.Add("239-01", 64.8f);
            ESP03.Add("239-02", 63.4f);

            ESP03.Add("240-01", 65f);
            ESP03.Add("240-02", 59.4f);

            ESP03.Add("241-01", 57.8f);
            ESP03.Add("241-02", 60.4f);
            ESP03.Add("241-03", 56.6f);

            ESP03.Add("242-01", 43.6f);
            ESP03.Add("242-02", 31f);
            ESP03.Add("242-03", 45.2f);

            ESP03.Add("Elevator", 84f);

            //ESP04
            ESP04.Add("Chairs", 51.4f);

            ESP04.Add("237-01", 57f);
            ESP04.Add("237-02", 65.6f);
            ESP04.Add("237-03", 64.4f);

            ESP04.Add("238-01", 71.4f);
            ESP04.Add("238-02", 78f);
            ESP04.Add("238-03", 81.6f);

            ESP04.Add("203", 83.6f);

            ESP04.Add("239-01", 85f);
            ESP04.Add("239-02", 82.8f);

            ESP04.Add("240-01", 85.2f);
            ESP04.Add("240-02", 89.4f);

            ESP04.Add("241-01", 90.4f);
            ESP04.Add("241-02", 86.2f);
            ESP04.Add("241-03", 91.8f);

            ESP04.Add("242-01", 89.6f);
            ESP04.Add("242-02", 92.4f);
            ESP04.Add("242-03", 94.4f);

            ESP04.Add("Elevator", 78.2f);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            logData(indata);
            Debug.Print(indata);
        }

        private void connect(object sender, EventArgs e)
        {
            connectButton.BackColor = Color.LawnGreen;
            portToUse = new SerialPort(comPort.Text, 115200, Parity.None, 8, StopBits.One);
            portToUse.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            portToUse.Open();            
            //portToUse.Close();
        }
        void logData(string data)
        {

        }
    }
}
