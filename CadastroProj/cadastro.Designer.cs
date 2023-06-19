namespace CADASTROprot
{
    partial class cadastro
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
            BtnEnviar = new Button();
            BtnApagar = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label10 = new Label();
            TxtCpf = new TextBox();
            label8 = new Label();
            LblStatus = new Label();
            label6 = new Label();
            TxtEndereco = new TextBox();
            TxtEmail = new TextBox();
            TxtIdade = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TxtNome = new TextBox();
            tabPage2 = new TabPage();
            GdvPessoa = new DataGridView();
            ColNome = new DataGridViewTextBoxColumn();
            ColCpf = new DataGridViewTextBoxColumn();
            LblEndereco = new Label();
            LblEmail = new Label();
            LblIdade = new Label();
            LblCpf = new Label();
            LblNome = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label11 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GdvPessoa).BeginInit();
            SuspendLayout();
            // 
            // BtnEnviar
            // 
            BtnEnviar.Location = new Point(394, 252);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(83, 50);
            BtnEnviar.TabIndex = 0;
            BtnEnviar.Text = "ENVIAR";
            BtnEnviar.UseVisualStyleBackColor = true;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // BtnApagar
            // 
            BtnApagar.Location = new Point(394, 323);
            BtnApagar.Name = "BtnApagar";
            BtnApagar.Size = new Size(83, 50);
            BtnApagar.TabIndex = 1;
            BtnApagar.Text = "APAGAR TUDO";
            BtnApagar.UseVisualStyleBackColor = true;
            BtnApagar.Click += BtnApagar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(314, 29);
            label1.Name = "label1";
            label1.Size = new Size(358, 54);
            label1.TabIndex = 2;
            label1.Text = "BANCO DE DADOS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 86);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1023, 464);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(TxtCpf);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(LblStatus);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(TxtEndereco);
            tabPage1.Controls.Add(TxtEmail);
            tabPage1.Controls.Add(BtnApagar);
            tabPage1.Controls.Add(BtnEnviar);
            tabPage1.Controls.Add(TxtIdade);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(TxtNome);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1015, 436);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CADASTRO";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(17, 17);
            label10.Name = "label10";
            label10.Size = new Size(112, 28);
            label10.TabIndex = 23;
            label10.Text = "CADASTRO";
            // 
            // TxtCpf
            // 
            TxtCpf.Location = new Point(119, 134);
            TxtCpf.Name = "TxtCpf";
            TxtCpf.Size = new Size(177, 23);
            TxtCpf.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(17, 136);
            label8.Name = "label8";
            label8.Size = new Size(37, 21);
            label8.TabIndex = 21;
            label8.Text = "CPF";
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblStatus.Location = new Point(14, 345);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(60, 28);
            LblStatus.TabIndex = 20;
            LblStatus.Text = "______";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 307);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 19;
            label6.Text = "Status";
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(119, 266);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(177, 23);
            TxtEndereco.TabIndex = 18;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(119, 222);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(177, 23);
            TxtEmail.TabIndex = 17;
            // 
            // TxtIdade
            // 
            TxtIdade.Location = new Point(119, 178);
            TxtIdade.Name = "TxtIdade";
            TxtIdade.Size = new Size(177, 23);
            TxtIdade.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 268);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 15;
            label5.Text = "Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 224);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 14;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 180);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 13;
            label3.Text = "Idade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 92);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 12;
            label2.Text = "Nome";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(119, 90);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(177, 23);
            TxtNome.TabIndex = 11;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(GdvPessoa);
            tabPage2.Controls.Add(LblEndereco);
            tabPage2.Controls.Add(LblEmail);
            tabPage2.Controls.Add(LblIdade);
            tabPage2.Controls.Add(LblCpf);
            tabPage2.Controls.Add(LblNome);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label11);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1015, 436);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "CONSULTA";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // GdvPessoa
            // 
            GdvPessoa.BackgroundColor = SystemColors.ButtonFace;
            GdvPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GdvPessoa.Columns.AddRange(new DataGridViewColumn[] { ColNome, ColCpf });
            GdvPessoa.Location = new Point(442, 16);
            GdvPessoa.Name = "GdvPessoa";
            GdvPessoa.RowHeadersVisible = false;
            GdvPessoa.RowTemplate.Height = 25;
            GdvPessoa.Size = new Size(556, 402);
            GdvPessoa.TabIndex = 36;
            // 
            // ColNome
            // 
            ColNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNome.HeaderText = "Nome";
            ColNome.Name = "ColNome";
            // 
            // ColCpf
            // 
            ColCpf.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCpf.HeaderText = "CPF";
            ColCpf.Name = "ColCpf";
            // 
            // LblEndereco
            // 
            LblEndereco.AutoSize = true;
            LblEndereco.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblEndereco.Location = new Point(124, 258);
            LblEndereco.Name = "LblEndereco";
            LblEndereco.Size = new Size(60, 28);
            LblEndereco.TabIndex = 35;
            LblEndereco.Text = "______";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblEmail.Location = new Point(124, 207);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(60, 28);
            LblEmail.TabIndex = 34;
            LblEmail.Text = "______";
            // 
            // LblIdade
            // 
            LblIdade.AutoSize = true;
            LblIdade.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblIdade.Location = new Point(124, 163);
            LblIdade.Name = "LblIdade";
            LblIdade.Size = new Size(60, 28);
            LblIdade.TabIndex = 33;
            LblIdade.Text = "______";
            // 
            // LblCpf
            // 
            LblCpf.AutoSize = true;
            LblCpf.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblCpf.Location = new Point(124, 119);
            LblCpf.Name = "LblCpf";
            LblCpf.Size = new Size(60, 28);
            LblCpf.TabIndex = 32;
            LblCpf.Text = "______";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LblNome.Location = new Point(124, 75);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(60, 28);
            LblNome.TabIndex = 31;
            LblNome.Text = "______";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(22, 126);
            label12.Name = "label12";
            label12.Size = new Size(37, 21);
            label12.TabIndex = 30;
            label12.Text = "CPF";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(22, 258);
            label13.Name = "label13";
            label13.Size = new Size(74, 21);
            label13.TabIndex = 29;
            label13.Text = "Endereço";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(22, 214);
            label14.Name = "label14";
            label14.Size = new Size(48, 21);
            label14.TabIndex = 28;
            label14.Text = "Email";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(22, 170);
            label15.Name = "label15";
            label15.Size = new Size(48, 21);
            label15.TabIndex = 27;
            label15.Text = "Idade";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(22, 82);
            label16.Name = "label16";
            label16.Size = new Size(53, 21);
            label16.TabIndex = 26;
            label16.Text = "Nome";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(16, 16);
            label11.Name = "label11";
            label11.Size = new Size(108, 28);
            label11.TabIndex = 25;
            label11.Text = "CONSULTA";
            // 
            // cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 617);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "cadastro";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GdvPessoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEnviar;
        private Button BtnApagar;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label10;
        private TextBox TxtCpf;
        private Label label8;
        private Label LblStatus;
        private Label label6;
        private TextBox TxtEndereco;
        private TextBox TxtEmail;
        private TextBox TxtIdade;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TxtNome;
        private TabPage tabPage2;
        private Label LblEndereco;
        private Label LblEmail;
        private Label LblIdade;
        private Label LblCpf;
        private Label LblNome;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label11;
        private DataGridView GdvPessoa;
        private DataGridViewTextBoxColumn ColNome;
        private DataGridViewTextBoxColumn ColCpf;
    }
}