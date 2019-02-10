using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFSchemaSyncServer.Models;

namespace EFSchemaSyncServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SDSchemaObjectController : ControllerBase
    {
        private readonly EFSchemaSyncServerContext _context;

        public SDSchemaObjectController(EFSchemaSyncServerContext context)
        {
            _context = context;
        }

        // GET: api/SDSchemaObject
        [HttpGet]
        public SDSchemaObject GetDbSchema()
        {
            var tables = _context.SDDataTables.Include(t => t.Columns).ToList();
            return new SDSchemaObject(tables, new List<SDColumn>());
        }

        // POST: api/SDSchemaObject
        [HttpPost]
        public async Task<IActionResult> PostSchemaObject([FromBody] SDSchemaObject schemaObject)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SDDataTables.AddRange(schemaObject.SDDataTables);
            _context.SDColumns.AddRange(schemaObject.SDColumns);

            await _context.SaveChangesAsync();

            return CreatedAtAction("schema", schemaObject);
        }

        // POST: api/SDSchemaObject
        [HttpDelete]
        public async Task<IActionResult> RemoveSchemaObject([FromBody] IEnumerable<string> Ids)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            foreach (var id in Ids)
            {
                var table = new SDDataTable { Id = id };
                var column = new SDColumn { Id = id };

                _context.SDDataTables.Attach(table);
                _context.SDDataTables.Remove(table);
                _context.SDColumns.Attach(column);
                _context.SDColumns.Remove(column);
            }
            _context.SaveChanges();

            return Ok(Ids);
        }
    }
}
