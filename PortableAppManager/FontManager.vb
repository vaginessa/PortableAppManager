'
' Created by SharpDevelop.
' User: s800239049
' Date: 1/7/2016
' Time: 9:06 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Runtime.InteropServices

Public Class FontManager
	<DllImport("gdi32.dll")> _
	Public Shared Function AddFontResource(ByVal lpszFilename As String) As Integer
	End Function
	
	Public Const HWND_BROADCAST As Integer = &HFFFF
	Public Const WM_FONTCHANGE As Integer = &H1D
	
	<DllImport("user32.dll")> _
	Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
	End Function
	
	Public Shared Sub AddFont(ByVal filename As String)
		AddFontResource(filename)
		SendMessage(New IntPtr(HWND_BROADCAST), WM_FONTCHANGE, IntPtr.Zero, IntPtr.Zero)
	End Sub
End Class
