using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CarAdded = "Ürün eklendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        public static string ColorsListed = "ürünler listelendi";
        public static string CarInvalidName = "İsim geçersiz";
        public static string CarRental = "Araç Kiralandı";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string CarImageAdded = "Görüntü eklendi";
        public static string CarImageDeletedSuccess = "Silme işlemi başarılı";
        public static string CarImageDeletedError = "Silme işlemi başarısız";
        public static string CarsListed = "Araçlar listelendi";
        public static string BrandsListed = "Modeller listelendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string RentalListed = "    ";
      

        public static string UserListed ="Kullanıcılar listelendi" ;

        public static string Listed { get; internal set; }
    }
}
