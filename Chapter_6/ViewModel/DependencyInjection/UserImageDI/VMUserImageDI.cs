using Chapter_6.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.ViewModel.DependencyInjection.UserImageDI
{
    public class VMUserImageDI
    {
        public VMIUserImage _userImage { get; set; }
        public VMUserImageDI() 
        {
            _userImage = new VMUserImage();
        }
    }
}
