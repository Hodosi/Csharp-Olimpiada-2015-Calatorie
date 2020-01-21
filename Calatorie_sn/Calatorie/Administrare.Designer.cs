namespace Calatorie
{
    partial class Administrare
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Init_Cord = new System.Windows.Forms.Button();
            this.button_Save_Cord = new System.Windows.Forms.Button();
            this.button_Actualizare_Cord = new System.Windows.Forms.Button();
            this.button_Generare = new System.Windows.Forms.Button();
            this.button_Lista_Croaziere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_Init_Cord
            // 
            this.button_Init_Cord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Init_Cord.Location = new System.Drawing.Point(892, 67);
            this.button_Init_Cord.Name = "button_Init_Cord";
            this.button_Init_Cord.Size = new System.Drawing.Size(267, 48);
            this.button_Init_Cord.TabIndex = 1;
            this.button_Init_Cord.Text = "Initializare Coordonate";
            this.button_Init_Cord.UseVisualStyleBackColor = true;
            this.button_Init_Cord.Click += new System.EventHandler(this.button_Init_Cord_Click);
            // 
            // button_Save_Cord
            // 
            this.button_Save_Cord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save_Cord.Location = new System.Drawing.Point(892, 146);
            this.button_Save_Cord.Name = "button_Save_Cord";
            this.button_Save_Cord.Size = new System.Drawing.Size(267, 48);
            this.button_Save_Cord.TabIndex = 2;
            this.button_Save_Cord.Text = "Salvare Coordonate";
            this.button_Save_Cord.UseVisualStyleBackColor = true;
            this.button_Save_Cord.Click += new System.EventHandler(this.button_Save_Cord_Click);
            // 
            // button_Actualizare_Cord
            // 
            this.button_Actualizare_Cord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Actualizare_Cord.Location = new System.Drawing.Point(892, 225);
            this.button_Actualizare_Cord.Name = "button_Actualizare_Cord";
            this.button_Actualizare_Cord.Size = new System.Drawing.Size(267, 48);
            this.button_Actualizare_Cord.TabIndex = 3;
            this.button_Actualizare_Cord.Text = "Actualizare Distante";
            this.button_Actualizare_Cord.UseVisualStyleBackColor = true;
            this.button_Actualizare_Cord.Click += new System.EventHandler(this.button_Actualizare_Cord_Click);
            // 
            // button_Generare
            // 
            this.button_Generare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Generare.Location = new System.Drawing.Point(892, 304);
            this.button_Generare.Name = "button_Generare";
            this.button_Generare.Size = new System.Drawing.Size(267, 48);
            this.button_Generare.TabIndex = 4;
            this.button_Generare.Text = "Generare Croaziere";
            this.button_Generare.UseVisualStyleBackColor = true;
            this.button_Generare.Click += new System.EventHandler(this.button_Generare_Click);
            // 
            // button_Lista_Croaziere
            // 
            this.button_Lista_Croaziere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Lista_Croaziere.Location = new System.Drawing.Point(892, 383);
            this.button_Lista_Croaziere.Name = "button_Lista_Croaziere";
            this.button_Lista_Croaziere.Size = new System.Drawing.Size(267, 48);
            this.button_Lista_Croaziere.TabIndex = 5;
            this.button_Lista_Croaziere.Text = "Lista Croaziere";
            this.button_Lista_Croaziere.UseVisualStyleBackColor = true;
            this.button_Lista_Croaziere.Click += new System.EventHandler(this.button_Lista_Croaziere_Click);
            // 
            // Administrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.button_Lista_Croaziere);
            this.Controls.Add(this.button_Generare);
            this.Controls.Add(this.button_Actualizare_Cord);
            this.Controls.Add(this.button_Save_Cord);
            this.Controls.Add(this.button_Init_Cord);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Administrare";
            this.Text = "Administrare";
            this.Load += new System.EventHandler(this.Administrare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Init_Cord;
        private System.Windows.Forms.Button button_Save_Cord;
        private System.Windows.Forms.Button button_Actualizare_Cord;
        private System.Windows.Forms.Button button_Generare;
        private System.Windows.Forms.Button button_Lista_Croaziere;
    }
}