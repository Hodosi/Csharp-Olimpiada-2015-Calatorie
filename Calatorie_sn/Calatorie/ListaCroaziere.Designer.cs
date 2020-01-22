namespace Calatorie
{
    partial class ListaCroaziere
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
            this.comboBox_tipCroaz = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_tipCroaz
            // 
            this.comboBox_tipCroaz.DisplayMember = "3";
            this.comboBox_tipCroaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipCroaz.FormattingEnabled = true;
            this.comboBox_tipCroaz.Items.AddRange(new object[] {
            "3 ",
            "5",
            "8"});
            this.comboBox_tipCroaz.Location = new System.Drawing.Point(329, 12);
            this.comboBox_tipCroaz.Name = "comboBox_tipCroaz";
            this.comboBox_tipCroaz.Size = new System.Drawing.Size(279, 37);
            this.comboBox_tipCroaz.TabIndex = 0;
            this.comboBox_tipCroaz.Text = "3";
            this.comboBox_tipCroaz.ValueMember = "3";
            this.comboBox_tipCroaz.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipCroaz_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1366, 435);
            this.dataGridView1.TabIndex = 1;
            // 
            // ListaCroaziere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 546);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_tipCroaz);
            this.Name = "ListaCroaziere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaCroaziere";
            this.Load += new System.EventHandler(this.ListaCroaziere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_tipCroaz;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}