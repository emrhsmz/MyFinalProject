using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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

        public static string AuthorizationDenied = "Yetkiniz bulunmamaktadır.";

        public static string UserRegistered ="Kullanıcı Oluşturuldu";
        public static string UserNotFound ="Kullanıcı bulunamadı";
        public static string PasswordError ="Parola Hatalı";
        public static string SuccessfullLogin ="Giriş Başarılı";
        public static string UserAlreadyExists = "Email daha önce eklenmiştir.";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted ="Kullanıcı Silidni";
        public static string UsersListed = "Kullanıcı listelendi";
        public static string UserUpdated = "Kullanıcı güncellendi";

        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
