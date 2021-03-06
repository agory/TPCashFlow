﻿namespace presentation
{
    partial class FSaisie
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
            this.tb_valeurResiduelle = new System.Windows.Forms.TextBox();
            this.tb_investissementP = new System.Windows.Forms.TextBox();
            this.tb_investissementM = new System.Windows.Forms.TextBox();
            this.tb_annees = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_tx = new System.Windows.Forms.TextBox();
            this.tb_cf = new System.Windows.Forms.TextBox();
            this.tb_cv = new System.Windows.Forms.TextBox();
            this.tb_ca = new System.Windows.Forms.TextBox();
            this.chkB_tx = new System.Windows.Forms.CheckBox();
            this.chkB_cf = new System.Windows.Forms.CheckBox();
            this.chkB_cv = new System.Windows.Forms.CheckBox();
            this.chkB_ca = new System.Windows.Forms.CheckBox();
            this.bt_valider = new System.Windows.Forms.Button();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.lab_err = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informations projet";
            // 
            // tb_valeurResiduelle
            // 
            this.tb_valeurResiduelle.Location = new System.Drawing.Point(283, 138);
            this.tb_valeurResiduelle.Name = "tb_valeurResiduelle";
            this.tb_valeurResiduelle.Size = new System.Drawing.Size(100, 20);
            this.tb_valeurResiduelle.TabIndex = 0;
            this.tb_valeurResiduelle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generalKeyPress);
            this.tb_valeurResiduelle.Validated += new System.EventHandler(this.tb_valeurResiduelle_Validated);
            // 
            // tb_investissementP
            // 
            this.tb_investissementP.Location = new System.Drawing.Point(283, 19);
            this.tb_investissementP.Name = "tb_investissementP";
            this.tb_investissementP.Size = new System.Drawing.Size(100, 20);
            this.tb_investissementP.TabIndex = 1;
            this.tb_investissementP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generalKeyPress);
            this.tb_investissementP.Validated += new System.EventHandler(this.tb_investissementP_Validated);
            // 
            // tb_investissementM
            // 
            this.tb_investissementM.Location = new System.Drawing.Point(283, 57);
            this.tb_investissementM.Name = "tb_investissementM";
            this.tb_investissementM.Size = new System.Drawing.Size(100, 20);
            this.tb_investissementM.TabIndex = 2;
            this.tb_investissementM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generalKeyPress);
            this.tb_investissementM.Validated += new System.EventHandler(this.tb_investissementM_Validated);
            // 
            // tb_annees
            // 
            this.tb_annees.Location = new System.Drawing.Point(283, 99);
            this.tb_annees.Name = "tb_annees";
            this.tb_annees.Size = new System.Drawing.Size(100, 20);
            this.tb_annees.TabIndex = 3;
            this.tb_annees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generalKeyPress);
            this.tb_annees.Validated += new System.EventHandler(this.tb_annees_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_investissementP);
            this.groupBox1.Controls.Add(this.tb_investissementM);
            this.groupBox1.Controls.Add(this.tb_valeurResiduelle);
            this.groupBox1.Controls.Add(this.tb_annees);
            this.groupBox1.Location = new System.Drawing.Point(16, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 175);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations du projet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valeur residuelle : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombres d\'années : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Montant investissement matériel : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Montant investissement projet : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_tx);
            this.groupBox2.Controls.Add(this.tb_cf);
            this.groupBox2.Controls.Add(this.tb_cv);
            this.groupBox2.Controls.Add(this.tb_ca);
            this.groupBox2.Controls.Add(this.chkB_tx);
            this.groupBox2.Controls.Add(this.chkB_cf);
            this.groupBox2.Controls.Add(this.chkB_cv);
            this.groupBox2.Controls.Add(this.chkB_ca);
            this.groupBox2.Location = new System.Drawing.Point(16, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 161);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option valeurs annuelles fixes";
            // 
            // tb_tx
            // 
            this.tb_tx.Location = new System.Drawing.Point(283, 121);
            this.tb_tx.Name = "tb_tx";
            this.tb_tx.Size = new System.Drawing.Size(100, 20);
            this.tb_tx.TabIndex = 7;
            this.tb_tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generalKeyPress);
            this.tb_tx.Validated += new System.EventHandler(this.tb_tx_Validated);
            // 
            // tb_cf
            // 
            this.tb_cf.Location = new System.Drawing.Point(283, 89);
            this.tb_cf.Name = "tb_cf";
            this.tb_cf.Size = new System.Drawing.Size(100, 20);
            this.tb_cf.TabIndex = 6;
            this.tb_cf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generalKeyPress);
            this.tb_cf.Validated += new System.EventHandler(this.tb_cf_Validated);
            // 
            // tb_cv
            // 
            this.tb_cv.Location = new System.Drawing.Point(283, 54);
            this.tb_cv.Name = "tb_cv";
            this.tb_cv.Size = new System.Drawing.Size(100, 20);
            this.tb_cv.TabIndex = 5;
            this.tb_cv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generalKeyPress);
            this.tb_cv.Validated += new System.EventHandler(this.tb_cv_Validated);
            // 
            // tb_ca
            // 
            this.tb_ca.Location = new System.Drawing.Point(283, 19);
            this.tb_ca.Name = "tb_ca";
            this.tb_ca.Size = new System.Drawing.Size(100, 20);
            this.tb_ca.TabIndex = 4;
            this.tb_ca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generalKeyPress);
            this.tb_ca.Validated += new System.EventHandler(this.tb_ca_Validated);
            // 
            // chkB_tx
            // 
            this.chkB_tx.AutoSize = true;
            this.chkB_tx.Location = new System.Drawing.Point(6, 121);
            this.chkB_tx.Name = "chkB_tx";
            this.chkB_tx.Size = new System.Drawing.Size(120, 17);
            this.chkB_tx.TabIndex = 3;
            this.chkB_tx.Text = "Taux d\'actualisation";
            this.chkB_tx.UseVisualStyleBackColor = true;
            this.chkB_tx.CheckedChanged += new System.EventHandler(this.check_tx);
            this.chkB_tx.Validated += new System.EventHandler(this.checkAll);
            // 
            // chkB_cf
            // 
            this.chkB_cf.AutoSize = true;
            this.chkB_cf.Location = new System.Drawing.Point(6, 89);
            this.chkB_cf.Name = "chkB_cf";
            this.chkB_cf.Size = new System.Drawing.Size(89, 17);
            this.chkB_cf.TabIndex = 2;
            this.chkB_cf.Text = "Charges fixes";
            this.chkB_cf.UseVisualStyleBackColor = true;
            this.chkB_cf.CheckedChanged += new System.EventHandler(this.check_cf);
            this.chkB_cf.Validated += new System.EventHandler(this.checkAll);
            // 
            // chkB_cv
            // 
            this.chkB_cv.AutoSize = true;
            this.chkB_cv.Location = new System.Drawing.Point(6, 54);
            this.chkB_cv.Name = "chkB_cv";
            this.chkB_cv.Size = new System.Drawing.Size(110, 17);
            this.chkB_cv.TabIndex = 1;
            this.chkB_cv.Text = "Charges variables";
            this.chkB_cv.UseVisualStyleBackColor = true;
            this.chkB_cv.CheckedChanged += new System.EventHandler(this.check_cv);
            this.chkB_cv.Validated += new System.EventHandler(this.checkAll);
            // 
            // chkB_ca
            // 
            this.chkB_ca.AutoSize = true;
            this.chkB_ca.BackColor = System.Drawing.SystemColors.Control;
            this.chkB_ca.Location = new System.Drawing.Point(6, 19);
            this.chkB_ca.Name = "chkB_ca";
            this.chkB_ca.Size = new System.Drawing.Size(106, 17);
            this.chkB_ca.TabIndex = 0;
            this.chkB_ca.Text = "Chiffres d\'affaires";
            this.chkB_ca.UseVisualStyleBackColor = false;
            this.chkB_ca.CheckedChanged += new System.EventHandler(this.check_ca);
            this.chkB_ca.Validated += new System.EventHandler(this.checkAll);
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(299, 408);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(100, 23);
            this.bt_valider.TabIndex = 6;
            this.bt_valider.Text = "Suivant";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(71, 408);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(100, 23);
            this.bt_annuler.TabIndex = 7;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // lab_err
            // 
            this.lab_err.AutoSize = true;
            this.lab_err.ForeColor = System.Drawing.Color.Red;
            this.lab_err.Location = new System.Drawing.Point(12, 445);
            this.lab_err.Name = "lab_err";
            this.lab_err.Size = new System.Drawing.Size(0, 13);
            this.lab_err.TabIndex = 8;
            // 
            // FSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 467);
            this.Controls.Add(this.lab_err);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FSaisie";
            this.Text = "FSaisie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_valeurResiduelle;
        private System.Windows.Forms.TextBox tb_investissementP;
        private System.Windows.Forms.TextBox tb_investissementM;
        private System.Windows.Forms.TextBox tb_annees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkB_tx;
        private System.Windows.Forms.CheckBox chkB_cf;
        private System.Windows.Forms.CheckBox chkB_cv;
        private System.Windows.Forms.CheckBox chkB_ca;
        private System.Windows.Forms.TextBox tb_cf;
        private System.Windows.Forms.TextBox tb_cv;
        private System.Windows.Forms.TextBox tb_ca;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.TextBox tb_tx;
        private System.Windows.Forms.Label lab_err;
    }
}