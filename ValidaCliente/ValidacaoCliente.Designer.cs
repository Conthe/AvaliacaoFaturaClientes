
namespace ValidaCliente
{
    partial class frmValidacao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxGeral = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblSelDiretorio = new System.Windows.Forms.Label();
            this.lblArquivoSel = new System.Windows.Forms.Label();
            this.btnSelDiretorio = new System.Windows.Forms.Button();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSelecionaArquivo = new System.Windows.Forms.Button();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.grpBoxGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxGeral
            // 
            this.grpBoxGeral.Controls.Add(this.btnCancelar);
            this.grpBoxGeral.Controls.Add(this.btnVerificar);
            this.grpBoxGeral.Controls.Add(this.lblSelDiretorio);
            this.grpBoxGeral.Controls.Add(this.lblArquivoSel);
            this.grpBoxGeral.Controls.Add(this.btnSelDiretorio);
            this.grpBoxGeral.Controls.Add(this.txtDiretorio);
            this.grpBoxGeral.Controls.Add(this.lblTitulo);
            this.grpBoxGeral.Controls.Add(this.btnSelecionaArquivo);
            this.grpBoxGeral.Controls.Add(this.txtNomeArquivo);
            this.grpBoxGeral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBoxGeral.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBoxGeral.Location = new System.Drawing.Point(91, 51);
            this.grpBoxGeral.Name = "grpBoxGeral";
            this.grpBoxGeral.Size = new System.Drawing.Size(500, 350);
            this.grpBoxGeral.TabIndex = 0;
            this.grpBoxGeral.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(252, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(96, 311);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 16;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblSelDiretorio
            // 
            this.lblSelDiretorio.AutoSize = true;
            this.lblSelDiretorio.Location = new System.Drawing.Point(50, 109);
            this.lblSelDiretorio.Name = "lblSelDiretorio";
            this.lblSelDiretorio.Size = new System.Drawing.Size(253, 15);
            this.lblSelDiretorio.TabIndex = 15;
            this.lblSelDiretorio.Text = "Selecione o diretorio para os arquivos de saída:";
            // 
            // lblArquivoSel
            // 
            this.lblArquivoSel.AutoSize = true;
            this.lblArquivoSel.Location = new System.Drawing.Point(50, 202);
            this.lblArquivoSel.Name = "lblArquivoSel";
            this.lblArquivoSel.Size = new System.Drawing.Size(175, 15);
            this.lblArquivoSel.TabIndex = 14;
            this.lblArquivoSel.Text = "Selecione o arquivo para leitura:";
            // 
            // btnSelDiretorio
            // 
            this.btnSelDiretorio.Location = new System.Drawing.Point(378, 138);
            this.btnSelDiretorio.Name = "btnSelDiretorio";
            this.btnSelDiretorio.Size = new System.Drawing.Size(75, 23);
            this.btnSelDiretorio.TabIndex = 13;
            this.btnSelDiretorio.Text = "Diretorio...";
            this.btnSelDiretorio.UseVisualStyleBackColor = true;
            this.btnSelDiretorio.Click += new System.EventHandler(this.btnSelDiretorio_Click);
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Enabled = false;
            this.txtDiretorio.Location = new System.Drawing.Point(50, 139);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.ReadOnly = true;
            this.txtDiretorio.Size = new System.Drawing.Size(310, 23);
            this.txtDiretorio.TabIndex = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(18, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(460, 84);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Verificação automática de clientes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelecionaArquivo
            // 
            this.btnSelecionaArquivo.Enabled = false;
            this.btnSelecionaArquivo.Location = new System.Drawing.Point(378, 229);
            this.btnSelecionaArquivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelecionaArquivo.Name = "btnSelecionaArquivo";
            this.btnSelecionaArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionaArquivo.TabIndex = 9;
            this.btnSelecionaArquivo.Text = "Selecionar..";
            this.btnSelecionaArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionaArquivo.Click += new System.EventHandler(this.btnSelecionaArquivo_Click);
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Enabled = false;
            this.txtNomeArquivo.Location = new System.Drawing.Point(50, 229);
            this.txtNomeArquivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.ReadOnly = true;
            this.txtNomeArquivo.Size = new System.Drawing.Size(310, 23);
            this.txtNomeArquivo.TabIndex = 10;
            // 
            // frmValidacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.grpBoxGeral);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmValidacao";
            this.Text = "Faturas - Validação de cliente";
            this.grpBoxGeral.ResumeLayout(false);
            this.grpBoxGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxGeral;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblSelDiretorio;
        private System.Windows.Forms.Label lblArquivoSel;
        private System.Windows.Forms.Button btnSelDiretorio;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSelecionaArquivo;
        private System.Windows.Forms.TextBox txtNomeArquivo;
    }
}

