Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraGrid.Views.Tile.ViewInfo

Namespace DXApplication189
    Public Class TileViewDrawButtonHelper
        Implements IDisposable

        Private _view As TileView
        Public Event GroupButtonClick As GroupEventHandler
        Public Delegate Sub GroupEventHandler(ByVal sender As Object, ByVal args As GroupButtonClickEventArgs)
        Public Property ButtonCaption() As String
        Public Sub New(ByVal view As TileView)
            _view = view
            SubscribeToEvents()
        End Sub

        Private Sub SubscribeToEvents()
            AddHandler _view.MouseDown, AddressOf OnMouseDown
            AddHandler _view.GridControl.Paint, AddressOf OnGridPaint
        End Sub

        Private Sub UnSubscribeFromEvents()
            RemoveHandler _view.MouseDown, AddressOf OnMouseDown
            RemoveHandler _view.GridControl.Paint, AddressOf OnGridPaint
        End Sub

        Private Sub OnGridPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
            Dim vInfo = _view.GetViewInfo()
            DrawButtons((TryCast(vInfo, ITileControl)).ViewInfo, e)
        End Sub

        Private Sub OnMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hitInfo = (TryCast(sender, TileView)).CalcHitInfo(e.Location)
            If hitInfo.GroupInfo IsNot Nothing Then
                Dim rect As Rectangle = GetButtonRectangle(hitInfo.GroupInfo)
                If rect.Contains(_view.GridControl.PointToClient(Cursor.Position)) Then
                    RaiseGroupButtonClick(hitInfo.GroupInfo)
                End If
            End If
        End Sub

        Private Sub RaiseGroupButtonClick(ByVal groupInfo As TileViewGroupInfo)
            RaiseEvent GroupButtonClick(Me, New GroupButtonClickEventArgs(groupInfo))
        End Sub

        Private Sub DrawButtons(ByVal viewInfo As TileControlViewInfo, ByVal e As PaintEventArgs)
            For Each group As TileGroupViewInfo In viewInfo.Groups
                Dim rect As Rectangle = GetButtonRectangle(group)
                Using cache As New GraphicsCache(e)
                    Dim element = SkinManager.GetSkinElement(SkinProductId.Common, UserLookAndFeel.Default, CommonSkins.SkinButton)
                    Dim info = New SkinElementInfo(element, rect)
                    ObjectPainter.DrawObject(cache, SkinElementPainter.Default, info)
                    viewInfo.PaintAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    viewInfo.PaintAppearance.DrawString(cache, ButtonCaption, rect)
                End Using
            Next group
        End Sub
        Private Function GetButtonRectangle(ByVal groupInfo As TileGroupViewInfo) As Rectangle
            Dim rect As Rectangle = groupInfo.TotalBounds
            rect.Width = 50
            rect.Height = groupInfo.TextBounds.Height
            rect.Offset(groupInfo.TotalBounds.Width - rect.Width - 2, 2)
            Return rect
        End Function

        Public Sub Dispose() Implements IDisposable.Dispose
            UnSubscribeFromEvents()
            _view = Nothing
        End Sub
    End Class

    Public Class GroupButtonClickEventArgs
        Public Sub New(ByVal group As TileGroupViewInfo)
            Me.Group = group
        End Sub
        Private privateGroup As TileGroupViewInfo
        Public Property Group() As TileGroupViewInfo
            Get
                Return privateGroup
            End Get
            Private Set(ByVal value As TileGroupViewInfo)
                privateGroup = value
            End Set
        End Property
    End Class
End Namespace
