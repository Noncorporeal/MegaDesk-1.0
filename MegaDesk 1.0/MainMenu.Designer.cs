
namespace MegaDesk_1._0
{
	partial class MainMenu
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
			this.newQuote = new System.Windows.Forms.Button();
			this.viewQuote = new System.Windows.Forms.Button();
			this.searchQuote = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// newQuote
			// 
			this.newQuote.Location = new System.Drawing.Point(12, 12);
			this.newQuote.Name = "newQuote";
			this.newQuote.Size = new System.Drawing.Size(162, 49);
			this.newQuote.TabIndex = 0;
			this.newQuote.Text = "Add New Quote";
			this.newQuote.UseVisualStyleBackColor = true;
			this.newQuote.Click += new System.EventHandler(this.OpenNewQuote);
			// 
			// viewQuote
			// 
			this.viewQuote.Location = new System.Drawing.Point(12, 70);
			this.viewQuote.Name = "viewQuote";
			this.viewQuote.Size = new System.Drawing.Size(162, 49);
			this.viewQuote.TabIndex = 1;
			this.viewQuote.Text = "View All Quotes";
			this.viewQuote.UseVisualStyleBackColor = true;
			this.viewQuote.Click += new System.EventHandler(this.OpenViewAllQuotes);
			// 
			// searchQuote
			// 
			this.searchQuote.Location = new System.Drawing.Point(12, 128);
			this.searchQuote.Name = "searchQuote";
			this.searchQuote.Size = new System.Drawing.Size(162, 49);
			this.searchQuote.TabIndex = 2;
			this.searchQuote.Text = "Search Quotes";
			this.searchQuote.UseVisualStyleBackColor = true;
			this.searchQuote.Click += new System.EventHandler(this.OpenSearchQuotes);
			// 
			// exit
			// 
			this.exit.Location = new System.Drawing.Point(12, 186);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(162, 49);
			this.exit.TabIndex = 3;
			this.exit.Text = "Exit";
			this.exit.UseVisualStyleBackColor = true;
			this.exit.Click += new System.EventHandler(this.ExitProgram);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 246);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.searchQuote);
			this.Controls.Add(this.viewQuote);
			this.Controls.Add(this.newQuote);
			this.MaximizeBox = false;
			this.Name = "MainMenu";
			this.Text = "MegaDesk";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button newQuote;
		private System.Windows.Forms.Button viewQuote;
		private System.Windows.Forms.Button searchQuote;
		private System.Windows.Forms.Button exit;
	}
}

