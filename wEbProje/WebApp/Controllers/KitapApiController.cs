using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Drawing;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitapApiController : ControllerBase
    {
        private KitapManager kitapManager = new KitapManager(new EfKitapDal());

        [HttpGet]
        public List<Kitap> Get() {

            return kitapManager.GetAll();
        }

        [HttpGet("{id}")]
        public Kitap Get(int id)
        {

            return kitapManager.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] KitapApi k)
        {
            Kitap kitap = new Kitap();
            kitap.KitapAdi = k.KitapAdi;
            kitap.KitapTanimi = k.KitapTanimi;
            kitap.YayinEvi = k.YayinEvi;
            kitap.KitapResmi= k.KitapResmi;
            kitap.YazarID= k.YazarID;
           
            kitapManager.Add(kitap);
            return Ok();

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] KitapApi y)
        {
           
            var y1 = kitapManager.GetById(id);
            if (y1 is null)
            {
                return NotFound("Güncellenmek istenen kitap yok!");
            }
            y1.KitapAdi = y.KitapAdi;
            y1.KitapTanimi = y.KitapTanimi;
            y1.YayinEvi = y.YayinEvi;
            y1.KitapResmi = y.KitapResmi;
            y1.YazarID = y.YazarID;
            kitapManager.Update(y1);
           
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var y1 = kitapManager.GetById(id);
            if (y1 is null)
            {
                return NotFound();
            }

            kitapManager.Delete(y1);
            
            return Ok();
        }


    }
}
