'
' Created by SharpDevelop.
' User: s800239049
' Date: 1/7/2016
' Time: 10:01 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class LogViewer
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
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.SuspendLayout
		'
		'textBox1
		'
		Me.textBox1.BackColor = System.Drawing.Color.White
		Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.textBox1.Location = New System.Drawing.Point(0, 0)
		Me.textBox1.Multiline = true
		Me.textBox1.Name = "textBox1"
		Me.textBox1.ReadOnly = true
		Me.textBox1.Size = New System.Drawing.Size(284, 262)
		Me.textBox1.TabIndex = 0
		'
		'LogViewer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 262)
		Me.Controls.Add(Me.textBox1)
		Me.Name = "LogViewer"
		Me.Text = "LogViewer"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private textBox1 As System.Windows.Forms.TextBox
End Class
