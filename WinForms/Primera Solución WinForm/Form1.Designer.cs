namespace Primera_Solución_WinForm
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
            this.BtnSaludar = new System.Windows.Forms.Button();
            this.lblSlaudo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSaludar
            // 
            this.BtnSaludar.Location = new System.Drawing.Point(210, 170);
            this.BtnSaludar.Name = "BtnSaludar";
            this.BtnSaludar.Size = new System.Drawing.Size(320, 93);
            this.BtnSaludar.TabIndex = 0;
            this.BtnSaludar.Text = "Saludar";
            this.BtnSaludar.UseVisualStyleBackColor = true;
            this.BtnSaludar.Click += new System.EventHandler(this.BtnSaludar_Click);
            // 
            // lblSlaudo
            // 
            this.lblSlaudo.AutoSize = true;
            this.lblSlaudo.Location = new System.Drawing.Point(347, 266);
            this.lblSlaudo.Name = "lblSlaudo";
            this.lblSlaudo.Size = new System.Drawing.Size(48, 20);
            this.lblSlaudo.TabIndex = 1;
            this.lblSlaudo.Text = "Label";
            this.lblSlaudo.Click += new System.EventHandler(this.BtnSaludar_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(381, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 26);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(206, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSlaudo);
            this.Controls.Add(this.BtnSaludar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSaludar;
        private System.Windows.Forms.Label lblSlaudo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}

