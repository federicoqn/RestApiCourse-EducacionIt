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
    public class LibroController : ControllerBase
    {
        private readonly DBLibrosEFContext _context;

        public LibroController(DBLibrosEFContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public Libro GetLibros(int id)
        {
            return _context.Libro.SingleOrDefault(l => l.IdLibro == id);
        }

        [HttpGet()]
        public IEnumerable<Libro> GetAllLibros()
        {
            return _context.Libro.ToList();
        }

        [HttpPost]
        public ActionResult Post(Libro libro)
        {
            _context.Libro.Add(libro);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Libro> Delete(int id) 
        {
            Libro libro = _context.Libro.Find(id);

            if (libro is null) 
            {
                return NotFound();
            }

            _context.Libro.Remove(libro);
            _context.SaveChanges();

            return libro;
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Libro libro)
        {
            if (id != libro.IdLibro)
            {
                return BadRequest();
            }

            _context.Entry(libro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet("{id}")]
        public Libro GetLibrosByTitulo(string titulo)
        {
            return _context.Libro.SingleOrDefault(l => l.Titulo == titulo);
        }
    }
}
