namespace tierion_hash_api_001
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxAccessToken = new System.Windows.Forms.TextBox();
            this.txtBoxHash = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxResponse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmitReceipt = new System.Windows.Forms.Button();
            this.txtBoxReceipt = new System.Windows.Forms.TextBox();
            this.txtBoxResponseReceipt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxAccessToken
            // 
            this.txtBoxAccessToken.Location = new System.Drawing.Point(96, 18);
            this.txtBoxAccessToken.Name = "txtBoxAccessToken";
            this.txtBoxAccessToken.Size = new System.Drawing.Size(583, 19);
            this.txtBoxAccessToken.TabIndex = 0;
            // 
            // txtBoxHash
            // 
            this.txtBoxHash.Location = new System.Drawing.Point(94, 73);
            this.txtBoxHash.Name = "txtBoxHash";
            this.txtBoxHash.Size = new System.Drawing.Size(223, 19);
            this.txtBoxHash.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(242, 107);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Access Token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hash";
            // 
            // txtBoxResponse
            // 
            this.txtBoxResponse.Location = new System.Drawing.Point(24, 153);
            this.txtBoxResponse.Multiline = true;
            this.txtBoxResponse.Name = "txtBoxResponse";
            this.txtBoxResponse.Size = new System.Drawing.Size(293, 111);
            this.txtBoxResponse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "receiptId";
            // 
            // btnSubmitReceipt
            // 
            this.btnSubmitReceipt.Location = new System.Drawing.Point(602, 107);
            this.btnSubmitReceipt.Name = "btnSubmitReceipt";
            this.btnSubmitReceipt.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitReceipt.TabIndex = 7;
            this.btnSubmitReceipt.Text = "Submit";
            this.btnSubmitReceipt.UseVisualStyleBackColor = true;
            this.btnSubmitReceipt.Click += new System.EventHandler(this.btnSubmitReceipt_Click);
            // 
            // txtBoxReceipt
            // 
            this.txtBoxReceipt.Location = new System.Drawing.Point(447, 73);
            this.txtBoxReceipt.Name = "txtBoxReceipt";
            this.txtBoxReceipt.Size = new System.Drawing.Size(230, 19);
            this.txtBoxReceipt.TabIndex = 8;
            // 
            // txtBoxResponseReceipt
            // 
            this.txtBoxResponseReceipt.Location = new System.Drawing.Point(378, 153);
            this.txtBoxResponseReceipt.Multiline = true;
            this.txtBoxResponseReceipt.Name = "txtBoxResponseReceipt";
            this.txtBoxResponseReceipt.Size = new System.Drawing.Size(299, 111);
            this.txtBoxResponseReceipt.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 280);
            this.Controls.Add(this.txtBoxResponseReceipt);
            this.Controls.Add(this.txtBoxReceipt);
            this.Controls.Add(this.btnSubmitReceipt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxResponse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxHash);
            this.Controls.Add(this.txtBoxAccessToken);
            this.Name = "Form1";
            this.Text = "Tierion HASH API Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAccessToken;
        private System.Windows.Forms.TextBox txtBoxHash;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxResponse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmitReceipt;
        private System.Windows.Forms.TextBox txtBoxReceipt;
        private System.Windows.Forms.TextBox txtBoxResponseReceipt;
    }
}

