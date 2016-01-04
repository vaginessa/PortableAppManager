'
' Created by SharpDevelop.
' User: Patrick
' Date: 2015-12-31
' Time: 11:12 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Bitmap
Imports System.IO

Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		Me.Icon = GetIcon(System.Reflection.Assembly.GetExecutingAssembly().Location)
		
	End Sub
	
	Dim AppsFolder As String = My.Application.Info.DirectoryPath + "/Apps"
	Dim Apps As New List(Of LaunchButton)
	#Region "Icon Functions"
	Public Function GetIcon(ByVal Path As String) As Icon
		Return Icon.ExtractAssociatedIcon(path)
	End Function
	Public Sub SaveIconAsPNG(ByVal IconToSave As Icon, ByVal Filename As String)
		IconToSave.ToBitmap().Save(Filename, ImageFormat.Png)
	End Sub
	#End Region
	
	Public Sub LoadApps()
		flowLayoutPanel1.Controls.Clear()
		Apps.Clear()
		If Directory.Exists(AppsFolder) = False Then
			Directory.CreateDirectory(AppsFolder)
		End If
		Dim di As New DirectoryInfo(AppsFolder)
		
		'Search for apps
		For Each d As DirectoryInfo In di.GetDirectories("*", SearchOption.TopDirectoryOnly)
			' Attempt to create and fill ExeName.txt if does not exist
			If IO.File.Exists(d.FullName + "/ExeName.txt") = False Then
				TryToCreateExeNameFile(d.FullName)
			End If
			
			If IO.File.Exists(d.FullName + "/ExeName.txt") Then
				Dim ExeDir As String = d.FullName
				Dim AppName As String = d.Name
				Dim ExePath As String = ExeDir + "/" + File.ReadAllText(ExeDir + "/ExeName.txt").Replace(Environment.NewLine, "")
				Dim ExeArguments As String = ""
				Dim lb As New LaunchButton()
				
				'Check for exe arguments
				If File.Exists(ExeDir + "/ExeArguments.txt") Then
					ExeArguments = File.ReadAllText(ExeDir + "/ExeArguments.txt").Replace(Environment.NewLine, "")
				End If
				
				'Make sure app actually exists
				If File.Exists(ExePath) = False Then
					Continue For ' Skip this entry
				End If
				
				'Set up the remove button
				lb.AppPath = ExeDir
				lb.AllowDelete = True
				
				'Create launcher process
				Dim p As New Process()
				p.StartInfo.FileName = ExePath
				p.StartInfo.Arguments = ExeArguments
				p.StartInfo.WorkingDirectory = ExeDir
				lb.Launch = p
				
				'Attempt to create icon.png if does not exist
				TryToCreateIconFile(ExePath, ExeDir)
				
				'Set the button's image to icon.png
				Dim fs As New FileStream(ExeDir + "/icon.png", IO.FileMode.Open, IO.FileAccess.Read)
				lb.Image = Image.FromStream(fs)
				fs.Close()
				
				'Set the text
				lb.Text = AppName
				
				'Add the button
				Apps.Add(lb)
				flowLayoutPanel1.Controls.Add(lb)
				Application.DoEvents()
			End If
		Next
	End Sub
	
	Function TryToCreateIconFile(ByVal ExePath As String, ByVal AppDir As String) As Boolean
		If File.Exists(AppDir + "/icon.png") = False Then
			SaveIconAsPNG(GetIcon(ExePath), AppDir + "/icon.png")
			Return True
		Else
			Return False
		End If
	End Function
	
	Function TryToCreateExeNameFile(ByVal AppDir As String, Optional ByVal promptForManyOptions As Boolean = False, optional ByVal doNotOverwrite As Boolean = False) As Boolean
		Try
			If doNotOverwrite = True Then
				If IO.File.Exists(AppDir + "/ExeName.txt") = True Then
					Return True
				End If
			End If
			Dim ddi As New DirectoryInfo(AppDir)
			Dim ffi As FileInfo() = ddi.GetFiles("*.exe",SearchOption.AllDirectories)
			Dim exe As String = ffi(0).FullName
			If promptForManyOptions = True Then
				If ffi.Length > 1 Then
					Select Case MsgBox("Many executables found. Would you like to stick with the default(" + ffi(0).Name + ")? Press yes to stick with it, and no to choose a new one.", MsgBoxStyle.YesNo, "Mutiple files found")
						Case MsgBoxResult.Yes
						Case MsgBoxResult.No
							While promptForManyOptions = True
								Dim ofd As New OpenFileDialog()
								ofd.InitialDirectory = AppDir
								ofd.Filter = "EXE|*.exe|BAT|*.bat"
								Select Case ofd.ShowDialog()
									Case DialogResult.OK
										If ofd.FileName.StartsWith(AppDir) OrElse ofd.FileName.Replace("/","\").StartsWith(AppDir.Replace("/","\")) = True Then
											exe = ofd.FileName
											promptForManyOptions = False
										Else
											MsgBox("Please choose a file in the application directory")
											ofd.Reset()
											ofd.RestoreDirectory = False
											ofd.InitialDirectory = AppDir
										End If
								End Select
							End While
					End Select
				End If
			End If
			IO.File.WriteAllText(AppDir + "/ExeName.txt",exe.Replace(AppDir,"").Replace(AppDir.Replace("/","\"),""))
		Catch ex As Exception
			Try
				Dim ddi As New DirectoryInfo(AppDir)
				Dim ffi As FileInfo = ddi.GetFiles("*.bat",SearchOption.AllDirectories)(0)
				IO.File.WriteAllText(AppDir + "/ExeName.txt",ffi.FullName.Replace(AppDir,""))
			Catch exx As Exception
				Return False
			End Try
		End Try
		Return True
	End Function
	
	
	
	Sub MainFormShown(sender As Object, e As EventArgs)
		LoadApps()
	End Sub
	
	Sub AddNewAppToolStripMenuItemClick(sender As Object, e As EventArgs)
		Dim fbd As New FolderBrowserDialog()
		fbd.Description = "Choose the folder with the app executables"
		fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
		Select Case fbd.ShowDialog()
			Case DialogResult.OK
				If MsgBox("Confirm folder: " + fbd.SelectedPath + " ?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
					Dim di As New DirectoryInfo(fbd.SelectedPath)
					Dim target As String = AppsFolder + "\" + di.Name
					MsgBox("This may take a while. Press OK to continue.")
					My.Computer.FileSystem.CopyDirectory(fbd.SelectedPath, target)
					If TryToCreateExeNameFile(target, True) = False Then
						MsgBox("Cannot find executable in the folder")
						Exit Sub
					Else
						If TryToCreateIconFile(target + "\" + IO.File.ReadAllText(target + "\ExeName.txt").Replace(Environment.NewLine,""),target) = False Then
							MsgBox("Error creating icon file. Continuing anyways.")
							LoadApps()
						End If
					End If
				Else
					MsgBox("Aborted")
				End If
		End Select
		MsgBox("Done.")
		LoadApps() 	
	End Sub
	
	Sub ContextMenuStrip1Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)
		
	End Sub
	
	Sub ReloadAppListToolStripMenuItemClick(sender As Object, e As EventArgs)
		LoadApps()
	End Sub
	
	Sub DarkThemeToolStripMenuItemClick(sender As Object, e As EventArgs)
		Me.BackColor = Color.FromArgb(32,32,32)
		Try
			IO.File.Create(AppsFolder + "/darktheme.txt")
		Catch ex As Exception
			
		End Try
	End Sub
	
	Sub LightThemeToolStripMenuItemClick(sender As Object, e As EventArgs)
		Me.BackColor = Color.White
		Try
			IO.File.Delete(AppsFolder + "/darktheme.txt")
		Catch ex As Exception
			
		End Try
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		Try
			If IO.File.Exists(AppsFolder + "/darktheme.txt") Then
				Me.BackColor = Color.FromArgb(32,32,32)
			Else
				Me.BackColor = Color.White
			End If
			
		Catch
			
		End Try
		Try
			If IO.File.Exists(AppsFolder + "/size.txt") Then
				Dim s As String() = IO.File.ReadAllText(AppsFolder + "/size.txt").Split(",")
				Me.Height = CInt(s(0))
				Me.Width = CInt(s(1))
			End If
			
		Catch ex As Exception
			
		End Try
		
	End Sub       
	

	
	Sub OpenAppsFolderToolStripMenuItemClick(sender As Object, e As EventArgs)
		Process.Start(AppsFolder)
	End Sub
	
	Sub AboutToolStripMenuItemClick(sender As Object, e As EventArgs)
		MsgBox(My.Application.Info.Title + " " + CStr(My.Application.Info.Version.Major) + "." + CStr(My.Application.Info.Version.Minor)  + Environment.NewLine + My.Application.Info.Description + Environment.NewLine + My.Application.Info.Copyright)
	End Sub
	
	Sub AddExistingAppToolStripMenuItemClick(sender As Object, e As EventArgs)
		Dim fbd As New FolderBrowserDialog()
		fbd.Description = "Choose the folder with the app files"
		fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
		Select Case fbd.ShowDialog()
			Case DialogResult.OK
				If MsgBox("Confirm folder: " + fbd.SelectedPath + " ?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
					Dim di As New DirectoryInfo(fbd.SelectedPath)
					Dim target As String = AppsFolder + "\" + di.Name
					MsgBox("This may take a while. Press OK to continue.")
					My.Computer.FileSystem.CopyDirectory(fbd.SelectedPath, target)
					If TryToCreateExeNameFile(target, True, True) = False Then
						MsgBox("Cannot find executable in the folder")
						Exit Sub
					Else
						If TryToCreateIconFile(target + "\" + IO.File.ReadAllText(target + "\ExeName.txt").Replace(Environment.NewLine,""),target) = False Then
							MsgBox("Error creating icon file. Continuing anyways.")
							LoadApps()
						End If
					End If
					
				Else
					MsgBox("Aborted")
				End If
		End Select
		MsgBox("Done.")
		LoadApps() 	
	End Sub
	
	Sub ExitToolStripMenuItemClick(sender As Object, e As EventArgs)
		Me.Close()
	End Sub
	
	Sub MainFormFormClosing(sender As Object, e As FormClosingEventArgs)
		Try
			IO.File.WriteAllText(AppsFolder + "/size.txt",CStr(Me.Height) + "," + CStr(Me.Width))
		Catch
			
		End Try
	End Sub
End Class
