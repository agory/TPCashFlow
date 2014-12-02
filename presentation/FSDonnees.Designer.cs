namespace presentation
{
    partial class FSDonnees
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
            this.lab_title = new System.Windows.Forms.Label();
            this.tb_tx = new System.Windows.Forms.TextBox();
            this.tb_cf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ca = new System.Windows.Forms.TextBox();
            this.tb_cv = new System.Windows.Forms.TextBox();
            this.bt_valider = new System.Windows.Forms.Button();
            this.lab_err2 = new System.Windows.Forms.Label();
            this.lab_err = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_title.Location = new System.Drawing.Point(12, 9);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(309, 26);
            this.lab_title.TabIndex = 0;
            this.lab_title.Text = "Saisie informations année   ";
            // 
            // tb_tx
            // 
            this.tb_tx.Location = new System.Drawing.Point(221, 61);
            this.tb_tx.Name = "tb_tx";
            this.tb_tx.Size = new System.Drawing.Size(176, 20);
            this.tb_tx.TabIndex = 1;
            this.tb_tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_interdictionSaisie);
            this.tb_tx.Validated += new System.EventHandler(this.tb_tx_Validated);
            // 
            // tb_cf
            // 
            this.tb_cf.Location = new System.Drawing.Point(221, 100);
            this.tb_cf.Name = "tb_cf";
            this.tb_cf.Size = new System.Drawing.Size(176, 20);
            this.tb_cf.TabIndex = 1;
            this.tb_cf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_interdictionSaisie);
            this.tb_cf.Validated += new System.EventHandler(this.tb_cf_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chiffre d\'affaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Taux d\'actualisation en %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Charges Fixes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Charges variables";
            // 
            // tb_ca
            // 
            this.tb_ca.Location = new System.Drawing.Point(12, 61);
            this.tb_ca.Name = "tb_ca";
            this.tb_ca.Size = new System.Drawing.Size(176, 20);
            this.tb_ca.TabIndex = 1;
            this.tb_ca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_interdictionSaisie);
            this.tb_ca.Validated += new System.EventHandler(this.tb_ca_Validated);
            // 
            // tb_cv
            // 
            this.tb_cv.Location = new System.Drawing.Point(12, 100);
            this.tb_cv.Name = "tb_cv";
            this.tb_cv.Size = new System.Drawing.Size(176, 20);
            this.tb_cv.TabIndex = 1;
            this.tb_cv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_interdictionSaisie);
            this.tb_cv.Validated += new System.EventHandler(this.tb_cv_Validated);
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(322, 126);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(75, 23);
            this.bt_valider.TabIndex = 3;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // lab_err2
            // 
            this.lab_err2.AutoSize = true;
            this.lab_err2.ForeColor = System.Drawing.Color.Red;
            this.lab_err2.Location = new System.Drawing.Point(9, 136);
            this.lab_err2.Name = "lab_err2";
            this.lab_err2.Size = new System.Drawing.Size(0, 13);
            this.lab_err2.TabIndex = 4;
            // 
            // lab_err
            // 
            this.lab_err.AutoSize = true;
            this.lab_err.ForeColor = System.Drawing.Color.Red;
            this.lab_err.Location = new System.Drawing.Point(9, 136);
            this.lab_err.Name = "lab_err";
            this.lab_err.Size = new System.Drawing.Size(0, 13);
            this.lab_err.TabIndex = 5;
            // 
            // FSDonnees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 158);
            this.Controls.Add(this.lab_err);
            this.Controls.Add(this.lab_err2);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cf);
            this.Controls.Add(this.tb_cv);
            this.Controls.Add(this.tb_ca);
            this.Controls.Add(this.tb_tx);
            this.Controls.Add(this.lab_title);
            this.Name = "FSDonnees";
            this.Text = "FSDonnées";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.TextBox tb_tx;
        private System.Windows.Forms.TextBox tb_cf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ca;
        private System.Windows.Forms.TextBox tb_cv;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Label lab_err2;
        private System.Windows.Forms.Label lab_err;
    }
}