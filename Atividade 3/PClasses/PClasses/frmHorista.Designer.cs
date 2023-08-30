namespace PClasses
{
    partial class frmHorista
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
            this.txtMatricula = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.Label();
            this.btnInstanciar = new System.Windows.Forms.Button();
            this.btnInstanciar2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMatricula
            // 
            this.txtMatricula.AutoSize = true;
            this.txtMatricula.Location = new System.Drawing.Point(56, 61);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(73, 20);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.Text = "Matrícula";
            this.txtMatricula.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(56, 107);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(51, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Nome";
            // 
            // txtSalario
            // 
            this.txtSalario.AutoSize = true;
            this.txtSalario.Location = new System.Drawing.Point(56, 148);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(113, 20);
            this.txtSalario.TabIndex = 2;
            this.txtSalario.Text = "Salário Mensal";
            // 
            // txtData
            // 
            this.txtData.AutoSize = true;
            this.txtData.Location = new System.Drawing.Point(56, 195);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(195, 20);
            this.txtData.TabIndex = 3;
            this.txtData.Text = "Data Entrada na Empresa";
            // 
            // btnInstanciar
            // 
            this.btnInstanciar.Location = new System.Drawing.Point(60, 296);
            this.btnInstanciar.Name = "btnInstanciar";
            this.btnInstanciar.Size = new System.Drawing.Size(184, 58);
            this.btnInstanciar.TabIndex = 4;
            this.btnInstanciar.Text = "Instanciar Mensalista";
            this.btnInstanciar.UseVisualStyleBackColor = true;
            this.btnInstanciar.Click += new System.EventHandler(this.BtnInstanciar_Click);
            // 
            // btnInstanciar2
            // 
            this.btnInstanciar2.Location = new System.Drawing.Point(297, 296);
            this.btnInstanciar2.Name = "btnInstanciar2";
            this.btnInstanciar2.Size = new System.Drawing.Size(184, 58);
            this.btnInstanciar2.TabIndex = 5;
            this.btnInstanciar2.Text = "Instanciar Mensalista passando parâmetros";
            this.btnInstanciar2.UseVisualStyleBackColor = true;
            this.btnInstanciar2.Click += new System.EventHandler(this.BtnInstanciar2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 26);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 26);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(297, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 26);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(297, 101);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(215, 26);
            this.textBox4.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.rbtnNao);
            this.groupBox1.Controls.Add(this.rbtnSim);
            this.groupBox1.Location = new System.Drawing.Point(560, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 160);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabalha em Home Office";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(31, 65);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(61, 24);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(31, 108);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(63, 24);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnInstanciar2);
            this.Controls.Add(this.btnInstanciar);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.Load += new System.EventHandler(this.FrmHorista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMatricula;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtSalario;
        private System.Windows.Forms.Label txtData;
        private System.Windows.Forms.Button btnInstanciar;
        private System.Windows.Forms.Button btnInstanciar2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
    }
}