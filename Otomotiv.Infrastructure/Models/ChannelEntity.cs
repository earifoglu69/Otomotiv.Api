using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.Infrastructure.Models
{
    [Table("Channels")]

    public class ChannelEntity : BaseEntity
    {
        public string Name { get; set; }
    }
}
