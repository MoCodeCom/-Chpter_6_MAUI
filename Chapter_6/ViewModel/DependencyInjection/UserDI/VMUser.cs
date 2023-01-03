using Chapter_6.Model.Data;
using Chapter_6.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.ViewModel.DependencyInjection.UserDI
{
    public class VMUser : VMIUser<User>
    {
        public List<User> GetAllUser()
        {
            List<User> lst = new List<User>();

            lst.Add( new User
            {
                FirstName = "mohammed",
                LastName = "alfadhel",
                Note = "Birmingham",
                PhoneNumber = "1234567890",
            });

            lst.Add(new User
            {
                FirstName = "ahmed",
                LastName = "alfadhel",
                Note = "Manchester",
                PhoneNumber = "2255114422",
            });

            lst.Add(new User
            {
                FirstName = "hasan",
                LastName = "alfadhel",
                Note = "Newcastle",
                PhoneNumber = "120000890",
            });

            lst.Add(new User
            {
                FirstName = "rasha",
                LastName = "almohy",
                Note = "London",
                PhoneNumber = "1234555555",
            });


            return lst;
        }
    }
}
