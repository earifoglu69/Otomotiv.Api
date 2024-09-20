using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.Infrastructure.Models
{
    [Table("Platforms")]

    public class PlatformEntity : BaseEntity
    {
        public string Name { get; set; }
    }
}
