
using Chapter_6.Model.Data;
using Chapter_6.Services.ListGroup;
using Chapter_6.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.ViewModel.DependencyInjection.UserGroup
{
    public class VMUserGroup : VMIUser<GroupUser>
    {
        public List<GroupUser> GetAllUser()
        {
            List<GroupUser> li = new List<GroupUser>();
            li.Add(new GroupUser("Important", new List<User>
            {
                new User{ FirstName="Mohammed", LastName="Alfa", Note="West-midland", PhoneNumber="07460"},
                new User{ FirstName="Ahmed", LastName="Alfa", Note="North-midland", PhoneNumber="07430"},
                new User{ FirstName="Hasan", LastName="Alfa", Note="South-midland", PhoneNumber="07450"},
                new User{ FirstName="Rasha", LastName="Almoh", Note="East-midland", PhoneNumber="07480"}
            }));
            li.Add(new GroupUser("Not-Important", new List<User>
            {
                new User{ FirstName="Ali", LastName="Jahor", Note="Liverpool", PhoneNumber="07560"},
                new User{ FirstName="Majed", LastName="Hussaini", Note="Leeds", PhoneNumber="07530"},
            }));

            return li;
        }
    }
}
