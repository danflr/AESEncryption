using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Length == 0 || txtOriginal.Text.Length == 0) MessageBox.Show("Uno o más campos requeridos se encuentran vacíos, favor de llenarlos.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                txtCifrado.Text = CryptoHelper.Cifrar(txtOriginal.Text, txtPass.Text);
            }
        }

        private void btnDescifrar_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Length == 0 || txtCifrado.Text.Length == 0) MessageBox.Show("Uno o más campos requeridos se encuentran vacíos, favor de llenarlos.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                txtOriginal.Text = CryptoHelper.Descifrar(txtCifrado.Text, txtPass.Text);
            }
        }

        
    }
}
