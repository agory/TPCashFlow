﻿namespace presentation
{
    partial class FAffichage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dgv_tab_1 = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgv_tab_2 = new System.Windows.Forms.TabPage();
            this.dgv_actualise = new System.Windows.Forms.DataGridView();
            this.dgv_tab_3 = new System.Windows.Forms.TabPage();
            this.lbl_van = new System.Windows.Forms.Label();
            this.lbl_conclusion = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.dgv_tab_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.dgv_tab_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_actualise)).BeginInit();
            this.dgv_tab_3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dgv_tab_1);
            this.tabControl1.Controls.Add(this.dgv_tab_2);
            this.tabControl1.Controls.Add(this.dgv_tab_3);
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 327);
            this.tabControl1.TabIndex = 0;
            // 
            // dgv_tab_1
            // 
            this.dgv_tab_1.Controls.Add(this.dgv);
            this.dgv_tab_1.Location = new System.Drawing.Point(4, 22);
            this.dgv_tab_1.Name = "dgv_tab_1";
            this.dgv_tab_1.Padding = new System.Windows.Forms.Padding(3);
            this.dgv_tab_1.Size = new System.Drawing.Size(794, 301);
            this.dgv_tab_1.TabIndex = 0;
            this.dgv_tab_1.Text = "Cash-Flow";
            this.dgv_tab_1.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(7, 7);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(781, 288);
            this.dgv.TabIndex = 0;
            // 
            // dgv_tab_2
            // 
            this.dgv_tab_2.Controls.Add(this.dgv_actualise);
            this.dgv_tab_2.Location = new System.Drawing.Point(4, 22);
            this.dgv_tab_2.Name = "dgv_tab_2";
            this.dgv_tab_2.Padding = new System.Windows.Forms.Padding(3);
            this.dgv_tab_2.Size = new System.Drawing.Size(794, 301);
            this.dgv_tab_2.TabIndex = 1;
            this.dgv_tab_2.Text = "Cash-Flow actualisé";
            this.dgv_tab_2.UseVisualStyleBackColor = true;
            // 
            // dgv_actualise
            // 
            this.dgv_actualise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_actualise.Location = new System.Drawing.Point(7, 7);
            this.dgv_actualise.Name = "dgv_actualise";
            this.dgv_actualise.Size = new System.Drawing.Size(784, 288);
            this.dgv_actualise.TabIndex = 0;
            // 
            // dgv_tab_3
            // 
            this.dgv_tab_3.Controls.Add(this.lbl_conclusion);
            this.dgv_tab_3.Controls.Add(this.lbl_van);
            this.dgv_tab_3.Location = new System.Drawing.Point(4, 22);
            this.dgv_tab_3.Name = "dgv_tab_3";
            this.dgv_tab_3.Size = new System.Drawing.Size(794, 301);
            this.dgv_tab_3.TabIndex = 2;
            this.dgv_tab_3.Text = "Conclusion";
            this.dgv_tab_3.UseVisualStyleBackColor = true;
            // 
            // lbl_van
            // 
            this.lbl_van.AutoSize = true;
            this.lbl_van.Location = new System.Drawing.Point(4, 46);
            this.lbl_van.Name = "lbl_van";
            this.lbl_van.Size = new System.Drawing.Size(71, 13);
            this.lbl_van.TabIndex = 0;
            this.lbl_van.Text = "Valeur VAN : ";
            // 
            // lbl_conclusion
            // 
            this.lbl_conclusion.AutoSize = true;
            this.lbl_conclusion.Location = new System.Drawing.Point(7, 120);
            this.lbl_conclusion.Name = "lbl_conclusion";
            this.lbl_conclusion.Size = new System.Drawing.Size(68, 13);
            this.lbl_conclusion.TabIndex = 1;
            this.lbl_conclusion.Text = "Conclusion : ";
            // 
            // FAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 411);
            this.Controls.Add(this.tabControl1);
            this.Name = "FAffichage";
            this.Text = "FAffichage";
            this.tabControl1.ResumeLayout(false);
            this.dgv_tab_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.dgv_tab_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_actualise)).EndInit();
            this.dgv_tab_3.ResumeLayout(false);
            this.dgv_tab_3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage dgv_tab_1;
        private System.Windows.Forms.TabPage dgv_tab_2;
        private System.Windows.Forms.TabPage dgv_tab_3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridView dgv_actualise;
        private System.Windows.Forms.Label lbl_conclusion;
        private System.Windows.Forms.Label lbl_van;

    }
}