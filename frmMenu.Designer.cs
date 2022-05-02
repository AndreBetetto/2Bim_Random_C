namespace _03AndreRandom72B
{
    partial class FormRandom
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
            this.btnSorteioJogos = new System.Windows.Forms.Button();
            this.btnDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSorteioJogos
            // 
            this.btnSorteioJogos.Location = new System.Drawing.Point(332, 199);
            this.btnSorteioJogos.Name = "btnSorteioJogos";
            this.btnSorteioJogos.Size = new System.Drawing.Size(100, 58);
            this.btnSorteioJogos.TabIndex = 0;
            this.btnSorteioJogos.Text = "SORTEIO";
            this.btnSorteioJogos.UseVisualStyleBackColor = true;
            this.btnSorteioJogos.Click += new System.EventHandler(this.btnSorteioJogos_Click);
            // 
            // btnDados
            // 
            this.btnDados.Location = new System.Drawing.Point(332, 263);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(100, 58);
            this.btnDados.TabIndex = 1;
            this.btnDados.Text = "Dados";
            this.btnDados.UseVisualStyleBackColor = true;
            this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
            // 
            // FormRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 476);
            this.Controls.Add(this.btnDados);
            this.Controls.Add(this.btnSorteioJogos);
            this.Name = "FormRandom";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSorteioJogos;
        private System.Windows.Forms.Button btnDados;
    }
}

