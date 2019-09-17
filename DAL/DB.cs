using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DB
    {
        public static int LastId = 0;

        public static List<Memo> memos = new List<Memo>();
    }
}
