using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESEncryptor
{
    public partial class FrmMITM : Form
    {
        ulong DESkey;
        ulong DESkey2;
        public FrmMITM()
        {
            InitializeComponent();
        }

        private void key_bt2_Click(object sender, EventArgs e)
        {
            if (key_tb2.Text.Length == 8)
            {
                byte[] keybyte = Encoding.Default.GetBytes(key_tb2.Text);
                var hexString = BitConverter.ToString(keybyte);
                ulong[] key = new ulong[4];
                string[] temp = hexString.Split('-');
                string k1 = temp[0] + temp[1];
                string k2 = temp[2] + temp[3];
                string k3 = temp[4] + temp[5];
                string k4 = temp[6] + temp[7];
                string kk = k1 + k2 + k3 + k4;
                DESkey2 = ulong.Parse(kk, System.Globalization.NumberStyles.HexNumber);
                decipher_bt.Enabled = true;
            }
            else
                MessageBox.Show("Please enter 8 characters");

        }

        private void key_bt_Click(object sender, EventArgs e)
        {
            if (key_tb.Text.Length == 8)
            {
                byte[] keybyte = Encoding.Default.GetBytes(key_tb.Text);
                var hexString = BitConverter.ToString(keybyte);
                ulong[] key = new ulong[4];
                string[] temp = hexString.Split('-');
                string k1 = temp[0] + temp[1];
                string k2 = temp[2] + temp[3];
                string k3 = temp[4] + temp[5];
                string k4 = temp[6] + temp[7];
                string kk = k1 + k2 + k3 + k4;
                DESkey = ulong.Parse(kk, System.Globalization.NumberStyles.HexNumber);
                cipher_bt.Enabled = true;
            }
            else
                MessageBox.Show("Please enter 8 characters");
        }

        private void cipher_bt_Click(object sender, EventArgs e)
        {
            if (plain_tp.Text.Length != 0)
            {
                byte[] keybyte = Encoding.Default.GetBytes(plain_tp.Text);
                var hexString = BitConverter.ToString(keybyte);
                string[] temp = hexString.Split('-');
                List<string> plain16 = new List<string>(temp);
                if (plain16.Count % 8 != 0)
                {
                    int temp1 = 8 - (plain16.Count % 8);
                    for (int i = 0; i < temp1; i++)
                        plain16.Add("00");
                }
                string res = "";
                string m1 = "";
                string m2 = "";
                string m3 = "";
                string m4 = "";
                ulong mes;

                for (int i = 0; i < plain16.Count; )
                {
                    m1 = plain16[i] + plain16[++i];
                    i++;
                    m2 = plain16[i] + plain16[++i];
                    i++;
                    m3 = plain16[i] + plain16[++i];
                    i++;
                    m4 = plain16[i] + plain16[++i];
                    i++;
                    string mm = m1 + m2 + m3 + m4;
                    mes = ulong.Parse(mm, System.Globalization.NumberStyles.HexNumber);
                    res = res + DES.Encrypte(mes, DESkey) + " ";
                }
                ciphered_tb.Text = res;
            }
            else
                MessageBox.Show("Please Enter some text");
        }

        private void decipher_bt_Click(object sender, EventArgs e)
        {
            if (ciphered_tp.Text.Length != 0)
            {
                string[] temp = ciphered_tp.Text.Split(' ');
                string res = "";
                string x = "";
                ulong xc;
                for (int i = 0; i < temp.Length-1; i++)
                {

                    x = temp[i];
                    xc = ulong.Parse(x);
                    xc = ulong.Parse(xc.ToString("x4"), System.Globalization.NumberStyles.HexNumber);
                    res = res + DES.Decrypte(xc, DESkey2) + " ";
                   
                }
                plain_tb.Text = res;

            }
            else
                MessageBox.Show("Please Enter some text");
        }
    }
}
