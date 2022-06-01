namespace Cajero_sin_if_grafico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CambioBtn = new System.Windows.Forms.Button();
            this.CambioTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca el valor de su billete";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CambioBtn
            // 
            this.CambioBtn.Location = new System.Drawing.Point(71, 124);
            this.CambioBtn.Name = "CambioBtn";
            this.CambioBtn.Size = new System.Drawing.Size(75, 23);
            this.CambioBtn.TabIndex = 1;
            this.CambioBtn.Text = "Cambio";
            this.CambioBtn.UseVisualStyleBackColor = true;
            this.CambioBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CambioTXT
            // 
            this.CambioTXT.Location = new System.Drawing.Point(71, 79);
            this.CambioTXT.Name = "CambioTXT";
            this.CambioTXT.Size = new System.Drawing.Size(170, 23);
            this.CambioTXT.TabIndex = 2;
            this.CambioTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "*Solo Recibe hasta 100 pesos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 210);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CambioTXT);
            this.Controls.Add(this.CambioBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button CambioBtn;
        private TextBox CambioTXT;
        private Label label2;
    }
}