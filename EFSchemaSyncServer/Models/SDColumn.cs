using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSchemaSyncServer.Models
{
    public class SDColumn
    {
        public SDColumn()
        {

        }

        public SDColumn(string name, string dataType, bool synchronize)
        {
            Name = name;
            DataType = dataType;
            Synchronize = synchronize;
        }

        public SDColumn(string name, string dataType, bool synchronize, string sDDataTableId)
        {
            Name = name;
            DataType = dataType;
            Synchronize = synchronize;
            SDDataTableId = sDDataTableId;
        }

        public SDColumn(string id, string name, string dataType, bool synchronize, string sDDataTableId)
        {
            Id = id;
            Name = name;
            DataType = dataType;
            Synchronize = synchronize;
            SDDataTableId = sDDataTableId;
        }

        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public bool Synchronize { get; set; }

        [ForeignKey(nameof(SDDataTable))]
        public string SDDataTableId { get; set; }

        public string GetSqlType()
        {
            return Type.GetType(DataType).GetSqlType();
        }
    }

    public static class TypeExtension
    {
        public static string GetSqlType(this Type type)
        {
            if (type == typeof(int))
            {
                return "INTEGER";
            }
            else if (type == typeof(double))
            {
                return "DOUBLE";
            }
            else if (type == typeof(bool))
            {
                return "BOOLEAN";
            }
            else if (type == typeof(DateTime))
            {
                return "DATETIME";
            }
            else
            {
                return "TEXT";
            }
        }
    }
}
