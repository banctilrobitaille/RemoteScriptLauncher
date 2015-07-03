/*
 * User: banctilr
 * Date: 03/07/2015
 * Time: 1:47 PM
 * 
 */
using System;
using System.Windows.Forms;
using System.Management;

namespace VDI_Migration
{
	/// <summary>
	/// Description of ProcessWatcher.
	/// </summary>
	public class ProcessWatcher
	{
		ManagementEventWatcher processStopEvent = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStopTrace");
		
		public ProcessWatcher()
		{
			processStopEvent.EventArrived += new EventArrivedEventHandler(processStopEvent_EventArrived);
			processStopEvent.Start();
		}
		
	
		void processStopEvent_EventArrived(object sender, EventArrivedEventArgs e)
        {
            string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
            string processID = Convert.ToInt32(e.NewEvent.Properties["ProcessID"].Value).ToString();
 
            foreach(var process in MainForm.process){
            	
            	if(Convert.ToInt32(process.PID).ToString() == processID){
            		
            		process.Status = "Completed";
            	}
            }
        }

	}
}
