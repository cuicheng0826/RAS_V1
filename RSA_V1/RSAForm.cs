using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSA_V1
{
    public partial class RSAFrom : Form
    {
        private RSAUtil rsaUtil = new RSAUtil();
        public RSAFrom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 生成秘钥对
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CreateKey_Click(object sender, EventArgs e)
        {
            try
            {
                rsaUtil.CreateRSAKey();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txt_RasStr.Text = rsaUtil.EnCrypt(txt_OldStr.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void New_Key()
        {
            rsaUtil.CreateRSAKey();
            StreamReader reader1 = new StreamReader("privatekey.xml");
            XmlDocument document1 = new XmlDocument();
            document1.LoadXml(reader1.ReadToEnd());
            XmlElement element1 = (XmlElement)document1.SelectSingleNode("root");
            //parameters1.Modulus = ReadChild(element1, "Modulus");  
            txt_D.Text = rsaUtil.ToHexString(rsaUtil.ReadChild(element1, "Exponent"));
            txt_E.Text = rsaUtil.ToHexString(rsaUtil.ReadChild(element1, "D"));
            txt_Q.Text = rsaUtil.ToHexString(rsaUtil.ReadChild(element1, "Q"));
            txt_P.Text = rsaUtil.ToHexString(rsaUtil.ReadChild(element1, "P"));
            reader1.Close();
        }

        private void RSAFrom_Load(object sender, EventArgs e)
        {
            try
            {
                New_Key();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txt_OldStr.Text = rsaUtil.DoEncrypt(txt_RasStr.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
