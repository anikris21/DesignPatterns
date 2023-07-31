using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class UserManager
    {
        private UserManager() {
            st = "user manager loaded";
        }
        public string st;
        
        private static readonly Lazy<UserManager> instance = new Lazy<UserManager>(() => { return new UserManager(); });
        public static UserManager Instance => instance.Value;
    }
}
