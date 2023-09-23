using BookApi.Models.Domain;
using BookApi.Models.DTOs;
using BookApi.Repositories.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;


namespace BookApi.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public IActionResult GetAll(string? term = "")
        {
            var data = _bookRepository.GetAll(term);
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var data = _bookRepository.GetById(id);
            return Ok(data);
        }


        [HttpGet]
        public IActionResult GetBookStatistic()
        {
            var data = _bookRepository.GetBookStatistic();
            return Ok(data);
        }

        [HttpPost]
        public IActionResult AddUpdate(Book book)
        {
            var status = new Status();
            if (!ModelState.IsValid)
            {
                status.StatusCode = 0;
                status.Message = "Validation failed";
            }
            var result = _bookRepository.AddUpdate(book);

            status.StatusCode = result ? 1 : 0;
            status.Message = result ? "Saved successfully" : "Error had occured";

            return Ok(status);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _bookRepository.Delete(id);
            var status = new Status
            {
                StatusCode = result ? 1 : 0,
                Message = result ? "Deleted successfully" : "Error had occured"
            };
            return Ok(status);
        }
    }
}
            
       
            

