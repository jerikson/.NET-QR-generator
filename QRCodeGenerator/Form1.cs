using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCodeGenerator;
using QRCoder;
namespace QRCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Generate_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator qrGen = new QRCoder.QRCodeGenerator();
            var qrData = qrGen.CreateQrCode(txtBox_UserInput.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var qrCode = new QRCoder.QRCode(qrData);
            var img = qrCode.GetGraphic(150);
            picBox_QrCode.Image = img;
        }

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Generate.PerformClick();
            }
        }

        private void txtBox_UserInput_TextChanged(object sender, EventArgs e)
        {
            this.txtBox_UserInput.KeyPress += new KeyPressEventHandler(CheckEnter);
        }
    }
}
