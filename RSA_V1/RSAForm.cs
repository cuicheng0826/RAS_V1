using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            rsaUtil.CreateRSAKey();
        }
    }
}
