using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastebinNew.Models
{
    class User
    {
        public string Username
        {
            get;
            set;
        }

        public string UserAuthKey
        {
            get;
            set;
        }

        public bool IsLoggedIn
        {
            get;
            set;
        }
        
        
        public User()
        {
            this.IsLoggedIn = false;
            this.UserAuthKey = string.Empty;
            this.Username = string.Empty;
        }
    }
}
