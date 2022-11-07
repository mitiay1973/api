using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication2.Entities;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class zakazisController : ApiController
    {
        private Sfera_IT_PPEntities db = new Sfera_IT_PPEntities();

        // GET: api/zakazis
        [ResponseType(typeof(List<ZakaziModel>))]
        public IHttpActionResult Getzakazi()
        {
            return Ok (db.zakazi.ToList().ConvertAll(x=> new ZakaziModel(x)));
        }

        // GET: api/zakazis/5
        [ResponseType(typeof(zakazi))]
        public IHttpActionResult Getzakazi(int id)
        {
            zakazi zakazi = db.zakazi.Find(id);
            if (zakazi == null)
            {
                return NotFound();
            }

            return Ok(zakazi);
        }

        // PUT: api/zakazis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putzakazi(int id, zakazi zakazi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != zakazi.id_zakaza)
            {
                return BadRequest();
            }

            db.Entry(zakazi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!zakaziExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/zakazis
        [ResponseType(typeof(zakazi))]
        public IHttpActionResult Postzakazi(zakazi zakazi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.zakazi.Add(zakazi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = zakazi.id_zakaza }, zakazi);
        }

        // DELETE: api/zakazis/5
        [ResponseType(typeof(zakazi))]
        public IHttpActionResult Deletezakazi(int id)
        {
            zakazi zakazi = db.zakazi.Find(id);
            if (zakazi == null)
            {
                return NotFound();
            }

            db.zakazi.Remove(zakazi);
            db.SaveChanges();

            return Ok(zakazi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool zakaziExists(int id)
        {
            return db.zakazi.Count(e => e.id_zakaza == id) > 0;
        }
    }
}