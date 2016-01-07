'
' Created by SharpDevelop.
' User: Patrick
' Date: 2015-12-31
' Time: 11:12 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.newAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.existingAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.appListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.fontsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.showLoadedFontsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.openAppsFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.openFontsFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.darkThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.lightThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.showLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FontRefresher = New System.Windows.Forms.Timer(Me.components)
		Me.FontLoader = New System.ComponentModel.BackgroundWorker()
		Me.contextMenuStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'flowLayoutPanel1
		'
		Me.flowLayoutPanel1.AutoScroll = true
		Me.flowLayoutPanel1.ContextMenuStrip = Me.contextMenuStrip1
		Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.flowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
		Me.flowLayoutPanel1.Size = New System.Drawing.Size(340, 261)
		Me.flowLayoutPanel1.TabIndex = 0
		'
		'contextMenuStrip1
		'
		Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1, Me.toolStripMenuItem2, Me.showLoadedFontsToolStripMenuItem, Me.toolStripSeparator3, Me.openAppsFolderToolStripMenuItem, Me.openFontsFolderToolStripMenuItem, Me.toolStripSeparator1, Me.darkThemeToolStripMenuItem, Me.lightThemeToolStripMenuItem, Me.toolStripSeparator2, Me.showLogToolStripMenuItem, Me.aboutToolStripMenuItem, Me.exitToolStripMenuItem})
		Me.contextMenuStrip1.Name = "contextMenuStrip1"
		Me.contextMenuStrip1.Size = New System.Drawing.Size(173, 264)
		AddHandler Me.contextMenuStrip1.Opening, AddressOf Me.ContextMenuStrip1Opening
		'
		'toolStripMenuItem1
		'
		Me.toolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newAppToolStripMenuItem, Me.existingAppToolStripMenuItem})
		Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
		Me.toolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
		Me.toolStripMenuItem1.Text = "Add"
		AddHandler Me.toolStripMenuItem1.Click, AddressOf Me.ToolStripMenuItem1Click
		'
		'newAppToolStripMenuItem
		'
		Me.newAppToolStripMenuItem.Name = "newAppToolStripMenuItem"
		Me.newAppToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
		Me.newAppToolStripMenuItem.Text = "New app"
		AddHandler Me.newAppToolStripMenuItem.Click, AddressOf Me.AddNewAppToolStripMenuItemClick
		'
		'existingAppToolStripMenuItem
		'
		Me.existingAppToolStripMenuItem.Name = "existingAppToolStripMenuItem"
		Me.existingAppToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
		Me.existingAppToolStripMenuItem.Text = "Existing app"
		AddHandler Me.existingAppToolStripMenuItem.Click, AddressOf Me.AddExistingAppToolStripMenuItemClick
		'
		'toolStripMenuItem2
		'
		Me.toolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.appListToolStripMenuItem, Me.fontsToolStripMenuItem})
		Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
		Me.toolStripMenuItem2.Size = New System.Drawing.Size(172, 22)
		Me.toolStripMenuItem2.Text = "Refresh"
		'
		'appListToolStripMenuItem
		'
		Me.appListToolStripMenuItem.Name = "appListToolStripMenuItem"
		Me.appListToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
		Me.appListToolStripMenuItem.Text = "App list"
		AddHandler Me.appListToolStripMenuItem.Click, AddressOf Me.ReloadAppListToolStripMenuItemClick
		'
		'fontsToolStripMenuItem
		'
		Me.fontsToolStripMenuItem.Name = "fontsToolStripMenuItem"
		Me.fontsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
		Me.fontsToolStripMenuItem.Text = "Fonts"
		AddHandler Me.fontsToolStripMenuItem.Click, AddressOf Me.ReloadFontsToolStripMenuItemClick
		'
		'showLoadedFontsToolStripMenuItem
		'
		Me.showLoadedFontsToolStripMenuItem.Name = "showLoadedFontsToolStripMenuItem"
		Me.showLoadedFontsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
		Me.showLoadedFontsToolStripMenuItem.Text = "Show loaded fonts"
		AddHandler Me.showLoadedFontsToolStripMenuItem.Click, AddressOf Me.ShowLoadedFontsToolStripMenuItemClick
		'
		'toolStripSeparator3
		'
		Me.toolStripSeparator3.Name = "toolStripSeparator3"
		Me.toolStripSeparator3.Size = New System.Drawing.Size(169, 6)
		'
		'openAppsFolderToolStripMenuItem
		'
		Me.openAppsFolderToolStripMenuItem.Name = "openAppsFolderToolStripMenuItem"
		Me.openAppsFolderToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
		Me.openAppsFolderToolStripMenuItem.Text = "Open apps folder"
		AddHandler Me.openAppsFolderToolStripMenuItem.Click, AddressOf Me.OpenAppsFolderToolStripMenuItemClick
		'
		'openFontsFolderToolStripMenuItem
		'
		Me.openFontsFolderToolStripMenuItem.Name = "openFontsFolderToolStripMenuItem"
		Me.openFontsFolderToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
		Me.openFontsFolderToolStripMenuItem.Text = "Open fonts folder"
		AddHandler Me.openFontsFolderToolStripMenuItem.Click, AddressOf Me.OpenFontsFolderToolStripMenuItemClick
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(169, 6)
		'
		'darkThemeToolStripMenuItem
		'
		Me.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem"
		Me.darkThemeToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
		Me.darkThemeToolStripMenuItem.Text = "Dark Theme"
		AddHandler Me.darkThemeToolStripMenuItem.Click, AddressOf Me.DarkThemeToolStripMenuItemClick
		'
		'lightThemeToolStripMenuItem
		'
		Me.lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem"
		Me.lightThemeToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
		Me.lightThemeToolStripMenuItem.Text = "Light Theme"
		AddHandler Me.lightThemeToolStripMenuItem.Click, AddressOf Me.LightThemeToolStripMenuItemClick
		'
		'toolStripSeparator2
		'
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(169, 6)
		'
		'showLogToolStripMenuItem
		'
		Me.showLogToolStripMenuItem.Name = "showLogToolStripMenuItem"
		Me.showLogToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
		Me.showLogToolStripMenuItem.Text = "Show Log"
		AddHandler Me.showLogToolStripMenuItem.Click, AddressOf Me.ShowLogToolStripMenuItemClick
		'
		'aboutToolStripMenuItem
		'
		Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
		Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
		Me.aboutToolStripMenuItem.Text = "About"
		AddHandler Me.aboutToolStripMenuItem.Click, AddressOf Me.AboutToolStripMenuItemClick
		'
		'exitToolStripMenuItem
		'
		Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
		Me.exitToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
		Me.exitToolStripMenuItem.Text = "Exit"
		AddHandler Me.exitToolStripMenuItem.Click, AddressOf Me.ExitToolStripMenuItemClick
		'
		'FontRefresher
		'
		Me.FontRefresher.Enabled = true
		Me.FontRefresher.Interval = 100000
		AddHandler Me.FontRefresher.Tick, AddressOf Me.FontRefresherTick
		'
		'FontLoader
		'
		AddHandler Me.FontLoader.DoWork, AddressOf Me.FontLoaderDoWork
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(340, 261)
		Me.Controls.Add(Me.flowLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.Name = "MainForm"
		Me.Text = "PortableAppManager"
		AddHandler FormClosing, AddressOf Me.MainFormFormClosing
		AddHandler Load, AddressOf Me.MainFormLoad
		AddHandler Shown, AddressOf Me.MainFormShown
		Me.contextMenuStrip1.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private showLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private showLoadedFontsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Private fontsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private appListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Private existingAppToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private newAppToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private openFontsFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private FontLoader As System.ComponentModel.BackgroundWorker
	Private FontRefresher As System.Windows.Forms.Timer
	Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private openAppsFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private lightThemeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private darkThemeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
	Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
End Class
