﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class DataBase
    {
        private static Entities _context;
        public static Entities GetEntities()
        {
            if (_context == null)
                _context = new Entities();
            return _context;
        }
    }
}
