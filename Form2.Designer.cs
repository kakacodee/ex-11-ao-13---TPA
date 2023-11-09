
namespace ex_11_ao_13
{
    partial class frm2
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
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnpara = new System.Windows.Forms.Button();
            this.btnenquanto = new System.Windows.Forms.Button();
            this.btnrepita = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlimpar.Location = new System.Drawing.Point(667, 270);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(100, 39);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnvoltar.Location = new System.Drawing.Point(16, 15);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(100, 28);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnpara
            // 
            this.btnpara.Location = new System.Drawing.Point(667, 220);
            this.btnpara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpara.Name = "btnpara";
            this.btnpara.Size = new System.Drawing.Size(100, 39);
            this.btnpara.TabIndex = 0;
            this.btnpara.Text = "Para";
            this.btnpara.UseVisualStyleBackColor = true;
            this.btnpara.Click += new System.EventHandler(this.btnpara_Click);
            // 
            // btnenquanto
            // 
            this.btnenquanto.Location = new System.Drawing.Point(559, 220);
            this.btnenquanto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnenquanto.Name = "btnenquanto";
            this.btnenquanto.Size = new System.Drawing.Size(100, 39);
            this.btnenquanto.TabIndex = 3;
            this.btnenquanto.Text = "Enquanto";
            this.btnenquanto.UseVisualStyleBackColor = true;
            this.btnenquanto.Click += new System.EventHandler(this.btnenquanto_Click);
            // 
            // btnrepita
            // 
            this.btnrepita.Location = new System.Drawing.Point(559, 270);
            this.btnrepita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrepita.Name = "btnrepita";
            this.btnrepita.Size = new System.Drawing.Size(100, 39);
            this.btnrepita.TabIndex = 4;
            this.btnrepita.Text = "Repita";
            this.btnrepita.UseVisualStyleBackColor = true;
            this.btnrepita.Click += new System.EventHandler(this.btnrepita_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(416, 213);
            this.txtresultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresultado.Size = new System.Drawing.Size(135, 196);
            this.txtresultado.TabIndex = 5;
            this.txtresultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(407, 162);
            this.txtnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(153, 22);
            this.txtnum.TabIndex = 7;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(225, 165);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(174, 17);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Digite o número desejado:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(225, 213);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(183, 17);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "A tabuada desse número é:";
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1067, 543);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btnrepita);
            this.Controls.Add(this.btnenquanto);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnpara);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm2";
            this.Text = "tabuadas";
            this.Load += new System.EventHandler(this.frm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnpara;
        private System.Windows.Forms.Button btnenquanto;
        private System.Windows.Forms.Button btnrepita;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}