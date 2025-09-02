namespace BackerCommerce
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnComandos = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(67, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(296, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menu Principal: Pandorosa";
            // 
            // btnComandos
            // 
            this.btnComandos.BackColor = System.Drawing.Color.Red;
            this.btnComandos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComandos.Location = new System.Drawing.Point(281, 112);
            this.btnComandos.Name = "btnComandos";
            this.btnComandos.Size = new System.Drawing.Size(264, 49);
            this.btnComandos.TabIndex = 1;
            this.btnComandos.Text = "Comandos";
            this.btnComandos.UseVisualStyleBackColor = false;
            this.btnComandos.Click += new System.EventHandler(this.btnComandos_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.Location = new System.Drawing.Point(281, 185);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(264, 50);
            this.btnProduto.TabIndex = 2;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = false;
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.Location = new System.Drawing.Point(281, 265);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(264, 55);
            this.btnCaixa.TabIndex = 3;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Blue;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(281, 349);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(264, 55);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(12, 63);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(654, 31);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "olá Admnistrador de Souza ! Escolha Uma Opção";
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BackerCommerce.Properties.Resources.padeiro_profissao_link_share;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnComandos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnComandos;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label lblDescricao;
    }
}