using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.ViewInfo;

namespace DataNavigatorInBar
{
    class NavigatorEditPainter : BaseEditPainter
    {
        public NavigatorEditPainter() : base() { }
        public override void Draw(ControlGraphicsInfoArgs info)
        {
            base.Draw(info);

            BaseEditViewInfo vi = info.ViewInfo as BaseEditViewInfo;
            NavigatorEditRepositoryItem cri = vi.Item as NavigatorEditRepositoryItem;
            if (cri.DrawNavigator == null)
                return;
            cri.DrawNavigator.DataSource = vi.EditValue;
            PaintEventArgs e = new PaintEventArgs(info.Graphics, vi.Bounds);
            cri.DrawNavigator.Draw(e);
        }
    }

}
