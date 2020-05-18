using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    public class CustomerData
    {
        private readonly ISqlDataAccess _db;

        public CustomerData(ISqlDataAccess db)
        {
            _db = db;
        }
    }
}
