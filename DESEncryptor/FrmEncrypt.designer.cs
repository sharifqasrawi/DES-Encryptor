namespace DESEncryptor
{
    partial class FrmEncrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEncrypt));
            this.key_bt = new System.Windows.Forms.Button();
            this.cipher_bt = new System.Windows.Forms.Button();
            this.key_tb = new System.Windows.Forms.TextBox();
            this.plain_tb = new System.Windows.Forms.TextBox();
            this.ciphered_tb = new System.Windows.Forms.TextBox();
            this.cipher_bt3 = new System.Windows.Forms.Button();
            this.cipher_bt2 = new System.Windows.Forms.Button();
            this.key_tb2 = new System.Windows.Forms.TextBox();
            this.key_bt2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMitm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // key_bt
            // 
            this.key_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.key_bt.Font = new System.Drawing.Font("Tahoma", 10F);
            this.key_bt.Location = new System.Drawing.Point(197, 28);
            this.key_bt.Name = "key_bt";
            this.key_bt.Size = new System.Drawing.Size(110, 24);
            this.key_bt.TabIndex = 0;
            this.key_bt.Text = "Enter Key 1";
            this.key_bt.UseVisualStyleBackColor = true;
            this.key_bt.Click += new System.EventHandler(this.key_bt_Click);
            // 
            // cipher_bt
            // 
            this.cipher_bt.Enabled = false;
            this.cipher_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cipher_bt.Location = new System.Drawing.Point(17, 22);
            this.cipher_bt.Name = "cipher_bt";
            this.cipher_bt.Size = new System.Drawing.Size(200, 23);
            this.cipher_bt.TabIndex = 1;
            this.cipher_bt.Text = "Single DES";
            this.cipher_bt.UseVisualStyleBackColor = true;
            this.cipher_bt.Click += new System.EventHandler(this.cipher_bt_Click);
            // 
            // key_tb
            // 
            this.key_tb.Font = new System.Drawing.Font("Tahoma", 10F);
            this.key_tb.Location = new System.Drawing.Point(56, 28);
            this.key_tb.MaxLength = 8;
            this.key_tb.Name = "key_tb";
            this.key_tb.Size = new System.Drawing.Size(135, 24);
            this.key_tb.TabIndex = 2;
            // 
            // plain_tb
            // 
            this.plain_tb.Location = new System.Drawing.Point(10, 17);
            this.plain_tb.Multiline = true;
            this.plain_tb.Name = "plain_tb";
            this.plain_tb.Size = new System.Drawing.Size(839, 77);
            this.plain_tb.TabIndex = 3;
            // 
            // ciphered_tb
            // 
            this.ciphered_tb.Location = new System.Drawing.Point(10, 19);
            this.ciphered_tb.Multiline = true;
            this.ciphered_tb.Name = "ciphered_tb";
            this.ciphered_tb.ReadOnly = true;
            this.ciphered_tb.Size = new System.Drawing.Size(839, 115);
            this.ciphered_tb.TabIndex = 4;
            // 
            // cipher_bt3
            // 
            this.cipher_bt3.Enabled = false;
            this.cipher_bt3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cipher_bt3.Location = new System.Drawing.Point(625, 22);
            this.cipher_bt3.Name = "cipher_bt3";
            this.cipher_bt3.Size = new System.Drawing.Size(200, 23);
            this.cipher_bt3.TabIndex = 5;
            this.cipher_bt3.Text = "Triple DES";
            this.cipher_bt3.UseVisualStyleBackColor = true;
            this.cipher_bt3.Click += new System.EventHandler(this.cipher_bt3_Click);
            // 
            // cipher_bt2
            // 
            this.cipher_bt2.Enabled = false;
            this.cipher_bt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cipher_bt2.Location = new System.Drawing.Point(311, 22);
            this.cipher_bt2.Name = "cipher_bt2";
            this.cipher_bt2.Size = new System.Drawing.Size(200, 23);
            this.cipher_bt2.TabIndex = 6;
            this.cipher_bt2.Text = "Double DES";
            this.cipher_bt2.UseVisualStyleBackColor = true;
            this.cipher_bt2.Click += new System.EventHandler(this.cipher_bt2_Click);
            // 
            // key_tb2
            // 
            this.key_tb2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.key_tb2.Location = new System.Drawing.Point(534, 28);
            this.key_tb2.MaxLength = 8;
            this.key_tb2.Name = "key_tb2";
            this.key_tb2.Size = new System.Drawing.Size(135, 24);
            this.key_tb2.TabIndex = 8;
            // 
            // key_bt2
            // 
            this.key_bt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_bt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.key_bt2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.key_bt2.Location = new System.Drawing.Point(675, 28);
            this.key_bt2.Name = "key_bt2";
            this.key_bt2.Size = new System.Drawing.Size(110, 24);
            this.key_bt2.TabIndex = 7;
            this.key_bt2.Text = "Enter Key 2";
            this.key_bt2.UseVisualStyleBackColor = true;
            this.key_bt2.Click += new System.EventHandler(this.key_bt2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 56);
            this.label1.TabIndex = 9;
            this.label1.Text = "DES Encryptor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(871, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.key_tb);
            this.groupBox1.Controls.Add(this.key_bt);
            this.groupBox1.Controls.Add(this.key_bt2);
            this.groupBox1.Controls.Add(this.key_tb2);
            this.groupBox1.Location = new System.Drawing.Point(24, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 68);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keys";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(485, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Key 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(7, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Key 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.plain_tb);
            this.groupBox2.Location = new System.Drawing.Point(24, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cipher_bt);
            this.groupBox3.Controls.Add(this.cipher_bt2);
            this.groupBox3.Controls.Add(this.cipher_bt3);
            this.groupBox3.Location = new System.Drawing.Point(24, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(855, 60);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DES Encryption Type";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ciphered_tb);
            this.groupBox4.Location = new System.Drawing.Point(24, 372);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(855, 140);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cipher";
            // 
            // btnDec
            // 
            this.btnDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDec.Location = new System.Drawing.Point(693, 28);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(87, 66);
            this.btnDec.TabIndex = 16;
            this.btnDec.Text = "Open Decryptor";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DESEncryptor.Properties.Resources.enc;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnMitm
            // 
            this.btnMitm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMitm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMitm.Location = new System.Drawing.Point(792, 28);
            this.btnMitm.Name = "btnMitm";
            this.btnMitm.Size = new System.Drawing.Size(87, 66);
            this.btnMitm.TabIndex = 16;
            this.btnMitm.Text = "Meet In Middle Attack";
            this.btnMitm.UseVisualStyleBackColor = true;
            this.btnMitm.Click += new System.EventHandler(this.btnMitm_Click);
            // 
            // FrmEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 524);
            this.Controls.Add(this.btnMitm);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmEncrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DES Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button key_bt;
        private System.Windows.Forms.Button cipher_bt;
        private System.Windows.Forms.TextBox key_tb;
        private System.Windows.Forms.TextBox plain_tb;
        private System.Windows.Forms.TextBox ciphered_tb;
        private System.Windows.Forms.Button cipher_bt3;
        private System.Windows.Forms.Button cipher_bt2;
        private System.Windows.Forms.TextBox key_tb2;
        private System.Windows.Forms.Button key_bt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnMitm;
    }
}

