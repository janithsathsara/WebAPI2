using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI2.Data;
using WebAPI2.Models;

namespace WebAPI2.Controllers
{
    public class CatController : ControllerBase
    {

        private ApplicationDbContext dbContext;

        //        public CatController()
        //        {
        //            string connectionString = "Server=.;Database=Villa_API;TrustServerCertificate=true;Trusted_Connection=true;MultipleActiveResultSets=true";
        //            dbContext = new ApplicationDbContext(connectionString);
        //        }

        // GET api/catalogue
        public IEnumerable<Villa> Get()
        {
            return dbContext.Villas.ToList();
        }

        // GET api/catalogue/{id}
        public Villa Get(int id)
        {
            return dbContext.Villas.FirstOrDefault(p => p.Id == id);
        }

        // POST api/catalogue
        public void Post([FromBody] Villa product)
        {
            dbContext.Villas.Add(product);
            dbContext.SaveChanges();
        }

        // PUT api/catalogue/{id}
        public void Put(int id, [FromBody] Villa product)
        {
            Villa existingVilla= dbContext.Villas.Find(id);
            if (existingVilla != null)
            {
                existingVilla.Name = product.Name;
                existingVilla.Rate = product.Rate;
                dbContext.SaveChanges();
            }
        }

        // DELETE api/catalogue/{id}
        public void Delete(int id)
        {
            Villa product = dbContext.Villas.Find(id);
            if (product != null)
            {
                dbContext.Villas.Remove(product);
                dbContext.SaveChanges();
            }
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//
//namespace ApplicationAPI
//{
//    public class Villa
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public decimal Rate { get; set; }
//    }
//
//    public class ApplicationController : ApiController
//    {
//        }
//    }
//}
//
