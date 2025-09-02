namespace BackerCommerce
{
    partial class FormUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenhaCadastro = new System.Windows.Forms.TextBox();
            this.txtEmailCadastro = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.lblEmailEditar = new System.Windows.Forms.Label();
            this.txtEmailEditar = new System.Windows.Forms.TextBox();
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.lblNomeCompletoEditar = new System.Windows.Forms.Label();
            this.lblSenhaEditar = new System.Windows.Forms.Label();
            this.txtSenhaEditar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(2, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(1031, 222);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.lblSenha);
            this.grbCadastro.Controls.Add(this.txbSenhaCadastro);
            this.grbCadastro.Controls.Add(this.txtEmailCadastro);
            this.grbCadastro.Controls.Add(this.lblEmail);
            this.grbCadastro.Controls.Add(this.txtNome);
            this.grbCadastro.Controls.Add(this.lblNomeCompleto);
            this.grbCadastro.Location = new System.Drawing.Point(12, 245);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(298, 233);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(3, 104);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // txbSenhaCadastro
            // 
            this.txbSenhaCadastro.Location = new System.Drawing.Point(6, 120);
            this.txbSenhaCadastro.Name = "txbSenhaCadastro";
            this.txbSenhaCadastro.Size = new System.Drawing.Size(265, 20);
            this.txbSenhaCadastro.TabIndex = 4;
            // 
            // txtEmailCadastro
            // 
            this.txtEmailCadastro.Location = new System.Drawing.Point(6, 71);
            this.txtEmailCadastro.Name = "txtEmailCadastro";
            this.txtEmailCadastro.Size = new System.Drawing.Size(259, 20);
            this.txtEmailCadastro.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 55);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(9, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(259, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(6, 16);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txtSenhaEditar);
            this.grbEditar.Controls.Add(this.lblSenhaEditar);
            this.grbEditar.Controls.Add(this.lblEmailEditar);
            this.grbEditar.Controls.Add(this.txtEmailEditar);
            this.grbEditar.Controls.Add(this.txtEditar);
            this.grbEditar.Controls.Add(this.lblNomeCompletoEditar);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(423, 245);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(299, 233);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            this.grbEditar.Enter += new System.EventHandler(this.grbEditar_Enter);
            // 
            // lblEmailEditar
            // 
            this.lblEmailEditar.AutoSize = true;
            this.lblEmailEditar.Location = new System.Drawing.Point(6, 69);
            this.lblEmailEditar.Name = "lblEmailEditar";
            this.lblEmailEditar.Size = new System.Drawing.Size(32, 13);
            this.lblEmailEditar.TabIndex = 6;
            this.lblEmailEditar.Text = "Email";
            // 
            // txtEmailEditar
            // 
            this.txtEmailEditar.Location = new System.Drawing.Point(7, 85);
            this.txtEmailEditar.Name = "txtEmailEditar";
            this.txtEmailEditar.Size = new System.Drawing.Size(289, 20);
            this.txtEmailEditar.TabIndex = 7;
            // 
            // txtEditar
            // 
            this.txtEditar.Location = new System.Drawing.Point(6, 39);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(289, 20);
            this.txtEditar.TabIndex = 6;
            // 
            // lblNomeCompletoEditar
            // 
            this.lblNomeCompletoEditar.AutoSize = true;
            this.lblNomeCompletoEditar.Location = new System.Drawing.Point(6, 23);
            this.lblNomeCompletoEditar.Name = "lblNomeCompletoEditar";
            this.lblNomeCompletoEditar.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCompletoEditar.TabIndex = 6;
            this.lblNomeCompletoEditar.Text = "Nome Completo";
            // 
            // lblSenhaEditar
            // 
            this.lblSenhaEditar.AutoSize = true;
            this.lblSenhaEditar.Location = new System.Drawing.Point(6, 120);
            this.lblSenhaEditar.Name = "lblSenhaEditar";
            this.lblSenhaEditar.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaEditar.TabIndex = 6;
            this.lblSenhaEditar.Text = "Senha";
            // 
            // txtSenhaEditar
            // 
            this.txtSenhaEditar.Location = new System.Drawing.Point(6, 136);
            this.txtSenhaEditar.Name = "txtSenhaEditar";
            this.txtSenhaEditar.Size = new System.Drawing.Size(296, 20);
            this.txtSenhaEditar.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Yellow;
            this.btnEditar.Location = new System.Drawing.Point(9, 175);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(284, 41);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 186);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(284, 41);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnApagar);
            this.groupBox1.Location = new System.Drawing.Point(12, 502);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnApagar.Location = new System.Drawing.Point(452, 37);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(284, 41);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecione um Usuários para Apagar";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1045, 644);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FormUsuarios";
            this.Text = "Form_Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbSenhaCadastro;
        private System.Windows.Forms.TextBox txtEmailCadastro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Label lblNomeCompletoEditar;
        private System.Windows.Forms.TextBox txtEditar;
        private System.Windows.Forms.Label lblEmailEditar;
        private System.Windows.Forms.TextBox txtEmailEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtSenhaEditar;
        private System.Windows.Forms.Label lblSenhaEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label1;
    }
}