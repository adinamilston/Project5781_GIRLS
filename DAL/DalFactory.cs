using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace DALApi
{
    public class DalFactory
    {
        public static IDal getDal()
        {
            return DalObject.Instance;
        }

    }
}
