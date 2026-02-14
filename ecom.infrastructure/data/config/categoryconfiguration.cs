using ecom.core.entities.product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.infrastructure.data.config
{
    public class categoryconfiguration : IEntityTypeConfiguration<category>
    {
        public void Configure(EntityTypeBuilder<category> builder)
        {
            builder.Property( x => x.name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.id).IsRequired();
            builder.HasData(
                new category { id=1,name="test",description="test"}
                );
        }
    }
}
