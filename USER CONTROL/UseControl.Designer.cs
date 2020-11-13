namespace Criptografia_Exemplo
{
    partial class UseControl
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
            this.btnGetState = new System.Windows.Forms.Button();
            this.userControlState1 = new Criptografia_Exemplo.userControlState();
            this.SuspendLayout();
            // 
            // btnGetState
            // 
            this.btnGetState.Location = new System.Drawing.Point(148, 57);
            this.btnGetState.Name = "btnGetState";
            this.btnGetState.Size = new System.Drawing.Size(75, 23);
            this.btnGetState.TabIndex = 1;
            this.btnGetState.Text = "Estado";
            this.btnGetState.UseVisualStyleBackColor = true;
            this.btnGetState.Click += new System.EventHandler(this.btnGetState_Click);
            // 
            // userControlState1
            // 
            this.userControlState1.Location = new System.Drawing.Point(12, 12);
            this.userControlState1.Name = "userControlState1";
            this.userControlState1.Size = new System.Drawing.Size(238, 39);
            this.userControlState1.TabIndex = 0;
            // 
            // UseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 99);
            this.Controls.Add(this.btnGetState);
            this.Controls.Add(this.userControlState1);
            this.Name = "UseControl";
            this.Text = "UseControl";
            this.ResumeLayout(false);

        }

        #endregion

        private userControlState userControlState1;
        private System.Windows.Forms.Button btnGetState;
    }
}