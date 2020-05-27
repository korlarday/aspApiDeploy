using System.Collections.Generic;
using System.Linq;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/Values")]
    public class ValuesController: ControllerBase
    {
        List<Value> values = new List<Value>() {
                new Value{ Id = 1, Name = "Value1"},
                new Value{ Id = 2, Name = "Value2"},
                new Value{ Id = 3, Name = "Value3"},
            };
        [HttpGet]
        public IActionResult GetValues() {
            return Ok(values);
        }

        [HttpGet("{id}")]
        public Value GetValueById(int id) {
            Value value = values.SingleOrDefault(x => x.Id == id);
            if(value == null){
                return null;
            }
            return value;
        }
    }
}