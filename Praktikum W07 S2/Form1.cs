using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_W07_S2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKonversi_Click(object sender, EventArgs e)
        {
            string Huruf = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] kumpulanHuruf = Huruf.ToCharArray();
            string kalimatinputan = tBoxInputKalimat.Text.ToUpper();
            char[] perubahanHuruf = kalimatinputan.ToCharArray();
            int jarak = tBoxTujuanHuruf.Text[0] - tBoxInputHuruf.Text[0];
            if (jarak < 0)
            {
                jarak += 26;
            }
            int output = 0;
            string teksOutput = "";
            for (int i=0; i<perubahanHuruf.Length; i++)
            {
                if (perubahanHuruf[i] == ' ')
                {
                    teksOutput = teksOutput + perubahanHuruf[i];
                }
                for (int j=0; j<26; j++)
                {
                    if (perubahanHuruf[i] == kumpulanHuruf[j])
                    {
                        teksOutput = teksOutput + kumpulanHuruf[j + jarak];
                    }
                }
            }
            lblOutput.Text = teksOutput;
        

        }
    }
}
