using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {

        public static string MaintenanceTime = "Sistem kapalıdır";

        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductsDeleted = "Ürün Silindi";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";

        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";

        public static string CategoriesListed="Kategoriler listelendi";
        public static string CategoryAdded="Kategori eklendi";
        public static string CategoryUpdated="Kategori güncellend";
        public static string CategoryDeleted="Kategori Silindi";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
