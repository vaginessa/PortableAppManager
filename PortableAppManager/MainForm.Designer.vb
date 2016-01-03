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
		Me.addNewAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.addExistingAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.reloadAppListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.openAppsFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.darkThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.lightThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
		Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addNewAppToolStripMenuItem, Me.addExistingAppToolStripMenuItem, Me.reloadAppListToolStripMenuItem, Me.openAppsFolderToolStripMenuItem, Me.toolStripSeparator1, Me.darkThemeToolStripMenuItem, Me.lightThemeToolStripMenuItem, Me.toolStripSeparator2, Me.aboutToolStripMenuItem, Me.exitToolStripMenuItem})
		Me.contextMenuStrip1.Name = "contextMenuStrip1"
		Me.contextMenuStrip1.Size = New System.Drawing.Size(166, 192)
		AddHandler Me.contextMenuStrip1.Opening, AddressOf Me.ContextMenuStrip1Opening
		'
		'addNewAppToolStripMenuItem
		'
		Me.addNewAppToolStripMenuItem.Name = "addNewAppToolStripMenuItem"
		Me.addNewAppToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
		Me.addNewAppToolStripMenuItem.Text = "Add new app"
		AddHandler Me.addNewAppToolStripMenuItem.Click, AddressOf Me.AddNewAppToolStripMenuItemClick
		'
		'addExistingAppToolStripMenuItem
		'
		Me.addExistingAppToolStripMenuItem.Name = "addExistingAppToolStripMenuItem"
		Me.addExistingAppToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
		Me.addExistingAppToolStripMenuItem.Text = "Add existing app"
		AddHandler Me.addExistingAppToolStripMenuItem.Click, AddressOf Me.AddExistingAppToolStripMenuItemClick
		'
		'reloadAppListToolStripMenuItem
		'
		Me.reloadAppListToolStripMenuItem.Name = "reloadAppListToolStripMenuItem"
		Me.reloadAppListToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
		Me.reloadAppListToolStripMenuItem.Text = "Reload app list"
		AddHandler Me.reloadAppListToolStripMenuItem.Click, AddressOf Me.ReloadAppListToolStripMenuItemClick
		'
		'openAppsFolderToolStripMenuItem
		'
		Me.openAppsFolderToolStripMenuItem.Name = "openAppsFolderToolStripMenuItem"
		Me.openAppsFolderToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
		Me.openAppsFolderToolStripMenuItem.Text = "Open apps folder"
		AddHandler Me.openAppsFolderToolStripMenuItem.Click, AddressOf Me.OpenAppsFolderToolStripMenuItemClick
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(162, 6)
		'
		'darkThemeToolStripMenuItem
		'
		Me.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem"
		Me.darkThemeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
		Me.darkThemeToolStripMenuItem.Text = "Dark Theme"
		AddHandler Me.darkThemeToolStripMenuItem.Click, AddressOf Me.DarkThemeToolStripMenuItemClick
		'
		'lightThemeToolStripMenuItem
		'
		Me.lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem"
		Me.lightThemeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
		Me.lightThemeToolStripMenuItem.Text = "Light Theme"
		AddHandler Me.lightThemeToolStripMenuItem.Click, AddressOf Me.LightThemeToolStripMenuItemClick
		'
		'toolStripSeparator2
		'
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(162, 6)
		'
		'aboutToolStripMenuItem
		'
		Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
		Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
		Me.aboutToolStripMenuItem.Text = "About"
		AddHandler Me.aboutToolStripMenuItem.Click, AddressOf Me.AboutToolStripMenuItemClick
		'
		'exitToolStripMenuItem
		'
		Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
		Me.exitToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
		Me.exitToolStripMenuItem.Text = "Exit"
		AddHandler Me.exitToolStripMenuItem.Click, AddressOf Me.ExitToolStripMenuItemClick
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
	Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private addExistingAppToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private openAppsFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private lightThemeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private darkThemeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private reloadAppListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private addNewAppToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
	Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
End Class
