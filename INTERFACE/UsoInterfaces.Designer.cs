namespace Criptografia_Exemplo
{
    partial class UsoInterfaces
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
            this.btnTeste1 = new System.Windows.Forms.Button();
            this.btnTeste2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTeste1
            // 
            this.btnTeste1.Location = new System.Drawing.Point(31, 13);
            this.btnTeste1.Name = "btnTeste1";
            this.btnTeste1.Size = new System.Drawing.Size(153, 42);
            this.btnTeste1.TabIndex = 0;
            this.btnTeste1.Text = "TESTE 1";
            this.btnTeste1.UseVisualStyleBackColor = true;
            this.btnTeste1.Click += new System.EventHandler(this.btnTeste1_Click);
            // 
            // btnTeste2
            // 
            this.btnTeste2.Location = new System.Drawing.Point(31, 76);
            this.btnTeste2.Name = "btnTeste2";
            this.btnTeste2.Size = new System.Drawing.Size(153, 42);
            this.btnTeste2.TabIndex = 1;
            this.btnTeste2.Text = "TESTE 2";
            this.btnTeste2.UseVisualStyleBackColor = true;
            this.btnTeste2.Click += new System.EventHandler(this.btnTeste2_Click);
            // 
            // UsoInterfaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 130);
            this.Controls.Add(this.btnTeste2);
            this.Controls.Add(this.btnTeste1);
            this.Name = "UsoInterfaces";
            this.Text = "UsoInterfaces";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTeste1;
        private System.Windows.Forms.Button btnTeste2;

    }
}