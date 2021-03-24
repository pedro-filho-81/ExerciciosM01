
namespace Exe002
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
            this.btn = new System.Windows.Forms.Button();
            this.lblMeu = new System.Windows.Forms.Label();
            this.lblBrasil = new System.Windows.Forms.Label();
            this.lblBrasileiro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn.Location = new System.Drawing.Point(85, 111);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(206, 72);
            this.btn.TabIndex = 0;
            this.btn.Text = "Iniciar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblMeu
            // 
            this.lblMeu.AutoSize = true;
            this.lblMeu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMeu.Location = new System.Drawing.Point(37, 43);
            this.lblMeu.Name = "lblMeu";
            this.lblMeu.Size = new System.Drawing.Size(0, 28);
            this.lblMeu.TabIndex = 1;
            // 
            // lblBrasil
            // 
            this.lblBrasil.AutoSize = true;
            this.lblBrasil.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrasil.Location = new System.Drawing.Point(115, 43);
            this.lblBrasil.Name = "lblBrasil";
            this.lblBrasil.Size = new System.Drawing.Size(0, 28);
            this.lblBrasil.TabIndex = 2;
            this.lblBrasil.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBrasileiro
            // 
            this.lblBrasileiro.AutoSize = true;
            this.lblBrasileiro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrasileiro.Location = new System.Drawing.Point(217, 43);
            this.lblBrasileiro.Name = "lblBrasileiro";
            this.lblBrasileiro.Size = new System.Drawing.Size(0, 28);
            this.lblBrasileiro.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 232);
            this.Controls.Add(this.lblBrasileiro);
            this.Controls.Add(this.lblBrasil);
            this.Controls.Add(this.lblMeu);
            this.Controls.Add(this.btn);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brasil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblMeu;
        private System.Windows.Forms.Label lblBrasil;
        private System.Windows.Forms.Label lblBrasileiro;
    }
}

