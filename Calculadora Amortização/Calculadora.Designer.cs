
namespace Calculadora_Amortização
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.textBox_Valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Taxa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Tempo = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmd_calcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Juros = new System.Windows.Forms.Label();
            this.lb_Amortizacao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Pagamento = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Valor
            // 
            this.textBox_Valor.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Valor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_Valor.Location = new System.Drawing.Point(10, 50);
            this.textBox_Valor.Name = "textBox_Valor";
            this.textBox_Valor.Size = new System.Drawing.Size(168, 20);
            this.textBox_Valor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Taxa:";
            // 
            // textBox_Taxa
            // 
            this.textBox_Taxa.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Taxa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_Taxa.Location = new System.Drawing.Point(10, 89);
            this.textBox_Taxa.Name = "textBox_Taxa";
            this.textBox_Taxa.Size = new System.Drawing.Size(168, 20);
            this.textBox_Taxa.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tempo:";
            // 
            // textBox_Tempo
            // 
            this.textBox_Tempo.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Tempo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_Tempo.Location = new System.Drawing.Point(10, 128);
            this.textBox_Tempo.Name = "textBox_Tempo";
            this.textBox_Tempo.Size = new System.Drawing.Size(168, 20);
            this.textBox_Tempo.TabIndex = 2;
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Pagamento Único",
            "Pagamentos Variáveis",
            "Americano",
            "Amortização Constante (SAC)",
            "Price",
            "Amortização Misto (SAM)",
            "Alemão",
            "Amortização Crescente (SACRE)"});
            this.comboBox.Location = new System.Drawing.Point(10, 167);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(168, 21);
            this.comboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Amortização:";
            // 
            // cmd_calcular
            // 
            this.cmd_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmd_calcular.ForeColor = System.Drawing.Color.White;
            this.cmd_calcular.Location = new System.Drawing.Point(110, 172);
            this.cmd_calcular.Name = "cmd_calcular";
            this.cmd_calcular.Size = new System.Drawing.Size(75, 23);
            this.cmd_calcular.TabIndex = 0;
            this.cmd_calcular.Text = "Calcular";
            this.cmd_calcular.UseVisualStyleBackColor = false;
            this.cmd_calcular.Click += new System.EventHandler(this.cmd_calcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Juros Total:";
            // 
            // lb_Juros
            // 
            this.lb_Juros.BackColor = System.Drawing.Color.Silver;
            this.lb_Juros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Juros.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_Juros.Location = new System.Drawing.Point(14, 50);
            this.lb_Juros.Name = "lb_Juros";
            this.lb_Juros.Size = new System.Drawing.Size(168, 20);
            this.lb_Juros.TabIndex = 1;
            this.lb_Juros.Text = "$";
            this.lb_Juros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Amortizacao
            // 
            this.lb_Amortizacao.BackColor = System.Drawing.Color.Silver;
            this.lb_Amortizacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Amortizacao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_Amortizacao.Location = new System.Drawing.Point(14, 89);
            this.lb_Amortizacao.Name = "lb_Amortizacao";
            this.lb_Amortizacao.Size = new System.Drawing.Size(168, 20);
            this.lb_Amortizacao.TabIndex = 2;
            this.lb_Amortizacao.Text = "$";
            this.lb_Amortizacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Amortização Total:";
            // 
            // lb_Pagamento
            // 
            this.lb_Pagamento.BackColor = System.Drawing.Color.Silver;
            this.lb_Pagamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Pagamento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_Pagamento.Location = new System.Drawing.Point(14, 128);
            this.lb_Pagamento.Name = "lb_Pagamento";
            this.lb_Pagamento.Size = new System.Drawing.Size(168, 20);
            this.lb_Pagamento.TabIndex = 3;
            this.lb_Pagamento.Text = "$";
            this.lb_Pagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Pagamento Total:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 30);
            this.label11.TabIndex = 4;
            this.label11.Text = "INPUTS";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox_Valor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_Taxa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_Tempo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 200);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lb_Pagamento);
            this.panel2.Controls.Add(this.cmd_calcular);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lb_Juros);
            this.panel2.Controls.Add(this.lb_Amortizacao);
            this.panel2.Controls.Add(this.label7);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(208, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 200);
            this.panel2.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 30);
            this.label12.TabIndex = 4;
            this.label12.Text = "RESULTADOS";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(410, 225);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Amortização";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Taxa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Tempo;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmd_calcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_Juros;
        private System.Windows.Forms.Label lb_Amortizacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_Pagamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
    }
}

