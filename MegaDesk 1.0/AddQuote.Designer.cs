
namespace MegaDesk_1._0
{
	partial class AddQuote
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
			this.Depth = new System.Windows.Forms.NumericUpDown();
			this.Width = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Drawers = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Material = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Rush = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.CustomerName = new System.Windows.Forms.TextBox();
			this.GetQuote = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Depth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Drawers)).BeginInit();
			this.SuspendLayout();
			// 
			// Depth
			// 
			this.Depth.Location = new System.Drawing.Point(232, 56);
			this.Depth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
			this.Depth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.Depth.Name = "Depth";
			this.Depth.Size = new System.Drawing.Size(80, 20);
			this.Depth.TabIndex = 0;
			this.Depth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// Width
			// 
			this.Width.Location = new System.Drawing.Point(72, 56);
			this.Width.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
			this.Width.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.Width.Name = "Width";
			this.Width.Size = new System.Drawing.Size(80, 20);
			this.Width.TabIndex = 1;
			this.Width.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Width";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(176, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Depth";
			// 
			// Drawers
			// 
			this.Drawers.Location = new System.Drawing.Point(160, 96);
			this.Drawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.Drawers.Name = "Drawers";
			this.Drawers.Size = new System.Drawing.Size(80, 20);
			this.Drawers.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(48, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Drawer Count";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(48, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Surface Material";
			// 
			// Material
			// 
			this.Material.FormattingEnabled = true;
			this.Material.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
			this.Material.Location = new System.Drawing.Point(160, 136);
			this.Material.Name = "Material";
			this.Material.Size = new System.Drawing.Size(121, 21);
			this.Material.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(48, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Rush Order";
			// 
			// Rush
			// 
			this.Rush.FormattingEnabled = true;
			this.Rush.Items.AddRange(new object[] {
            "None",
            "3 Days",
            "5 Days",
            "7 Days"});
			this.Rush.Location = new System.Drawing.Point(160, 176);
			this.Rush.Name = "Rush";
			this.Rush.Size = new System.Drawing.Size(121, 21);
			this.Rush.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(16, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Customer Name";
			// 
			// CustomerName
			// 
			this.CustomerName.Location = new System.Drawing.Point(112, 16);
			this.CustomerName.Name = "CustomerName";
			this.CustomerName.Size = new System.Drawing.Size(200, 20);
			this.CustomerName.TabIndex = 11;
			// 
			// GetQuote
			// 
			this.GetQuote.Location = new System.Drawing.Point(184, 224);
			this.GetQuote.Name = "GetQuote";
			this.GetQuote.Size = new System.Drawing.Size(96, 31);
			this.GetQuote.TabIndex = 12;
			this.GetQuote.Text = "Get Quote";
			this.GetQuote.UseVisualStyleBackColor = true;
			this.GetQuote.Click += new System.EventHandler(this.GetQuote_Click);
			// 
			// Cancel
			// 
			this.Cancel.Location = new System.Drawing.Point(56, 224);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(91, 31);
			this.Cancel.TabIndex = 13;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// AddQuote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(337, 277);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.GetQuote);
			this.Controls.Add(this.CustomerName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Rush);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Material);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Drawers);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Width);
			this.Controls.Add(this.Depth);
			this.Name = "AddQuote";
			this.Text = "Add Quote";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.Depth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Drawers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown Depth;
		private System.Windows.Forms.NumericUpDown Width;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown Drawers;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox Material;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox Rush;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox CustomerName;
		private System.Windows.Forms.Button GetQuote;
		private System.Windows.Forms.Button Cancel;
	}
}