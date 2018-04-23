Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports System.Drawing

Namespace WindowsFormsApplication3
	<System.ComponentModel.DesignerCategory("")> _
	Public Class InplaceDataNavigator
		Inherits BaseEdit
		Shared Sub New()
			RepositoryItemInplaceDataNavigator.Register()
		End Sub
		Public Sub New()
			MyBase.New()
			Bounds = New Rectangle(Location,New Size(200,20))
			Controls.Add(Properties.EditNavigator)
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemInplaceDataNavigator.EditorName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemInplaceDataNavigator
			Get
				Return TryCast(MyBase.Properties, RepositoryItemInplaceDataNavigator)
			End Get
		End Property
	End Class
End Namespace
