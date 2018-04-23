using System;
using System.Collections.Generic;
using System.ComponentModel;

using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using System.Windows.Forms;
using DevExpress.XtraEditors.ViewInfo;

namespace DataNavigatorInBar
{
    [UserRepositoryItem("Register")]
    class NavigatorEditRepositoryItem:RepositoryItem
    {
        MyDataNavigator _drawNavigator;
        public MyDataNavigator DrawNavigator
        {
            get { return _drawNavigator;}
            set { _drawNavigator = value;}
        }
        MyDataNavigator _editorNavigator;
        public MyDataNavigator EditorNavigator
        {
            get { return _editorNavigator; }
            set { _editorNavigator = value; }
        }

        static NavigatorEditRepositoryItem()
        {
            Register();
        }
        public NavigatorEditRepositoryItem() :base()
        {
            _drawNavigator = new MyDataNavigator();
            _drawNavigator.Dock = DockStyle.Fill;
            _editorNavigator = new MyDataNavigator();
            _editorNavigator.Dock = DockStyle.Fill;
            _drawNavigator.BindingContext = new BindingContext();

        }
        internal const string EditorName = "DataNavigatorEdit";

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(NavigatorEdit),
                typeof(NavigatorEditRepositoryItem), typeof(BaseEditViewInfo),
                new NavigatorEditPainter(), true));
        }
        public override string EditorTypeName
        {
            get { return EditorName; }
        }
    }

}
