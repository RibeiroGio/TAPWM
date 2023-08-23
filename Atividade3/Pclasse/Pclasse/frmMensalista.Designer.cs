namespace Pclasse
{
    partial class frmMensalista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.btnInstanciar1 = new System.Windows.Forms.Button();
            this.btnInstanciar2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario Mensal";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Entrada na Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(302, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(178, 26);
            this.txtNome.TabIndex = 5;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(302, 86);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(178, 26);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(302, 178);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(178, 26);
            this.txtData.TabIndex = 7;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(302, 136);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(178, 26);
            this.txtSalario.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNao);
            this.groupBox1.Controls.Add(this.rbtnSim);
            this.groupBox1.Location = new System.Drawing.Point(541, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 91);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabalha em Home Office?";
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(21, 25);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(63, 24);
            this.rbtnSim.TabIndex = 10;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "SIM";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(21, 55);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(68, 24);
            this.rbtnNao.TabIndex = 11;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "NÃO";
            this.rbtnNao.UseVisualStyleBackColor = true;
            this.rbtnNao.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // btnInstanciar1
            // 
            this.btnInstanciar1.Location = new System.Drawing.Point(67, 286);
            this.btnInstanciar1.Name = "btnInstanciar1";
            this.btnInstanciar1.Size = new System.Drawing.Size(136, 64);
            this.btnInstanciar1.TabIndex = 10;
            this.btnInstanciar1.Text = "Instanciar Mensalista";
            this.btnInstanciar1.UseVisualStyleBackColor = true;
            this.btnInstanciar1.Click += new System.EventHandler(this.BtnInstanciar1_Click);
            // 
            // btnInstanciar2
            // 
            this.btnInstanciar2.Location = new System.Drawing.Point(243, 286);
            this.btnInstanciar2.Name = "btnInstanciar2";
            this.btnInstanciar2.Size = new System.Drawing.Size(180, 64);
            this.btnInstanciar2.TabIndex = 11;
            this.btnInstanciar2.Text = "Instanciar Mensalista passando parâmetros";
            this.btnInstanciar2.UseVisualStyleBackColor = true;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInstanciar2);
            this.Controls.Add(this.btnInstanciar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.Load += new System.EventHandler(this.FrmMensalista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.Button btnInstanciar1;
        private System.Windows.Forms.Button btnInstanciar2;
    }
}