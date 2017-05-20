namespace MemeFryer
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.btn_load = new System.Windows.Forms.Button();
            this.lbl_memename_label = new System.Windows.Forms.Label();
            this.lbl_memename = new System.Windows.Forms.Label();
            this.btn_fry = new System.Windows.Forms.Button();
            this.btn_savememe = new System.Windows.Forms.Button();
            this.lbl_goodshit = new System.Windows.Forms.Label();
            this.pbx_maymay = new System.Windows.Forms.PictureBox();
            this.ofd_main = new System.Windows.Forms.OpenFileDialog();
            this.sfd_main = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_maymay)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 12);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(205, 56);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load Meme";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lbl_memename_label
            // 
            this.lbl_memename_label.AutoSize = true;
            this.lbl_memename_label.Location = new System.Drawing.Point(13, 75);
            this.lbl_memename_label.Name = "lbl_memename_label";
            this.lbl_memename_label.Size = new System.Drawing.Size(52, 13);
            this.lbl_memename_label.TabIndex = 2;
            this.lbl_memename_label.Text = "File name";
            // 
            // lbl_memename
            // 
            this.lbl_memename.AutoSize = true;
            this.lbl_memename.Location = new System.Drawing.Point(13, 88);
            this.lbl_memename.Name = "lbl_memename";
            this.lbl_memename.Size = new System.Drawing.Size(0, 13);
            this.lbl_memename.TabIndex = 3;
            // 
            // btn_fry
            // 
            this.btn_fry.Location = new System.Drawing.Point(12, 111);
            this.btn_fry.Name = "btn_fry";
            this.btn_fry.Size = new System.Drawing.Size(205, 103);
            this.btn_fry.TabIndex = 4;
            this.btn_fry.Text = "FRY IT MY NI🅱️🅱️A";
            this.btn_fry.UseVisualStyleBackColor = true;
            this.btn_fry.Click += new System.EventHandler(this.btn_fry_Click);
            // 
            // btn_savememe
            // 
            this.btn_savememe.Location = new System.Drawing.Point(12, 220);
            this.btn_savememe.Name = "btn_savememe";
            this.btn_savememe.Size = new System.Drawing.Size(205, 23);
            this.btn_savememe.TabIndex = 5;
            this.btn_savememe.Text = "Save Meme";
            this.btn_savememe.UseVisualStyleBackColor = true;
            // 
            // lbl_goodshit
            // 
            this.lbl_goodshit.AutoSize = true;
            this.lbl_goodshit.Location = new System.Drawing.Point(13, 487);
            this.lbl_goodshit.Name = "lbl_goodshit";
            this.lbl_goodshit.Size = new System.Drawing.Size(195, 195);
            this.lbl_goodshit.TabIndex = 6;
            this.lbl_goodshit.Text = resources.GetString("lbl_goodshit.Text");
            // 
            // pbx_maymay
            // 
            this.pbx_maymay.Image = global::MemeFryer.Properties.Resources.b;
            this.pbx_maymay.Location = new System.Drawing.Point(235, 12);
            this.pbx_maymay.Name = "pbx_maymay";
            this.pbx_maymay.Size = new System.Drawing.Size(758, 670);
            this.pbx_maymay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_maymay.TabIndex = 0;
            this.pbx_maymay.TabStop = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 694);
            this.Controls.Add(this.lbl_goodshit);
            this.Controls.Add(this.btn_savememe);
            this.Controls.Add(this.btn_fry);
            this.Controls.Add(this.lbl_memename);
            this.Controls.Add(this.lbl_memename_label);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.pbx_maymay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Androidas\' Meme Fryer!";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_maymay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_maymay;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label lbl_memename_label;
        private System.Windows.Forms.Label lbl_memename;
        private System.Windows.Forms.Button btn_fry;
        private System.Windows.Forms.Button btn_savememe;
        private System.Windows.Forms.Label lbl_goodshit;
        private System.Windows.Forms.OpenFileDialog ofd_main;
        private System.Windows.Forms.SaveFileDialog sfd_main;
    }
}

