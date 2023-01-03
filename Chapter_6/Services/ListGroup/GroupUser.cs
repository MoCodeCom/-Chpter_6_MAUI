using Chapter_6.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6.Services.ListGroup
{
    public class GroupUser:List<User>
    {
        public string _key { get; private set; }
        public GroupUser(string key, List<User> lst)
        {
            _key = key;
            foreach (var i in lst)
            {
                this.Add(i);
            }
        }
    }
}
