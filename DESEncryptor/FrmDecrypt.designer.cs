namespace DESEncryptor
{
    partial class FrmDecrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDecrypt));
            this.plain_tb = new System.Windows.Forms.TextBox();
            this.cipher_tb = new System.Windows.Forms.TextBox();
            this.decipher_bt2 = new System.Windows.Forms.Button();
            this.decipher_bt3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.key_tb = new System.Windows.Forms.TextBox();
            this.key_bt = new System.Windows.Forms.Button();
            this.key_bt2 = new System.Windows.Forms.Button();
            this.key_tb2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.decipher_bt = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // plain_tb
            // 
            this.plain_tb.Location = new System.Drawing.Point(9, 19);
            this.plain_tb.Multiline = true;
            this.plain_tb.Name = "plain_tb";
            this.plain_tb.ReadOnly = true;
            this.plain_tb.Size = new System.Drawing.Size(840, 115);
            this.plain_tb.TabIndex = 9;
            // 
            // cipher_tb
            // 
            this.cipher_tb.Location = new System.Drawing.Point(9, 17);
            this.cipher_tb.Multiline = true;
            this.cipher_tb.Name = "cipher_tb";
            this.cipher_tb.Size = new System.Drawing.Size(840, 77);
            this.cipher_tb.TabIndex = 8;
            // 
            // decipher_bt2
            // 
            this.decipher_bt2.Enabled = false;
            this.decipher_bt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decipher_bt2.Location = new System.Drawing.Point(327, 24);
            this.decipher_bt2.Name = "decipher_bt2";
            this.decipher_bt2.Size = new System.Drawing.Size(200, 23);
            this.decipher_bt2.TabIndex = 13;
            this.decipher_bt2.Text = "Double DES";
            this.decipher_bt2.UseVisualStyleBackColor = true;
            this.decipher_bt2.Click += new System.EventHandler(this.decipher_bt2_Click);
            // 
            // decipher_bt3
            // 
            this.decipher_bt3.Enabled = false;
            this.decipher_bt3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decipher_bt3.Location = new System.Drawing.Point(632, 24);
            this.decipher_bt3.Name = "decipher_bt3";
            this.decipher_bt3.Size = new System.Drawing.Size(200, 23);
            this.decipher_bt3.TabIndex = 12;
            this.decipher_bt3.Text = "Triple DES";
            this.decipher_bt3.UseVisualStyleBackColor = true;
            this.decipher_bt3.Click += new System.EventHandler(this.decipher_bt3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(871, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 56);
            this.label1.TabIndex = 14;
            this.label1.Text = "DES Decryptor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DESEncryptor.Properties.Resources.Decrypted;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.key_tb);
            this.groupBox1.Controls.Add(this.key_bt);
            this.groupBox1.Controls.Add(this.key_bt2);
            this.groupBox1.Controls.Add(this.key_tb2);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 68);
            this.groupBox1.TabIndex = 17;
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
            // key_tb
            // 
            this.key_tb.Font = new System.Drawing.Font("Tahoma", 10F);
            this.key_tb.Location = new System.Drawing.Point(56, 28);
            this.key_tb.MaxLength = 8;
            this.key_tb.Name = "key_tb";
            this.key_tb.Size = new System.Drawing.Size(135, 24);
            this.key_tb.TabIndex = 2;
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
            // key_tb2
            // 
            this.key_tb2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.key_tb2.Location = new System.Drawing.Point(534, 28);
            this.key_tb2.MaxLength = 8;
            this.key_tb2.Name = "key_tb2";
            this.key_tb2.Size = new System.Drawing.Size(135, 24);
            this.key_tb2.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cipher_tb);
            this.groupBox2.Location = new System.Drawing.Point(13, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cipher";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.decipher_bt2);
            this.groupBox3.Controls.Add(this.decipher_bt);
            this.groupBox3.Controls.Add(this.decipher_bt3);
            this.groupBox3.Location = new System.Drawing.Point(13, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(855, 60);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DES Decryption Type";
            // 
            // decipher_bt
            // 
            this.decipher_bt.Enabled = false;
            this.decipher_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decipher_bt.Location = new System.Drawing.Point(19, 24);
            this.decipher_bt.Name = "decipher_bt";
            this.decipher_bt.Size = new System.Drawing.Size(200, 23);
            this.decipher_bt.TabIndex = 6;
            this.decipher_bt.Text = "Single DES";
            this.decipher_bt.UseVisualStyleBackColor = true;
            this.decipher_bt.Click += new System.EventHandler(this.decipher_bt_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.plain_tb);
            this.groupBox4.Location = new System.Drawing.Point(13, 376);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(855, 140);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Text";
            // 
            // FrmDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 528);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmDecrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DES Decryptor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plain_tb;
        private System.Windows.Forms.TextBox cipher_tb;
        private System.Windows.Forms.Button decipher_bt2;
        private System.Windows.Forms.Button decipher_bt3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox key_tb;
        private System.Windows.Forms.Button key_bt;
        private System.Windows.Forms.Button key_bt2;
        private System.Windows.Forms.TextBox key_tb2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button decipher_bt;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

