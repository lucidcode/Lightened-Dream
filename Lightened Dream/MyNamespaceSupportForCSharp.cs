using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

// This file was created by the VB to C# converter (SharpDevelop 4.4.2.9749).
// It contains classes for supporting the VB "My" namespace in C#.
// If the VB application does not use the "My" namespace, or if you removed the usage
// after the conversion to C#, you can delete this file.

namespace LightenedDream.My
{
	sealed partial class MyProject
	{
		[ThreadStatic] static MyApplication application;
		
		public static MyApplication Application {
			[DebuggerStepThrough]
			get {
				if (application == null)
					application = new MyApplication();
				return application;
			}
		}
		
		[ThreadStatic] static MyComputer computer;
		
		public static MyComputer Computer {
			[DebuggerStepThrough]
			get {
				if (computer == null)
					computer = new MyComputer();
				return computer;
			}
		}
		
		[ThreadStatic] static User user;
		
		public static User User {
			[DebuggerStepThrough]
			get {
				if (user == null)
					user = new User();
				return user;
			}
		}
		
		[ThreadStatic] static MyForms forms;
		
		public static MyForms Forms {
			[DebuggerStepThrough]
			get {
				if (forms == null)
					forms = new MyForms();
				return forms;
			}
		}
		
		internal sealed class MyForms
		{
			global::LightenedDream.SplashForm SplashForm_instance;
			bool SplashForm_isCreating;
			public global::LightenedDream.SplashForm SplashForm {
				[DebuggerStepThrough] get { return GetForm(ref SplashForm_instance, ref SplashForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref SplashForm_instance, value); }
			}
			
			global::LightenedDream.AboutForm AboutForm_instance;
			bool AboutForm_isCreating;
			public global::LightenedDream.AboutForm AboutForm {
				[DebuggerStepThrough] get { return GetForm(ref AboutForm_instance, ref AboutForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref AboutForm_instance, value); }
			}
			
			global::LightenedDream.SupportForm SupportForm_instance;
			bool SupportForm_isCreating;
			public global::LightenedDream.SupportForm SupportForm {
				[DebuggerStepThrough] get { return GetForm(ref SupportForm_instance, ref SupportForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref SupportForm_instance, value); }
			}
			
			global::LightenedDream.RegisterForm RegisterForm_instance;
			bool RegisterForm_isCreating;
			public global::LightenedDream.RegisterForm RegisterForm {
				[DebuggerStepThrough] get { return GetForm(ref RegisterForm_instance, ref RegisterForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref RegisterForm_instance, value); }
			}
			
			global::LightenedDream.FullScreenForm FullScreenForm_instance;
			bool FullScreenForm_isCreating;
			public global::LightenedDream.FullScreenForm FullScreenForm {
				[DebuggerStepThrough] get { return GetForm(ref FullScreenForm_instance, ref FullScreenForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref FullScreenForm_instance, value); }
			}
			
			global::LightenedDream.DataDirectoryForm DataDirectoryForm_instance;
			bool DataDirectoryForm_isCreating;
			public global::LightenedDream.DataDirectoryForm DataDirectoryForm {
				[DebuggerStepThrough] get { return GetForm(ref DataDirectoryForm_instance, ref DataDirectoryForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref DataDirectoryForm_instance, value); }
			}
			
			global::LightenedDream.ExportForm ExportForm_instance;
			bool ExportForm_isCreating;
			public global::LightenedDream.ExportForm ExportForm {
				[DebuggerStepThrough] get { return GetForm(ref ExportForm_instance, ref ExportForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref ExportForm_instance, value); }
			}
			
			global::LightenedDream.MainForm MainForm_instance;
			bool MainForm_isCreating;
			public global::LightenedDream.MainForm MainForm {
				[DebuggerStepThrough] get { return GetForm(ref MainForm_instance, ref MainForm_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref MainForm_instance, value); }
			}
			
			[DebuggerStepThrough]
			static T GetForm<T>(ref T instance, ref bool isCreating) where T : Form, new()
			{
				if (instance == null || instance.IsDisposed) {
					if (isCreating) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
					isCreating = true;
					try {
						instance = new T();
					} catch (System.Reflection.TargetInvocationException ex) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[] { ex.InnerException.Message }), ex.InnerException);
					} finally {
						isCreating = false;
					}
				}
				return instance;
			}
			
			[DebuggerStepThrough]
			static void SetForm<T>(ref T instance, T value) where T : Form
			{
				if (instance != value) {
					if (value == null) {
						instance.Dispose();
						instance = null;
					} else {
						throw new ArgumentException("Property can only be set to null");
					}
				}
			}
		}
	}
	
	partial class MyApplication : WindowsFormsApplicationBase
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.SetCompatibleTextRenderingDefault(UseCompatibleTextRendering);
			MyProject.Application.Run(args);
		}
	}
	
	partial class MyComputer : Computer
	{
	}
}
