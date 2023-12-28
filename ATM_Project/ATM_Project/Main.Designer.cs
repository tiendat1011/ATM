namespace ATM_Project
{
    partial class Main
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
            this.btn_GenKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_PrivateKey = new System.Windows.Forms.TextBox();
            this.tb_PublicKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_DecryptOutput = new System.Windows.Forms.TextBox();
            this.tb_EncryptOutput = new System.Windows.Forms.TextBox();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_PF_Encrypt = new System.Windows.Forms.Button();
            this.btn_PF_Decrypt = new System.Windows.Forms.Button();
            this.tb_PF_Result = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_PF_Key = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_PF_Input = new System.Windows.Forms.TextBox();
            this.panel_Matrix = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GenKey
            // 
            this.btn_GenKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenKey.Location = new System.Drawing.Point(15, 19);
            this.btn_GenKey.Name = "btn_GenKey";
            this.btn_GenKey.Size = new System.Drawing.Size(102, 57);
            this.btn_GenKey.TabIndex = 0;
            this.btn_GenKey.Text = "Generate Pair Key";
            this.btn_GenKey.UseVisualStyleBackColor = true;
            this.btn_GenKey.Click += new System.EventHandler(this.btn_GenKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Public Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Private Key";
            // 
            // tb_PrivateKey
            // 
            this.tb_PrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PrivateKey.Location = new System.Drawing.Point(239, 16);
            this.tb_PrivateKey.Name = "tb_PrivateKey";
            this.tb_PrivateKey.Size = new System.Drawing.Size(467, 23);
            this.tb_PrivateKey.TabIndex = 4;
            // 
            // tb_PublicKey
            // 
            this.tb_PublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PublicKey.Location = new System.Drawing.Point(239, 53);
            this.tb_PublicKey.Name = "tb_PublicKey";
            this.tb_PublicKey.Size = new System.Drawing.Size(467, 23);
            this.tb_PublicKey.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_DecryptOutput);
            this.groupBox1.Controls.Add(this.tb_EncryptOutput);
            this.groupBox1.Controls.Add(this.tb_Input);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_Decrypt);
            this.groupBox1.Controls.Add(this.btn_Encrypt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_GenKey);
            this.groupBox1.Controls.Add(this.tb_PublicKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_PrivateKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 224);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSA";
            // 
            // tb_DecryptOutput
            // 
            this.tb_DecryptOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DecryptOutput.Location = new System.Drawing.Point(239, 171);
            this.tb_DecryptOutput.Name = "tb_DecryptOutput";
            this.tb_DecryptOutput.Size = new System.Drawing.Size(467, 23);
            this.tb_DecryptOutput.TabIndex = 13;
            // 
            // tb_EncryptOutput
            // 
            this.tb_EncryptOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EncryptOutput.Location = new System.Drawing.Point(239, 130);
            this.tb_EncryptOutput.Name = "tb_EncryptOutput";
            this.tb_EncryptOutput.Size = new System.Drawing.Size(467, 23);
            this.tb_EncryptOutput.TabIndex = 12;
            // 
            // tb_Input
            // 
            this.tb_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Input.Location = new System.Drawing.Point(239, 92);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.Size = new System.Drawing.Size(467, 23);
            this.tb_Input.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Input";
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Decrypt.Location = new System.Drawing.Point(15, 167);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(102, 31);
            this.btn_Decrypt.TabIndex = 8;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encrypt.Location = new System.Drawing.Point(15, 126);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(102, 30);
            this.btn_Encrypt.TabIndex = 7;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel_Matrix);
            this.groupBox2.Controls.Add(this.btn_PF_Encrypt);
            this.groupBox2.Controls.Add(this.btn_PF_Decrypt);
            this.groupBox2.Controls.Add(this.tb_PF_Result);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_PF_Key);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_PF_Input);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 224);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PlayFair";
            // 
            // btn_PF_Encrypt
            // 
            this.btn_PF_Encrypt.Location = new System.Drawing.Point(14, 55);
            this.btn_PF_Encrypt.Name = "btn_PF_Encrypt";
            this.btn_PF_Encrypt.Size = new System.Drawing.Size(102, 40);
            this.btn_PF_Encrypt.TabIndex = 7;
            this.btn_PF_Encrypt.Text = "Encrypt";
            this.btn_PF_Encrypt.UseVisualStyleBackColor = true;
            this.btn_PF_Encrypt.Click += new System.EventHandler(this.btn_PF_Encrypt_Click);
            // 
            // btn_PF_Decrypt
            // 
            this.btn_PF_Decrypt.Location = new System.Drawing.Point(14, 130);
            this.btn_PF_Decrypt.Name = "btn_PF_Decrypt";
            this.btn_PF_Decrypt.Size = new System.Drawing.Size(102, 40);
            this.btn_PF_Decrypt.TabIndex = 6;
            this.btn_PF_Decrypt.Text = "Decrypt";
            this.btn_PF_Decrypt.UseVisualStyleBackColor = true;
            this.btn_PF_Decrypt.Click += new System.EventHandler(this.btn_PF_Decrypt_Click);
            // 
            // tb_PF_Result
            // 
            this.tb_PF_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PF_Result.Location = new System.Drawing.Point(240, 147);
            this.tb_PF_Result.Name = "tb_PF_Result";
            this.tb_PF_Result.Size = new System.Drawing.Size(240, 23);
            this.tb_PF_Result.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(154, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Result";
            // 
            // tb_PF_Key
            // 
            this.tb_PF_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PF_Key.Location = new System.Drawing.Point(240, 98);
            this.tb_PF_Key.Name = "tb_PF_Key";
            this.tb_PF_Key.Size = new System.Drawing.Size(240, 23);
            this.tb_PF_Key.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Input";
            // 
            // tb_PF_Input
            // 
            this.tb_PF_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PF_Input.Location = new System.Drawing.Point(240, 52);
            this.tb_PF_Input.Name = "tb_PF_Input";
            this.tb_PF_Input.Size = new System.Drawing.Size(240, 23);
            this.tb_PF_Input.TabIndex = 0;
            // 
            // panel_Matrix
            // 
            this.panel_Matrix.Location = new System.Drawing.Point(508, 36);
            this.panel_Matrix.Name = "panel_Matrix";
            this.panel_Matrix.Size = new System.Drawing.Size(220, 182);
            this.panel_Matrix.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GenKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_PrivateKey;
        private System.Windows.Forms.TextBox tb_PublicKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_DecryptOutput;
        private System.Windows.Forms.TextBox tb_EncryptOutput;
        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_PF_Key;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_PF_Input;
        private System.Windows.Forms.Button btn_PF_Encrypt;
        private System.Windows.Forms.Button btn_PF_Decrypt;
        private System.Windows.Forms.TextBox tb_PF_Result;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_Matrix;
    }
}

