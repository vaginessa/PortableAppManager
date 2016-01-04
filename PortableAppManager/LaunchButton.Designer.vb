'
' Created by SharpDevelop.
' User: Patrick
' Date: 2015-12-31
' Time: 11:31 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class LaunchButton
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the control.
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
		Me.button1 = New System.Windows.Forms.Button()
		Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.launchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.openFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.removeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.refreshIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.contextMenuStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'button1
		'
		Me.button1.BackColor = System.Drawing.Color.Transparent
		Me.button1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
		Me.button1.FlatAppearance.BorderSize = 0
		Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
		Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.button1.Location = New System.Drawing.Point(0, 0)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(48, 48)
		Me.button1.TabIndex = 0
		Me.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.button1.UseVisualStyleBackColor = false
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		AddHandler Me.button1.MouseUp, AddressOf Me.Button1MouseUp
		'
		'contextMenuStrip1
		'
		Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.launchToolStripMenuItem, Me.openFolderToolStripMenuItem, Me.refreshIconToolStripMenuItem, Me.removeToolStripMenuItem})
		Me.contextMenuStrip1.Name = "contextMenuStrip1"
		Me.contextMenuStrip1.Size = New System.Drawing.Size(153, 114)
		'
		'launchToolStripMenuItem
		'
		Me.launchToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.launchToolStripMenuItem.Name = "launchToolStripMenuItem"
		Me.launchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.launchToolStripMenuItem.Text = "Launch"
		AddHandler Me.launchToolStripMenuItem.Click, AddressOf Me.LaunchToolStripMenuItemClick
		'
		'openFolderToolStripMenuItem
		'
		Me.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem"
		Me.openFolderToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.openFolderToolStripMenuItem.Text = "Open Folder"
		AddHandler Me.openFolderToolStripMenuItem.Click, AddressOf Me.OpenFolderToolStripMenuItemClick
		'
		'removeToolStripMenuItem
		'
		Me.removeToolStripMenuItem.Name = "removeToolStripMenuItem"
		Me.removeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.removeToolStripMenuItem.Text = "Remove"
		Me.removeToolStripMenuItem.Visible = false
		AddHandler Me.removeToolStripMenuItem.Click, AddressOf Me.RemoveToolStripMenuItemClick
		'
		'refreshIconToolStripMenuItem
		'
		Me.refreshIconToolStripMenuItem.Name = "refreshIconToolStripMenuItem"
		Me.refreshIconToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.refreshIconToolStripMenuItem.Text = "Refresh icon"
		AddHandler Me.refreshIconToolStripMenuItem.Click, AddressOf Me.RefreshIconToolStripMenuItemClick
		'
		'LaunchButton
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Transparent
		Me.Controls.Add(Me.button1)
		Me.Name = "LaunchButton"
		Me.Size = New System.Drawing.Size(48, 48)
		AddHandler Load, AddressOf Me.LaunchButtonLoad
		Me.contextMenuStrip1.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private refreshIconToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private openFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private launchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private removeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
	Private button1 As System.Windows.Forms.Button
End Class
