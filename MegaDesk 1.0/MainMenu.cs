using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_1._0
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void OpenNewQuote(object sender, EventArgs e)
		{
			this.Hide();
			AddQuote addQuote = new AddQuote(this);
			addQuote.ShowDialog();
		}

		private void OpenViewAllQuotes(object sender, EventArgs e)
		{
			this.Hide();
			ViewAllQuotes viewAll = new ViewAllQuotes(this);
			viewAll.ShowDialog();
		}
		private void OpenSearchQuotes(object sender, EventArgs e)
		{
			this.Hide();
			SearchQuotes searchQuotes = new SearchQuotes(this);
			searchQuotes.ShowDialog();
		}

		private void ExitProgram(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
