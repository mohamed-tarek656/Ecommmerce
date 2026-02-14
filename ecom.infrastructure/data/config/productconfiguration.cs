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
    public class productconfiguration : IEntityTypeConfiguration<product>
    {
        public void Configure(EntityTypeBuilder<product> builder)
        {
            builder.Property(x => x.name).IsRequired();
            builder.Property(x => x.description).IsRequired();
            builder.Property(x => x.price).HasColumnType("decimal(18,2)");
            builder.HasData(
                new product { id=1,name="test",description="test",price=12,categoryid=1}
                );
        }
    }
}
