namespace Facturation.PL
{
    partial class All_Article
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
            this.dgvArticle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticle
            // 
            this.dgvArticle.AllowUserToAddRows = false;
            this.dgvArticle.AllowUserToDeleteRows = false;
            this.dgvArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticle.Location = new System.Drawing.Point(0, 0);
            this.dgvArticle.MultiSelect = false;
            this.dgvArticle.Name = "dgvArticle";
            this.dgvArticle.ReadOnly = true;
            this.dgvArticle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticle.Size = new System.Drawing.Size(616, 398);
            this.dgvArticle.TabIndex = 0;
            this.dgvArticle.DoubleClick += new System.EventHandler(this.dgvArticle_DoubleClick);
            // 
            // All_Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 398);
            this.Controls.Add(this.dgvArticle);
            this.Name = "All_Article";
            this.Text = "All_Article";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvArticle;
    }
}