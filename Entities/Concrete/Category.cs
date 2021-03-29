using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // Çıplak Class Kalmasın // implamentasyon alacak // varlıklarımızı işaretleriz. Gruplarız.
    // Bunlar bir veritabanı tablosuna karşılık geliyor.
    public class Category:IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
