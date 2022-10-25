using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ptoject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class JobConfiguration : BaseConfiguration<Job>
    {
        public override void Configure(EntityTypeBuilder<Job> builder)
        {
            base.Configure(builder);
        }
    }
}
