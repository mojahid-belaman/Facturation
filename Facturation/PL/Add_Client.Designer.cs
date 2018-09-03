namespace Facturation.PL
{
    partial class Add_Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.txtville = new System.Windows.Forms.TextBox();
            this.txtsolde = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodeCl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Solde :";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(150, 85);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(219, 25);
            this.txtnom.TabIndex = 0;
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(152, 143);
            this.txtadresse.Margin = new System.Windows.Forms.Padding(4);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(219, 25);
            this.txtadresse.TabIndex = 2;
            // 
            // txtville
            // 
            this.txtville.Location = new System.Drawing.Point(152, 202);
            this.txtville.Margin = new System.Windows.Forms.Padding(4);
            this.txtville.Name = "txtville";
            this.txtville.Size = new System.Drawing.Size(219, 25);
            this.txtville.TabIndex = 3;
            // 
            // txtsolde
            // 
            this.txtsolde.Location = new System.Drawing.Point(152, 258);
            this.txtsolde.Margin = new System.Windows.Forms.Padding(4);
            this.txtsolde.Name = "txtsolde";
            this.txtsolde.Size = new System.Drawing.Size(219, 25);
            this.txtsolde.TabIndex = 4;
            this.txtsolde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsolde_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 321);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code Client :";
            // 
            // txtCodeCl
            // 
            this.txtCodeCl.Location = new System.Drawing.Point(150, 25);
            this.txtCodeCl.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeCl.Name = "txtCodeCl";
            this.txtCodeCl.Size = new System.Drawing.Size(219, 25);
            this.txtCodeCl.TabIndex = 0;
            this.txtCodeCl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeCl_KeyPress);
            this.txtCodeCl.Validated += new System.EventHandler(this.txtCodeCl_Validated);
            // 
            // Add_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsolde);
            this.Controls.Add(this.txtville);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.txtCodeCl);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Client";
            this.Text = "Add_Client";
            this.Load += new System.EventHandler(this.Add_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.TextBox txtville;
        private System.Windows.Forms.TextBox txtsolde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodeCl;
    }
}