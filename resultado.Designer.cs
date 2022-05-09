namespace _03AndreRandom72B
{
    partial class resultado
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblResultadoVencedor = new System.Windows.Forms.Label();
            this.lblTextoVencedor = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(99)))));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.btnVoltar.Location = new System.Drawing.Point(65, 140);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblResultadoVencedor);
            this.panel2.Controls.Add(this.lblTextoVencedor);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 134);
            this.panel2.TabIndex = 10;
            // 
            // lblResultadoVencedor
            // 
            this.lblResultadoVencedor.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoVencedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.lblResultadoVencedor.Location = new System.Drawing.Point(3, 78);
            this.lblResultadoVencedor.Name = "lblResultadoVencedor";
            this.lblResultadoVencedor.Size = new System.Drawing.Size(209, 46);
            this.lblResultadoVencedor.TabIndex = 1;
            this.lblResultadoVencedor.Text = "label2";
            this.lblResultadoVencedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextoVencedor
            // 
            this.lblTextoVencedor.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoVencedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.lblTextoVencedor.Location = new System.Drawing.Point(3, 14);
            this.lblTextoVencedor.Name = "lblTextoVencedor";
            this.lblTextoVencedor.Size = new System.Drawing.Size(209, 46);
            this.lblTextoVencedor.TabIndex = 0;
            this.lblTextoVencedor.Text = "O vencedor é...";
            this.lblTextoVencedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(216, 176);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVoltar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.Name = "resultado";
            this.Text = "resultado";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblResultadoVencedor;
        private System.Windows.Forms.Label lblTextoVencedor;
    }
}