using PrintDataBase;
using PrintServiceQuery.DTO;
using ServiceCommonCollection;
using ServiceCommonMapping;
using ServiceCommonPapping;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PrintServiceQuery
{
    public interface IPrintQueryService
    {
        Task<DataCollection<PrinterDTO>> GetAllAsync();
    }

    public class PrintQueryService : IPrintQueryService
    {
        private readonly ApplicationDbContext _context;

        public PrintQueryService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<DataCollection<PrinterDTO>> GetAllAsync()
        {
            var collection = await _context.Printers
                .OrderBy(x => x.ID_Printer)
                .GetPagedAsync();

            return collection.MapTo<DataCollection<PrinterDTO>>();
        }
    }
}
