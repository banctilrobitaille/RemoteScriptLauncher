/*
 * Created by SharpDevelop.
 * User: banctilr
 * Date: 17/06/2015
 * Time: 2:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;
using System.IO;

namespace VDI_Migration
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class RemoteComputer
	{
		private string name;
		
		public RemoteComputer(string name)
		{
			if(!this.nameIsValid(name)){
				
				throw new InvalidComputerException("Invalid computer name: " + name);
			}
			else{
				
				this.name = name;
			}
			
		}
		
		public string getName(){
			
			return this.name;
		}
		
		public bool nameIsValid(string name){
			
			return true;
			
		}
		
	}
}
