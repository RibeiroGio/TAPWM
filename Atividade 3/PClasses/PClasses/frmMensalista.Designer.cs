namespace PClasses
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInstanciar2 = new System.Windows.Forms.Button();
            this.btnInstanciar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.rbtnNao);
            this.groupBox1.Controls.Add(this.rbtnSim);
            this.groupBox1.Location = new System.Drawing.Point(552, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 160);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabalha em Home Office";
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(289, 122);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(215, 26);
            this.textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(289, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 26);
            this.textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(289, 210);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 26);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 26);
            this.textBox1.TabIndex = 17;
            // 
            // btnInstanciar2
            // 
            this.btnInstanciar2.Location = new System.Drawing.Point(289, 317);
            this.btnInstanciar2.Name = "btnInstanciar2";
            this.btnInstanciar2.Size = new System.Drawing.Size(184, 58);
            this.btnInstanciar2.TabIndex = 16;
            this.btnInstanciar2.Text = "Instanciar Mensalista passando parâmetros";
            this.btnInstanciar2.UseVisualStyleBackColor = true;
            // 
            // btnInstanciar
            // 
            this.btnInstanciar.Location = new System.Drawing.Point(52, 317);
            this.btnInstanciar.Name = "btnInstanciar";
            this.btnInstanciar.Size = new System.Drawing.Size(184, 58);
            this.btnInstanciar.TabIndex = 15;
            this.btnInstanciar.Text = "Instanciar Mensalista";
            this.btnInstanciar.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.AutoSize = true;
            this.txtData.Location = new System.Drawing.Point(48, 216);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(195, 20);
            this.txtData.TabIndex = 14;
            this.txtData.Text = "Data Entrada na Empresa";
            // 
            // txtSalario
            // 
            this.txtSalario.AutoSize = true;
            this.txtSalario.Location = new System.Drawing.Point(48, 169);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(113, 20);
            this.txtSalario.TabIndex = 13;
            this.txtSalario.Text = "Salário Mensal";
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(48, 128);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(51, 20);
            this.txtNome.TabIndex = 12;
            this.txtNome.Text = "Nome";
            // 
            // txtMatricula
            // 
            this.txtMatricula.AutoSize = true;
            this.txtMatricula.Location = new System.Drawing.Point(48, 82);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(73, 20);
            this.txtMatricula.TabIndex = 11;
            this.txtMatricula.Text = "Matrícula";
            // 
            // frmMensalista
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
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnInstanciar2;
        private System.Windows.Forms.Button btnInstanciar;
        private System.Windows.Forms.Label txtData;
        private System.Windows.Forms.Label txtSalario;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtMatricula;
    }
}