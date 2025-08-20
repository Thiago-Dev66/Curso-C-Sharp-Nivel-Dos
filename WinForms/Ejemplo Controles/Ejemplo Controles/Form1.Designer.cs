namespace Ejemplo_Controles
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.dtpPersona = new System.Windows.Forms.DateTimePicker();
            this.lblEdad = new System.Windows.Forms.Label();
            this.chboxChoco = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbMaiden = new System.Windows.Forms.RadioButton();
            this.gbBanda = new System.Windows.Forms.GroupBox();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbMetallica = new System.Windows.Forms.RadioButton();
            this.cbColores = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblNdelaSuerte = new System.Windows.Forms.Label();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.gbBanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(199, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(363, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNacionalidad.Location = new System.Drawing.Point(199, 224);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(363, 26);
            this.txtNacionalidad.TabIndex = 2;
            // 
            // lblname
            // 
            this.lblname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(73, 134);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(65, 20);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Nombre";
            // 
            // dtpPersona
            // 
            this.dtpPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPersona.Location = new System.Drawing.Point(199, 176);
            this.dtpPersona.Name = "dtpPersona";
            this.dtpPersona.Size = new System.Drawing.Size(363, 26);
            this.dtpPersona.TabIndex = 1;
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(91, 182);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(47, 20);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad";
            // 
            // chboxChoco
            // 
            this.chboxChoco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chboxChoco.AutoSize = true;
            this.chboxChoco.Location = new System.Drawing.Point(199, 273);
            this.chboxChoco.Name = "chboxChoco";
            this.chboxChoco.Size = new System.Drawing.Size(169, 24);
            this.chboxChoco.TabIndex = 3;
            this.chboxChoco.Text = "Te gusta el choco?";
            this.chboxChoco.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(181, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 45);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Perfil Personal";
            // 
            // rbMaiden
            // 
            this.rbMaiden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMaiden.AutoSize = true;
            this.rbMaiden.Location = new System.Drawing.Point(27, 39);
            this.rbMaiden.Name = "rbMaiden";
            this.rbMaiden.Size = new System.Drawing.Size(118, 24);
            this.rbMaiden.TabIndex = 9;
            this.rbMaiden.TabStop = true;
            this.rbMaiden.Text = "Iron Maiden";
            this.rbMaiden.UseVisualStyleBackColor = true;
            // 
            // gbBanda
            // 
            this.gbBanda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbBanda.Controls.Add(this.rbBlack);
            this.gbBanda.Controls.Add(this.rbMetallica);
            this.gbBanda.Controls.Add(this.rbMaiden);
            this.gbBanda.Location = new System.Drawing.Point(77, 326);
            this.gbBanda.Name = "gbBanda";
            this.gbBanda.Size = new System.Drawing.Size(500, 100);
            this.gbBanda.TabIndex = 4;
            this.gbBanda.TabStop = false;
            this.gbBanda.Text = "Banda Favorita? ";
            // 
            // rbBlack
            // 
            this.rbBlack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(347, 39);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(138, 24);
            this.rbBlack.TabIndex = 11;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Black Sabbath";
            this.rbBlack.UseVisualStyleBackColor = true;
            // 
            // rbMetallica
            // 
            this.rbMetallica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMetallica.AutoSize = true;
            this.rbMetallica.Location = new System.Drawing.Point(195, 39);
            this.rbMetallica.Name = "rbMetallica";
            this.rbMetallica.Size = new System.Drawing.Size(96, 24);
            this.rbMetallica.TabIndex = 10;
            this.rbMetallica.TabStop = true;
            this.rbMetallica.Text = "Metallica";
            this.rbMetallica.UseVisualStyleBackColor = true;
            // 
            // cbColores
            // 
            this.cbColores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbColores.FormattingEnabled = true;
            this.cbColores.Location = new System.Drawing.Point(199, 463);
            this.cbColores.Name = "cbColores";
            this.cbColores.Size = new System.Drawing.Size(378, 28);
            this.cbColores.TabIndex = 5;
            this.cbColores.SelectedIndexChanged += new System.EventHandler(this.cbColores_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(31, 466);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(107, 20);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color Favorito";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(248, 525);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 6;
            // 
            // lblNdelaSuerte
            // 
            this.lblNdelaSuerte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNdelaSuerte.AutoSize = true;
            this.lblNdelaSuerte.Location = new System.Drawing.Point(31, 531);
            this.lblNdelaSuerte.Name = "lblNdelaSuerte";
            this.lblNdelaSuerte.Size = new System.Drawing.Size(177, 20);
            this.lblNdelaSuerte.TabIndex = 14;
            this.lblNdelaSuerte.Text = "Tu Numero de la Suerte";
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerfil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPerfil.Location = new System.Drawing.Point(216, 594);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(191, 42);
            this.btnPerfil.TabIndex = 9;
            this.btnPerfil.Text = "Ver Perfil";
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(38, 230);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(100, 20);
            this.lblNacionalidad.TabIndex = 16;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(637, 717);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.lblNdelaSuerte);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cbColores);
            this.Controls.Add(this.gbBanda);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chboxChoco);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.dtpPersona);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(962, 856);
            this.MinimumSize = new System.Drawing.Size(659, 773);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbBanda.ResumeLayout(false);
            this.gbBanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.DateTimePicker dtpPersona;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.CheckBox chboxChoco;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbMaiden;
        private System.Windows.Forms.GroupBox gbBanda;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.RadioButton rbMetallica;
        private System.Windows.Forms.ComboBox cbColores;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblNdelaSuerte;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Label lblNacionalidad;
    }
}

