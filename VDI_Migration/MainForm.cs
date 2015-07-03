/*
 * Created by SharpDevelop.
 * User: banctilr
 * Date: 17/06/2015
 * Time: 2:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace VDI_Migration
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private RemoteComputer computerToBackup;
		public static BindingList<MigrationProcess> process = new BindingList<MigrationProcess>();
		public static String ScanListPath = "\\\\nas\\vdimigration$\\scripts\\scan_disk_Proto.vbs";
		public static String BackupPath = "\\\\nas\\vdimigration$\\scripts\\Backup_Migration_Final_Proto.vbs";
		private ProcessWatcher processWatcher;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.dgProcess.DataSource = MainForm.process;
			
		}
		void BtnMigrateClick(object sender, EventArgs e)
		{
			try{
				this.cbProfile.Items.Clear();
				this.cbProfile.Enabled = false;
				this.computerToBackup = new RemoteComputer(this.txtComputerName.Text);
				this.btnMigrate.Enabled = true;
				
				String[] computerInfos = CommUtility.getComputerInfos(this.computerToBackup.getName());
				
				this.labelOS.Text = computerInfos[0];
				this.status.Text = computerInfos[1];
				this.status.ForeColor = Color.DarkGreen;
				
				foreach(var profile in CommUtility.getProfile(this.computerToBackup.getName())){
				       
					this.cbProfile.Items.Add(Convert.ToString(profile));
				}
				this.cbProfile.Enabled = true;
			}
			catch(InvalidComputerException exception){
				
				MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch(Exception ex){
				
				this.labelOS.Text = "";
				this.status.Text = "Not Responding";
				this.status.ForeColor = Color.DarkRed;
				MessageBox.Show("Unable to retrieve profiles for: " + this.computerToBackup.getName(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void CbProfileSelectedIndexChanged(object sender, EventArgs e)
		{
			this.btnBackup.Enabled = true;
		}
		void QuitterToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void ErrorCenterToolStripMenuItemClick(object sender, EventArgs e)
		{
			Browser browser = new Browser();
			browser.Show();
		}
		void BtnBackupClick(object sender, EventArgs e)
		{
			
			if(this.processWatcher == null){
				
				processWatcher = new ProcessWatcher();
			}
			
			CommUtility.launchBackupScript(this.txtComputerName.Text, Convert.ToString(this.cbProfile.SelectedItem));
			
		}
		void ScriptPathToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmScriptPath pathDialog = new frmScriptPath();
			pathDialog.Show();
		}
		
	}
}
