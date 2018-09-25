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
using Emma2CRMApi.Models;

namespace Emma2CRMApi.Controllers
{
    public class E2CSubscriptionController : ApiController
    {
        private E2CDbContext db = new E2CDbContext();

        // GET: api/E2CSubscription
        public IQueryable<E2CClientBaseInfo> GetSubscriptions()
        {
            return db.Subscriptions;
        }

        // GET: api/E2CSubscription/5
        [ResponseType(typeof(E2CClientBaseInfo))]
        public IHttpActionResult GetE2CClientBaseInfo(int id)
        {
            E2CClientBaseInfo e2CClientBaseInfo = db.Subscriptions.Find(id);
            if (e2CClientBaseInfo == null)
            {
                return NotFound();
            }

            return Ok(e2CClientBaseInfo);
        }

        // PUT: api/E2CSubscription/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutE2CClientBaseInfo(int id, E2CClientBaseInfo e2CClientBaseInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != e2CClientBaseInfo.ID)
            {
                return BadRequest();
            }

            db.Entry(e2CClientBaseInfo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!E2CClientBaseInfoExists(id))
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

        // POST: api/E2CSubscription
        [ResponseType(typeof(E2CClientBaseInfo))]
        public IHttpActionResult PostE2CClientBaseInfo(E2CClientBaseInfo e2CClientBaseInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Subscriptions.Add(e2CClientBaseInfo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = e2CClientBaseInfo.ID }, e2CClientBaseInfo);
        }

        // DELETE: api/E2CSubscription/5
        [ResponseType(typeof(E2CClientBaseInfo))]
        public IHttpActionResult DeleteE2CClientBaseInfo(int id)
        {
            E2CClientBaseInfo e2CClientBaseInfo = db.Subscriptions.Find(id);
            if (e2CClientBaseInfo == null)
            {
                return NotFound();
            }

            db.Subscriptions.Remove(e2CClientBaseInfo);
            db.SaveChanges();

            return Ok(e2CClientBaseInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool E2CClientBaseInfoExists(int id)
        {
            return db.Subscriptions.Count(e => e.ID == id) > 0;
        }
    }
}