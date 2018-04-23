Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraGrid.Views.Tile.ViewInfo

Namespace DXApplication189
    Partial Public Class Form1
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
            Dim helper As New TileViewDrawButtonHelper(tileView1) With {.ButtonCaption = "Add task"}
            AddHandler helper.GroupButtonClick, AddressOf Helper_GroupButtonClick
        End Sub

        Private Sub Helper_GroupButtonClick(ByVal sender As Object, ByVal args As GroupButtonClickEventArgs)
            MessageBox.Show(args.Group.Group.Text)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            Me.customersTableAdapter.Fill(Me.nwindDataSet.Customers)
        End Sub
    End Class


End Namespace
