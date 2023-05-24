namespace mycalculator1._0
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnone = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnone
            // 
            this.btnone.Location = new System.Drawing.Point(24, 67);
            this.btnone.Name = "btnone";
            this.btnone.Size = new System.Drawing.Size(75, 59);
            this.btnone.TabIndex = 2;
            this.btnone.Text = "1";
            this.btnone.UseVisualStyleBackColor = true;
            this.btnone.Click += new System.EventHandler(this.btnone_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(129, 67);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 59);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(129, 154);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(75, 59);
            this.igual.TabIndex = 4;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 89);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblop
            // 
            this.lblop.AutoSize = true;
            this.lblop.Location = new System.Drawing.Point(13, 34);
            this.lblop.Name = "lblop";
            this.lblop.Size = new System.Drawing.Size(0, 13);
            this.lblop.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 278);
            this.Controls.Add(this.lblop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnone);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnone;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblop;
    }
}

