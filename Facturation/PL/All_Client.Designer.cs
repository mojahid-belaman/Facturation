namespace Facturation.PL
{
    partial class All_Client
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
            this.dgvAllClient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllClient
            // 
            this.dgvAllClient.AllowUserToAddRows = false;
            this.dgvAllClient.AllowUserToDeleteRows = false;
            this.dgvAllClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllClient.Location = new System.Drawing.Point(0, 0);
            this.dgvAllClient.MultiSelect = false;
            this.dgvAllClient.Name = "dgvAllClient";
            this.dgvAllClient.ReadOnly = true;
            this.dgvAllClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllClient.Size = new System.Drawing.Size(616, 398);
            this.dgvAllClient.TabIndex = 0;
            this.dgvAllClient.DoubleClick += new System.EventHandler(this.dgvAllClient_DoubleClick);
            // 
            // All_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 398);
            this.Controls.Add(this.dgvAllClient);
            this.Name = "All_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All_Client";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvAllClient;
    }
}