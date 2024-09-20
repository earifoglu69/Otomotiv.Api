using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.Infrastructure.Models
{
    [Table("Brands")]

    public class BrandEntity :BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
