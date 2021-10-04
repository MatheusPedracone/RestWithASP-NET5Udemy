using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNETUdemy.Business;
using RestWithASPNETUdemy.Data.DTO;
using RestWithASPNETUdemy.models;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BookController : ControllerBase
    {

        // Declaration of the service used
        private IBookBusiness _bookBusiness;

        public BookController(IBookBusiness bookBusiness)
        {
            _bookBusiness = bookBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var book = _bookBusiness.FindByID(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public IActionResult Post([FromBody] BookDTO book)
        {
            if (book == null) return BadRequest();
            return Ok(_bookBusiness.Create(book));
        }

        [HttpPut]
        public IActionResult Put([FromBody] BookDTO book)
        {
            if (book == null) return BadRequest();
            return Ok(_bookBusiness.Update(book));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _bookBusiness.Delete(id);
            return NoContent();
        }
    }
}