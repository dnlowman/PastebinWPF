using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PastebinNew.Models
{
    class ButtonVisibility : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        private string _visibility;
        public string Visibility
        {
            get
            {
                return this._visibility;
            }

            set
            {
                this._visibility = value;
                NotifyPropertyChanged();
            }
        }
        
        public ButtonVisibility()
        {
            this.Visibility = "Visible";
        }
    }
}
