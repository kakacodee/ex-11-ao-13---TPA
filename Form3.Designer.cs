
namespace ex_11_ao_13
{
    partial class Frm3
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
            this.btnpara = new System.Windows.Forms.Button();
            this.btnen = new System.Windows.Forms.Button();
            this.btnre = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtc = new System.Windows.Forms.TextBox();
            this.lblc = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnpara
            // 
            this.btnpara.Location = new System.Drawing.Point(501, 260);
            this.btnpara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpara.Name = "btnpara";
            this.btnpara.Size = new System.Drawing.Size(108, 46);
            this.btnpara.TabIndex = 0;
            this.btnpara.Text = "Para";
            this.btnpara.UseVisualStyleBackColor = true;
            this.btnpara.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnen
            // 
            this.btnen.Location = new System.Drawing.Point(501, 204);
            this.btnen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnen.Name = "btnen";
            this.btnen.Size = new System.Drawing.Size(108, 46);
            this.btnen.TabIndex = 1;
            this.btnen.Text = "Enquanto";
            this.btnen.UseVisualStyleBackColor = true;
            this.btnen.Click += new System.EventHandler(this.btnen_Click);
            // 
            // btnre
            // 
            this.btnre.Location = new System.Drawing.Point(617, 207);
            this.btnre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnre.Name = "btnre";
            this.btnre.Size = new System.Drawing.Size(108, 46);
            this.btnre.TabIndex = 2;
            this.btnre.Text = "Repíta";
            this.btnre.UseVisualStyleBackColor = true;
            this.btnre.Click += new System.EventHandler(this.btnre_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlimpar.Location = new System.Drawing.Point(617, 261);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(108, 46);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(16, 15);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(108, 46);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtc
            // 
            this.txtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc.Location = new System.Drawing.Point(463, 145);
            this.txtc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(289, 37);
            this.txtc.TabIndex = 5;
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc.Location = new System.Drawing.Point(107, 145);
            this.lblc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(348, 31);
            this.lblc.TabIndex = 6;
            this.lblc.Text = "Digite a temperatura em Cº:";
            // 
            // txtR
            // 
            this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR.Location = new System.Drawing.Point(387, 207);
            this.txtR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtR.Multiline = true;
            this.txtR.Name = "txtR";
            this.txtR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtR.Size = new System.Drawing.Size(104, 174);
            this.txtR.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Temperatura Em Fº:";
            // 
            // Frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnre);
            this.Controls.Add(this.btnen);
            this.Controls.Add(this.btnpara);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm3";
            this.Text = "Cº para Fº";
            this.Load += new System.EventHandler(this.Frm3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpara;
        private System.Windows.Forms.Button btnen;
        private System.Windows.Forms.Button btnre;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label1;
    }
}