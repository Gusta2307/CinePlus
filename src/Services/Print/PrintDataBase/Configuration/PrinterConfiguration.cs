using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrintDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDataBase.Configuration
{
    public class PrinterConfiguration
    {
        public PrinterConfiguration(EntityTypeBuilder<Printer> entityBuilder)
        {
            entityBuilder.HasKey(printer => printer.ID_Printer); //declarar la llave de tabla
            entityBuilder.Property(printer => printer.PrinterName).IsRequired().HasMaxLength(100);
            entityBuilder.HasData(printers); //default printers
        }

        public List<Printer> printers = new List<Printer>()
        {
            new Printer
            {
                ID_Printer = 1,
                PrinterName = "Adobe PDF"
            },

            new Printer
            {
                ID_Printer = 2,
                PrinterName = "Fax"
            },

            new Printer
            {
                ID_Printer = 3,
                PrinterName = "Microsoft XPS Document Writer"
            },
        };
    }
}
