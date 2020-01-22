namespace Calatorie
{
    partial class Operatii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operatii));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Administrare = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Turisti = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Iesire = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Administrare,
            this.toolStripButton_Turisti,
            this.toolStripButton_Iesire});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Administrare
            // 
            this.toolStripButton_Administrare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Administrare.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Administrare.Image")));
            this.toolStripButton_Administrare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Administrare.Name = "toolStripButton_Administrare";
            this.toolStripButton_Administrare.Size = new System.Drawing.Size(98, 24);
            this.toolStripButton_Administrare.Text = "Administrare";
            this.toolStripButton_Administrare.Click += new System.EventHandler(this.toolStripButton_Administrare_Click);
            // 
            // toolStripButton_Turisti
            // 
            this.toolStripButton_Turisti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Turisti.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Turisti.Image")));
            this.toolStripButton_Turisti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Turisti.Name = "toolStripButton_Turisti";
            this.toolStripButton_Turisti.Size = new System.Drawing.Size(53, 24);
            this.toolStripButton_Turisti.Text = "Turisti";
            this.toolStripButton_Turisti.Click += new System.EventHandler(this.toolStripButton_Turisti_Click);
            // 
            // toolStripButton_Iesire
            // 
            this.toolStripButton_Iesire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Iesire.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Iesire.Image")));
            this.toolStripButton_Iesire.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Iesire.Name = "toolStripButton_Iesire";
            this.toolStripButton_Iesire.Size = new System.Drawing.Size(48, 24);
            this.toolStripButton_Iesire.Text = "Iesire";
            this.toolStripButton_Iesire.Click += new System.EventHandler(this.toolStripButton_Iesire_Click);
            // 
            // Operatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Operatii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operatii";
            this.Load += new System.EventHandler(this.Operatii_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton toolStripButton_Administrare;
        public System.Windows.Forms.ToolStripButton toolStripButton_Turisti;
        public System.Windows.Forms.ToolStripButton toolStripButton_Iesire;
    }
}