using System;					
using System.Diagnostics;		

namespace GeneralUtility_CSharp
{
	/// <summary>
	/// Provides general utilities used to manage exceptions.
	/// Specifically, manages the logging of exceptions.
	/// </summary>
	public class ExceptionUtility
	{
		public ExceptionUtility()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		/// <summary>
		/// Adds an entry to the event log.
		/// </summary>
		/// <param name="sText">Text to add to the event log entry</param>
		/// <param name="eEntryType">Type of event log entry</param>
		public static void AddEventLogEntry(string sText, EventLogEntryType eEntryType)
		{
			// Get the current executing Assembly 
			System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();

			// Get the Title Attribute 
			System.Reflection.AssemblyTitleAttribute assTitleAttr = (System.Reflection.AssemblyTitleAttribute)asm.GetCustomAttributes(typeof(System.Reflection.AssemblyTitleAttribute),false)[0];
			string AppName = assTitleAttr.Title;

			// Ensure application is registered in event log
			if (!EventLog.SourceExists(AppName))
			{
				EventLog.CreateEventSource(AppName, "Application");
			}

			//   Add entry
			EventLog.WriteEntry(AppName, sText, eEntryType);
		}
	}

}
