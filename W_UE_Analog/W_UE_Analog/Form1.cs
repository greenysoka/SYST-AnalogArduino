using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_UE_Analog
{
    public partial class AnalogWriter : Form
    {
        public AnalogWriter()
        {
            InitializeComponent();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            byte bytHelligkeit; 

            Einlesen(out bytHelligkeit);

            Senden(bytHelligkeit);
        }
        private void Einlesen(out byte bytWert)
        {
            bytWert = Convert.ToByte(lightninginput.Value);
        }

        private void Senden(byte bytHelligkeit)
        {
            Port_Open();
            Port_Senden(bytHelligkeit);
            Port_Close();
        }
        private void Port_Open()
        {
            serialPortArduino.Open();
        }
        private void Port_Close()
        {
            serialPortArduino.Close();
        }
        private void Port_Senden(byte bytWert)
        {
            byte[] bytArrSenden = new byte[1];
            bytArrSenden[0] = bytWert;
            serialPortArduino.Write(bytArrSenden, 0, 1);
        }


        private void lightninginput_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
