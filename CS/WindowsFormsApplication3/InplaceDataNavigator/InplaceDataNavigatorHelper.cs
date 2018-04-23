using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars;

namespace WindowsFormsApplication3
{
    public class InplaceDataNavigatorHelper
    {
        BarEditItem owner { get; set; } //Change owner type if you want to place DataNavigator within another container
        RepositoryItemInplaceDataNavigator repo { get; set; }

        public InplaceDataNavigatorHelper(BarEditItem barItem)
        {
            owner = barItem;

            repo = owner.Edit as RepositoryItemInplaceDataNavigator;
            repo.EditNavigator.PositionChanged += EditNavigator_PositionChanged;
        }
        ~InplaceDataNavigatorHelper()
        {
            repo.EditNavigator.PositionChanged -= EditNavigator_PositionChanged;
            owner = null;
            repo = null;
        }

        void EditNavigator_PositionChanged(object sender, EventArgs e)
        {
            owner.Refresh();
        }
    }
}
