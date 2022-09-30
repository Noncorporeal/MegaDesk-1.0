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
	public partial class AddQuote : Form
	{
		private Form _mainMenu;
		public AddQuote(Form mainMenu)
		{
			InitializeComponent();
			_mainMenu = mainMenu;
		}
		private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
		{
			_mainMenu.Show();
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			_mainMenu.Show();
			this.Close();
		}

		private void GetQuote_Click(object sender, EventArgs e)
		{
			DisplayQuote quote = new DisplayQuote(_mainMenu);
			quote.ShowDialog();
			this.Close();
		}
	}
}
