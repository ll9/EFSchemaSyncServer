using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSchemaSyncServer.Models
{
    public class SDSchemaObject
    {
        public SDSchemaObject(  )
        {
        }

        public SDSchemaObject(ICollection<SDDataTable> sDDataTables, ICollection<SDColumn> columns)
        {
            SDDataTables = sDDataTables;
            SDColumns = columns;
        }

        public ICollection<SDDataTable> SDDataTables { get; set; }
        public ICollection<SDColumn> SDColumns { get; set; }
    }
}
