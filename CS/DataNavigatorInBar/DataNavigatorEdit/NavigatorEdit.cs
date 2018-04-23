using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace DataNavigatorInBar
{
    class NavigatorEdit : BaseEdit
    {
        static NavigatorEdit()
        {
            NavigatorEditRepositoryItem.Register();
        }
        public NavigatorEdit()
            : base()
        {
            Controls.Add(Properties.EditorNavigator);
        }
        public override string EditorTypeName
        {
            get { return NavigatorEditRepositoryItem.EditorName; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new NavigatorEditRepositoryItem Properties
        {
            get { return base.Properties as NavigatorEditRepositoryItem; }
        }
        public override object EditValue
        {
            get
            {
                return base.EditValue;
            }
            set
            {
                base.EditValue = value;
                Properties.EditorNavigator.DataSource = value;
            }
        }
    }

}
