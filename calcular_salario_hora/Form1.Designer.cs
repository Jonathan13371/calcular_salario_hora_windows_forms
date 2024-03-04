
namespace ex03
{
    partial class frmTelaPrinciopal
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textHoras = new System.Windows.Forms.TextBox();
            this.lblHoras2 = new System.Windows.Forms.Label();
            this.lblRecebidoPorHora = new System.Windows.Forms.Label();
            this.textValorHora = new System.Windows.Forms.TextBox();
            this.bntSalario = new System.Windows.Forms.Button();
            this.lblSaida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(194, 84);
            this.lblNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(114, 126);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(124, 19);
            this.lblHoras.TabIndex = 1;
            this.lblHoras.Text = "Quantidade de ";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(263, 82);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(216, 26);
            this.textNome.TabIndex = 2;
            // 
            // textHoras
            // 
            this.textHoras.Location = new System.Drawing.Point(263, 142);
            this.textHoras.Name = "textHoras";
            this.textHoras.Size = new System.Drawing.Size(216, 26);
            this.textHoras.TabIndex = 3;
            // 
            // lblHoras2
            // 
            this.lblHoras2.AutoSize = true;
            this.lblHoras2.Location = new System.Drawing.Point(104, 145);
            this.lblHoras2.Name = "lblHoras2";
            this.lblHoras2.Size = new System.Drawing.Size(159, 19);
            this.lblHoras2.TabIndex = 4;
            this.lblHoras2.Text = "Horas Trabalhadas:";
            // 
            // lblRecebidoPorHora
            // 
            this.lblRecebidoPorHora.AutoSize = true;
            this.lblRecebidoPorHora.Location = new System.Drawing.Point(66, 193);
            this.lblRecebidoPorHora.Name = "lblRecebidoPorHora";
            this.lblRecebidoPorHora.Size = new System.Drawing.Size(197, 19);
            this.lblRecebidoPorHora.TabIndex = 5;
            this.lblRecebidoPorHora.Text = "Valor recebido Por Hora:";
            // 
            // textValorHora
            // 
            this.textValorHora.Location = new System.Drawing.Point(263, 186);
            this.textValorHora.Name = "textValorHora";
            this.textValorHora.Size = new System.Drawing.Size(216, 26);
            this.textValorHora.TabIndex = 6;
            // 
            // bntSalario
            // 
            this.bntSalario.BackColor = System.Drawing.SystemColors.Desktop;
            this.bntSalario.ForeColor = System.Drawing.Color.Cornsilk;
            this.bntSalario.Location = new System.Drawing.Point(283, 230);
            this.bntSalario.Name = "bntSalario";
            this.bntSalario.Size = new System.Drawing.Size(154, 64);
            this.bntSalario.TabIndex = 7;
            this.bntSalario.Text = "Calcular Salario Mensal";
            this.bntSalario.UseVisualStyleBackColor = false;
            this.bntSalario.Click += new System.EventHandler(this.bntSalario_Click);
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(125, 318);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(0, 19);
            this.lblSaida.TabIndex = 8;
            // 
            // frmTelaPrinciopal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(747, 377);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.bntSalario);
            this.Controls.Add(this.textValorHora);
            this.Controls.Add(this.lblRecebidoPorHora);
            this.Controls.Add(this.lblHoras2);
            this.Controls.Add(this.textHoras);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmTelaPrinciopal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTelaPrinciopal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textHoras;
        private System.Windows.Forms.Label lblHoras2;
        private System.Windows.Forms.Label lblRecebidoPorHora;
        private System.Windows.Forms.TextBox textValorHora;
        private System.Windows.Forms.Button bntSalario;
        private System.Windows.Forms.Label lblSaida;
    }
}

