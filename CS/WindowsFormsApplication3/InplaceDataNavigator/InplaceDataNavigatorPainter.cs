using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public class InplaceDataNavigatorPainter : BaseEditPainter
    {
        public override void Draw(ControlGraphicsInfoArgs info)
        {
            base.Draw(info);
            BaseEditViewInfo vi = info.ViewInfo as BaseEditViewInfo;
            RepositoryItemInplaceDataNavigator cri = vi.Item as RepositoryItemInplaceDataNavigator;
            PaintEventArgs e = new PaintEventArgs(info.Graphics, vi.Bounds);      
            cri.EditNavigator.Draw(e);            
        }
    }
}
