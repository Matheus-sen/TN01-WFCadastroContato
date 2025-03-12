namespace TN01_WFCadastroContato_
{
    partial class FormCadastrarContato
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
            lblNome = new Label();
            lblSobrenome = new Label();
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            label3 = new Label();
            lblTelefone = new Label();
            mkdTelefone = new MaskedTextBox();
            gbxTipoTelefone = new GroupBox();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            rdbRecado = new RadioButton();
            label5 = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnVoltar = new Button();
            btnSalvar = new Button();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(26, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome :";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(268, 24);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(74, 15);
            lblSobrenome.TabIndex = 1;
            lblSobrenome.Text = "Sobrenome :";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(27, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(153, 23);
            txtNome.TabIndex = 12;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(268, 51);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(159, 23);
            txtSobrenome.TabIndex = 3;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(27, 97);
            label3.Name = "label3";
            label3.Size = new Size(400, 1);
            label3.TabIndex = 4;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(26, 121);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(80, 15);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "DDD/Telefone";
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(27, 139);
            mkdTelefone.Mask = "(99) 00000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(100, 23);
            mkdTelefone.TabIndex = 6;
            mkdTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Location = new Point(168, 122);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(229, 55);
            gbxTipoTelefone.TabIndex = 7;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo Telefone : ";
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(76, 22);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(6, 22);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(161, 22);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 8;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(27, 207);
            label5.Name = "label5";
            label5.Size = new Size(400, 1);
            label5.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(26, 227);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "E-mail :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(26, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(401, 23);
            txtEmail.TabIndex = 11;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(267, 329);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(352, 329);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastrarContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 450);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(label5);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(mkdTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(label3);
            Controls.Add(txtSobrenome);
            Controls.Add(txtNome);
            Controls.Add(lblSobrenome);
            Controls.Add(lblNome);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrarContato";
            Text = "FormCadastrarContato";
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblSobrenome;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private Label label3;
        private Label lblTelefone;
        private MaskedTextBox mkdTelefone;
        private GroupBox gbxTipoTelefone;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
        private RadioButton rdbRecado;
        private Label label5;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnVoltar;
        private Button btnSalvar;
    }
}