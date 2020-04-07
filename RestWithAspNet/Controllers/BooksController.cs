﻿using Tapioca.HATEOAS;
using Microsoft.AspNetCore.Mvc;
using RestWithAspNet.Business;
using RestWithAspNet.Data.VO;

namespace RestWithAspNet.Controllers
{

    /* Mapeia as requisições de http://localhost:{porta}/api/books/v1/
    Por padrão o ASP.NET Core mapeia todas as classes que extendem Controller
    pegando a primeira parte do nome da classe em lower case [Book]Controller
    e expõe como endpoint REST
    */
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BooksController : Controller
    {
        //Declaração do serviço usado
        private IBookBusiness _bookBusiness;

        /* Injeção de uma instancia de IBookBusiness ao criar
        uma instancia de BookController */
        public BooksController(IBookBusiness bookBusiness)
        {
            _bookBusiness = bookBusiness;
        }

        //Mapeia as requisições GET para http://localhost:{porta}/api/books/v1/
        //Get sem parâmetros para o FindAll --> Busca Todos
        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_bookBusiness.FindAll());
        }

        //Mapeia as requisições GET para http://localhost:{porta}/api/books/v1/{id}
        //recebendo um ID como no Path da requisição
        //Get com parâmetros para o FindById --> Busca Por ID
        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var book = _bookBusiness.FindById(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        //Mapeia as requisições POST para http://localhost:{porta}/api/books/v1/
        //O [FromBody] consome o Objeto JSON enviado no corpo da requisição
        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]BookVO book)
        {
            if (book == null) return BadRequest();
            return new ObjectResult(_bookBusiness.Create(book));
        }

        //Mapeia as requisições PUT para http://localhost:{porta}/api/books/v1/
        //O [FromBody] consome o Objeto JSON enviado no corpo da requisição
        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody]BookVO book)
        {
            if (book == null) return BadRequest();
            var updatedBook = _bookBusiness.Update(book);
            if (updatedBook == null) return BadRequest();
            return new ObjectResult(updatedBook);
        }


        //Mapeia as requisições DELETE para http://localhost:{porta}/api/books/v1/{id}
        //recebendo um ID como no Path da requisição
        [HttpDelete("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Delete(int id)
        {
            _bookBusiness.Delete(id);
            return NoContent();
        }
    }
}