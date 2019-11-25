using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicAPI.Models.Entities;
using ComicAPI.Services.ComicServices;
using Microsoft.AspNetCore.Mvc;

namespace ComicAPI.Controllers
{
    [Route("api/chapters")]
    [ApiController]
    public class ChaperController : ControllerBase
    {
        private IChapService _chapservice;
        public ChaperController(IChapService chap)
        {
            _chapservice=chap;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Chapter>> Get()
        {
            return _chapservice.GetChaps();
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Chapter>> Get(int id)
        {
            return _chapservice.GetChapsofComic(id);
        }
        
        [HttpPost]
        public void Post([FromBody] Chapter chapter)
        {
             _chapservice.AddChap(chapter);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}