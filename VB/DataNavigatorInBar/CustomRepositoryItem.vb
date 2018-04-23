Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.ViewInfo

Namespace DataNavigatorInBar
	<UserRepositoryItem("Register")> _
	Friend Class NavigatorEditRepositoryItem
		Inherits RepositoryItem
		Private _drawNavigator As MyDataNavigator
		Public Property DrawNavigator() As MyDataNavigator
			Get
				Return _drawNavigator
			End Get
			Set(ByVal value As MyDataNavigator)
				_drawNavigator = value
			End Set
		End Property
		Private _editorNavigator As MyDataNavigator
		Public Property EditorNavigator() As MyDataNavigator
			Get
				Return _editorNavigator
			End Get
			Set(ByVal value As MyDataNavigator)
				_editorNavigator = value
			End Set
		End Property

		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
			MyBase.New()
			_drawNavigator = New MyDataNavigator()
			_drawNavigator.Dock = DockStyle.Fill
			_editorNavigator = New MyDataNavigator()
			_editorNavigator.Dock = DockStyle.Fill
			_drawNavigator.BindingContext = New BindingContext()

		End Sub
		Friend Const EditorName As String = "DataNavigatorEdit"

		Public Shared Sub Register()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(NavigatorEdit), GetType(NavigatorEditRepositoryItem), GetType(BaseEditViewInfo), New NavigatorEditPainter(), True))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property
	End Class

End Namespace
