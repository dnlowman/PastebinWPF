using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PastebinNew.ViewModels.Abstract;

namespace PastebinNew.ViewModels.BodyViewModels
{
    class MainBodyViewModel : ChildBaseViewModel
    {
        public MainBodyViewModel(MainWindowViewModel parent) : base(parent)
        {
        }
    }
}