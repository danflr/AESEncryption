namespace AESEncryption
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTexto = new System.Windows.Forms.TabPage();
            this.tabImg = new System.Windows.Forms.TabPage();
            this.tabFile = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnDescifrar = new System.Windows.Forms.Button();
            this.txtOriginal = new System.Windows.Forms.RichTextBox();
            this.txtCifrado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtImgPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDescifrarImg = new System.Windows.Forms.Button();
            this.btnCifrarImg = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbImgOriginal = new System.Windows.Forms.PictureBox();
            this.pbImgCifrada = new System.Windows.Forms.PictureBox();
            this.lblRutaOriginal = new System.Windows.Forms.Label();
            this.btnExaminarOriginal = new System.Windows.Forms.Button();
            this.btnExaminarCifrada = new System.Windows.Forms.Button();
            this.lblRutaCifrada = new System.Windows.Forms.Label();
            this.ofdExaminar = new System.Windows.Forms.OpenFileDialog();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabTexto.SuspendLayout();
            this.tabImg.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgCifrada)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTexto);
            this.tabControl1.Controls.Add(this.tabImg);
            this.tabControl1.Controls.Add(this.tabFile);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTexto
            // 
            this.tabTexto.Controls.Add(this.groupBox2);
            this.tabTexto.Controls.Add(this.groupBox1);
            this.tabTexto.Controls.Add(this.panel1);
            this.tabTexto.Location = new System.Drawing.Point(4, 22);
            this.tabTexto.Name = "tabTexto";
            this.tabTexto.Size = new System.Drawing.Size(792, 424);
            this.tabTexto.TabIndex = 0;
            this.tabTexto.Text = "Texto";
            this.tabTexto.UseVisualStyleBackColor = true;
            // 
            // tabImg
            // 
            this.tabImg.Controls.Add(this.groupBox3);
            this.tabImg.Controls.Add(this.groupBox4);
            this.tabImg.Controls.Add(this.panel2);
            this.tabImg.Location = new System.Drawing.Point(4, 22);
            this.tabImg.Name = "tabImg";
            this.tabImg.Size = new System.Drawing.Size(792, 424);
            this.tabImg.TabIndex = 1;
            this.tabImg.Text = "Imagen";
            this.tabImg.UseVisualStyleBackColor = true;
            // 
            // tabFile
            // 
            this.tabFile.Location = new System.Drawing.Point(4, 22);
            this.tabFile.Name = "tabFile";
            this.tabFile.Size = new System.Drawing.Size(792, 424);
            this.tabFile.TabIndex = 2;
            this.tabFile.Text = "Archivo de texto";
            this.tabFile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOriginal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Texto sin cifrar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDescifrar);
            this.panel1.Controls.Add(this.btnEncriptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 35);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCifrado);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(390, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 389);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Texto cifrado";
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(636, 6);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptar.TabIndex = 0;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnDescifrar
            // 
            this.btnDescifrar.Location = new System.Drawing.Point(717, 6);
            this.btnDescifrar.Name = "btnDescifrar";
            this.btnDescifrar.Size = new System.Drawing.Size(75, 23);
            this.btnDescifrar.TabIndex = 1;
            this.btnDescifrar.Text = "Desencriptar";
            this.btnDescifrar.UseVisualStyleBackColor = true;
            this.btnDescifrar.Click += new System.EventHandler(this.btnDescifrar_Click);
            // 
            // txtOriginal
            // 
            this.txtOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOriginal.Location = new System.Drawing.Point(3, 16);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(378, 370);
            this.txtOriginal.TabIndex = 0;
            this.txtOriginal.Text = "";
            // 
            // txtCifrado
            // 
            this.txtCifrado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCifrado.Location = new System.Drawing.Point(3, 16);
            this.txtCifrado.Name = "txtCifrado";
            this.txtCifrado.Size = new System.Drawing.Size(396, 370);
            this.txtCifrado.TabIndex = 0;
            this.txtCifrado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Llave de cifrado:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(100, 8);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(530, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtImgPass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnDescifrarImg);
            this.panel2.Controls.Add(this.btnCifrarImg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 35);
            this.panel2.TabIndex = 2;
            // 
            // txtImgPass
            // 
            this.txtImgPass.Location = new System.Drawing.Point(100, 8);
            this.txtImgPass.Name = "txtImgPass";
            this.txtImgPass.Size = new System.Drawing.Size(530, 20);
            this.txtImgPass.TabIndex = 3;
            this.txtImgPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Llave de cifrado:";
            // 
            // btnDescifrarImg
            // 
            this.btnDescifrarImg.Location = new System.Drawing.Point(717, 6);
            this.btnDescifrarImg.Name = "btnDescifrarImg";
            this.btnDescifrarImg.Size = new System.Drawing.Size(75, 23);
            this.btnDescifrarImg.TabIndex = 1;
            this.btnDescifrarImg.Text = "Desencriptar";
            this.btnDescifrarImg.UseVisualStyleBackColor = true;
            // 
            // btnCifrarImg
            // 
            this.btnCifrarImg.Location = new System.Drawing.Point(636, 6);
            this.btnCifrarImg.Name = "btnCifrarImg";
            this.btnCifrarImg.Size = new System.Drawing.Size(75, 23);
            this.btnCifrarImg.TabIndex = 0;
            this.btnCifrarImg.Text = "Encriptar";
            this.btnCifrarImg.UseVisualStyleBackColor = true;
            this.btnCifrarImg.Click += new System.EventHandler(this.btnCifrarImg_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbImgCifrada);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(390, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 389);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagen cifrada";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbImgOriginal);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(0, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(384, 389);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Imagen original";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExaminarOriginal);
            this.panel3.Controls.Add(this.lblRutaOriginal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 34);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExaminarCifrada);
            this.panel4.Controls.Add(this.lblRutaCifrada);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 346);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 40);
            this.panel4.TabIndex = 1;
            // 
            // pbImgOriginal
            // 
            this.pbImgOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImgOriginal.Location = new System.Drawing.Point(3, 16);
            this.pbImgOriginal.Name = "pbImgOriginal";
            this.pbImgOriginal.Size = new System.Drawing.Size(378, 336);
            this.pbImgOriginal.TabIndex = 1;
            this.pbImgOriginal.TabStop = false;
            // 
            // pbImgCifrada
            // 
            this.pbImgCifrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImgCifrada.Location = new System.Drawing.Point(3, 16);
            this.pbImgCifrada.Name = "pbImgCifrada";
            this.pbImgCifrada.Size = new System.Drawing.Size(396, 330);
            this.pbImgCifrada.TabIndex = 2;
            this.pbImgCifrada.TabStop = false;
            // 
            // lblRutaOriginal
            // 
            this.lblRutaOriginal.AutoSize = true;
            this.lblRutaOriginal.Location = new System.Drawing.Point(10, 12);
            this.lblRutaOriginal.Name = "lblRutaOriginal";
            this.lblRutaOriginal.Size = new System.Drawing.Size(0, 13);
            this.lblRutaOriginal.TabIndex = 0;
            // 
            // btnExaminarOriginal
            // 
            this.btnExaminarOriginal.Location = new System.Drawing.Point(300, 6);
            this.btnExaminarOriginal.Name = "btnExaminarOriginal";
            this.btnExaminarOriginal.Size = new System.Drawing.Size(75, 23);
            this.btnExaminarOriginal.TabIndex = 1;
            this.btnExaminarOriginal.Text = "Examinar";
            this.btnExaminarOriginal.UseVisualStyleBackColor = true;
            this.btnExaminarOriginal.Click += new System.EventHandler(this.btnExaminarOriginal_Click);
            // 
            // btnExaminarCifrada
            // 
            this.btnExaminarCifrada.Location = new System.Drawing.Point(306, 9);
            this.btnExaminarCifrada.Name = "btnExaminarCifrada";
            this.btnExaminarCifrada.Size = new System.Drawing.Size(75, 23);
            this.btnExaminarCifrada.TabIndex = 3;
            this.btnExaminarCifrada.Text = "Examinar";
            this.btnExaminarCifrada.UseVisualStyleBackColor = true;
            // 
            // lblRutaCifrada
            // 
            this.lblRutaCifrada.AutoSize = true;
            this.lblRutaCifrada.Location = new System.Drawing.Point(16, 15);
            this.lblRutaCifrada.Name = "lblRutaCifrada";
            this.lblRutaCifrada.Size = new System.Drawing.Size(0, 13);
            this.lblRutaCifrada.TabIndex = 2;
            // 
            // ofdExaminar
            // 
            this.ofdExaminar.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Cifrado AES";
            this.tabControl1.ResumeLayout(false);
            this.tabTexto.ResumeLayout(false);
            this.tabImg.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgCifrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTexto;
        private System.Windows.Forms.TabPage tabImg;
        private System.Windows.Forms.TabPage tabFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDescifrar;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.RichTextBox txtOriginal;
        private System.Windows.Forms.RichTextBox txtCifrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtImgPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDescifrarImg;
        private System.Windows.Forms.Button btnCifrarImg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbImgOriginal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbImgCifrada;
        private System.Windows.Forms.Label lblRutaOriginal;
        private System.Windows.Forms.Button btnExaminarCifrada;
        private System.Windows.Forms.Label lblRutaCifrada;
        private System.Windows.Forms.Button btnExaminarOriginal;
        private System.Windows.Forms.OpenFileDialog ofdExaminar;
        private System.Windows.Forms.SaveFileDialog sfdGuardar;
    }
}

