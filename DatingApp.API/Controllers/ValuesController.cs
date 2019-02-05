using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{   //POST http://localhost:5000/api/values
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //campo privado que solo podremos acceder en esta clase
        private  readonly DataContext _context;
        

        //constructor de nuestra clase quwe inyectamos el dataContext 
        //Permitir a esta clase acceder a los metodos del dataContext
        public ValuesController(DataContext context)
        {
            _context = context;

        }

        // GET api/values
        [HttpGet]
        //Metodo para obtener los valores de la base de datos
        public IActionResult GetValues()
        {
            //recuperar los valores en una lista
            var values = _context.Values.ToList();

            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        // metodo para seleccionar un valor en especifico 
        public IActionResult GetValue(int id)
        {
            // toma el primero de los valores predeterminados que coincidan con el id
            var value = _context.Values.FirstOrDefault( x => x.Id == id);
            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
