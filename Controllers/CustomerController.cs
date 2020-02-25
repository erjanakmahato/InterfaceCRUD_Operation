using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterfaceCRUD.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly IDataRepository<Customer> _repository;
        public CustomerController(IDataRepository<Customer> repository)
        {
            _repository = repository;
        }
          // GET: api/<controller>  
          [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Customer> customers = _repository.GetAll();
            return Ok(customers);
        }

        // GET api/<controller>/5  
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Customer customer = _repository.Get(id);

            if (customer == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            return Ok(customer);
        }

        // POST api/<controller>  
        [HttpPost]
        public IActionResult Post([FromBody]Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Customer is Null");
            }
            _repository.Add(customer);
            return CreatedAtRoute("Get", new { Id = customer.ID }, customer);
        }

        // PUT api/<controller>/5  
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Customer is null");
            }
            Customer customerToUpdate = _repository.Get(id);
            if (customerToUpdate == null)
            {
                return NotFound("Customer could not be found");
            }
            _repository.change(customerToUpdate, customer);
            return NoContent();
        }

        // DELETE api/<controller>/5  
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Customer customer = _repository.Get(id);
            if (customer == null)
            {
                return BadRequest("Customer is not found");
            }
            _repository.Delete(customer);
            return NoContent();
        }
    }
}