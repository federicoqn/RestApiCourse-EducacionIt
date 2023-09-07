using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using WebApiEF.Data;
using WebApiEF.Models;

namespace WebApiEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly DBLibrosEFContext _context;

        public AutorController(DBLibrosEFContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public Autor GetLibros(int id)
        {
            return _context.Autor.SingleOrDefault(a => a.IdAutor == id);
        }

        [HttpGet()]
        public IEnumerable<Autor> GetAllLibros()
        {
            return _context.Autor.ToList();
        }

        [HttpPost]
        public ActionResult Post(Autor autor)
        {
            _context.Autor.Add(autor);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Autor> Delete(int id) 
        {
            Autor autor = _context.Autor.Find(id);

            if (autor is null) 
            {
                return NotFound();
            }

            _context.Autor.Remove(autor);
            _context.SaveChanges();

            return autor;
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Autor autor)
        {
            if (id != autor.IdAutor)
            {
                return BadRequest();
            }

            _context.Entry(autor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }
    }
}
