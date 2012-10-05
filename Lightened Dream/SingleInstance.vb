Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

Namespace WindowsFormsApplication10
  NotInheritable Class Program
    Private Sub New()
    End Sub
    Shared SplashForm3 As SplashForm

    ''' <summary>  
    ''' The main entry point for the application.  
    ''' </summary>  
    <STAThread()> _
    Private Shared Sub Main()
      Application.EnableVisualStyles()
      Application.SetCompatibleTextRenderingDefault(False)
      SplashForm3 = New SplashForm()
      SingleInstanceApplication.Run(MainForm, AddressOf NewInstanceHandler)
    End Sub

    Public Shared Sub NewInstanceHandler(ByVal sender As Object, ByVal e As StartupNextInstanceEventArgs)
      'You can add a method on your Form1 class to notify it has been started again  
      'and perhaps pass parameters to it. That is if you need to know for instance   
      'the startup parameters.  

      'MainForm.NewInstance(e);  

      e.BringToForeground = True
    End Sub

    Public Class SingleInstanceApplication
      Inherits WindowsFormsApplicationBase
      Private Sub New()
        MyBase.IsSingleInstance = True
      End Sub

      Public Overloads Shared Sub Run(ByVal f As Form, ByVal startupHandler As StartupNextInstanceEventHandler)
        Dim app As New SingleInstanceApplication()
        app.MainForm = f
        AddHandler app.StartupNextInstance, startupHandler
        app.Run(Environment.GetCommandLineArgs())
      End Sub
    End Class

  End Class
End Namespace