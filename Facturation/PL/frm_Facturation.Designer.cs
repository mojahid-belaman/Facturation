namespace Facturation.PL
{
    partial class frm_Facturation
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
			this.txtVendu = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dtp = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAddCli = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.txtSolde = new System.Windows.Forms.TextBox();
			this.txtNumCl = new System.Windows.Forms.TextBox();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnAddAtc = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.txtQV = new System.Windows.Forms.TextBox();
			this.txtQS = new System.Windows.Forms.TextBox();
			this.txtPrix = new System.Windows.Forms.TextBox();
			this.txtNumArt = new System.Windows.Forms.TextBox();
			this.txtDesign = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txtMontantRest = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(231, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "N_Vente :";
			// 
			// txtVendu
			// 
			this.txtVendu.Location = new System.Drawing.Point(352, 18);
			this.txtVendu.Margin = new System.Windows.Forms.Padding(4);
			this.txtVendu.Name = "txtVendu";
			this.txtVendu.ReadOnly = true;
			this.txtVendu.Size = new System.Drawing.Size(190, 25);
			this.txtVendu.TabIndex = 1;
			this.txtVendu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(614, 22);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Date :";
			// 
			// dtp
			// 
			this.dtp.Enabled = false;
			this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp.Location = new System.Drawing.Point(694, 18);
			this.dtp.Margin = new System.Windows.Forms.Padding(4);
			this.dtp.Name = "dtp";
			this.dtp.Size = new System.Drawing.Size(190, 25);
			this.dtp.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAddCli);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.txtSolde);
			this.groupBox1.Controls.Add(this.txtNumCl);
			this.groupBox1.Controls.Add(this.txtNom);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(18, 51);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(524, 267);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Client";
			// 
			// btnAddCli
			// 
			this.btnAddCli.BackColor = System.Drawing.Color.White;
			this.btnAddCli.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnAddCli.FlatAppearance.BorderSize = 0;
			this.btnAddCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddCli.Location = new System.Drawing.Point(365, 229);
			this.btnAddCli.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddCli.Name = "btnAddCli";
			this.btnAddCli.Size = new System.Drawing.Size(139, 30);
			this.btnAddCli.TabIndex = 4;
			this.btnAddCli.Text = "Nouveau Client";
			this.btnAddCli.UseVisualStyleBackColor = false;
			this.btnAddCli.Click += new System.EventHandler(this.btnAddCli_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(426, 43);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(78, 26);
			this.button1.TabIndex = 3;
			this.button1.Text = ".........";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtSolde
			// 
			this.txtSolde.Location = new System.Drawing.Point(187, 162);
			this.txtSolde.Margin = new System.Windows.Forms.Padding(4);
			this.txtSolde.Name = "txtSolde";
			this.txtSolde.ReadOnly = true;
			this.txtSolde.Size = new System.Drawing.Size(232, 25);
			this.txtSolde.TabIndex = 2;
			this.txtSolde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtNumCl
			// 
			this.txtNumCl.Location = new System.Drawing.Point(187, 43);
			this.txtNumCl.Margin = new System.Windows.Forms.Padding(4);
			this.txtNumCl.Name = "txtNumCl";
			this.txtNumCl.ReadOnly = true;
			this.txtNumCl.Size = new System.Drawing.Size(232, 25);
			this.txtNumCl.TabIndex = 1;
			this.txtNumCl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(187, 103);
			this.txtNom.Margin = new System.Windows.Forms.Padding(4);
			this.txtNom.Name = "txtNom";
			this.txtNom.ReadOnly = true;
			this.txtNom.Size = new System.Drawing.Size(232, 25);
			this.txtNom.TabIndex = 1;
			this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(44, 165);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(53, 17);
			this.label12.TabIndex = 0;
			this.label12.Text = "Solde :";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(44, 46);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(114, 17);
			this.label11.TabIndex = 0;
			this.label11.Text = "Numéro Client :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 106);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Nom :";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnAddAtc);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.txtQV);
			this.groupBox2.Controls.Add(this.txtQS);
			this.groupBox2.Controls.Add(this.txtPrix);
			this.groupBox2.Controls.Add(this.txtNumArt);
			this.groupBox2.Controls.Add(this.txtDesign);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(550, 51);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(472, 368);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Article";
			// 
			// btnAddAtc
			// 
			this.btnAddAtc.BackColor = System.Drawing.Color.White;
			this.btnAddAtc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnAddAtc.FlatAppearance.BorderSize = 0;
			this.btnAddAtc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddAtc.Location = new System.Drawing.Point(176, 324);
			this.btnAddAtc.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddAtc.Name = "btnAddAtc";
			this.btnAddAtc.Size = new System.Drawing.Size(167, 36);
			this.btnAddAtc.TabIndex = 4;
			this.btnAddAtc.Text = "Nouveau Article";
			this.btnAddAtc.UseVisualStyleBackColor = false;
			this.btnAddAtc.Click += new System.EventHandler(this.btnAddAtc_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(381, 38);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(78, 26);
			this.button3.TabIndex = 3;
			this.button3.Text = ".........";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// txtQV
			// 
			this.txtQV.Location = new System.Drawing.Point(176, 280);
			this.txtQV.Margin = new System.Windows.Forms.Padding(4);
			this.txtQV.Name = "txtQV";
			this.txtQV.Size = new System.Drawing.Size(200, 25);
			this.txtQV.TabIndex = 1;
			this.txtQV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtQV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQV_KeyPress);
			// 
			// txtQS
			// 
			this.txtQS.Location = new System.Drawing.Point(175, 220);
			this.txtQS.Margin = new System.Windows.Forms.Padding(4);
			this.txtQS.Name = "txtQS";
			this.txtQS.ReadOnly = true;
			this.txtQS.Size = new System.Drawing.Size(200, 25);
			this.txtQS.TabIndex = 1;
			this.txtQS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPrix
			// 
			this.txtPrix.Location = new System.Drawing.Point(175, 157);
			this.txtPrix.Margin = new System.Windows.Forms.Padding(4);
			this.txtPrix.Name = "txtPrix";
			this.txtPrix.ReadOnly = true;
			this.txtPrix.Size = new System.Drawing.Size(200, 25);
			this.txtPrix.TabIndex = 1;
			this.txtPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtNumArt
			// 
			this.txtNumArt.Location = new System.Drawing.Point(173, 40);
			this.txtNumArt.Margin = new System.Windows.Forms.Padding(4);
			this.txtNumArt.Name = "txtNumArt";
			this.txtNumArt.ReadOnly = true;
			this.txtNumArt.Size = new System.Drawing.Size(200, 25);
			this.txtNumArt.TabIndex = 1;
			this.txtNumArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDesign
			// 
			this.txtDesign.Location = new System.Drawing.Point(175, 98);
			this.txtDesign.Margin = new System.Windows.Forms.Padding(4);
			this.txtDesign.Name = "txtDesign";
			this.txtDesign.ReadOnly = true;
			this.txtDesign.Size = new System.Drawing.Size(200, 25);
			this.txtDesign.TabIndex = 1;
			this.txtDesign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(22, 284);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(126, 17);
			this.label9.TabIndex = 0;
			this.label9.Text = "Quantité Vendus :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(21, 224);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(123, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Quantité Stocké :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(19, 43);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(85, 17);
			this.label10.TabIndex = 0;
			this.label10.Text = "Reference :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(21, 161);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(101, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Prix Unitaire :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 101);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Designation :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(447, 617);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 17);
			this.label8.TabIndex = 0;
			this.label8.Text = "Total Vendu :";
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(561, 614);
			this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(200, 25);
			this.txtTotal.TabIndex = 1;
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dgv
			// 
			this.dgv.AllowUserToAddRows = false;
			this.dgv.AllowUserToDeleteRows = false;
			this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(18, 427);
			this.dgv.Margin = new System.Windows.Forms.Padding(4);
			this.dgv.MultiSelect = false;
			this.dgv.Name = "dgv";
			this.dgv.ReadOnly = true;
			this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv.Size = new System.Drawing.Size(1004, 169);
			this.dgv.TabIndex = 5;
			this.dgv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_RowsRemoved);
			this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button6);
			this.groupBox3.Controls.Add(this.button5);
			this.groupBox3.Controls.Add(this.button4);
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Location = new System.Drawing.Point(18, 326);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(524, 93);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Opération";
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(399, 36);
			this.button6.Margin = new System.Windows.Forms.Padding(4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(112, 30);
			this.button6.TabIndex = 7;
			this.button6.Text = "Imprimer";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(295, 36);
			this.button5.Margin = new System.Windows.Forms.Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(96, 30);
			this.button5.TabIndex = 8;
			this.button5.Text = "Valider";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(144, 36);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(143, 30);
			this.button4.TabIndex = 9;
			this.button4.Text = "Supprimer Ligne";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(8, 36);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 30);
			this.button2.TabIndex = 10;
			this.button2.Text = "Ajouter Ligne";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtMontantRest
			// 
			this.txtMontantRest.Location = new System.Drawing.Point(822, 614);
			this.txtMontantRest.Margin = new System.Windows.Forms.Padding(4);
			this.txtMontantRest.Name = "txtMontantRest";
			this.txtMontantRest.ReadOnly = true;
			this.txtMontantRest.Size = new System.Drawing.Size(200, 25);
			this.txtMontantRest.TabIndex = 7;
			this.txtMontantRest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// frm_Facturation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1027, 643);
			this.Controls.Add(this.txtMontantRest);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dtp);
			this.Controls.Add(this.txtVendu);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_Facturation";
			this.Text = "frm_Facturation";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVendu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddCli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddAtc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtQS;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtDesign;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtQV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumArt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMontantRest;
        private System.Windows.Forms.TextBox txtNumCl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSolde;
        private System.Windows.Forms.Label label12;
    }
}