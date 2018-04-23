using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace WindowsFormsApplication3
{
    [System.ComponentModel.DesignerCategory("")]
    public class InplaceDataNavigator : BaseEdit
    {
        static InplaceDataNavigator() { RepositoryItemInplaceDataNavigator.Register(); }
        public InplaceDataNavigator()
            :base()
        {
            Bounds = new Rectangle(Location,new Size(200,20));
            Controls.Add(Properties.EditNavigator);
        }

        public override string EditorTypeName
        {
            get { return RepositoryItemInplaceDataNavigator.EditorName; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemInplaceDataNavigator Properties
        {
            get { return base.Properties as RepositoryItemInplaceDataNavigator; }
        }
    }
}
