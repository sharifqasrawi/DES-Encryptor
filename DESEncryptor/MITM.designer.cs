namespace DESEncryptor
{
    partial class FrmMITM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMITM));
            this.key_tb2 = new System.Windows.Forms.TextBox();
            this.key_bt2 = new System.Windows.Forms.Button();
            this.key_tb = new System.Windows.Forms.TextBox();
            this.key_bt = new System.Windows.Forms.Button();
            this.plain_tp = new System.Windows.Forms.TextBox();
            this.ciphered_tp = new System.Windows.Forms.TextBox();
            this.plain_tb = new System.Windows.Forms.TextBox();
            this.ciphered_tb = new System.Windows.Forms.TextBox();
            this.cipher_bt = new System.Windows.Forms.Button();
            this.decipher_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // key_tb2
            // 
            this.key_tb2.Location = new System.Drawing.Point(559, 315);
            this.key_tb2.MaxLength = 8;
            this.key_tb2.Name = "key_tb2";
            this.key_tb2.Size = new System.Drawing.Size(206, 20);
            this.key_tb2.TabIndex = 12;
            // 
            // key_bt2
            // 
            this.key_bt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_bt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.key_bt2.Location = new System.Drawing.Point(771, 313);
            this.key_bt2.Name = "key_bt2";
            this.key_bt2.Size = new System.Drawing.Size(110, 23);
            this.key_bt2.TabIndex = 11;
            this.key_bt2.Text = "Enter Key 2";
            this.key_bt2.UseVisualStyleBackColor = true;
            this.key_bt2.Click += new System.EventHandler(this.key_bt2_Click);
            // 
            // key_tb
            // 
            this.key_tb.Location = new System.Drawing.Point(63, 315);
            this.key_tb.MaxLength = 8;
            this.key_tb.Name = "key_tb";
            this.key_tb.Size = new System.Drawing.Size(199, 20);
            this.key_tb.TabIndex = 10;
            // 
            // key_bt
            // 
            this.key_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.key_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.key_bt.Location = new System.Drawing.Point(268, 313);
            this.key_bt.Name = "key_bt";
            this.key_bt.Size = new System.Drawing.Size(123, 23);
            this.key_bt.TabIndex = 9;
            this.key_bt.Text = "Enter Key 1";
            this.key_bt.UseVisualStyleBackColor = true;
            this.key_bt.Click += new System.EventHandler(this.key_bt_Click);
            // 
            // plain_tp
            // 
            this.plain_tp.Location = new System.Drawing.Point(6, 19);
            this.plain_tp.Multiline = true;
            this.plain_tp.Name = "plain_tp";
            this.plain_tp.Size = new System.Drawing.Size(855, 70);
            this.plain_tp.TabIndex = 13;
            // 
            // ciphered_tp
            // 
            this.ciphered_tp.Location = new System.Drawing.Point(6, 19);
            this.ciphered_tp.Multiline = true;
            this.ciphered_tp.Name = "ciphered_tp";
            this.ciphered_tp.Size = new System.Drawing.Size(855, 54);
            this.ciphered_tp.TabIndex = 14;
            // 
            // plain_tb
            // 
            this.plain_tb.Location = new System.Drawing.Point(522, 371);
            this.plain_tb.Multiline = true;
            this.plain_tb.Name = "plain_tb";
            this.plain_tb.ReadOnly = true;
            this.plain_tb.Size = new System.Drawing.Size(365, 149);
            this.plain_tb.TabIndex = 17;
            // 
            // ciphered_tb
            // 
            this.ciphered_tb.Location = new System.Drawing.Point(26, 371);
            this.ciphered_tb.Multiline = true;
            this.ciphered_tb.Name = "ciphered_tb";
            this.ciphered_tb.ReadOnly = true;
            this.ciphered_tb.Size = new System.Drawing.Size(365, 149);
            this.ciphered_tb.TabIndex = 18;
            // 
            // cipher_bt
            // 
            this.cipher_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cipher_bt.Enabled = false;
            this.cipher_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cipher_bt.Location = new System.Drawing.Point(26, 342);
            this.cipher_bt.Name = "cipher_bt";
            this.cipher_bt.Size = new System.Drawing.Size(365, 23);
            this.cipher_bt.TabIndex = 19;
            this.cipher_bt.Text = "Encrypt Original Text Using Key 1";
            this.cipher_bt.UseVisualStyleBackColor = true;
            this.cipher_bt.Click += new System.EventHandler(this.cipher_bt_Click);
            // 
            // decipher_bt
            // 
            this.decipher_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decipher_bt.Enabled = false;
            this.decipher_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decipher_bt.Location = new System.Drawing.Point(522, 342);
            this.decipher_bt.Name = "decipher_bt";
            this.decipher_bt.Size = new System.Drawing.Size(359, 23);
            this.decipher_bt.TabIndex = 20;
            this.decipher_bt.Text = "Decrypt Ecrypted Text Using Key 2";
            this.decipher_bt.UseVisualStyleBackColor = true;
            this.decipher_bt.Click += new System.EventHandler(this.decipher_bt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(871, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(471, 56);
            this.label4.TabIndex = 21;
            this.label4.Text = "Meet-In-Middle Attack";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.plain_tp);
            this.groupBox1.Location = new System.Drawing.Point(20, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 95);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original Text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ciphered_tp);
            this.groupBox2.Location = new System.Drawing.Point(20, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(867, 79);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encrypted Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Key 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Key 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DESEncryptor.Properties.Resources.at;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMITM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decipher_bt);
            this.Controls.Add(this.cipher_bt);
            this.Controls.Add(this.ciphered_tb);
            this.Controls.Add(this.plain_tb);
            this.Controls.Add(this.key_tb2);
            this.Controls.Add(this.key_bt2);
            this.Controls.Add(this.key_tb);
            this.Controls.Add(this.key_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmMITM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meet In Middle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox key_tb2;
        private System.Windows.Forms.Button key_bt2;
        private System.Windows.Forms.TextBox key_tb;
        private System.Windows.Forms.Button key_bt;
        private System.Windows.Forms.TextBox plain_tp;
        private System.Windows.Forms.TextBox ciphered_tp;
        private System.Windows.Forms.TextBox plain_tb;
        private System.Windows.Forms.TextBox ciphered_tb;
        private System.Windows.Forms.Button cipher_bt;
        private System.Windows.Forms.Button decipher_bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

