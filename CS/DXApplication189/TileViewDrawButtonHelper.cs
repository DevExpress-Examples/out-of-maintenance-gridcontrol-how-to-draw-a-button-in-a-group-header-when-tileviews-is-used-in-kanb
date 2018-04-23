using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraGrid.Views.Tile.ViewInfo;

namespace DXApplication189 {
    public class TileViewDrawButtonHelper : IDisposable {
        TileView _view;
        public event GroupEventHandler GroupButtonClick;
        public delegate void GroupEventHandler(object sender, GroupButtonClickEventArgs args);
        public string ButtonCaption { get; set; }
        public TileViewDrawButtonHelper(TileView view) {
            _view = view;
            SubscribeToEvents();
        }

        private void SubscribeToEvents() {
            _view.MouseDown += OnMouseDown;
            _view.GridControl.Paint += OnGridPaint;
        }

        private void UnSubscribeFromEvents() {
            _view.MouseDown -= OnMouseDown;
            _view.GridControl.Paint -= OnGridPaint;
        }

        private void OnGridPaint(object sender, PaintEventArgs e) {
            var vInfo = _view.GetViewInfo();
            DrawButtons((vInfo as ITileControl).ViewInfo, e);
        }

        private void OnMouseDown(object sender, MouseEventArgs e) {
            var hitInfo = (sender as TileView).CalcHitInfo(e.Location);
            if (hitInfo.GroupInfo != null) {
                Rectangle rect = GetButtonRectangle(hitInfo.GroupInfo);
                if (rect.Contains(_view.GridControl.PointToClient(Cursor.Position))) {
                    RaiseGroupButtonClick(hitInfo.GroupInfo);
                }
            }
        }

        private void RaiseGroupButtonClick(TileViewGroupInfo groupInfo) {
            if (GroupButtonClick != null)
                GroupButtonClick(this, new GroupButtonClickEventArgs(groupInfo));
        }

        private void DrawButtons(TileControlViewInfo viewInfo, PaintEventArgs e) {
            foreach (TileGroupViewInfo group in viewInfo.Groups) {
                Rectangle rect = GetButtonRectangle(group);
                using (GraphicsCache cache = new GraphicsCache(e)) {
                    var element = SkinManager.GetSkinElement(SkinProductId.Common, UserLookAndFeel.Default, CommonSkins.SkinButton);
                    var info = new SkinElementInfo(element, rect);
                    ObjectPainter.DrawObject(cache, SkinElementPainter.Default, info);
                    viewInfo.PaintAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    viewInfo.PaintAppearance.DrawString(cache, ButtonCaption, rect);
                }
            }
        }
        Rectangle GetButtonRectangle(TileGroupViewInfo groupInfo) {
            Rectangle rect = groupInfo.TotalBounds;
            rect.Width = 50;
            rect.Height = groupInfo.TextBounds.Height;
            rect.Offset(groupInfo.TotalBounds.Width - rect.Width - 2, 2);
            return rect;
        }

        public void Dispose() {
            UnSubscribeFromEvents();
            _view = null;
        }
    }

    public class GroupButtonClickEventArgs {
        public GroupButtonClickEventArgs(TileGroupViewInfo group) {
            Group = group;
        }
        public TileGroupViewInfo Group { get; private set; }
    }
}
