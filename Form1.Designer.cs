namespace Aula_03___Interface_Gráfica
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDigite = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lstNomes = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            this.btnPreenche = new System.Windows.Forms.Button();
            this.cmbNum = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnApagarCaractere = new System.Windows.Forms.Button();
            this.radioGato = new System.Windows.Forms.RadioButton();
            this.radioCachorro = new System.Windows.Forms.RadioButton();
            this.radioFurao = new System.Windows.Forms.RadioButton();
            this.grpAnimal = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnLimpaImagem = new System.Windows.Forms.Button();
            this.btnDesmarca = new System.Windows.Forms.Button();
            this.btnProcuraImagem = new System.Windows.Forms.Button();
            this.pictAnimal = new System.Windows.Forms.PictureBox();
            this.grpAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(23, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(119, 23);
            this.txtNome.TabIndex = 0;
            // 
            // lblDigite
            // 
            this.lblDigite.AutoSize = true;
            this.lblDigite.Location = new System.Drawing.Point(37, 9);
            this.lblDigite.Name = "lblDigite";
            this.lblDigite.Size = new System.Drawing.Size(99, 15);
            this.lblDigite.TabIndex = 1;
            this.lblDigite.Text = "Digite um nome :";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(37, 56);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(86, 42);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lstNomes
            // 
            this.lstNomes.FormattingEnabled = true;
            this.lstNomes.ItemHeight = 15;
            this.lstNomes.Location = new System.Drawing.Point(28, 104);
            this.lstNomes.Name = "lstNomes";
            this.lstNomes.Size = new System.Drawing.Size(120, 139);
            this.lstNomes.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(53, 249);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 42);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(152, 114);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(85, 39);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnApaga
            // 
            this.btnApaga.Location = new System.Drawing.Point(151, 199);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(86, 35);
            this.btnApaga.TabIndex = 6;
            this.btnApaga.Text = "Apagar item";
            this.btnApaga.UseVisualStyleBackColor = true;
            this.btnApaga.Click += new System.EventHandler(this.btnApaga_Click);
            // 
            // btnPreenche
            // 
            this.btnPreenche.Location = new System.Drawing.Point(37, 331);
            this.btnPreenche.Name = "btnPreenche";
            this.btnPreenche.Size = new System.Drawing.Size(105, 38);
            this.btnPreenche.TabIndex = 7;
            this.btnPreenche.Text = "Preenche ComboBox";
            this.btnPreenche.UseVisualStyleBackColor = true;
            this.btnPreenche.Click += new System.EventHandler(this.btnPreenche_Click);
            // 
            // cmbNum
            // 
            this.cmbNum.FormattingEnabled = true;
            this.cmbNum.Location = new System.Drawing.Point(28, 375);
            this.cmbNum.Name = "cmbNum";
            this.cmbNum.Size = new System.Drawing.Size(121, 23);
            this.cmbNum.TabIndex = 8;
            this.cmbNum.SelectedIndexChanged += new System.EventHandler(this.cmbNum_SelectedIndexChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(183, 354);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(121, 15);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Número Selecionado:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(192, 372);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 23);
            this.txtNum.TabIndex = 10;
            // 
            // btnApagarCaractere
            // 
            this.btnApagarCaractere.Location = new System.Drawing.Point(155, 21);
            this.btnApagarCaractere.Name = "btnApagarCaractere";
            this.btnApagarCaractere.Size = new System.Drawing.Size(137, 41);
            this.btnApagarCaractere.TabIndex = 11;
            this.btnApagarCaractere.Text = "Apagar último caracter";
            this.btnApagarCaractere.UseVisualStyleBackColor = true;
            this.btnApagarCaractere.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioGato
            // 
            this.radioGato.AutoSize = true;
            this.radioGato.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioGato.Location = new System.Drawing.Point(6, 36);
            this.radioGato.Name = "radioGato";
            this.radioGato.Size = new System.Drawing.Size(80, 29);
            this.radioGato.TabIndex = 12;
            this.radioGato.TabStop = true;
            this.radioGato.Text = "Gato";
            this.radioGato.UseVisualStyleBackColor = true;
            // 
            // radioCachorro
            // 
            this.radioCachorro.AutoSize = true;
            this.radioCachorro.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioCachorro.Location = new System.Drawing.Point(6, 68);
            this.radioCachorro.Name = "radioCachorro";
            this.radioCachorro.Size = new System.Drawing.Size(126, 29);
            this.radioCachorro.TabIndex = 13;
            this.radioCachorro.TabStop = true;
            this.radioCachorro.Text = "Cachorro";
            this.radioCachorro.UseVisualStyleBackColor = true;
            // 
            // radioFurao
            // 
            this.radioFurao.AutoSize = true;
            this.radioFurao.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioFurao.Location = new System.Drawing.Point(6, 103);
            this.radioFurao.Name = "radioFurao";
            this.radioFurao.Size = new System.Drawing.Size(90, 29);
            this.radioFurao.TabIndex = 14;
            this.radioFurao.TabStop = true;
            this.radioFurao.Text = "Furão";
            this.radioFurao.UseVisualStyleBackColor = true;
            // 
            // grpAnimal
            // 
            this.grpAnimal.Controls.Add(this.radioGato);
            this.grpAnimal.Controls.Add(this.radioFurao);
            this.grpAnimal.Controls.Add(this.radioCachorro);
            this.grpAnimal.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpAnimal.Location = new System.Drawing.Point(560, 78);
            this.grpAnimal.Name = "grpAnimal";
            this.grpAnimal.Size = new System.Drawing.Size(204, 149);
            this.grpAnimal.TabIndex = 15;
            this.grpAnimal.TabStop = false;
            this.grpAnimal.Text = "Animal";
            this.grpAnimal.Enter += new System.EventHandler(this.grpAnimal_Enter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAnimal
            // 
            this.btnAnimal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnimal.Location = new System.Drawing.Point(770, 92);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(113, 61);
            this.btnAnimal.TabIndex = 16;
            this.btnAnimal.Text = "Escolha Animal";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnLimpaImagem
            // 
            this.btnLimpaImagem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpaImagem.Location = new System.Drawing.Point(560, 622);
            this.btnLimpaImagem.Name = "btnLimpaImagem";
            this.btnLimpaImagem.Size = new System.Drawing.Size(139, 57);
            this.btnLimpaImagem.TabIndex = 17;
            this.btnLimpaImagem.Text = "Limpar a imagem";
            this.btnLimpaImagem.UseVisualStyleBackColor = true;
            this.btnLimpaImagem.Click += new System.EventHandler(this.btnLimpaImagem_Click);
            // 
            // btnDesmarca
            // 
            this.btnDesmarca.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDesmarca.Location = new System.Drawing.Point(770, 163);
            this.btnDesmarca.Name = "btnDesmarca";
            this.btnDesmarca.Size = new System.Drawing.Size(113, 61);
            this.btnDesmarca.TabIndex = 18;
            this.btnDesmarca.Text = "Desmarcar Opções";
            this.btnDesmarca.UseVisualStyleBackColor = true;
            this.btnDesmarca.Click += new System.EventHandler(this.btnDesmarca_Click);
            // 
            // btnProcuraImagem
            // 
            this.btnProcuraImagem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcuraImagem.Location = new System.Drawing.Point(784, 622);
            this.btnProcuraImagem.Name = "btnProcuraImagem";
            this.btnProcuraImagem.Size = new System.Drawing.Size(177, 57);
            this.btnProcuraImagem.TabIndex = 19;
            this.btnProcuraImagem.Text = "Selecionar Imagem do PC...";
            this.btnProcuraImagem.UseVisualStyleBackColor = true;
            this.btnProcuraImagem.Click += new System.EventHandler(this.btnProcuraImagem_Click);
            // 
            // pictAnimal
            // 
            this.pictAnimal.Location = new System.Drawing.Point(560, 230);
            this.pictAnimal.Name = "pictAnimal";
            this.pictAnimal.Size = new System.Drawing.Size(401, 386);
            this.pictAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictAnimal.TabIndex = 20;
            this.pictAnimal.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 732);
            this.Controls.Add(this.pictAnimal);
            this.Controls.Add(this.btnProcuraImagem);
            this.Controls.Add(this.btnDesmarca);
            this.Controls.Add(this.btnLimpaImagem);
            this.Controls.Add(this.btnAnimal);
            this.Controls.Add(this.grpAnimal);
            this.Controls.Add(this.btnApagarCaractere);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.cmbNum);
            this.Controls.Add(this.btnPreenche);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lstNomes);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblDigite);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpAnimal.ResumeLayout(false);
            this.grpAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private Label lblDigite;
        private Button btnAdicionar;
        private ListBox lstNomes;
        private Button btnLimpar;
        private Button btnVerificar;
        private Button btnApaga;
        private Button btnPreenche;
        private ComboBox cmbNum;
        private Label lblNumero;
        private TextBox txtNum;
        private Button btnApagarCaractere;
        private RadioButton radioGato;
        private RadioButton radioCachorro;
        private RadioButton radioFurao;
        private GroupBox grpAnimal;
        private OpenFileDialog openFileDialog1;
        private Button btnAnimal;
        private Button btnLimpaImagem;
        private Button btnDesmarca;
        private Button btnProcuraImagem;
        private PictureBox pictAnimal;
    }
}