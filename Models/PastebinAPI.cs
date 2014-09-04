using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;
using System.Diagnostics;

using PastebinNew.Common;

namespace PastebinNew.Models
{   
    public class PastebinAPI
    {
        
        public Dictionary<string, string> langCodes = new Dictionary<string, string>
        {
            {"PHP", "php"},
        };

        public Dictionary<string, string> expiration = new Dictionary<string, string>
        {
            {"10 minutes", "10M"},
            {"1 hour", "1H"},
            {"1 day", "1D"},
            {"1 week", "1W"},
            {"2 weeks", "2W"},
            {"1 months", "1M"},
        };

        public Dictionary<string, string> exposure = new Dictionary<string, string>
        {
            {"Public", "0"},
            {"Unlisted", "1"},
            {"Private", "2"},
        };

        private List<string> _userErrorResponses;
        
        public PastebinAPI()
        {
            _userErrorResponses = new List<string>();
            _userErrorResponses.Add("Bad API request, use POST request, not GET");
            _userErrorResponses.Add("Bad API request, invalid api_dev_key");
            _userErrorResponses.Add("Bad API request, invalid login");
            _userErrorResponses.Add("Bad API request, account not active");
            _userErrorResponses.Add("Bad API request, invalid POST parameters");
        }

        public string Paste(string pasteText, string exposure, string pasteName, string pasteExpire, string pasteFormat, string pasteUserKey = "")
        {
            using(var web = new WebClient())
            {
                var data = new NameValueCollection();
                data["api_option"] = "paste";
                data["api_user_key"] = pasteUserKey;
                data["api_paste_private"] = exposure;
                data["api_paste_name"] = pasteName;
                data["api_paste_expire_date"] = pasteExpire;
                data["api_paste_format"] = pasteFormat;
                data["api_dev_key"] = Constants.PASTEBIN_API_DEV_KEY;
                data["api_paste_code"] = pasteText;
                var response = web.UploadValues(Constants.PASTEBIN_API_URL, Constants.PASTEBIN_HTTP_METHOD_POST, data);
                return System.Text.Encoding.UTF8.GetString(response);
            }
        }

        public string Login(string username, string password)
        {
            using (var web = new WebClient())
            {
                var _data = new NameValueCollection();
                _data["api_dev_key"] = Constants.PASTEBIN_API_DEV_KEY;
                _data["api_user_name"] = username;
                _data["api_user_password"] = password;
                var _response = System.Text.Encoding.UTF8.GetString(web.UploadValues(Constants.PASTEBIN_USER_API_URL, Constants.PASTEBIN_HTTP_METHOD_POST, _data));
                foreach(string response in _userErrorResponses)
                {
                    if (response == _response) throw new Exception("Bad Login Request!");
                }
                return _response;
            }
        }
    }
}
