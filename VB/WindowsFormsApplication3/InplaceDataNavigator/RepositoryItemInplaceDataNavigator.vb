Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace WindowsFormsApplication3
	<System.ComponentModel.DesignerCategory(""), UserRepositoryItem("Register")> _
	Public Class RepositoryItemInplaceDataNavigator
		Inherits RepositoryItem
		Private _editNavigator As MyDataNavigator
		Public Property EditNavigator() As MyDataNavigator
			Get
				Return _editNavigator
			End Get
			Set(ByVal value As MyDataNavigator)
				_editNavigator = value
			End Set
		End Property

		Friend Const EditorName As String = "InplaceDataNavigator"

		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
			AutoHeight = False
			EditNavigator = New MyDataNavigator()
			EditNavigator.Dock = DockStyle.Fill
			EditNavigator.BindingContext = New BindingContext()
		End Sub

		Protected Overrides Sub Finalize()
			EditNavigator.Dispose()
		End Sub

		Public Shared Sub Register()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(InplaceDataNavigator), GetType(RepositoryItemInplaceDataNavigator), GetType(BaseEditViewInfo), New InplaceDataNavigatorPainter(), True))
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source As RepositoryItemInplaceDataNavigator = TryCast(item, RepositoryItemInplaceDataNavigator)
				If source Is Nothing Then
					Return
				End If
				EditNavigator.DataSource = source.EditNavigator.DataSource
			Finally
				EndUpdate()
			End Try
		End Sub
	End Class
End Namespace
