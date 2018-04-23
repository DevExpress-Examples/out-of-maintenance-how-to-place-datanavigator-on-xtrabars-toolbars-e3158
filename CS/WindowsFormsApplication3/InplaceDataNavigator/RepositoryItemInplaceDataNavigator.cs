using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    [System.ComponentModel.DesignerCategory("")]
    [UserRepositoryItem("Register")]
    public class RepositoryItemInplaceDataNavigator : RepositoryItem
    {
        private MyDataNavigator _editNavigator;
        public MyDataNavigator EditNavigator
        {
            get { return _editNavigator; }
            set { _editNavigator = value; }
        }

        internal const string EditorName = "InplaceDataNavigator";

        static RepositoryItemInplaceDataNavigator() { Register(); }
        public RepositoryItemInplaceDataNavigator()
        {
            AutoHeight = false;            
            EditNavigator = new MyDataNavigator();
            EditNavigator.Dock = DockStyle.Fill;
            EditNavigator.BindingContext = new BindingContext();
        }

        ~RepositoryItemInplaceDataNavigator()
        {
            EditNavigator.Dispose();
        }

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(InplaceDataNavigator),
                typeof(RepositoryItemInplaceDataNavigator), typeof(BaseEditViewInfo),
                new InplaceDataNavigatorPainter(), true));
        }

        public override string EditorTypeName
        {
            get { return EditorName; }
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemInplaceDataNavigator source = item as RepositoryItemInplaceDataNavigator;
                if (source == null) return;
                EditNavigator.DataSource = source.EditNavigator.DataSource;
            }
            finally
            {
                EndUpdate();
            }
        }
    }
}
