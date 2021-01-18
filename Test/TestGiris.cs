using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TestGiris
    {
        /*Giriş isimli sınıfın nesnesini oluşturduk*/
        TaskBoardProjesi.Giris girisformu = new TaskBoardProjesi.Giris();
        [TestMethod]
        public void BasariliGirisYap()
        {
            /*Bilgileri doğru girerek daha önce giriş sınıfında oluşturduğumuz kontrol fonksiyonunu çağırıp bool değişkenine atadık. */
            bool giris = girisformu.GirisKontrol("Kübra", "1234");
            /*giriş true ise testimiz başarılı */
            Assert.AreEqual(true, giris);

        }
        [TestMethod]
        public void BasarisizGirisYap()
        {
            /*Bilgileri yanlış girerek daha önce giriş sınıfında oluşturduğumuz kontrol fonksiyonunu çağırıp bool değişkenine atadık. */
            bool giris = girisformu.GirisKontrol("Kübra", "1592");
            /*giriş false ise testimiz başarılı */
            Assert.AreEqual(false, giris);

        }
    }
}
