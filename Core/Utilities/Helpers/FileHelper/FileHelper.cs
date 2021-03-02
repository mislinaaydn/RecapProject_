using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelper : IFileHelper
    {
        public IDataResult<string> Upload(IFormFile file, string path, string fileType)//burası dosya upload için parametreler
        {
            var resultFileRotates = FileExtensionRotates(fileType);//burada ilk olarak dosyatipi varmı sistemde onu kontrol ederiz 
            if (resultFileRotates.Success)
            {//varsa burası çalısır
                var resultFileControl = FileControl(file, resultFileRotates.Data);//burada gelen dosyayı kontrol ederiz bakarız bama resim formatındamı değilse hata veririz görüntü formatındaysa görüntünün yeni ismi gelir
                if (resultFileControl.Success)
                {
                    string replaceFileName = resultFileControl.Data;
                    var files = Path.Combine(path + replaceFileName);//burada dosyanın yolunu ve kendisinin bir path ini olustururuz kaydedilecek yolunu
                    using (var fileStream = new FileStream(files, FileMode.Create))//burada dosyayı oluştur deriz
                    {
                        file.CopyTo(fileStream);//burada dosyanın bilgilerini kopyalarız sisteme 
                    }
                    return new SuccessDataResult<string>(replaceFileName.Replace('\\', '/'));//kopyalama islemi başarılı //anlamadığınız biyer varmı hayır yok çok iyi anladım
                }
                return new ErrorDataResult<string>(resultFileControl.Message);
            }
            return new ErrorDataResult<string>(resultFileRotates.Message);//yoksa burası

        }

        public IResult Delete(string path,string file)
        {
            System.IO.File.Delete(path+file);
            return new SuccessResult();
        }

        public IResult Move(string oldPath, string newPath)
        {
            throw new NotImplementedException();
        }


        public IDataResult<string[]> FileExtensionRotates(string FileType)//bu method dosya uzantıları bulunduruyor dosya tipine göre uzantı döndürür
        {
            if (FileType.ToUpper() == "IMAGE")//burada kontrol ederiz dosya tipi IMAGE SE 
            {
                string[] extensions = { "Images", ".jpg", ".tif", ".png", ".jpeg", ".bmp" };//BU UZANTILARI DÖNDÜR
                return new SuccessDataResult<string[]>(extensions);
            }//BURAYA DAHAFAZLA DOSYATİPİ VE UZANTISI GÖNDERE BİLİRSİN bize lazım olan sadece image oyüzden sadece image döndürüyoruz
            return new ErrorDataResult<string[]>();
        }

        public IDataResult<string> FileControl(IFormFile file, string[] fileExtentions)//burası dosya kontrol ve dosya isimlendirme
        {
            var getFileExtensions = Path.GetExtension(file.FileName).ToLower();
            for (int i = 1; i < fileExtentions.Length; i++)
            {
                if (fileExtentions[i].ToLower() == getFileExtensions)//buradagelen dosya türünü kontrol ediyoruz
                {
                    string fileName = "\\" + fileExtentions[0] + "\\" + Guid.NewGuid().ToString() + getFileExtensions;//buradadosyanın yeni isminin verildiği kısım
                    return new SuccessDataResult<string>(fileName);
                }
            }
            return new ErrorDataResult<string>("Gönderilen dosya türü hatalı !");
        }
    }
}
