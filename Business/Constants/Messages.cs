﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string[] ValidImageFileTypes = { ".JPG", ".JPEG", ".PNG", ".TIF", ".TIFF", ".GIF", ".BMP", ".ICO" };

        public static string CarAdded = "Ürün eklendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Ürünler listelendi";
        public static string CarDeleted = "Ürün silindi";
        public static string CarUpdeted = "Ürün güncellendi";
        public static string BrandUpdeted = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInvalid = "Ürün ismi geçersiz ";
        public static string ColorUpdeted = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz ";
        public static string NameProperty = "2 karakterden fazla giriniz ";
        public static string CustomerUpdeted = "Müşteri güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string UserUpdeted = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string RentalUpdeted = "Kiralama güncellendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalAdded = "Kiralama eklendi";
        public static string ImageLimitExpiredForCar = "5ten fazla fotoğraf ekleyemezsiniz";


        public static string InvalidImageExtension = "Geçersiz dosya uzantısı, fotoğraf için kabul edilen uzantılar" + string.Join(",", ValidImageFileTypes);

        public static string CarImageMustBeExists = "Resim bulunamadı";
        public static string AuthorizationDenied ="Yetkiniz yok.";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        
        public  static string CarUpdated="Araba güncellendi";
    }
}
