using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Yer_istasyonu
{
    static class BitMapHandler
    {
        //kullanılacak yayın stream'ını bitmap çevirme fonksiyonudur
        public static BitmapImage ToBitmapImage(this Bitmap bitmap)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();                        //bitmapImage başlatma
            MemoryStream ms = new MemoryStream(); //kısa süreliğine ana bellekte memorystream oluşturarak daha performanslı veri aktarımı sağlanır
            bitmap.Save(ms, ImageFormat.Bmp);    //kaydedilecek format Bmp
            ms.Seek(0, SeekOrigin.Begin);       //akışı başlangıca göre konumlandırma
            bi.StreamSource = ms;
            bi.EndInit();
            return bi;
        }
    }
}
