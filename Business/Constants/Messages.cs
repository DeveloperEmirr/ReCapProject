using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarDeleted = "Araç Silindi";
        public static string CarDeletedInvalid = "Araç Numarası Geçerli Değil";
        public static string CarUptades = "Araç Güncellendi";
        public static string CarNameInvalid = "Araç İsmi Geçersiz İsimdir!"; 
        public static string MaintenanceTime = "Üzgünüz Şuanda Sistemde Bakım Olduğundan Dolayı İşleme Devam Edemezsiniz!";
        public static string CarListed = "Araçlar Listelendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUptades = "Müşteri Güncellendi";
        public static string CustomerListed = "Müşteriler Listelendi";

        public static string UserAdedd = "Kullanıcı Eklendi";
        public static string UserDeletedd = "Kullanıcı Silindi";
        public static string UserUptadedd = "Kullanıcı Güncellendi";
        public static string UserListed = "Kullanıcı Listelendi";

        public static string RentalAdded = "Araç Kiralandı";
        public static string RentalDeleted = "Araç Silindi";
        public static string RentalUptades = "Araç Güncellendi";
        public static string RentalListed = "Kiralanan Araçlar Listelendi";
        public static string RentalDate = "Aracın kiralabilmesi İçin Aracın Teslim Edilmesi Gerekmektedir.";
    }
}
