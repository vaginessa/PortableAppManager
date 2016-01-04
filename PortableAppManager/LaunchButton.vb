'
' Created by SharpDevelop.
' User: Patrick
' Date: 2015-12-31
' Time: 11:31 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class LaunchButton
	Inherits System.Windows.Forms.UserControl
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	Private m_Text As String
	Public Overrides Property Text As String
		Get
			Return m_Text
		End Get
		Set(value As String)
			m_Text = value
			UpdateText()
		End Set
	End Property
	
	Private m_ShowText As Boolean = False
	Public Property ShowText As Boolean
		Get
			Return m_ShowText
		End Get
		Set(value As Boolean)
			m_ShowText = value
			UpdateText()
		End Set
	End Property
	
	Sub UpdateText()
		If m_ShowText = True Then
			button1.Text = m_Text
		Else
			button1.Text = Nothing
		End If
		launchToolStripMenuItem.Text = m_Text
	End Sub
	
	Public Property Image As Image
		Get
			Return button1.Image
		End Get
		Set(value As Image)
			button1.Image = value
		End Set
	End Property
	
	Private m_Launch As Process = New Process()
	Public Property Launch As Process
		Get
			Return m_Launch
		End Get
		Set(value As Process)
			m_Launch = value
		End Set
	End Property
	
	Private m_AppPath As String
	Public Property AppPath As String
		Get
			Return m_AppPath
		End Get
		Set(value As String)
			m_AppPath = value
		End Set
	End Property
	
	Public Property AllowDelete As Boolean
		Get
			Return removeToolStripMenuItem.Visible
		End Get
		Set(value As Boolean)
			removeToolStripMenuItem.Visible = value
		End Set
	End Property
	
	Sub Button1Click(sender As Object, e As EventArgs)
		LaunchApp()
	End Sub
	
	Public Sub LaunchApp()
		Try
			Launch.Start()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
		End Try
	End Sub
	
	Sub Button1MouseUp(sender As Object, e As MouseEventArgs)
		If e.Button = MouseButtons.Right Then
			contextMenuStrip1.Show(CType(sender, Control), New Point(e.X, e.Y))
		End If
	End Sub
	
	Sub LaunchToolStripMenuItemClick(sender As Object, e As EventArgs)
		LaunchApp()
	End Sub
	
	Sub RemoveToolStripMenuItemClick(sender As Object, e As EventArgs)
		DeleteApp()
	End Sub
	
	Public Sub DeleteApp()
		Select Case MsgBox("Permanently delete this application?", MsgBoxStyle.YesNoCancel, "Remove")
			Case MsgBoxResult.Yes
				Launch = Nothing
				button1.Image = Nothing
				Try
					IO.Directory.Delete(AppPath, True)
				Catch
				End Try
				Me.Visible = False
				Try
					Me.Dispose()
				Catch ex As Exception
					
				End Try
		End Select
	End Sub
	
	Sub LaunchButtonLoad(sender As Object, e As EventArgs)
		
	End Sub
	
	
	Sub OpenFolderToolStripMenuItemClick(sender As Object, e As EventArgs)
		Process.Start(AppPath)
	End Sub
	
	Sub RefreshIconToolStripMenuItemClick(sender As Object, e As EventArgs)
		Try
			IO.File.Delete(AppPath + "/icon.png")
		Catch
			
		End Try
		MainForm.LoadApps()
	End Sub
End Class
