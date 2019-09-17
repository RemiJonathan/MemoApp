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
        public static int LastId = 7;

        public static List<Memo> memos = new List<Memo>()
        {
            new Memo(){Id = 1, Note = "Test1"},
            new Memo(){Id = 2, Note = "Test2"},
            new Memo(){Id = 3, Note = "Test3"},
            new Memo(){Id = 4, Note = "Test4"},
            new Memo(){Id = 5, Note = "Test5"},
            new Memo(){Id = 6, Note = "Test6"},
            new Memo(){Id = 7, Note = "Test7"}
        };
    }
}
