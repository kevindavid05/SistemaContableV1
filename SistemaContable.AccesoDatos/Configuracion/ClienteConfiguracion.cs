using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaContable.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContable.AccesoDatos.Configuracion
{
    public class ClienteConfiguracion : IEntityTypeConfiguration<Cliente>
    {

        public void Configure(EntityTypeBuilder<Cliente> builder) {

            builder.Property(x => x.ClId).IsRequired();
            builder.Property(x => x.Clnombre).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Cldireccion);
        }
    }
}
