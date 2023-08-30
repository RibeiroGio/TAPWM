namespace Pclasse
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
            this.btnInstanciar = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNumeroHora = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtFaltas = new System.Windows.Forms.TextBox();
            this.lblFaltas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInstanciar
            // 
            this.btnInstanciar.Location = new System.Drawing.Point(276, 357);
            this.btnInstanciar.Name = "btnInstanciar";
            this.btnInstanciar.Size = new System.Drawing.Size(136, 64);
            this.btnInstanciar.TabIndex = 22;
            this.btnInstanciar.Text = "Instanciar Horista";
            this.btnInstanciar.UseVisualStyleBackColor = true;
            this.btnInstanciar.Click += new System.EventHandler(this.BtnInstanciar_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(378, 159);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(178, 26);
            this.txtSalario.TabIndex = 20;
            // 
            // txtNumeroHora
            // 
            this.txtNumeroHora.Location = new System.Drawing.Point(378, 201);
            this.txtNumeroHora.Name = "txtNumeroHora";
            this.txtNumeroHora.Size = new System.Drawing.Size(178, 26);
            this.txtNumeroHora.TabIndex = 19;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(378, 109);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(178, 26);
            this.txtMatricula.TabIndex = 18;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(378, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(178, 26);
            this.txtNome.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 16;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(130, 207);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(131, 20);
            this.lblHoras.TabIndex = 15;
            this.lblHoras.Text = "Número de horas";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(130, 165);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(121, 20);
            this.lblSalario.TabIndex = 14;
            this.lblSalario.Text = "Salario por hora";
            this.lblSalario.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(130, 115);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(73, 20);
            this.lblMatricula.TabIndex = 13;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(130, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(378, 243);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(178, 26);
            this.txtData.TabIndex = 25;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(130, 249);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(213, 20);
            this.lblData.TabIndex = 24;
            this.lblData.Text = "Data de entrada na empresa";
            this.lblData.Click += new System.EventHandler(this.Label6_Click);
            // 
            // txtFaltas
            // 
            this.txtFaltas.Location = new System.Drawing.Point(378, 290);
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(178, 26);
            this.txtFaltas.TabIndex = 27;
            // 
            // lblFaltas
            // 
            this.lblFaltas.AutoSize = true;
            this.lblFaltas.Location = new System.Drawing.Point(130, 296);
            this.lblFaltas.Name = "lblFaltas";
            this.lblFaltas.Size = new System.Drawing.Size(106, 20);
            this.lblFaltas.TabIndex = 26;
            this.lblFaltas.Text = "Dias de faltas";
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFaltas);
            this.Controls.Add(this.lblFaltas);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnInstanciar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNumeroHora);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblNome);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.Load += new System.EventHandler(this.FrmHorista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInstanciar;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtNumeroHora;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtFaltas;
        private System.Windows.Forms.Label lblFaltas;
    }
}