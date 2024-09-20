using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.Infrastructure.Models
{
    [Table("BrandSettings")]
    public class BrandSettingEntity : BaseEntity
    {
        [ForeignKey("Brand")]
        public int? BrandId { get; set; }
        public virtual BrandEntity Brand { get; set; }

        [ForeignKey("Platform")]
        public int? PlatformId { get; set; }
        public virtual PlatformEntity Platform { get; set; }

        [ForeignKey("Channel")]
        public int? ChannelId { get; set; }
        public virtual ChannelEntity  Channel { get; set; }


    }
}
