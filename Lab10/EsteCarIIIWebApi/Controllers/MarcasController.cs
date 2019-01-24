using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstCarIIILibrary.Data;
using EstCarIIILibrary.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EsteCarIIIWebApi
{
    [Route("api/Marcas")]
    public class MarcasController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MarcasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Marca> Get()
        {
            return _context.Marca.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Marca Get(int id)
        {
            return _context.Marca.First(m => m.MarcaId == id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Marca marca)
        {
            _context.Marca.Add(marca);
            _context.SaveChanges();
        }


        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Marca marca)
        {
            if (marca != null && marca.MarcaId == id)
            {
                var marcaObj = _context.Marca.FirstOrDefault(m => m.MarcaId == id);

                marcaObj.Designacao = marca.Designacao;

                _context.Marca.Update(marcaObj);
                _context.SaveChanges();
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var marca = _context.Marca.FirstOrDefault(m => m.MarcaId == id);
            if (marca != null)
            {
                _context.Marca.Remove(marca);
                _context.SaveChanges();
            }
        }
    }
}
