Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraBars

Namespace WindowsFormsApplication3
	Public Class InplaceDataNavigatorHelper
		Private privateowner As BarEditItem
		Private Property owner() As BarEditItem
			Get
				Return privateowner
			End Get
			Set(ByVal value As BarEditItem)
				privateowner = value
			End Set
		End Property
		Private privaterepo As RepositoryItemInplaceDataNavigator
		Private Property repo() As RepositoryItemInplaceDataNavigator
			Get
				Return privaterepo
			End Get
			Set(ByVal value As RepositoryItemInplaceDataNavigator)
				privaterepo = value
			End Set
		End Property

		Public Sub New(ByVal barItem As BarEditItem)
			owner = barItem

			repo = TryCast(owner.Edit, RepositoryItemInplaceDataNavigator)
			AddHandler repo.EditNavigator.PositionChanged, AddressOf EditNavigator_PositionChanged
		End Sub
		Protected Overrides Sub Finalize()
			RemoveHandler repo.EditNavigator.PositionChanged, AddressOf EditNavigator_PositionChanged
			owner = Nothing
			repo = Nothing
		End Sub

		Private Sub EditNavigator_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
			owner.Refresh()
		End Sub
	End Class
End Namespace
