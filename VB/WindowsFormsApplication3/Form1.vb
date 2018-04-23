Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms

Namespace WindowsFormsApplication3
	Partial Public Class Form1
		Inherits Form
		Private dt As New DataTable()
		Private bs As New BindingSource()

		Public Sub New()
			InitializeComponent()

			dt = New DataTable()
			dt.Columns.Add("Column", GetType(String))
			dt.Rows.Add("String 1")
			dt.Rows.Add("String 2")
			dt.Rows.Add("String 3")

			bs.DataSource = dt
			gridControl1.DataSource = bs

			Dim repo As RepositoryItemInplaceDataNavigator = TryCast(barEditItem1.Edit, RepositoryItemInplaceDataNavigator)
			repo.EditNavigator.DataSource = bs

			Dim dnHelper As New InplaceDataNavigatorHelper(barEditItem1) 'This helper class is required to refresh bar edit item when position changes
		End Sub
	End Class
End Namespace
