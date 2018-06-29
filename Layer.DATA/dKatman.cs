using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Layer.DATA
{
    public class dKatman
    {
        public List<Employees> calisanListesi()
        {
            CalisanEntities em = new CalisanEntities();

            return em.Employees.ToList();
        }

    }
}