/*
 * Created by SharpDevelop.
 * User: banctilr
 * Date: 17/06/2015
 * Time: 2:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace VDI_Migration
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox cbProfile;
		private System.Windows.Forms.Label lblComputer;
		private System.Windows.Forms.TextBox txtComputerName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnMigrate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnBackup;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem migrationStatsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem errorCenterToolStripMenuItem;
		private System.Windows.Forms.Label lblOS;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.Label labelOS;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel status;
		private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scriptPathToolStripMenuItem;
		private System.Windows.Forms.GroupBox gbMigrationInfo;
		private System.Windows.Forms.DataGrid dgProcess;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>{
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.cbProfile = new System.Windows.Forms.ComboBox();
			this.lblComputer = new System.Windows.Forms.Label();
			this.txtComputerName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnMigrate = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelOS = new System.Windows.Forms.Label();
			this.lblOS = new System.Windows.Forms.Label();
			this.btnBackup = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.migrationStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.errorCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scriptPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.status = new System.Windows.Forms.ToolStripStatusLabel();
			this.dgProcess = new System.Windows.Forms.DataGrid();
			this.gbMigrationInfo = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgProcess)).BeginInit();
			this.gbMigrationInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbProfile
			// 
			this.cbProfile.Enabled = false;
			this.cbProfile.FormattingEnabled = true;
			this.cbProfile.Location = new System.Drawing.Point(118, 156);
			this.cbProfile.Name = "cbProfile";
			this.cbProfile.Size = new System.Drawing.Size(145, 21);
			this.cbProfile.TabIndex = 0;
			this.cbProfile.Text = "Select a user Profile";
			this.cbProfile.SelectedIndexChanged += new System.EventHandler(this.CbProfileSelectedIndexChanged);
			// 
			// lblComputer
			// 
			this.lblComputer.Location = new System.Drawing.Point(6, 33);
			this.lblComputer.Name = "lblComputer";
			this.lblComputer.Size = new System.Drawing.Size(100, 23);
			this.lblComputer.TabIndex = 1;
			this.lblComputer.Text = "Computer Name:";
			// 
			// txtComputerName
			// 
			this.txtComputerName.Location = new System.Drawing.Point(114, 30);
			this.txtComputerName.Name = "txtComputerName";
			this.txtComputerName.Size = new System.Drawing.Size(145, 20);
			this.txtComputerName.TabIndex = 0;
			this.txtComputerName.Text = "Enter A computer Name";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 159);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Available profiles:";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(10, 212);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// btnMigrate
			// 
			this.btnMigrate.Location = new System.Drawing.Point(118, 212);
			this.btnMigrate.Name = "btnMigrate";
			this.btnMigrate.Size = new System.Drawing.Size(75, 23);
			this.btnMigrate.TabIndex = 5;
			this.btnMigrate.Text = "Get Profiles";
			this.btnMigrate.UseVisualStyleBackColor = true;
			this.btnMigrate.Click += new System.EventHandler(this.BtnMigrateClick);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.labelOS);
			this.groupBox1.Controls.Add(this.lblOS);
			this.groupBox1.Controls.Add(this.txtComputerName);
			this.groupBox1.Controls.Add(this.lblComputer);
			this.groupBox1.Location = new System.Drawing.Point(4, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(301, 101);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Remote Computer Infos";
			// 
			// labelOS
			// 
			this.labelOS.Location = new System.Drawing.Point(99, 68);
			this.labelOS.Name = "labelOS";
			this.labelOS.Size = new System.Drawing.Size(193, 23);
			this.labelOS.TabIndex = 5;
			// 
			// lblOS
			// 
			this.lblOS.Location = new System.Drawing.Point(8, 68);
			this.lblOS.Name = "lblOS";
			this.lblOS.Size = new System.Drawing.Size(100, 23);
			this.lblOS.TabIndex = 2;
			this.lblOS.Text = "Operating System:";
			// 
			// btnBackup
			// 
			this.btnBackup.Enabled = false;
			this.btnBackup.Location = new System.Drawing.Point(221, 212);
			this.btnBackup.Name = "btnBackup";
			this.btnBackup.Size = new System.Drawing.Size(75, 23);
			this.btnBackup.TabIndex = 7;
			this.btnBackup.Text = "Backup !";
			this.btnBackup.UseVisualStyleBackColor = true;
			this.btnBackup.Click += new System.EventHandler(this.BtnBackupClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fichierToolStripMenuItem,
			this.migrationStatsToolStripMenuItem,
			this.configurationToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(738, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.quitterToolStripMenuItem});
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.fichierToolStripMenuItem.Text = "Files";
			// 
			// quitterToolStripMenuItem
			// 
			this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
			this.quitterToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.quitterToolStripMenuItem.Text = "Exit";
			this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItemClick);
			// 
			// migrationStatsToolStripMenuItem
			// 
			this.migrationStatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.errorCenterToolStripMenuItem});
			this.migrationStatsToolStripMenuItem.Name = "migrationStatsToolStripMenuItem";
			this.migrationStatsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
			this.migrationStatsToolStripMenuItem.Text = "Migration Stats";
			// 
			// errorCenterToolStripMenuItem
			// 
			this.errorCenterToolStripMenuItem.Name = "errorCenterToolStripMenuItem";
			this.errorCenterToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.errorCenterToolStripMenuItem.Text = "Error Center";
			this.errorCenterToolStripMenuItem.Click += new System.EventHandler(this.ErrorCenterToolStripMenuItemClick);
			// 
			// configurationToolStripMenuItem
			// 
			this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.scriptPathToolStripMenuItem});
			this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
			this.configurationToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.configurationToolStripMenuItem.Text = "Configuration";
			// 
			// scriptPathToolStripMenuItem
			// 
			this.scriptPathToolStripMenuItem.Name = "scriptPathToolStripMenuItem";
			this.scriptPathToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.scriptPathToolStripMenuItem.Text = "Script Path";
			this.scriptPathToolStripMenuItem.Click += new System.EventHandler(this.ScriptPathToolStripMenuItemClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.lblStatus,
			this.status});
			this.statusStrip1.Location = new System.Drawing.Point(0, 266);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(738, 22);
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(45, 17);
			this.lblStatus.Text = "Status: ";
			// 
			// status
			// 
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(10, 17);
			this.status.Text = " ";
			// 
			// dgProcess
			// 
			this.dgProcess.DataMember = "";
			this.dgProcess.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgProcess.Location = new System.Drawing.Point(6, 19);
			this.dgProcess.Name = "dgProcess";
			this.dgProcess.ReadOnly = true;
			this.dgProcess.Size = new System.Drawing.Size(387, 197);
			this.dgProcess.TabIndex = 10;
			// 
			// gbMigrationInfo
			// 
			this.gbMigrationInfo.Controls.Add(this.dgProcess);
			this.gbMigrationInfo.Location = new System.Drawing.Point(327, 32);
			this.gbMigrationInfo.Name = "gbMigrationInfo";
			this.gbMigrationInfo.Size = new System.Drawing.Size(399, 222);
			this.gbMigrationInfo.TabIndex = 11;
			this.gbMigrationInfo.TabStop = false;
			this.gbMigrationInfo.Text = "Your Migration Info";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(738, 288);
			this.Controls.Add(this.gbMigrationInfo);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btnBackup);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnMigrate);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbProfile);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Backup Utility for VDI";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgProcess)).EndInit();
			this.gbMigrationInfo.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

