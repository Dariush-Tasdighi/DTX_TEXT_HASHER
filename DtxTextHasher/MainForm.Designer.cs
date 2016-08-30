namespace MyApplication
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtText = new System.Windows.Forms.TextBox();
			this.lblText = new System.Windows.Forms.Label();
			this.lblMD5 = new System.Windows.Forms.Label();
			this.txtMD5 = new System.Windows.Forms.TextBox();
			this.lblSha1 = new System.Windows.Forms.Label();
			this.txtSha1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtText
			// 
			this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txtText.Location = new System.Drawing.Point(67, 15);
			this.txtText.Margin = new System.Windows.Forms.Padding(4);
			this.txtText.Name = "txtText";
			this.txtText.Size = new System.Drawing.Size(504, 22);
			this.txtText.TabIndex = 1;
			this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
			this.txtText.Enter += new System.EventHandler(this.txtText_Enter);
			// 
			// lblText
			// 
			this.lblText.AutoSize = true;
			this.lblText.Location = new System.Drawing.Point(12, 18);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(40, 16);
			this.lblText.TabIndex = 0;
			this.lblText.Text = "&Text";
			// 
			// lblMD5
			// 
			this.lblMD5.AutoSize = true;
			this.lblMD5.Location = new System.Drawing.Point(12, 48);
			this.lblMD5.Name = "lblMD5";
			this.lblMD5.Size = new System.Drawing.Size(32, 16);
			this.lblMD5.TabIndex = 2;
			this.lblMD5.Text = "&MD5";
			// 
			// txtMD5
			// 
			this.txtMD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txtMD5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMD5.Location = new System.Drawing.Point(67, 45);
			this.txtMD5.Margin = new System.Windows.Forms.Padding(4);
			this.txtMD5.Name = "txtMD5";
			this.txtMD5.ReadOnly = true;
			this.txtMD5.Size = new System.Drawing.Size(504, 22);
			this.txtMD5.TabIndex = 3;
			// 
			// lblSha1
			// 
			this.lblSha1.AutoSize = true;
			this.lblSha1.Location = new System.Drawing.Point(12, 78);
			this.lblSha1.Name = "lblSha1";
			this.lblSha1.Size = new System.Drawing.Size(48, 16);
			this.lblSha1.TabIndex = 4;
			this.lblSha1.Text = "&SHA-1";
			// 
			// txtSha1
			// 
			this.txtSha1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSha1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSha1.Location = new System.Drawing.Point(67, 75);
			this.txtSha1.Margin = new System.Windows.Forms.Padding(4);
			this.txtSha1.Name = "txtSha1";
			this.txtSha1.ReadOnly = true;
			this.txtSha1.Size = new System.Drawing.Size(504, 22);
			this.txtSha1.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 112);
			this.Controls.Add(this.lblSha1);
			this.Controls.Add(this.txtSha1);
			this.Controls.Add(this.lblMD5);
			this.Controls.Add(this.txtMD5);
			this.Controls.Add(this.lblText);
			this.Controls.Add(this.txtText);
			this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(600, 150);
			this.MinimumSize = new System.Drawing.Size(600, 150);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DT Hasher - Mr. Dariush Tasdighi - 09121087461 - Version 1.0.0";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtText;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.Label lblMD5;
		private System.Windows.Forms.TextBox txtMD5;
		private System.Windows.Forms.Label lblSha1;
		private System.Windows.Forms.TextBox txtSha1;
	}
}
