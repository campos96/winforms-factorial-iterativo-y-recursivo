
namespace FactorialIterativoYRecursivo
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIterativo = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecursivo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.btnRecursivo);
            this.groupBox1.Controls.Add(this.btnIterativo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(454, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculo de factorial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // btnIterativo
            // 
            this.btnIterativo.BackColor = System.Drawing.Color.Black;
            this.btnIterativo.FlatAppearance.BorderSize = 0;
            this.btnIterativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIterativo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIterativo.ForeColor = System.Drawing.Color.White;
            this.btnIterativo.Location = new System.Drawing.Point(242, 174);
            this.btnIterativo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnIterativo.Name = "btnIterativo";
            this.btnIterativo.Size = new System.Drawing.Size(187, 39);
            this.btnIterativo.TabIndex = 1;
            this.btnIterativo.Text = "Forma recursiva";
            this.btnIterativo.UseVisualStyleBackColor = false;
            this.btnIterativo.Click += new System.EventHandler(this.btnIterativo_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(135, 45);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(294, 29);
            this.txtNumero.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Gainsboro;
            this.txtResultado.Location = new System.Drawing.Point(135, 97);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(294, 29);
            this.txtResultado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado:";
            // 
            // btnRecursivo
            // 
            this.btnRecursivo.BackColor = System.Drawing.Color.Black;
            this.btnRecursivo.FlatAppearance.BorderSize = 0;
            this.btnRecursivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecursivo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecursivo.ForeColor = System.Drawing.Color.White;
            this.btnRecursivo.Location = new System.Drawing.Point(26, 174);
            this.btnRecursivo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRecursivo.Name = "btnRecursivo";
            this.btnRecursivo.Size = new System.Drawing.Size(187, 39);
            this.btnRecursivo.TabIndex = 1;
            this.btnRecursivo.Text = "Forma Iterativa";
            this.btnRecursivo.UseVisualStyleBackColor = false;
            this.btnRecursivo.Click += new System.EventHandler(this.btnRecursivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de factorial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnIterativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecursivo;
    }
}

