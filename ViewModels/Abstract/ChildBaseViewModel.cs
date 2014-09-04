#region SYSTEM REFERENCES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace PastebinNew.ViewModels.Abstract
{
    abstract class ChildBaseViewModel : BaseViewModel
    {
        #region PROPERTIES / FIELDS
        protected MainWindowViewModel ParentViewModel
        {
            get;
            set;
        }
        #endregion

        #region CONSTRUCTOR
        protected ChildBaseViewModel(MainWindowViewModel parent)
        {
            this.ParentViewModel = parent;
        }
        #endregion
    }
}
