namespace Criptografia_Exemplo
{
    partial class ColecoesGenericas
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
            this.Lista = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnHS = new System.Windows.Forms.Button();
            this.btnDic = new System.Windows.Forms.Button();
            this.btnSL = new System.Windows.Forms.Button();
            this.btnSD = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(11, 10);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(304, 251);
            this.Lista.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(321, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(131, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "LIST";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnHS
            // 
            this.btnHS.Location = new System.Drawing.Point(321, 41);
            this.btnHS.Name = "btnHS";
            this.btnHS.Size = new System.Drawing.Size(131, 23);
            this.btnHS.TabIndex = 2;
            this.btnHS.Text = "HEADSET";
            this.btnHS.UseVisualStyleBackColor = true;
            this.btnHS.Click += new System.EventHandler(this.btnHS_Click);
            // 
            // btnDic
            // 
            this.btnDic.Location = new System.Drawing.Point(321, 70);
            this.btnDic.Name = "btnDic";
            this.btnDic.Size = new System.Drawing.Size(131, 23);
            this.btnDic.TabIndex = 3;
            this.btnDic.Text = "DICTIONARY";
            this.btnDic.UseVisualStyleBackColor = true;
            this.btnDic.Click += new System.EventHandler(this.btnDic_Click);
            // 
            // btnSL
            // 
            this.btnSL.Location = new System.Drawing.Point(321, 99);
            this.btnSL.Name = "btnSL";
            this.btnSL.Size = new System.Drawing.Size(131, 23);
            this.btnSL.TabIndex = 4;
            this.btnSL.Text = "SORTEDLIST";
            this.btnSL.UseVisualStyleBackColor = true;
            this.btnSL.Click += new System.EventHandler(this.btnSL_Click);
            // 
            // btnSD
            // 
            this.btnSD.Location = new System.Drawing.Point(321, 128);
            this.btnSD.Name = "btnSD";
            this.btnSD.Size = new System.Drawing.Size(131, 23);
            this.btnSD.TabIndex = 5;
            this.btnSD.Text = "SORTEDDICTIONARY";
            this.btnSD.UseVisualStyleBackColor = true;
            this.btnSD.Click += new System.EventHandler(this.btnSD_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(321, 157);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(131, 23);
            this.btnQueue.TabIndex = 6;
            this.btnQueue.Text = "QUEUE";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(321, 186);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(131, 23);
            this.btnStack.TabIndex = 7;
            this.btnStack.Text = "STACK";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // ColecoesGenericas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 271);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnSD);
            this.Controls.Add(this.btnSL);
            this.Controls.Add(this.btnDic);
            this.Controls.Add(this.btnHS);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.Lista);
            this.Name = "ColecoesGenericas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Coleções Genéricas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnHS;
        private System.Windows.Forms.Button btnDic;
        private System.Windows.Forms.Button btnSL;
        private System.Windows.Forms.Button btnSD;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnStack;
    }
}