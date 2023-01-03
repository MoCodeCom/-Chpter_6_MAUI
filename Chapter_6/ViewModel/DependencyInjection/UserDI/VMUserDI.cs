using Chapter_6.Model.Data;
using Chapter_6.Model.Interface;
using Chapter_6.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Xamarin.Google.Crypto.Tink.Proto;

namespace Chapter_6.ViewModel.DependencyInjection.UserDI
{
    public class VMUserDI
    {
        public VMIUser<User> _user { get; set; }
        public VMUserDI()
        {
            _user = new VMUser();
        }
    }
}
