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
    public partial class FrmDecrypt : Form
    {
        ulong DESkey;
        ulong DESkey2;
        public FrmDecrypt()
        {
            InitializeComponent();
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
                decipher_bt.Enabled = true;
            }
            else
                MessageBox.Show("Please enter 8 characters");
        }

        private void decipher_bt_Click(object sender, EventArgs e)
        {

            if (cipher_tb.Text.Length != 0)
            {
                string[] temp = cipher_tb.Text.Split(' ');
                string res = "";
                string x = "";
                ulong xc;
                string hexValues = "";
                for (int i = 0; i < temp.Length-1; i++)
                {

                    x = temp[i];
                    xc = ulong.Parse(x);
                    xc = ulong.Parse(xc.ToString("x4"), System.Globalization.NumberStyles.HexNumber);
                    res = "" + DES.Decrypte(xc, DESkey);//10724270742800021139 5731921580069976853
                    ulong ti = ulong.Parse(res);
                    string ts = ti.ToString("x4").Substring(0, 2);
                    string ts1 = ti.ToString("x4").Substring(2, 2);
                    string ts2 = ti.ToString("x4").Substring(4, 2);
                    string ts3 = ti.ToString("x4").Substring(6, 2);
                    string ts4 = ti.ToString("x4").Substring(8, 2);
                    string ts5 = ti.ToString("x4").Substring(10, 2);
                    string ts6 = ti.ToString("x4").Substring(12, 2);
                    string ts7 = ti.ToString("x4").Substring(14, 2);
                    hexValues = hexValues + ts + " " + ts1 + " " + ts2 + " " + ts3 + " " + ts4 + " " + ts5 + " " + ts6 + " " + ts7 + " ";// +ts2 + " " + ts3 + " ";
                }
                string[] hexValuesSplit = hexValues.Split(' ');
                res = "";
                foreach (String hex in hexValuesSplit)
                {
                    if (hex.Length != 0)
                    {
                        int value = Convert.ToInt32(hex, 16);
                        string stringValue = Char.ConvertFromUtf32(value);
                        char charValue = (char)value;
                        res = res + stringValue;
                    }
                }
                plain_tb.Text = res;
                
            }
            else
                MessageBox.Show("Please Enter some text");
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
                decipher_bt2.Enabled = true;
                decipher_bt3.Enabled = true;
            }
            else
                MessageBox.Show("Please enter 8 characters");
        }

        private void decipher_bt2_Click(object sender, EventArgs e)
        {
            if (cipher_tb.Text.Length != 0)
            {
                string[] temp = cipher_tb.Text.Split(' ');
                string res = "";
                string x = "";
                ulong xc;
                string hexValues = "";
                for (int i = 0; i < temp.Length-1; i++)
                {

                    x = temp[i];
                    xc = ulong.Parse(x);
                    xc = ulong.Parse(xc.ToString("x4"), System.Globalization.NumberStyles.HexNumber);
                    //DOUBLE
                    ulong res1 = DES.Decrypte(xc, DESkey2);
                    ulong res2 = DES.Decrypte(res1, DESkey);
                    res = "" + res2;
                    ulong ti = ulong.Parse(res);
                    string ts = ti.ToString("x4").Substring(0, 2);
                    string ts1 = ti.ToString("x4").Substring(2, 2);
                    string ts2 = ti.ToString("x4").Substring(4, 2);
                    string ts3 = ti.ToString("x4").Substring(6, 2);
                    string ts4 = ti.ToString("x4").Substring(8, 2);
                    string ts5 = ti.ToString("x4").Substring(10, 2);
                    string ts6 = ti.ToString("x4").Substring(12, 2);
                    string ts7 = ti.ToString("x4").Substring(14, 2);
                    hexValues = hexValues + ts + " " + ts1 + " " + ts2 + " " + ts3 + " " + ts4 + " " + ts5 + " " + ts6 + " " + ts7 + " ";// +ts2 + " " + ts3 + " ";
                }
                string[] hexValuesSplit = hexValues.Split(' ');
                res = "";
                foreach (String hex in hexValuesSplit)
                {
                    if (hex.Length != 0)
                    {
                        int value = Convert.ToInt32(hex, 16);
                        string stringValue = Char.ConvertFromUtf32(value);
                        char charValue = (char)value;
                        res = res + stringValue;
                    }
                }
                plain_tb.Text = res;

            }
            else
                MessageBox.Show("Please Enter some text");
        }

        private void decipher_bt3_Click(object sender, EventArgs e)
        {
            if (cipher_tb.Text.Length != 0)
            {
                string[] temp = cipher_tb.Text.Split(' ');
                string res = "";
                string x = "";
                ulong xc;
                string hexValues = "";
                for (int i = 0; i < temp.Length-1; i++)
                {

                    x = temp[i];
                    xc = ulong.Parse(x);
                    xc = ulong.Parse(xc.ToString("x4"), System.Globalization.NumberStyles.HexNumber);

                    //
                    ulong res1 = DES.Decrypte(xc, DESkey);
                    ulong res2 = DES.Encrypte(res1, DESkey2);
                    ulong res3 = DES.Decrypte(res2, DESkey);
                    res = "" + res3;
                    ulong ti = ulong.Parse(res);
                    string ts = ti.ToString("x4").Substring(0, 2);
                    string ts1 = ti.ToString("x4").Substring(2, 2);
                    string ts2 = ti.ToString("x4").Substring(4, 2);
                    string ts3 = ti.ToString("x4").Substring(6, 2);
                    string ts4 = ti.ToString("x4").Substring(8, 2);
                    string ts5 = ti.ToString("x4").Substring(10, 2);
                    string ts6 = ti.ToString("x4").Substring(12, 2);
                    string ts7 = ti.ToString("x4").Substring(14, 2);
                    hexValues = hexValues + ts + " " + ts1 + " " + ts2 + " " + ts3 + " " + ts4 + " " + ts5 + " " + ts6 + " " + ts7 + " ";// +ts2 + " " + ts3 + " ";
                }
                string[] hexValuesSplit = hexValues.Split(' ');
                res = "";
                foreach (String hex in hexValuesSplit)
                {
                    if (hex.Length != 0)
                    {
                        int value = Convert.ToInt32(hex, 16);
                        string stringValue = Char.ConvertFromUtf32(value);
                        char charValue = (char)value;
                        res = res + stringValue;
                    }
                }
                plain_tb.Text = res;

            }
            else
                MessageBox.Show("Please Enter some text");

        }
    }
}
