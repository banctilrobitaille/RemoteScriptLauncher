/*
 * User: banctilr
 * Date: 03/07/2015
 * Time: 8:45 AM
 * 
 */
namespace VDI_Migration
{
	partial class frmScriptPath
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblScanList;
		private System.Windows.Forms.Label lblBackupScript;
		private System.Windows.Forms.TextBox txtScanList;
		private System.Windows.Forms.TextBox txtBackupPath;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		
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
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScriptPath));
			this.lblScanList = new System.Windows.Forms.Label();
			this.lblBackupScript = new System.Windows.Forms.Label();
			this.txtScanList = new System.Windows.Forms.TextBox();
			this.txtBackupPath = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblScanList
			// 
			this.lblScanList.Location = new System.Drawing.Point(22, 9);
			this.lblScanList.Name = "lblScanList";
			this.lblScanList.Size = new System.Drawing.Size(100, 23);
			this.lblScanList.TabIndex = 0;
			this.lblScanList.Text = "File Scan Script:";
			// 
			// lblBackupScript
			// 
			this.lblBackupScript.Location = new System.Drawing.Point(22, 49);
			this.lblBackupScript.Name = "lblBackupScript";
			this.lblBackupScript.Size = new System.Drawing.Size(100, 23);
			this.lblBackupScript.TabIndex = 1;
			this.lblBackupScript.Text = "Backup Script:";
			// 
			// txtScanList
			// 
			this.txtScanList.Location = new System.Drawing.Point(116, 9);
			this.txtScanList.Name = "txtScanList";
			this.txtScanList.Size = new System.Drawing.Size(217, 20);
			this.txtScanList.TabIndex = 2;
			// 
			// txtBackupPath
			// 
			this.txtBackupPath.Location = new System.Drawing.Point(116, 46);
			this.txtBackupPath.Name = "txtBackupPath";
			this.txtBackupPath.Size = new System.Drawing.Size(217, 20);
			this.txtBackupPath.TabIndex = 3;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(191, 77);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(286, 77);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// frmScriptPath
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 112);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtBackupPath);
			this.Controls.Add(this.txtScanList);
			this.Controls.Add(this.lblBackupScript);
			this.Controls.Add(this.lblScanList);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmScriptPath";
			this.Text = "Script Path Configuration";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
