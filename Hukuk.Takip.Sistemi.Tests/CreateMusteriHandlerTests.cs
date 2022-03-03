using Hukuk.Takip.Sistemi.App.Commands.Request;
using Hukuk.Takip.Sistemi.App.Handlers.Commands;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using Hukuk.Takip.Sistemi.Entities.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Hukuk.Takip.Sistemi.Tests
{
    public class CreateMusteriHandlerTests
    {
        public Mock<IMusteriService> _musteriService { get; set; }


        public CreateMusteriHandlerTests( )
        {
            _musteriService =new Mock<IMusteriService>();
           

        }

        [Fact]
        public async Task CreateMusteriHandlerTest()
        {
            var musteriServiceMock = new Mock<IMusteriService>();
            Guid id = new Guid();
            musteriServiceMock.Setup(x => x.InsertAsync(It.IsAny<Musteri>())).Returns(Task.FromResult(id));
            var createMusteriHandler = new CreateMusteriHandler(musteriServiceMock.Object);

            var testRequest = new CreateMusteriRequest
            {
                Id = 1,
                Ad = "Arif",
                Soyad = "Yılmaz",
                AnaAdi = "Ayşe",
                BabaAdi = "Ahmet",
                MusteriNo=256314,
                DogumTarihi=null,
                GuncellenmeTarihi=null,
                Guncelleyen=null,
                EklenmeTarihi=null,
                EkleyenKisi=null,
                SilindiMi=false,
                Cinsiyet = "Erkek",
                DogumYeri = "Ordu",
                MusteriTipi = 1,
                PasaportNo = "24535",
                TakipSubeAdi = "Fatsa",
                TakipSubeKodu = 5252,
                TCKN = "24535785369",
                VKN = "24553",
                MedeniHali = "Bekar",
                HayattaMi = false,
                VefatTarihi =null
      
            };

            var token = new CancellationToken();
            var result = await createMusteriHandler.Handle(testRequest, token);
            Assert.True(result.IsSuccess == true);
        }
    }
}
