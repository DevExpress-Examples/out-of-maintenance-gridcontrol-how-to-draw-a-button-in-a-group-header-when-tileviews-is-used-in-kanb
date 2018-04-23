Namespace DXApplication189
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
            Dim tileViewItemElement1 As New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement2 As New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement3 As New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colCompanyName = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colContactName = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New DXApplication189.nwindDataSet()
            Me.tileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.colContactTitle = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colAddress = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colCity = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colRegion = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colPostalCode = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colCountry = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colPhone = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colFax = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.skinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.rpgSkins = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.customersTableAdapter = New DXApplication189.nwindDataSetTableAdapters.CustomersTableAdapter()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tileView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colCustomerID
            ' 
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            Me.colCustomerID.Visible = True
            Me.colCustomerID.VisibleIndex = 0
            ' 
            ' colCompanyName
            ' 
            Me.colCompanyName.FieldName = "CompanyName"
            Me.colCompanyName.Name = "colCompanyName"
            Me.colCompanyName.Visible = True
            Me.colCompanyName.VisibleIndex = 1
            ' 
            ' colContactName
            ' 
            Me.colContactName.FieldName = "ContactName"
            Me.colContactName.Name = "colContactName"
            Me.colContactName.Visible = True
            Me.colContactName.VisibleIndex = 2
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.customersBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 143)
            Me.gridControl1.MainView = Me.tileView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(905, 348)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.tileView1})
            ' 
            ' customersBindingSource
            ' 
            Me.customersBindingSource.DataMember = "Customers"
            Me.customersBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' tileView1
            ' 
            Me.tileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colPhone, Me.colFax})
            Me.tileView1.ColumnSet.GroupColumn = Me.colCity
            Me.tileView1.GridControl = Me.gridControl1
            Me.tileView1.Name = "tileView1"
            Me.tileView1.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban
            Me.tileView1.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
            Me.tileView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCity, DevExpress.Data.ColumnSortOrder.Ascending)})
            tileViewItemElement1.Column = Me.colCustomerID
            tileViewItemElement1.Text = "colCustomerID"
            tileViewItemElement2.Column = Me.colCompanyName
            tileViewItemElement2.Text = "colCompanyName"
            tileViewItemElement3.Column = Me.colContactName
            tileViewItemElement3.Text = "colContactName"
            Me.tileView1.TileTemplate.Add(tileViewItemElement1)
            Me.tileView1.TileTemplate.Add(tileViewItemElement2)
            Me.tileView1.TileTemplate.Add(tileViewItemElement3)
            ' 
            ' colContactTitle
            ' 
            Me.colContactTitle.FieldName = "ContactTitle"
            Me.colContactTitle.Name = "colContactTitle"
            Me.colContactTitle.Visible = True
            Me.colContactTitle.VisibleIndex = 3
            ' 
            ' colAddress
            ' 
            Me.colAddress.FieldName = "Address"
            Me.colAddress.Name = "colAddress"
            Me.colAddress.Visible = True
            Me.colAddress.VisibleIndex = 4
            ' 
            ' colCity
            ' 
            Me.colCity.FieldName = "City"
            Me.colCity.Name = "colCity"
            Me.colCity.Visible = True
            Me.colCity.VisibleIndex = 5
            ' 
            ' colRegion
            ' 
            Me.colRegion.FieldName = "Region"
            Me.colRegion.Name = "colRegion"
            Me.colRegion.Visible = True
            Me.colRegion.VisibleIndex = 6
            ' 
            ' colPostalCode
            ' 
            Me.colPostalCode.FieldName = "PostalCode"
            Me.colPostalCode.Name = "colPostalCode"
            Me.colPostalCode.Visible = True
            Me.colPostalCode.VisibleIndex = 7
            ' 
            ' colCountry
            ' 
            Me.colCountry.FieldName = "Country"
            Me.colCountry.Name = "colCountry"
            Me.colCountry.Visible = True
            Me.colCountry.VisibleIndex = 8
            ' 
            ' colPhone
            ' 
            Me.colPhone.FieldName = "Phone"
            Me.colPhone.Name = "colPhone"
            Me.colPhone.Visible = True
            Me.colPhone.VisibleIndex = 9
            ' 
            ' colFax
            ' 
            Me.colFax.FieldName = "Fax"
            Me.colFax.Name = "colFax"
            Me.colFax.Visible = True
            Me.colFax.VisibleIndex = 10
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.skinRibbonGalleryBarItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 2
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl1.Size = New System.Drawing.Size(905, 143)
            ' 
            ' skinRibbonGalleryBarItem1
            ' 
            Me.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1"
            Me.skinRibbonGalleryBarItem1.Id = 1
            Me.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1"
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.rpgSkins})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "ribbonPage1"
            ' 
            ' rpgSkins
            ' 
            Me.rpgSkins.ItemLinks.Add(Me.skinRibbonGalleryBarItem1)
            Me.rpgSkins.Name = "rpgSkins"
            Me.rpgSkins.Text = "Skins"
            ' 
            ' customersTableAdapter
            ' 
            Me.customersTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(905, 491)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Form1"
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tileView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private rpgSkins As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private skinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
        Private tileView1 As DevExpress.XtraGrid.Views.Tile.TileView
        Private nwindDataSet As nwindDataSet
        Private customersBindingSource As System.Windows.Forms.BindingSource
        Private customersTableAdapter As nwindDataSetTableAdapters.CustomersTableAdapter
        Private colCustomerID As DevExpress.XtraGrid.Columns.TileViewColumn
        Private colCompanyName As DevExpress.XtraGrid.Columns.TileViewColumn
        Private colContactName As DevExpress.XtraGrid.Columns.TileViewColumn
        Private colContactTitle As DevExpress.XtraGrid.Columns.TileViewColumn
        Private colAddress As DevExpress.XtraGrid.Columns.TileViewColumn
        Private colCity As DevExpress.XtraGrid.Columns.TileViewColumn
        Private colRegion As DevExpress.XtraGrid.Columns.TileViewColumn
        Private colPostalCode As DevExpress.XtraGrid.Columns.TileViewColumn
        Private colCountry As DevExpress.XtraGrid.Columns.TileViewColumn
        Private colPhone As DevExpress.XtraGrid.Columns.TileViewColumn
        Private colFax As DevExpress.XtraGrid.Columns.TileViewColumn
    End Class
End Namespace
