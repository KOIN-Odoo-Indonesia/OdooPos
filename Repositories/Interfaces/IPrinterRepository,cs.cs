using System.Collections.Generic;
using OdooPos.Models;

namespace OdooPos.Repositories.Interfaces
{
    public interface IPrinterRepository
    {
        IEnumerable<Printers> GetPrinter();
    }
}
