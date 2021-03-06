﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        internal static readonly string findexPointMax = "Findex puanınız 1900";
        internal static readonly string findexPointAdd = "20 findex puanı eklendi";
        public static string CarAdded = "Ürün eklendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        public static string ColorsListed = "ürünler listelendi";

        public static string CarInvalidName = " Araç isimi geçersiz";
        public static string CarRental = "Araç Kiralandı";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string CarImageAdded = "Görüntü eklendi";

        public static string CarImageDeletedSuccess = "Silme işlemi başarılı";
        public static string CarImageDeletedError = "Silme işlemi başarısız";

        public static string CarsListed = "Araçlar listelendi";
        public static string BrandsListed = "Modeller listelendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string RentalListed = "Kiralamalar Listelendi";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string Listed = "Listelendi";

        public static string SuccessAdded = "Ekleme başarılı";
        public static string SuccessDeleted = "Silme başarılı";
        public static string SuccessListed = "Listeleme başarılı";

        public static string CarImageLimitExceeded = "Maksimum resim ekleme sınırına ulaşıldı(5)";

        public static string CarImageUpdated = "Resim güncellendi";
        public static string SuccessUpdated = "Güncelleme başarılı";
        public static string SuccessfullyPaid = "Ödeme başarılı";

        public static string CardAdded = "Kart eklendi";
        public static string CarDeleted = "Araç silindi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";

        public static string SuccessUpdateUser = "Kullanıcı güncellendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";

        public static string BrandUpdated = "Marka Güncellendi";
        public static string NameInvalid = " İsim geçersiz";

        public static string PasswordInvalid = " Şifre geçersiz";
        public static string SurnameInvalid = " LastName geçersiz";
        public static string EmailInvalid = " Email geçersiz";
    }
}