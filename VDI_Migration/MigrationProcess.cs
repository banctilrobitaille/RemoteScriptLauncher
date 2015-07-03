/*
 * User: banctilr
 * Date: 03/07/2015
 * Time: 11:37 AM
 * 
 */
using System;
using System.ComponentModel;

namespace VDI_Migration
{
	/// <summary>
	/// Description of MigrationProcess.
	/// </summary>
	public class MigrationProcess : INotifyPropertyChanged
	{
		private Object _PID;
		private String _computerName;
		private String _profile;
		private String _status;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		public MigrationProcess(Object PID, String computerName, String profile, String status)
		{
			this._PID = PID;
			this._computerName = computerName;
			this._profile = profile;
			this._status = status;
		}
		
		public Object PID
  		{
    		get { return _PID; }
    		set { _PID = value;
    			 this.NotifyPropertyChanged("PID");
    		}
  		}
		
		public String ComputerName
  		{
    		get { return _computerName; }
    		set { _computerName = value;
				 this.NotifyPropertyChanged("ComputerName");
    		}
  		}
		
		public String Profile
  		{
    		get { return _profile; }
    		set { _profile = value;
    			this.NotifyPropertyChanged("Profile");
    		}
  		}
		
		public String Status
  		{
    		get { return _status; }
    		set { _status = value;
    			this.NotifyPropertyChanged("Status");
    		}
  		}
	}
}
