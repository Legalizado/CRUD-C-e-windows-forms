namespace funcionario
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            generom = new RadioButton();
            generof = new RadioButton();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            txtEndereco = new TextBox();
            btnCadastrar = new Button();
            btnpesquisar = new Button();
            txtId = new TextBox();
            label5 = new Label();
            generoconsulta = new TextBox();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(70, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 19);
            label2.TabIndex = 2;
            label2.Text = "Cpf:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(70, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(70, 140);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 19);
            label4.TabIndex = 4;
            label4.Text = "Endereço:";
            label4.Click += label4_Click;
            // 
            // generom
            // 
            generom.AutoSize = true;
            generom.Location = new Point(70, 196);
            generom.Margin = new Padding(4);
            generom.Name = "generom";
            generom.Size = new Size(105, 23);
            generom.TabIndex = 5;
            generom.TabStop = true;
            generom.Text = "Masculino";
            generom.UseVisualStyleBackColor = true;
            generom.CheckedChanged += generom_CheckedChanged;
            // 
            // generof
            // 
            generof.AutoSize = true;
            generof.Location = new Point(210, 196);
            generof.Margin = new Padding(4);
            generof.Name = "generof";
            generof.Size = new Size(98, 23);
            generof.TabIndex = 6;
            generof.TabStop = true;
            generof.Text = "Feminino";
            generof.UseVisualStyleBackColor = true;
            generof.CheckedChanged += generof_CheckedChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(167, 24);
            txtNome.Margin = new Padding(4);
            txtNome.MaxLength = 30;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(141, 26);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(167, 61);
            txtCpf.Margin = new Padding(4);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(141, 26);
            txtCpf.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 98);
            txtEmail.Margin = new Padding(4);
            txtEmail.MaxLength = 30;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(141, 26);
            txtEmail.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(167, 133);
            txtEndereco.Margin = new Padding(4);
            txtEndereco.MaxLength = 500;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(386, 26);
            txtEndereco.TabIndex = 4;
            txtEndereco.TextChanged += txtEndereco_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(561, 133);
            btnCadastrar.Margin = new Padding(4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(107, 29);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnpesquisar
            // 
            btnpesquisar.Location = new Point(488, 193);
            btnpesquisar.Margin = new Padding(4);
            btnpesquisar.Name = "btnpesquisar";
            btnpesquisar.Size = new Size(107, 29);
            btnpesquisar.TabIndex = 12;
            btnpesquisar.Text = "Pesquisar";
            btnpesquisar.UseVisualStyleBackColor = true;
            btnpesquisar.Click += button1_Click;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Control;
            txtId.BorderStyle = BorderStyle.None;
            txtId.Location = new Point(357, 27);
            txtId.Margin = new Padding(4);
            txtId.MaxLength = 30;
            txtId.Name = "txtId";
            txtId.Size = new Size(141, 19);
            txtId.TabIndex = 13;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(320, 27);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(29, 19);
            label5.TabIndex = 14;
            label5.Text = "Id:";
            label5.Click += label5_Click;
            // 
            // generoconsulta
            // 
            generoconsulta.Location = new Point(602, 350);
            generoconsulta.Margin = new Padding(4);
            generoconsulta.MaxLength = 30;
            generoconsulta.Name = "generoconsulta";
            generoconsulta.Size = new Size(141, 26);
            generoconsulta.TabIndex = 15;
            generoconsulta.TextChanged += generoconsulta_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(373, 230);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 29);
            btnClear.TabIndex = 16;
            btnClear.Text = "Limpar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(373, 193);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Atualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(488, 230);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 29);
            btnDelete.TabIndex = 18;
            btnDelete.TabStop = false;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 433);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(generoconsulta);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(btnpesquisar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEndereco);
            Controls.Add(txtEmail);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(generof);
            Controls.Add(generom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Funcionarios";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton generom;
        private RadioButton generof;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private TextBox txtEndereco;
        private Button btnCadastrar;
        private Button btnpesquisar;
        private TextBox txtId;
        private Label label5;
        private TextBox generoconsulta;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
