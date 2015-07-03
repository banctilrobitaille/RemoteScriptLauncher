/*
 * Created by SharpDevelop.
 * User: banctilr
 * Date: 17/06/2015
 * Time: 4:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Management;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace VDI_Migration
{
	/// <summary>
	/// Description of CommUtility.
	/// </summary>
	public static class CommUtility
	{
		
		/*
		 *Method that execute a WMI command on a remote computer and return all the profile folders' name
		 * in an arraylist
		 */
		public static ArrayList getProfile(string computername){
			
			//List to store the user profiles
			ArrayList profileList = new ArrayList();
			
			//Line of the file written on the client
			string line;
				
			ConnectionOptions connOptions = new ConnectionOptions();
            ObjectGetOptions objectGetOptions = new ObjectGetOptions();
            ManagementPath managementPath = new ManagementPath("Win32_Process");
            
            //To use caller credential
            connOptions.Impersonation = ImpersonationLevel.Impersonate;
            connOptions.EnablePrivileges = true;
    		ManagementScope manScope = new ManagementScope(String.Format(@"\\{0}\ROOT\CIMV2", computername), connOptions);
            manScope.Connect();
            InvokeMethodOptions methodOptions = new InvokeMethodOptions(null, System.TimeSpan.MaxValue);
            ManagementClass processClass = new ManagementClass(manScope, managementPath, objectGetOptions);
            ManagementBaseObject inParams = processClass.GetMethodParameters("Create");
            
            //The command to execute to get the profile folder and write the result to C:\\tmp.txt    
            inParams["CommandLine"] = "cmd /c " + "dir C:\\Users /B" + " > c:\\tmp.txt";
            ManagementBaseObject outParams = processClass.InvokeMethod("Create", inParams,methodOptions);
			
			//Arbitratry delay to make sure that the command is done            
            Thread.Sleep(2000);
            
            //Reading the result file
            StreamReader sr = new StreamReader("\\\\" + computername + "\\c$\\tmp.txt");
            line = sr.ReadLine();
            
            //While there are profile
            while (line != null)
            {
              //Add the profile to the arraylist
              profileList.Add(line);
              line = sr.ReadLine();
                      
            }

            sr.Close();
            
            return profileList;
		}
		
		public static String[] getComputerInfos(string computername){
		
			String[] computerInfos = new String[2];
			
			ConnectionOptions connOptions = new ConnectionOptions();
            ObjectGetOptions objectGetOptions = new ObjectGetOptions();
            ManagementPath managementPath = new ManagementPath("Win32_Process");
            
            //To use caller credential
            connOptions.Impersonation = ImpersonationLevel.Impersonate;
            connOptions.EnablePrivileges = true;
    		ManagementScope manScope = new ManagementScope(String.Format(@"\\{0}\ROOT\CIMV2", computername), connOptions);
            manScope.Connect();
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(manScope, query);
            ManagementObjectCollection queryCollection = searcher.Get();
            
            foreach (ManagementObject m in queryCollection){
            
            	computerInfos[0] = Convert.ToString(m["Caption"]);
            	computerInfos[1] = Convert.ToString(m["Status"]);
            	
            }
            
			return computerInfos;
		}
		
				/*
		 *Method that execute a WMI command on a remote computer and return all the profile folders' name
		 * in an arraylist
		 */
		public static void launchBackupScript(string computername, string profileFolder){
			
			ConnectionOptions connOptions = new ConnectionOptions();
            ObjectGetOptions objectGetOptions = new ObjectGetOptions();
            ManagementPath managementPath = new ManagementPath("Win32_Process");
            
            //To use caller credential
            connOptions.Impersonation = ImpersonationLevel.Impersonate;
            connOptions.EnablePrivileges = true;
    		ManagementScope manScope = new ManagementScope(String.Format(@"\\{0}\ROOT\CIMV2", "."), connOptions);
            manScope.Connect();
            InvokeMethodOptions methodOptions = new InvokeMethodOptions(null, System.TimeSpan.MaxValue);
            ManagementClass processClass = new ManagementClass(manScope, managementPath, objectGetOptions);
            ManagementBaseObject inParams = processClass.GetMethodParameters("Create");
            
            //The command to execute  
            inParams["CommandLine"] = "wscript.exe " + MainForm.BackupPath + " " + computername + " " + profileFolder;
            ManagementBaseObject outParams = processClass.InvokeMethod("Create", inParams,methodOptions);
            
            MainForm.process.Add(new MigrationProcess(outParams["processId"], computername, profileFolder, "Running"));
		}
	}
}
