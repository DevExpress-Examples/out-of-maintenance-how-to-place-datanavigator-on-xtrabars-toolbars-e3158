Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace WindowsFormsApplication3
	Public Class InplaceDataNavigatorPainter
		Inherits BaseEditPainter
		Public Overrides Sub Draw(ByVal info As ControlGraphicsInfoArgs)
			MyBase.Draw(info)
			Dim vi As BaseEditViewInfo = TryCast(info.ViewInfo, BaseEditViewInfo)
			Dim cri As RepositoryItemInplaceDataNavigator = TryCast(vi.Item, RepositoryItemInplaceDataNavigator)
			Dim e As New PaintEventArgs(info.Graphics, vi.Bounds)
			cri.EditNavigator.Draw(e)
		End Sub
	End Class
End Namespace
