#region SYSTEM REFERENCES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

#region LOCAL REFERENCES
using PastebinNew.Views.BodyViews;
using PastebinNew.ViewModels.BodyViewModels;
using PastebinNew.ViewModels.Abstract;
using PastebinNew.Commands;
using PastebinNew.Models;
#endregion

namespace PastebinNew.ViewModels
{
    public enum E_BODY_TYPES
    {
        E_BODY_MAIN,
        E_BODY_LOGIN,
    };

    public enum E_APPLICATION_STATE
    {
        E_APPLICATION_USER_LOGGED_IN,
        E_APPLICATION_USER_LOGGED_OUT,
    };
    
    class MainWindowViewModel : BaseViewModel
    {
        #region PROPERTIES / FIELDS
        private ButtonVisibility _signupVisibility;
        public ButtonVisibility SignupVisibility
        {
            get
            {
                return this._signupVisibility;
            }

            set
            {
                this._signupVisibility = value;
                this.NotifyPropertyChanged();
            }
        }
        private ButtonVisibility _welcomeVisibility;
        public ButtonVisibility WelcomeVisibility
        {
            get
            {
                return this._welcomeVisibility;
            }

            set
            {
                this._welcomeVisibility = value;
                this.NotifyPropertyChanged();
            }
        }
        private E_APPLICATION_STATE _currentState;
        private object _currentBodyView;
        private object _currentBodyViewModel;
        public object CurrentBodyView
        {
            get
            {
                return this._currentBodyView;
            }

            set
            {
                this._currentBodyView = value;
                NotifyPropertyChanged();
            }
        }

        private string _loggedText;
        public string LoggedText
        {
            get
            {
                return this._loggedText;
            }

            set
            {
                this._loggedText = value;
                NotifyPropertyChanged();
            }
        }

        private MainBodyView _mainBodyView;
        private MainBodyViewModel _mainBodyViewModel;
        private LoginBodyView _loginBodyView;
        private LoginBodyViewModel _loginBodyViewModel;

        public CommandMap Commands
        {
            get;
            set;
        } 

        #endregion

        #region CONSTRUCTOR
        public MainWindowViewModel()
        {
            this._signupVisibility = new ButtonVisibility();
            this._welcomeVisibility = new ButtonVisibility();
            this.LoggedText = string.Empty;
            this.ChangeApplicationState(E_APPLICATION_STATE.E_APPLICATION_USER_LOGGED_OUT);
            this.Commands = new CommandMap();
            this.Commands.AddCommand("LoginButtonCommand",
                x =>
                {
                    this.ChangeBody(E_BODY_TYPES.E_BODY_LOGIN);
                });
            this.Commands.AddCommand("CreateNewPasteCommand",
                x =>
                {
                    this.ChangeBody(E_BODY_TYPES.E_BODY_MAIN);
                });
            this.Commands.AddCommand("LogoutCommand",
            x =>
            {
                MessageBox.Show(UserSession.Instance.Username);
                this.ChangeApplicationState(E_APPLICATION_STATE.E_APPLICATION_USER_LOGGED_OUT);
                this.ChangeBody(E_BODY_TYPES.E_BODY_MAIN);
            });
            this._mainBodyView = new MainBodyView();
            this._mainBodyViewModel = new MainBodyViewModel(this);
            this._loginBodyView = new LoginBodyView();
            this._loginBodyViewModel = new LoginBodyViewModel(this);
            this.ChangeBody(E_BODY_TYPES.E_BODY_MAIN);
        }
        #endregion

        #region METHODS
        public void ChangeBody(E_BODY_TYPES change)
        {
            switch(change)
            {
                case E_BODY_TYPES.E_BODY_MAIN:
                {
                    this.CurrentBodyView = this._mainBodyView;
                    (this.CurrentBodyView as MainBodyView).DataContext = this._mainBodyViewModel;
                    this._currentBodyViewModel = this._mainBodyViewModel;
                    break;
                }

                case E_BODY_TYPES.E_BODY_LOGIN:
                {
                    this.CurrentBodyView = this._loginBodyView;
                    (this.CurrentBodyView as LoginBodyView).DataContext = this._loginBodyViewModel;
                    this._currentBodyViewModel = this._loginBodyViewModel;
                    break;
                }
            }
        }

        public void ChangeApplicationState(E_APPLICATION_STATE state)
        {
            switch(state)
            {
                case E_APPLICATION_STATE.E_APPLICATION_USER_LOGGED_OUT:
                {
                    this.LoggedText = "You are currently logged out!";
                    this.SignupVisibility.Visibility = "Visible";
                    this.WelcomeVisibility.Visibility = "Hidden";
                    break;
                }

                case E_APPLICATION_STATE.E_APPLICATION_USER_LOGGED_IN:
                {
                    this.LoggedText = "You are logged in!";
                    this.SignupVisibility.Visibility = "Hidden";
                    this.WelcomeVisibility.Visibility = "Visible";
                    break;
                }
            }
        }
        #endregion
    }
}