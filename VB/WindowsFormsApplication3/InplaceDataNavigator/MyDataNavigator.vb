Imports Microsoft.VisualBasic
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Namespace WindowsFormsApplication3
	Public Class MyDataNavigator
		Inherits DataNavigator
		Protected Overrides Function CreateViewInfo() As BaseStyleControlViewInfo
			Return New MyNavigatorControlViewInfo(Me)
		End Function

		Public Sub Draw(ByVal e As PaintEventArgs)
			TryCast(ViewInfo, MyNavigatorControlViewInfo).CalcViewInfo(e.Graphics, MouseButtons.None, New Point(-6000, -6000), e.ClipRectangle)
			Dim cache As New GraphicsCache(New DXPaintEventArgs(e))
			Try
				Dim info As New ControlGraphicsInfoArgs(ViewInfo, cache, ViewInfo.Bounds)
				Dim reg As ISupportGlassRegions = TryCast(Parent, ISupportGlassRegions)
				If reg IsNot Nothing Then
					info.IsDrawOnGlass = reg.IsOnGlass(Parent.RectangleToClient(RectangleToScreen(ViewInfo.Bounds)))
				End If
				Painter.Draw(info)
				RaisePaintEvent(Me, e)
			Finally
				cache.Dispose()
			End Try
		End Sub

		Private Class MyNavigatorControlViewInfo
			Inherits NavigatorControlViewInfo
			Public Sub New(ByVal owner As BaseStyleControl)
				MyBase.New(owner)
			End Sub

			Public Shadows Sub CalcViewInfo(ByVal g As Graphics, ByVal buttons As MouseButtons, ByVal p As Point, ByVal rec As Rectangle)
				MyBase.CalcViewInfo(g, buttons, p, rec)
				Me.Bounds = rec
				CalcRects()
			End Sub
		End Class
	End Class
End Namespace
