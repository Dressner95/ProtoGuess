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
    public partial class ProtoGuess : Form
    {
        private SerialPort portToUse;
        Dictionary<string, float> ESP01 = new Dictionary<string, float>();
        Dictionary<string, float> ESP02 = new Dictionary<string, float>();
        Dictionary<string, float> ESP03 = new Dictionary<string, float>();
        Dictionary<string, float> ESP04 = new Dictionary<string, float>();

        string closest;

        string ESP01Guess = "";
        string ESP02Guess = "";
        string ESP03Guess = "";
        string ESP04Guess = "";


        public ProtoGuess()
        {
            InitializeComponent();
            //ESP01.Add("Chairs",0);

            ESP01.Add("230P", 84.8f);

            ESP01.Add("230O", 75.8f);

            ESP01.Add("230N", 80f);

            ESP01.Add("230M", 76f);

            ESP01.Add("230L", 74.4f);

            ESP01.Add("230K", 79.4f);

            ESP01.Add("230J", 74.4f);

            ESP01.Add("230I", 62f);

            ESP01.Add("230H", 72f);

            ESP01.Add("230G", 68.2f);

            ESP01.Add("230E", 49.4f);

            ESP01.Add("230D", 49.4f);

            ESP01.Add("230C", 41.8f);

            ESP01.Add("230B", 34.6f);

            ESP01.Add("230F", 60.4f);

            ESP01.Add("230-KITCHEN", 42.8f);





            //ESP02
            ESP02.Add("230P", 68.6f);

            ESP02.Add("230O", 61.2f);

            ESP02.Add("230N",66f);

            ESP02.Add("230M", 69.3f);

            ESP02.Add("230L", 68f);

            ESP02.Add("230K", 70.2f);

            ESP02.Add("230J", 71.2f);

            ESP02.Add("230I", 77.4f);

            ESP02.Add("230H", 77.6f);

            ESP02.Add("230G", 82f);

            ESP02.Add("230E", 83.6f);

            ESP02.Add("230D", 82.8f);

            ESP02.Add("230C", 86f);

            ESP02.Add("230B", 88.6f);

            ESP02.Add("230F", 87.2f);

            ESP02.Add("230-KITCHEN", 90.4f);

            //ESP03
            ESP03.Add("230P", 0f);

            ESP03.Add("230O", 0f);

            ESP03.Add("230N", 0f);

            ESP03.Add("230M", 0f);

            ESP03.Add("230L", 0f);

            ESP03.Add("230K", 0f);

            ESP03.Add("230J", 0f);

            ESP03.Add("230I", 0f);

            ESP03.Add("230H", 0f);

            ESP03.Add("230G", 0f);

            ESP03.Add("230E", 0f);

            ESP03.Add("230D", 0f);

            ESP03.Add("230C", 93f);

            ESP03.Add("230B", 0f);

            ESP03.Add("230F", 87.2f);

            ESP03.Add("230-KITCHEN", 90.4f);

            //ESP04
            ESP04.Add("230P", 89.8f);

            ESP04.Add("230O", 75f);

            ESP04.Add("230N", 75.2f);

            ESP04.Add("230M", 95.2f);

            ESP04.Add("230L", 84f);

            ESP04.Add("230K", 91.6f);

            ESP04.Add("230J", 94.2f);

            ESP04.Add("230I", 0f);

            ESP04.Add("230H", 97.8f);

            ESP04.Add("230G", 0f);

            ESP04.Add("230E", 0f);

            ESP04.Add("230D", 0f);

            ESP04.Add("230C", 0f);

            ESP04.Add("230B", 0f);

            ESP04.Add("230F", 0f);

            ESP04.Add("230-KITCHEN", 0f);

        }

        private void connect(object sender, EventArgs e)
        {
            connectButton.BackColor = Color.LawnGreen;
            portToUse = new SerialPort(comPort.Text, 115200, Parity.None, 8, StopBits.One);
            portToUse.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            portToUse.Open();
            //portToUse.Close();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            logData(indata);
            Debug.Print(indata);
        }

        
        void logData(string dataESP)
        {
            string[] splitData = dataESP.Split('-');
            switch (splitData[0])
            {
                case "ESP01":
                    ESP01Guess = closestMatch(ESP01, float.Parse(splitData[1]));
                    esp01GuessText.Invoke(new MethodInvoker(delegate { esp01GuessText.Text = ESP01Guess; }));
                    Debug.Print("01 Found");
                    break;

                case "ESP02":
                    ESP02Guess = closestMatch(ESP02, float.Parse(splitData[1]));
                    esp02GuessText.Invoke(new MethodInvoker(delegate { esp01GuessText.Text = ESP02Guess; }));
                    Debug.Print("02 Found");
                    break;

                case "ESP03":
                    ESP03Guess = closestMatch(ESP03, float.Parse(splitData[1]));
                    esp03GuessText.Invoke(new MethodInvoker(delegate { esp03GuessText.Text = ESP03Guess; }));
                    Debug.Print("03 Found");
                    break;

                case "ESP04":
                    ESP04Guess = closestMatch(ESP04, float.Parse(splitData[1]));
                    esp04GuessLabel.Invoke(new MethodInvoker(delegate { esp04GuessLabel.Text = ESP04Guess; }));
                    Debug.Print("04 Found");
                    break;
            }



        }
        string closestMatch(Dictionary<string,float> dict, float rssi)
        {
            float diff = 0;
            closest = "";

            foreach (KeyValuePair<string, float> entry in dict)
            {
                if (entry.Value != 0)
                {
                    float tempDiff = Math.Abs(entry.Value - rssi);
                    if (tempDiff < diff || diff == 0)
                    {
                        diff = tempDiff;
                        closest = entry.Key;
                    }
                }
            }
            return closest;
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            portToUse.Write("scan");
            Debug.Print("scanning");
            ESP01Guess = "";
            ESP02Guess = "";
            ESP03Guess = "";
            ESP04Guess = "";


            esp01GuessText.Invoke(new MethodInvoker(delegate { esp01GuessText.Text = ""; }));
            esp02GuessText.Invoke(new MethodInvoker(delegate { esp02GuessText.Text = ""; }));
            esp03GuessText.Invoke(new MethodInvoker(delegate { esp03GuessText.Text = ""; }));
            esp04GuessText.Invoke(new MethodInvoker(delegate { esp04GuessText.Text = ""; }));


        }

    }
}
