using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace visualizador_imagens
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public List<string> imagens = new List<string>();
        public int iImagemAtual = 0;

        public bool bEmApresentacao = false;

        public string Arquivo = "ApresentacaoImagem.dll";
        public string PastaTemp = @"c:\Area27\ApresentacaoImagens\";

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(PastaTemp))
                Directory.CreateDirectory(PastaTemp);
            if (File.Exists(PastaTemp + Arquivo))
            {
                StreamReader sr = new StreamReader(PastaTemp + Arquivo);
                string pasta = sr.ReadLine();
                txtPastaApresentação.Text = pasta;
                sr.Close();
                if (Directory.Exists(txtPastaApresentação.Text))
                    BuscaImagens(txtPastaApresentação.Text);
            }
            else
                txtPastaApresentação.Text = string.Empty;
        }

        private void IniciarApresntacao()
        {
            try
            {
                grConfig.Visible = false;
                pnTitulo.Visible = false;
                ssStatus.Visible = false;
                bEmApresentacao = true;
                this.FormBorderStyle = FormBorderStyle.None;
                piImagem.Focus();
                if (chkApresencacaoAutomatica.Checked)
                {
                    tiApresentacao.Interval = (int)nmSegundosApresentacaoAutomatica.Value * 1000;
                    tiApresentacao.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                FinalizarApresntacao();
            }
        }

        private void FinalizarApresntacao()
        {
            try
            {
                tiApresentacao.Stop();
                grConfig.Visible = true;
                pnTitulo.Visible = true;
                ssStatus.Visible = true;
                bEmApresentacao = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IniciarApresntacao();
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.F11) && !bEmApresentacao) IniciarApresntacao();
            if (e.KeyCode == Keys.Escape && bEmApresentacao) FinalizarApresntacao();
            if (e.KeyCode == Keys.Right) ProximaImagem();
            if (e.KeyCode == Keys.Left) ImagemAnterior();
        }

        private void ProximaImagem()
        {
            if (piImagem.Focus())
            {
                iImagemAtual++;
                if (iImagemAtual >= imagens.Count)
                    iImagemAtual = 0;

                ExibeImagem(iImagemAtual);
            }
        }

        private void ImagemAnterior()
        {
            if (piImagem.Focus())
            {
                iImagemAtual--;
                if (iImagemAtual < 0)
                    iImagemAtual = imagens.Count - 1;

                ExibeImagem(iImagemAtual);
            }
        }

        public void ExibeImagem(int iimagem)
        {
            Bitmap imagem = new Bitmap(imagens[iimagem].ToString());
            piImagem.Image = imagem;
            lblImagem.Text = " | " + (iImagemAtual + 1) + " - " + imagens[iimagem].ToString();
        }

        private void FormPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            this.KeyUp += MainForm_KeyUp;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter && !bEmApresentacao) IniciarApresntacao();
            //if (e.KeyCode == Keys.Escape && bEmApresentacao) FinalizarApresntacao();
        }

        private void btnBuscarPasta_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.SelectedPath = txtPastaApresentação.Text;

            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                BuscaImagens(fbd.SelectedPath);
        }

        private void BuscaImagens(string sPath)
        {
            if(txtPastaApresentação.Text != sPath)
                txtPastaApresentação.Text = sPath;
            StreamWriter sw = new StreamWriter(PastaTemp + Arquivo);
            sw.WriteLine(sPath);
            sw.Close();
            imagens.Clear();
            var getimagens = Directory.GetFiles(txtPastaApresentação.Text, "*.*", SearchOption.AllDirectories).Where(s =>
            s.EndsWith(".png")
            || s.EndsWith(".jpg")
            || s.EndsWith(".png")
            || s.EndsWith(".tiff")
            || s.EndsWith(".gif")
            || s.EndsWith(".bmp")
            || s.EndsWith(".jpeg")).OrderBy(f => new FileInfo(f).Name).ToArray();
            if (getimagens.Count() > 0)
            {
                imagens.AddRange(getimagens);
                ExibeImagem(iImagemAtual);
            }
        }

        private void chkApresencacaoAutomatica_CheckedChanged(object sender, EventArgs e)
        {
            nmSegundosApresentacaoAutomatica.Enabled = chkApresencacaoAutomatica.Checked;
        }

        private void tiApresentacao_Tick(object sender, EventArgs e)
        {
            ProximaImagem();
        }

        private void txtPastaApresentação_Leave(object sender, EventArgs e)
        {
            if (Directory.Exists(txtPastaApresentação.Text))
                BuscaImagens(txtPastaApresentação.Text);
        }
    }
}
