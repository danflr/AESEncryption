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

        private void btnExaminarOriginal_Click(object sender, EventArgs e)
        {
            if(ofdExaminar.ShowDialog() == DialogResult.OK)
            {
                string path = ofdExaminar.FileName;
                lblRutaOriginal.Text = path;
                Image img = Image.FromFile(path);
                pbImgOriginal.Image = img;
                pbImgOriginal.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void btnCifrarImg_Click(object sender, EventArgs e)
        {
            if (txtImgPass.Text.Length == 0 || lblRutaOriginal.Text.Length == 0) MessageBox.Show("Uno o más campos requeridos se encuentran vacíos, favor de llenarlos.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //txtCifrado.Text = CryptoHelper.Cifrar(txtOriginal.Text, txtPass.Text);
                string ruta = CryptoHelper.CifrarImagen(lblRutaOriginal.Text, txtImgPass.Text);
                pbImgCifrada.Image = Image.FromFile(ruta);
                lblRutaCifrada.Text = ruta;
                pbImgCifrada.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }
    }
}
