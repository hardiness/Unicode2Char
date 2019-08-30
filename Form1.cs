using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           

            if (txtGb2312.Text.Length==0)
            {
                return;
            }
            byte[] bytes;
            //bytes = System.Text.Encoding.Unicode.GetBytes(txtInput.Text);
            bytes = System.Text.Encoding.Unicode.GetBytes(rhtInput.Text);
            txtUnicode.Text = string.Empty;
            txtUnicodeHex.Text = string.Empty;
            for (int i = 0; i < bytes.Length; i += 2)
            {
              
                
                txtUnicode.Text += (bytes[i + 1] * 256 + bytes[i]).ToString() + " ";
                txtUnicodeHex.Text += "0x"+(bytes[i + 1] * 256 + bytes[i]).ToString("x") + " ";
              
            }

            Byte[] gb= Encoding.GetEncoding("gb2312").GetBytes(rhtInput.Text);
            txtGb2312.Text = string.Empty;
            for (int i = 0; i < gb.Length; i++)
            {
                if (gb[i]<128)
                {
                    txtGb2312.Text += gb[i]+" ";
                }
                else
                {
                    txtGb2312.Text += (gb[i] * 256 + gb[i + 1]).ToString() + " ";
                    i += 1;
                }
                   
            }

        }

        private void BtnConvertToChar_Click(object sender, EventArgs e)
        {
            if (txtUnicode.Text == string.Empty) return;

            string iStr = txtUnicode.Text.Trim();
            
            for (int i = 0; i < iStr.Length; i++)
            {
                if ((iStr[i]>'9' || iStr[i] <'0' ) && iStr[i]!=' ')
                {
                    MessageBox.Show("非法数字，请输入纯数字");
                    return;
                }
              
            }

          

            rhtInput.Text = string.Empty;
            string[] str= txtUnicode.Text.Trim().Split(' ');
            UInt16[] st=new UInt16[str.Length];
            byte[] bytes=new byte[st.Length *2];

            UInt16 num;
            for (int i = 0; i < st.Length; i++)
            {

              
                    if (!UInt16.TryParse(str[i].ToString(), out num))
                    {
                        MessageBox.Show("数字太大，无法转换");
                        return;
                    }
                    
               

                st[i] = Convert.ToUInt16(str[i]);
                
                bytes[i * 2] = (byte)(st[i] % 256);
                bytes[i * 2 + 1] = (byte)(st[i] / 256);

            }

            rhtInput.Text += System.Text.Encoding.Unicode.GetString(bytes);
           // System.Text.Encoding.GetEncodings

        }
    }
}
