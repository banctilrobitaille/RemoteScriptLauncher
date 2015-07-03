/*
 * User: banctilr
 * Date: 03/07/2015
 * Time: 8:45 AM
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace VDI_Migration
{
	/// <summary>
	/// Description of frmScriptPath.
	/// </summary>
	public partial class frmScriptPath : Form
	{
		
		public frmScriptPath()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.txtBackupPath.Text = MainForm.BackupPath;
			this.txtScanList.Text = MainForm.ScanListPath;
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnSaveClick(object sender, EventArgs e)
		{
			MainForm.BackupPath = this.txtBackupPath.Text;
			MainForm.ScanListPath = this.txtScanList.Text;
			this.Close();
		}
	}
}
