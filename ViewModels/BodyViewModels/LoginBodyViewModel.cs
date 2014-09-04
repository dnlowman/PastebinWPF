using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

using PastebinNew.ViewModels.Abstract;
using PastebinNew.Commands;
using PastebinNew.Models;

namespace PastebinNew.ViewModels.BodyViewModels
{
    class LoginBodyViewModel : ChildBaseViewModel
    {
        public CommandMap Commands
        {
            get;
            set;
        }

        public PastebinAPI Pastebin
        {
            get;
            set;
        }

        public string Username
        {

        }
        
        public LoginBodyViewModel(MainWindowViewModel parent) : base(parent)
        {
            this.Pastebin = new PastebinAPI();
            this.Commands = new CommandMap();
            this.Commands.AddCommand("SubmitCommand",
                x =>
                {
                    try
                    {
                        MessageBox.Show(UserSession.Instance.Username);
                        UserSession.Instance.UserAuthKey = this.Paste
                        bin.Login(UserSession.Instance.Username, (x as PasswordBox).Password);
                        this.ParentViewModel.ChangeBody(E_BODY_TYPES.E_BODY_MAIN);
                        this.ParentViewModel.ChangeApplicationState(E_APPLICATION_STATE.E_APPLICATION_USER_LOGGED_IN);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Wrong Login!");
                    }
                });
        }
    }
}
