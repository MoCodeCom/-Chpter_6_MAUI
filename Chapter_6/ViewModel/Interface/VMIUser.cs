using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter_6.Model.Data;

namespace Chapter_6.ViewModel.Interface
{
    public interface VMIUser<T>
    {
        List<T> GetAllUser();
    }
}
