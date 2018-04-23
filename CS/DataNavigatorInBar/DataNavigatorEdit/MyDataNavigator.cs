using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using System.Drawing;
using DevExpress.XtraEditors.Drawing;

namespace DataNavigatorInBar
{
    public class MyDataNavigator : DataNavigator
    {
        public void Draw(PaintEventArgs e)
        {
            (ViewInfo as MyNavigatorControlViewInfo).CalcViewInfo(e.Graphics, MouseButtons.None, new Point(-6000, -6000), e.ClipRectangle);
            GraphicsCache cache = new GraphicsCache(new DXPaintEventArgs(e));
            try
            {
                ControlGraphicsInfoArgs info = new ControlGraphicsInfoArgs(ViewInfo, cache, ViewInfo.Bounds);
                ISupportGlassRegions reg = Parent as ISupportGlassRegions;
                if (reg != null)
                {
                    info.IsDrawOnGlass = reg.IsOnGlass(Parent.RectangleToClient(RectangleToScreen(ViewInfo.Bounds)));
                }
                Painter.Draw(info);
                RaisePaintEvent(this, e);
            }
            finally
            {
                cache.Dispose();
            }

        }
        protected override BaseStyleControlViewInfo CreateViewInfo()
        {
            return new MyNavigatorControlViewInfo(this);
        }
    }
    class MyNavigatorControlViewInfo : NavigatorControlViewInfo
    {
        public MyNavigatorControlViewInfo(BaseStyleControl owner) : base(owner) { }

        public new void CalcViewInfo(Graphics g, MouseButtons buttons, Point p, Rectangle rec)
        {
            base.CalcViewInfo(g, buttons, p, rec);
            this.Bounds = rec;
            CalcRects();
        }
    }

}
