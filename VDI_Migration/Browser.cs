/*
 * User: banctilr
 * Date: 23/06/2015
 * Time: 2:43 PM
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VDI_Migration
{
	/// <summary>
	/// Description of Browser.
	/// </summary>
	public partial class Browser : Form
	{
		public Browser()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
