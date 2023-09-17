using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Service
{
    static class IdGenerator
    {
        private static int _nextId = 1;

        public static int GetNextId()
        {
            return _nextId++;
        }
    }
}
