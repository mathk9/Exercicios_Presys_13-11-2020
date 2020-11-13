namespace Criptografia_Exemplo
{
    partial class Teste2
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
            this.btnSubtrai = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnElevar = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubtrai
            // 
            this.btnSubtrai.Location = new System.Drawing.Point(12, 174);
            this.btnSubtrai.Name = "btnSubtrai";
            this.btnSubtrai.Size = new System.Drawing.Size(87, 32);
            this.btnSubtrai.TabIndex = 17;
            this.btnSubtrai.Text = "SUBTRAIR";
            this.btnSubtrai.UseVisualStyleBackColor = true;
            this.btnSubtrai.Click += new System.EventHandler(this.btnSubtrai_Click);
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.Location = new System.Drawing.Point(105, 136);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(87, 32);
            this.btnMultiplica.TabIndex = 16;
            this.btnMultiplica.Text = "MULTIPLICAR";
            this.btnMultiplica.UseVisualStyleBackColor = true;
            this.btnMultiplica.Click += new System.EventHandler(this.btnMultiplica_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(12, 136);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(87, 32);
            this.btnSomar.TabIndex = 15;
            this.btnSomar.Text = "SOMAR";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Resultado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Número 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Número 1:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(74, 101);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(118, 20);
            this.txtResultado.TabIndex = 21;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(105, 174);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(87, 32);
            this.btnDividir.TabIndex = 22;
            this.btnDividir.Text = "DIVIDIR";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnElevar
            // 
            this.btnElevar.Location = new System.Drawing.Point(13, 212);
            this.btnElevar.Name = "btnElevar";
            this.btnElevar.Size = new System.Drawing.Size(87, 32);
            this.btnElevar.TabIndex = 23;
            this.btnElevar.Text = "ELEVAR";
            this.btnElevar.UseVisualStyleBackColor = true;
            this.btnElevar.Click += new System.EventHandler(this.btnElevar_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(106, 212);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(87, 32);
            this.btnRaiz.TabIndex = 24;
            this.btnRaiz.Text = "RAÍZ";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(74, 58);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(118, 20);
            this.txtNum2.TabIndex = 25;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(72, 15);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(118, 20);
            this.txtNum1.TabIndex = 26;
            // 
            // Teste2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 261);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnElevar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnSubtrai);
            this.Controls.Add(this.btnMultiplica);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Teste2";
            this.Text = "Teste2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubtrai;
        private System.Windows.Forms.Button btnMultiplica;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnElevar;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
    }
}