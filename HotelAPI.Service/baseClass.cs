using HotelAPI.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Service
{
    public class baseClass
    {
        protected readonly AppDBContext _appDBContext;
        public baseClass(AppDBContext appDBCONTEXT)
        {
            _appDBContext = appDBCONTEXT;
        }
    }
}
