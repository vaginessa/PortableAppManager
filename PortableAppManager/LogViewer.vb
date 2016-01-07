'
' Created by SharpDevelop.
' User: s800239049
' Date: 1/7/2016
' Time: 10:01 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class LogViewer
	Public Sub New(ByRef logString As String)
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		textBox1.DataBindings.Add("Text",logString, "")
	End Sub
End Class
