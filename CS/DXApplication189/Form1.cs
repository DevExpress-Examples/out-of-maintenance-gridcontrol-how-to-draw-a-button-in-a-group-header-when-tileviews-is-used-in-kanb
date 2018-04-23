using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraGrid.Views.Tile.ViewInfo;

namespace DXApplication189 {
    public partial class Form1 : RibbonForm {
        public Form1() {
            InitializeComponent();
            TileViewDrawButtonHelper helper = new TileViewDrawButtonHelper(tileView1) { ButtonCaption = "Add task"};
            helper.GroupButtonClick += Helper_GroupButtonClick;
        }

        private void Helper_GroupButtonClick(object sender, GroupButtonClickEventArgs args) {
            MessageBox.Show(args.Group.Group.Text);
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);
        }
    }


}
