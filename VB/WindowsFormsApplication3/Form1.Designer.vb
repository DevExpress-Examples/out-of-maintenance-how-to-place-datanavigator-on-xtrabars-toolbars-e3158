Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication3
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemInplaceDataNavigator2 = New WindowsFormsApplication3.RepositoryItemInplaceDataNavigator()
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.repositoryItemInplaceDataNavigator1 = New WindowsFormsApplication3.RepositoryItemInplaceDataNavigator()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemInplaceDataNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemInplaceDataNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 51)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(722, 353)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barEditItem1})
			Me.barManager1.MainMenu = Me.bar2
			Me.barManager1.MaxItemId = 1
			Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemInplaceDataNavigator1, Me.repositoryItemInplaceDataNavigator2})
			Me.barManager1.StatusBar = Me.bar3
			' 
			' bar1
			' 
			Me.bar1.BarName = "Tools"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem1)})
			Me.bar1.Text = "Tools"
			' 
			' barEditItem1
			' 
			Me.barEditItem1.Caption = "barEditItem1"
			Me.barEditItem1.Edit = Me.repositoryItemInplaceDataNavigator2
			Me.barEditItem1.Id = 0
			Me.barEditItem1.Name = "barEditItem1"
			Me.barEditItem1.Width = 200
			' 
			' repositoryItemInplaceDataNavigator2
			' 
			Me.repositoryItemInplaceDataNavigator2.AutoHeight = False
			Me.repositoryItemInplaceDataNavigator2.Name = "repositoryItemInplaceDataNavigator2"
			' 
			' bar2
			' 
			Me.bar2.BarName = "Main menu"
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 1
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.OptionsBar.MultiLine = True
			Me.bar2.OptionsBar.UseWholeRow = True
			Me.bar2.Text = "Main menu"
			' 
			' bar3
			' 
			Me.bar3.BarName = "Status bar"
			Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar3.DockCol = 0
			Me.bar3.DockRow = 0
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar3.OptionsBar.AllowQuickCustomization = False
			Me.bar3.OptionsBar.DrawDragBorder = False
			Me.bar3.OptionsBar.UseWholeRow = True
			Me.bar3.Text = "Status bar"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(722, 51)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 404)
			Me.barDockControlBottom.Size = New System.Drawing.Size(722, 23)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 51)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 353)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(722, 51)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 353)
			' 
			' repositoryItemInplaceDataNavigator1
			' 
			Me.repositoryItemInplaceDataNavigator1.AutoHeight = False
			Me.repositoryItemInplaceDataNavigator1.Name = "repositoryItemInplaceDataNavigator1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(722, 427)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemInplaceDataNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemInplaceDataNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar1 As DevExpress.XtraBars.Bar
		Private barEditItem1 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemInplaceDataNavigator2 As RepositoryItemInplaceDataNavigator
		Private bar2 As DevExpress.XtraBars.Bar
		Private bar3 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private repositoryItemInplaceDataNavigator1 As RepositoryItemInplaceDataNavigator

	End Class
End Namespace

