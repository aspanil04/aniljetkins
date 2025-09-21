using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using githubcicd.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace githubcicd.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_context.Employees.ToList());
        }
        [HttpGet("getproduct/{id}")]
        public IActionResult GetProductById(int id)
        {
            return Ok(_context.Employees.Find(id));
        }

        [HttpGet("getproductdetails")]
        public IActionResult GetProductDetails()
        {
            return Ok("GetProductdetails method call complete");
        }

    }
}