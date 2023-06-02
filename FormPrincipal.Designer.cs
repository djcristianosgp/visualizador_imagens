namespace visualizador_imagens
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            ssStatus = new System.Windows.Forms.StatusStrip();
            lblDesenvolvedor = new System.Windows.Forms.ToolStripStatusLabel();
            lblImagem = new System.Windows.Forms.ToolStripStatusLabel();
            pnTitulo = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            grConfig = new System.Windows.Forms.GroupBox();
            btnIniciar = new System.Windows.Forms.Button();
            nmSegundosApresentacaoAutomatica = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            chkApresencacaoAutomatica = new System.Windows.Forms.CheckBox();
            btnBuscarPasta = new System.Windows.Forms.Button();
            txtPastaApresentação = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            piImagem = new System.Windows.Forms.PictureBox();
            tiApresentacao = new System.Windows.Forms.Timer(components);
            ssStatus.SuspendLayout();
            pnTitulo.SuspendLayout();
            grConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmSegundosApresentacaoAutomatica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piImagem).BeginInit();
            SuspendLayout();
            // 
            // ssStatus
            // 
            ssStatus.BackColor = System.Drawing.Color.Gray;
            ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblDesenvolvedor, lblImagem });
            ssStatus.Location = new System.Drawing.Point(0, 428);
            ssStatus.Name = "ssStatus";
            ssStatus.Size = new System.Drawing.Size(800, 22);
            ssStatus.TabIndex = 0;
            ssStatus.Text = "statusStrip1";
            // 
            // lblDesenvolvedor
            // 
            lblDesenvolvedor.Name = "lblDesenvolvedor";
            lblDesenvolvedor.Size = new System.Drawing.Size(198, 17);
            lblDesenvolvedor.Text = "Desenvolvido por Cristiano Grobério";
            // 
            // lblImagem
            // 
            lblImagem.Name = "lblImagem";
            lblImagem.Size = new System.Drawing.Size(16, 17);
            lblImagem.Text = "...";
            // 
            // pnTitulo
            // 
            pnTitulo.Controls.Add(label1);
            pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            pnTitulo.Location = new System.Drawing.Point(0, 0);
            pnTitulo.Name = "pnTitulo";
            pnTitulo.Size = new System.Drawing.Size(800, 47);
            pnTitulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(800, 47);
            label1.TabIndex = 0;
            label1.Text = "Apresentação de Imagens";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grConfig
            // 
            grConfig.Controls.Add(btnIniciar);
            grConfig.Controls.Add(nmSegundosApresentacaoAutomatica);
            grConfig.Controls.Add(label3);
            grConfig.Controls.Add(chkApresencacaoAutomatica);
            grConfig.Controls.Add(btnBuscarPasta);
            grConfig.Controls.Add(txtPastaApresentação);
            grConfig.Controls.Add(label2);
            grConfig.Dock = System.Windows.Forms.DockStyle.Left;
            grConfig.ForeColor = System.Drawing.Color.White;
            grConfig.Location = new System.Drawing.Point(0, 47);
            grConfig.Name = "grConfig";
            grConfig.Size = new System.Drawing.Size(236, 381);
            grConfig.TabIndex = 2;
            grConfig.TabStop = false;
            grConfig.Text = "Configurações";
            // 
            // btnIniciar
            // 
            btnIniciar.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIniciar.Location = new System.Drawing.Point(3, 320);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new System.Drawing.Size(230, 58);
            btnIniciar.TabIndex = 7;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // nmSegundosApresentacaoAutomatica
            // 
            nmSegundosApresentacaoAutomatica.Dock = System.Windows.Forms.DockStyle.Top;
            nmSegundosApresentacaoAutomatica.Enabled = false;
            nmSegundosApresentacaoAutomatica.Location = new System.Drawing.Point(3, 111);
            nmSegundosApresentacaoAutomatica.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nmSegundosApresentacaoAutomatica.Name = "nmSegundosApresentacaoAutomatica";
            nmSegundosApresentacaoAutomatica.Size = new System.Drawing.Size(230, 23);
            nmSegundosApresentacaoAutomatica.TabIndex = 6;
            nmSegundosApresentacaoAutomatica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nmSegundosApresentacaoAutomatica.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Location = new System.Drawing.Point(3, 86);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(230, 25);
            label3.TabIndex = 5;
            label3.Text = "Tempo da Apresentação:(em segundos)";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkApresencacaoAutomatica
            // 
            chkApresencacaoAutomatica.AutoSize = true;
            chkApresencacaoAutomatica.Dock = System.Windows.Forms.DockStyle.Top;
            chkApresencacaoAutomatica.Location = new System.Drawing.Point(3, 67);
            chkApresencacaoAutomatica.Name = "chkApresencacaoAutomatica";
            chkApresencacaoAutomatica.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            chkApresencacaoAutomatica.Size = new System.Drawing.Size(230, 19);
            chkApresencacaoAutomatica.TabIndex = 4;
            chkApresencacaoAutomatica.Text = "Apresentação Automática";
            chkApresencacaoAutomatica.UseVisualStyleBackColor = true;
            chkApresencacaoAutomatica.CheckedChanged += chkApresencacaoAutomatica_CheckedChanged;
            // 
            // btnBuscarPasta
            // 
            btnBuscarPasta.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnBuscarPasta.FlatAppearance.BorderSize = 0;
            btnBuscarPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscarPasta.Image = (System.Drawing.Image)resources.GetObject("btnBuscarPasta.Image");
            btnBuscarPasta.Location = new System.Drawing.Point(209, 43);
            btnBuscarPasta.Name = "btnBuscarPasta";
            btnBuscarPasta.Size = new System.Drawing.Size(25, 25);
            btnBuscarPasta.TabIndex = 3;
            btnBuscarPasta.UseVisualStyleBackColor = true;
            btnBuscarPasta.Click += btnBuscarPasta_Click;
            // 
            // txtPastaApresentação
            // 
            txtPastaApresentação.Dock = System.Windows.Forms.DockStyle.Top;
            txtPastaApresentação.Location = new System.Drawing.Point(3, 44);
            txtPastaApresentação.Name = "txtPastaApresentação";
            txtPastaApresentação.PlaceholderText = "Selecione a pasta que contem as imagens:";
            txtPastaApresentação.Size = new System.Drawing.Size(230, 23);
            txtPastaApresentação.TabIndex = 2;
            txtPastaApresentação.Text = "C:\\Users\\DevReport01\\Pictures\\Walpaper\\";
            txtPastaApresentação.Leave += txtPastaApresentação_Leave;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Location = new System.Drawing.Point(3, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(230, 25);
            label2.TabIndex = 1;
            label2.Text = "Pasta:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // piImagem
            // 
            piImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            piImagem.Location = new System.Drawing.Point(236, 47);
            piImagem.Name = "piImagem";
            piImagem.Size = new System.Drawing.Size(564, 381);
            piImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            piImagem.TabIndex = 3;
            piImagem.TabStop = false;
            // 
            // tiApresentacao
            // 
            tiApresentacao.Interval = 1000;
            tiApresentacao.Tick += tiApresentacao_Tick;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DimGray;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(piImagem);
            Controls.Add(grConfig);
            Controls.Add(pnTitulo);
            Controls.Add(ssStatus);
            ForeColor = System.Drawing.Color.White;
            KeyPreview = true;
            Name = "FormPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Apresentação";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            KeyDown += FormPrincipal_KeyDown;
            KeyUp += FormPrincipal_KeyUp;
            ssStatus.ResumeLayout(false);
            ssStatus.PerformLayout();
            pnTitulo.ResumeLayout(false);
            grConfig.ResumeLayout(false);
            grConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmSegundosApresentacaoAutomatica).EndInit();
            ((System.ComponentModel.ISupportInitialize)piImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.Panel pnTitulo;
        private System.Windows.Forms.GroupBox grConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarPasta;
        private System.Windows.Forms.TextBox txtPastaApresentação;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox piImagem;
        private System.Windows.Forms.Timer tiApresentacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkApresencacaoAutomatica;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.NumericUpDown nmSegundosApresentacaoAutomatica;
        private System.Windows.Forms.ToolStripStatusLabel lblImagem;
        private System.Windows.Forms.ToolStripStatusLabel lblDesenvolvedor;
    }
}