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
        internal static string CarsListed = "ürünler listelendi";


        public static string CarInvalidName = "İsim geçersiz";

        public static string CarRental = "Araç Kiralandı";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string CarImageAdded = "Görüntü eklendi";

        public static string CarImageDeletedSuccess = "Silme işlemi başarılı";//buraya böyle ezım bazı  şimdi anladım   
        public static string CarImageDeletedError = "Silme işlemi başarısız";

    }
}
