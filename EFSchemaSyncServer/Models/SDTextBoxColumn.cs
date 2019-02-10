using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSchemaSyncServer.Models
{
    public class SDTextBoxColumn : SDColumn
    {
        public SDTextBoxColumn()
        {
        }

        public SDTextBoxColumn(string name, string dataType, bool synchronize) : base(name, dataType, synchronize)
        {
        }

        public SDTextBoxColumn(string name, string dataType, bool synchronize, string sDDataTableId) : base(name, dataType, synchronize, sDDataTableId)
        {
        }

        public SDTextBoxColumn(string id, string name, string dataType, bool synchronize, string sDDataTableId) : base(id, name, dataType, synchronize, sDDataTableId)
        {
        }
    }
}
