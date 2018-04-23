Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.ViewInfo

Namespace DataNavigatorInBar
	Friend Class NavigatorEditPainter
		Inherits BaseEditPainter
		Public Sub New()
			MyBase.New()
		End Sub
		Public Overrides Sub Draw(ByVal info As ControlGraphicsInfoArgs)
			MyBase.Draw(info)

			Dim vi As BaseEditViewInfo = TryCast(info.ViewInfo, BaseEditViewInfo)
			Dim cri As NavigatorEditRepositoryItem = TryCast(vi.Item, NavigatorEditRepositoryItem)
			If cri.DrawNavigator Is Nothing Then
				Return
			End If
			cri.DrawNavigator.DataSource = vi.EditValue
			Dim e As New PaintEventArgs(info.Graphics, vi.Bounds)
			cri.DrawNavigator.Draw(e)
		End Sub
	End Class

End Namespace
