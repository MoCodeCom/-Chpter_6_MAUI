using Chapter_6.Model.Data;
using Chapter_6.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.ViewModel.DependencyInjection.UserImageDI
{
    public class VMUserImage : VMIUserImage
    {
        public List<UserImage> GetAllUserImage()
        {
            List<UserImage> lst = new List<UserImage>();

            lst.Add(new UserImage
            {
                FirstName = "mohammed",
                LastName = "alfadhel",
                Note = "Birmingham",
                PhoneNumber = "1234567890",
                img = "hasanpng.png"
            });

            lst.Add(new UserImage
            {
                FirstName = "ahmed",
                LastName = "alfadhel",
                Note = "Manchester",
                PhoneNumber = "2255114422",
                img = "hasanpng.png"
            });

            lst.Add(new UserImage
            {
                FirstName = "hasan",
                LastName = "alfadhel",
                Note = "Newcastle",
                PhoneNumber = "120000890",
                img = "hasanpng.png"
            });

            lst.Add(new UserImage
            {
                FirstName = "rasha",
                LastName = "almohy",
                Note = "London",
                PhoneNumber = "1234555555",
                img = "hasanpng.png"
            });


            return lst;
        }
    }
}
