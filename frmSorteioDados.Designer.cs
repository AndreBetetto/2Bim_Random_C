﻿namespace _03AndreRandom72B
{
    partial class frmSorteioDados
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
            this.picBoxQuadradro1 = new System.Windows.Forms.PictureBox();
            this.picBoxQuadradro2 = new System.Windows.Forms.PictureBox();
            this.lblPlacarJog1 = new System.Windows.Forms.Label();
            this.lblPlacarJog2 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtboxNickName1 = new System.Windows.Forms.TextBox();
            this.txtboxNickName2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmpates = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuadradro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuadradro2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxQuadradro1
            // 
            this.picBoxQuadradro1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxQuadradro1.Location = new System.Drawing.Point(88, 42);
            this.picBoxQuadradro1.Name = "picBoxQuadradro1";
            this.picBoxQuadradro1.Size = new System.Drawing.Size(147, 142);
            this.picBoxQuadradro1.TabIndex = 0;
            this.picBoxQuadradro1.TabStop = false;
            // 
            // picBoxQuadradro2
            // 
            this.picBoxQuadradro2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxQuadradro2.Location = new System.Drawing.Point(308, 42);
            this.picBoxQuadradro2.MaximumSize = new System.Drawing.Size(222, 227);
            this.picBoxQuadradro2.Name = "picBoxQuadradro2";
            this.picBoxQuadradro2.Size = new System.Drawing.Size(147, 142);
            this.picBoxQuadradro2.TabIndex = 1;
            this.picBoxQuadradro2.TabStop = false;
            // 
            // lblPlacarJog1
            // 
            this.lblPlacarJog1.BackColor = System.Drawing.Color.LightGray;
            this.lblPlacarJog1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlacarJog1.Location = new System.Drawing.Point(88, 203);
            this.lblPlacarJog1.Name = "lblPlacarJog1";
            this.lblPlacarJog1.Size = new System.Drawing.Size(147, 23);
            this.lblPlacarJog1.TabIndex = 2;
            // 
            // lblPlacarJog2
            // 
            this.lblPlacarJog2.BackColor = System.Drawing.Color.LightGray;
            this.lblPlacarJog2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlacarJog2.Location = new System.Drawing.Point(305, 203);
            this.lblPlacarJog2.Name = "lblPlacarJog2";
            this.lblPlacarJog2.Size = new System.Drawing.Size(150, 23);
            this.lblPlacarJog2.TabIndex = 3;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(227, 285);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(79, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Jogar";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtboxNickName1
            // 
            this.txtboxNickName1.Location = new System.Drawing.Point(88, 16);
            this.txtboxNickName1.Name = "txtboxNickName1";
            this.txtboxNickName1.Size = new System.Drawing.Size(147, 20);
            this.txtboxNickName1.TabIndex = 5;
            // 
            // txtboxNickName2
            // 
            this.txtboxNickName2.Location = new System.Drawing.Point(308, 16);
            this.txtboxNickName2.Name = "txtboxNickName2";
            this.txtboxNickName2.Size = new System.Drawing.Size(147, 20);
            this.txtboxNickName2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblEmpates);
            this.panel1.Location = new System.Drawing.Point(80, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 269);
            this.panel1.TabIndex = 7;
            // 
            // lblEmpates
            // 
            this.lblEmpates.BackColor = System.Drawing.Color.LightGray;
            this.lblEmpates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpates.Location = new System.Drawing.Point(146, 233);
            this.lblEmpates.Name = "lblEmpates";
            this.lblEmpates.Size = new System.Drawing.Size(79, 23);
            this.lblEmpates.TabIndex = 8;
            // 
            // frmSorteioDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxNickName2);
            this.Controls.Add(this.txtboxNickName1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblPlacarJog2);
            this.Controls.Add(this.lblPlacarJog1);
            this.Controls.Add(this.picBoxQuadradro2);
            this.Controls.Add(this.picBoxQuadradro1);
            this.Controls.Add(this.panel1);
            this.Name = "frmSorteioDados";
            this.Text = "SorteioDados";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuadradro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuadradro2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxQuadradro1;
        private System.Windows.Forms.PictureBox picBoxQuadradro2;
        private System.Windows.Forms.Label lblPlacarJog1;
        private System.Windows.Forms.Label lblPlacarJog2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtboxNickName1;
        private System.Windows.Forms.TextBox txtboxNickName2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmpates;
    }
}