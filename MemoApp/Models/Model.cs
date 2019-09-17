using Entities;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoApp.Models
{
    public class Model
    {
        private Business bll = new Business();
        public List<Memo> GetList()
        {
            return bll.GetMemos();
        }
    }
}