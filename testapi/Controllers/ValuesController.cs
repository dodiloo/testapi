using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testapi.Models;
using testapi.Repo;
using testapi.ViewModel;

namespace testapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private Itestrepo _repo;

        public ValuesController(Itestrepo repo)
        {
            _repo = repo;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<TmpNames> Get()
        {

            var data = _repo.Getdata();


            return Ok(data);
            
        }

       

        // POST api/values
        [HttpPost]
        public ActionResult Post(TmpNames data)
        {
            var list = _repo.Insert(data);

            var response = new Message();


            response.message = "Berhasil";
            response.status = "001";

            return Ok(response);
        }

       
    }
}
