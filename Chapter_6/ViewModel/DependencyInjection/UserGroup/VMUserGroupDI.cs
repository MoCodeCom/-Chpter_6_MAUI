using Chapter_6.Services.ListGroup;
using Chapter_6.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.ViewModel.DependencyInjection.UserGroup
{
    public class VMUserGroupDI
    {
        public VMIUser<GroupUser> _user { get; set; }
        public VMUserGroupDI()
        {
            _user = new VMUserGroup();
        }
    }
}
