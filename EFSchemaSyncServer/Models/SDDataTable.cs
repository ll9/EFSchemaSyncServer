using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSchemaSyncServer.Models
{
    public class SDDataTable
    {
        public SDDataTable()
        {

        }

        public SDDataTable(string name, bool synchronize, ICollection<SDColumn> columns)
        {
            Name = name;
            Synchronize = synchronize;
            Columns = columns;
        }

        public SDDataTable(string id, string name, bool synchronize)
        {
            Id = id;
            Name = name;
            Synchronize = synchronize;
        }

        public SDDataTable(string id, string name, bool synchronize, ICollection<SDColumn> columns)
        {
            Id = id;
            Name = name;
            Synchronize = synchronize;
            Columns = columns;
        }

        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Synchronize { get; set; }

        public ICollection<SDColumn> Columns { get; set; }
    }
}
