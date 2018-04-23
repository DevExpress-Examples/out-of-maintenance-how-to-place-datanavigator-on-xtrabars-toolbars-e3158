Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataNavigatorInBar
	Partial Public Class Form1
		Inherits Form
		Private dt As New DataTable()
		Private bs As New BindingSource()
		Public Sub New()
			InitializeComponent()
			dt = New DataTable()
			dt.Columns.Add("Column",GetType(String))
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			bs.DataSource = dt
			dt.Rows.Add("String 1")
			dt.Rows.Add("String 2")
			dt.Rows.Add("String 3")
			gridControl1.DataSource = bs
			barEditItem1.EditValue = bs
		End Sub
	End Class
End Namespace
