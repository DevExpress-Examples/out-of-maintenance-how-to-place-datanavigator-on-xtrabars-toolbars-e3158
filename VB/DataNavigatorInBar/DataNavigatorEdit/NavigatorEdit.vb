Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors
Imports System.ComponentModel

Namespace DataNavigatorInBar
	Friend Class NavigatorEdit
		Inherits BaseEdit
		Shared Sub New()
			NavigatorEditRepositoryItem.Register()
		End Sub
		Public Sub New()
			MyBase.New()
			Controls.Add(Properties.EditorNavigator)
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return NavigatorEditRepositoryItem.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As NavigatorEditRepositoryItem
			Get
				Return TryCast(MyBase.Properties, NavigatorEditRepositoryItem)
			End Get
		End Property
		Public Overrides Property EditValue() As Object
			Get
				Return MyBase.EditValue
			End Get
			Set(ByVal value As Object)
				MyBase.EditValue = value
				Properties.EditorNavigator.DataSource = value
			End Set
		End Property
	End Class

End Namespace
