namespace InflateDeflateBase64
{
	partial class Form1
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
			this.btnInflate = new System.Windows.Forms.Button();
			this.btnDeflate = new System.Windows.Forms.Button();
			this.txtXml = new System.Windows.Forms.TextBox();
			this.txtEncoded = new System.Windows.Forms.TextBox();
			this.btnClearXml = new System.Windows.Forms.Button();
			this.btnClearEncoded = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnInflate
			// 
			this.btnInflate.Location = new System.Drawing.Point(793, 331);
			this.btnInflate.Name = "btnInflate";
			this.btnInflate.Size = new System.Drawing.Size(145, 34);
			this.btnInflate.TabIndex = 0;
			this.btnInflate.Text = "Inflate";
			this.btnInflate.UseVisualStyleBackColor = true;
			this.btnInflate.Click += new System.EventHandler(this.btnInflate_Click);
			// 
			// btnDeflate
			// 
			this.btnDeflate.Location = new System.Drawing.Point(176, 331);
			this.btnDeflate.Name = "btnDeflate";
			this.btnDeflate.Size = new System.Drawing.Size(145, 34);
			this.btnDeflate.TabIndex = 1;
			this.btnDeflate.Text = "Deflate";
			this.btnDeflate.UseVisualStyleBackColor = true;
			this.btnDeflate.Click += new System.EventHandler(this.btnDeflate_Click);
			// 
			// txtXml
			// 
			this.txtXml.Location = new System.Drawing.Point(43, 53);
			this.txtXml.Multiline = true;
			this.txtXml.Name = "txtXml";
			this.txtXml.Size = new System.Drawing.Size(527, 242);
			this.txtXml.TabIndex = 2;
			// 
			// txtEncoded
			// 
			this.txtEncoded.Location = new System.Drawing.Point(639, 53);
			this.txtEncoded.Multiline = true;
			this.txtEncoded.Name = "txtEncoded";
			this.txtEncoded.Size = new System.Drawing.Size(527, 242);
			this.txtEncoded.TabIndex = 3;
			// 
			// btnClearXml
			// 
			this.btnClearXml.Location = new System.Drawing.Point(358, 331);
			this.btnClearXml.Name = "btnClearXml";
			this.btnClearXml.Size = new System.Drawing.Size(145, 34);
			this.btnClearXml.TabIndex = 4;
			this.btnClearXml.Text = "Clear";
			this.btnClearXml.UseVisualStyleBackColor = true;
			this.btnClearXml.Click += new System.EventHandler(this.btnClearXml_Click);
			// 
			// btnClearEncoded
			// 
			this.btnClearEncoded.Location = new System.Drawing.Point(958, 331);
			this.btnClearEncoded.Name = "btnClearEncoded";
			this.btnClearEncoded.Size = new System.Drawing.Size(145, 34);
			this.btnClearEncoded.TabIndex = 5;
			this.btnClearEncoded.Text = "Clear";
			this.btnClearEncoded.UseVisualStyleBackColor = true;
			this.btnClearEncoded.Click += new System.EventHandler(this.btnClearEncoded_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1244, 515);
			this.Controls.Add(this.btnClearEncoded);
			this.Controls.Add(this.btnClearXml);
			this.Controls.Add(this.txtEncoded);
			this.Controls.Add(this.txtXml);
			this.Controls.Add(this.btnDeflate);
			this.Controls.Add(this.btnInflate);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnInflate;
		private System.Windows.Forms.Button btnDeflate;
		private System.Windows.Forms.TextBox txtXml;
		private System.Windows.Forms.TextBox txtEncoded;
		private System.Windows.Forms.Button btnClearXml;
		private System.Windows.Forms.Button btnClearEncoded;
	}
}

