
namespace CalculadoraSimples
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.BtnSomar = new System.Windows.Forms.Button();
            this.BtnDiminuir = new System.Windows.Forms.Button();
            this.BtnMultiplicar = new System.Windows.Forms.Button();
            this.BtnDividir = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Pink;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "1º Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Pink;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "2º Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Pink;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNum1.Location = new System.Drawing.Point(112, 50);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNum2.Location = new System.Drawing.Point(112, 79);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 5;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtResultado.Location = new System.Drawing.Point(112, 108);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 6;
            // 
            // BtnSomar
            // 
            this.BtnSomar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSomar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSomar.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSomar.Location = new System.Drawing.Point(274, 47);
            this.BtnSomar.Name = "BtnSomar";
            this.BtnSomar.Size = new System.Drawing.Size(45, 41);
            this.BtnSomar.TabIndex = 7;
            this.BtnSomar.Text = "+";
            this.BtnSomar.UseVisualStyleBackColor = false;
            this.BtnSomar.Click += new System.EventHandler(this.BtnSomar_Click);
            // 
            // BtnDiminuir
            // 
            this.BtnDiminuir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDiminuir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnDiminuir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDiminuir.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiminuir.Location = new System.Drawing.Point(325, 47);
            this.BtnDiminuir.Name = "BtnDiminuir";
            this.BtnDiminuir.Size = new System.Drawing.Size(45, 41);
            this.BtnDiminuir.TabIndex = 8;
            this.BtnDiminuir.Text = "-";
            this.BtnDiminuir.UseVisualStyleBackColor = false;
            this.BtnDiminuir.Click += new System.EventHandler(this.BtnDiminuir_Click);
            // 
            // BtnMultiplicar
            // 
            this.BtnMultiplicar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMultiplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMultiplicar.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicar.Location = new System.Drawing.Point(274, 94);
            this.BtnMultiplicar.Name = "BtnMultiplicar";
            this.BtnMultiplicar.Size = new System.Drawing.Size(45, 41);
            this.BtnMultiplicar.TabIndex = 9;
            this.BtnMultiplicar.Text = "X";
            this.BtnMultiplicar.UseVisualStyleBackColor = false;
            this.BtnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicar_Click);
            // 
            // BtnDividir
            // 
            this.BtnDividir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDividir.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDividir.Location = new System.Drawing.Point(325, 94);
            this.BtnDividir.Name = "BtnDividir";
            this.BtnDividir.Size = new System.Drawing.Size(45, 41);
            this.BtnDividir.TabIndex = 10;
            this.BtnDividir.Text = "/";
            this.BtnDividir.UseVisualStyleBackColor = false;
            this.BtnDividir.Click += new System.EventHandler(this.BtnDividir_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(393, 53);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 28);
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnOff
            // 
            this.BtnOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOff.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOff.Location = new System.Drawing.Point(393, 98);
            this.BtnOff.Name = "BtnOff";
            this.BtnOff.Size = new System.Drawing.Size(75, 30);
            this.BtnOff.TabIndex = 12;
            this.BtnOff.Text = "Off";
            this.BtnOff.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalculadoraSimples.Properties.Resources.numeros_naturais;
            this.ClientSize = new System.Drawing.Size(480, 147);
            this.Controls.Add(this.BtnOff);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDividir);
            this.Controls.Add(this.BtnMultiplicar);
            this.Controls.Add(this.BtnDiminuir);
            this.Controls.Add(this.BtnSomar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button BtnSomar;
        private System.Windows.Forms.Button BtnDiminuir;
        private System.Windows.Forms.Button BtnMultiplicar;
        private System.Windows.Forms.Button BtnDividir;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnOff;
    }
}

