using Microsoft.AspNetCore.Mvc;
using PhoneViewPageApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneViewPageApp.Controllers
{

    [Route("api/phones")]
    public class PhoneController : Controller
    {
        PhoneContext db;

        public PhoneController(PhoneContext context)
        {
            db = context;
            if (!db.Phones.Any())
            {
                db.Phones.Add(new Phone { ModelName = "iPhone X", Processor = "ARM", CameraMP = 20, Cores = 4, MemerySizeMB = 10240, RAMSizeMB = 2048, PhoneIMGName = "phone.jpg" });
                db.Phones.Add(new Phone { ModelName = "Galaxy S8", Processor = "ARM", CameraMP = 30, Cores = 8, MemerySizeMB = 10240, RAMSizeMB = 2048, PhoneIMGName = "phone.jpg" });
                db.SaveChanges();
            }
        }

        [HttpGet]
        public JsonResult Get()
        {
            var data = db.Phones.ToList();
            return  Json(data);
        }


        [HttpGet("{id}")]
        public Phone Get(int id)
        {
            Phone product = db.Phones.FirstOrDefault(x => x.Id == id);
            return product;
        }

        [HttpPost]
        public IActionResult Post([FromBody]Phone phone)
        {
            if (ModelState.IsValid)
            {
                db.Phones.Add(phone);
                db.SaveChanges();
                return Ok(phone);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Phone phone)
        {
            if (ModelState.IsValid)
            {
                db.Update(phone);
                db.SaveChanges();
                return Ok(phone);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Phone product = db.Phones.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                db.Phones.Remove(product);
                db.SaveChanges();
            }
            return Ok(product);

        }
    }
}