namespace ExerciciosCSharp
{
    partial class InteirosQuetao1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelIntervalo = new System.Windows.Forms.Label();
            this.UpInicio = new System.Windows.Forms.NumericUpDown();
            this.UpFinal = new System.Windows.Forms.NumericUpDown();
            this.EdtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Barra = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.UpInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(458, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1.  Dada uma seqüência de números inteiros não-nulos, seguida por 0, imprimir seu" +
    "s quadrados.";
            // 
            // labelIntervalo
            // 
            this.labelIntervalo.AutoSize = true;
            this.labelIntervalo.Location = new System.Drawing.Point(12, 38);
            this.labelIntervalo.Name = "labelIntervalo";
            this.labelIntervalo.Size = new System.Drawing.Size(140, 13);
            this.labelIntervalo.TabIndex = 1;
            this.labelIntervalo.Text = "Informe Abaixo Um Intervalo";
            // 
            // UpInicio
            // 
            this.UpInicio.Location = new System.Drawing.Point(15, 64);
            this.UpInicio.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.UpInicio.Name = "UpInicio";
            this.UpInicio.Size = new System.Drawing.Size(75, 20);
            this.UpInicio.TabIndex = 2;
            // 
            // UpFinal
            // 
            this.UpFinal.Location = new System.Drawing.Point(96, 64);
            this.UpFinal.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.UpFinal.Name = "UpFinal";
            this.UpFinal.Size = new System.Drawing.Size(75, 20);
            this.UpFinal.TabIndex = 3;
            // 
            // EdtResultado
            // 
            this.EdtResultado.Location = new System.Drawing.Point(15, 136);
            this.EdtResultado.Multiline = true;
            this.EdtResultado.Name = "EdtResultado";
            this.EdtResultado.Size = new System.Drawing.Size(455, 278);
            this.EdtResultado.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Barra
            // 
            this.Barra.ForeColor = System.Drawing.Color.Blue;
            this.Barra.Location = new System.Drawing.Point(15, 121);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(455, 10);
            this.Barra.TabIndex = 7;
            // 
            // InteirosQuetao1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 426);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EdtResultado);
            this.Controls.Add(this.UpFinal);
            this.Controls.Add(this.UpInicio);
            this.Controls.Add(this.labelIntervalo);
            this.Controls.Add(this.textBox1);
            this.Name = "InteirosQuetao1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InteirosQuetao1";
            ((System.ComponentModel.ISupportInitialize)(this.UpInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelIntervalo;
        private System.Windows.Forms.NumericUpDown UpInicio;
        private System.Windows.Forms.NumericUpDown UpFinal;
        private System.Windows.Forms.TextBox EdtResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar Barra;
    }
}