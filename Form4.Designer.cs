
namespace ex_11_ao_13
{
    partial class frm4
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtcom = new System.Windows.Forms.TextBox();
            this.txtlarg = new System.Windows.Forms.TextBox();
            this.txtcomprimento = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnen = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.txtat = new System.Windows.Forms.TextBox();
            this.lblarea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(376, 80);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(173, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Digite o nome do cômodo:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(376, 116);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(109, 17);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Digite a largura:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(376, 151);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(145, 17);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Digite o comprimento:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(376, 183);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(116, 17);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Área do cômodo:";
            // 
            // txtcom
            // 
            this.txtcom.Location = new System.Drawing.Point(572, 76);
            this.txtcom.Margin = new System.Windows.Forms.Padding(4);
            this.txtcom.Name = "txtcom";
            this.txtcom.Size = new System.Drawing.Size(132, 22);
            this.txtcom.TabIndex = 4;
            // 
            // txtlarg
            // 
            this.txtlarg.Location = new System.Drawing.Point(492, 112);
            this.txtlarg.Margin = new System.Windows.Forms.Padding(4);
            this.txtlarg.Name = "txtlarg";
            this.txtlarg.Size = new System.Drawing.Size(212, 22);
            this.txtlarg.TabIndex = 5;
            // 
            // txtcomprimento
            // 
            this.txtcomprimento.Location = new System.Drawing.Point(529, 151);
            this.txtcomprimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtcomprimento.Name = "txtcomprimento";
            this.txtcomprimento.Size = new System.Drawing.Size(175, 22);
            this.txtcomprimento.TabIndex = 6;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(501, 183);
            this.txtresultado.Margin = new System.Windows.Forms.Padding(4);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(203, 22);
            this.txtresultado.TabIndex = 7;
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnlimpar.Location = new System.Drawing.Point(449, 256);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(100, 28);
            this.btnlimpar.TabIndex = 10;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            // 
            // btnen
            // 
            this.btnen.Location = new System.Drawing.Point(572, 256);
            this.btnen.Margin = new System.Windows.Forms.Padding(4);
            this.btnen.Name = "btnen";
            this.btnen.Size = new System.Drawing.Size(100, 28);
            this.btnen.TabIndex = 11;
            this.btnen.Text = "Calcular";
            this.btnen.UseVisualStyleBackColor = true;
            this.btnen.Click += new System.EventHandler(this.btnen_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnvoltar.Location = new System.Drawing.Point(16, 26);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(100, 28);
            this.btnvoltar.TabIndex = 12;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            // 
            // txtat
            // 
            this.txtat.Location = new System.Drawing.Point(449, 314);
            this.txtat.Margin = new System.Windows.Forms.Padding(4);
            this.txtat.Name = "txtat";
            this.txtat.Size = new System.Drawing.Size(255, 22);
            this.txtat.TabIndex = 13;
            this.txtat.Visible = false;
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(376, 317);
            this.lblarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(73, 17);
            this.lblarea.TabIndex = 14;
            this.lblarea.Text = "Área total:";
            this.lblarea.Visible = false;
            // 
            // frm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.txtat);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnen);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtcomprimento);
            this.Controls.Add(this.txtlarg);
            this.Controls.Add(this.txtcom);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm4";
            this.Text = "Area da Casa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtcom;
        private System.Windows.Forms.TextBox txtlarg;
        private System.Windows.Forms.TextBox txtcomprimento;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnen;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtat;
        private System.Windows.Forms.Label lblarea;
    }
}