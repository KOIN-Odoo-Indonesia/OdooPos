using System.Collections.Generic;
using System.Printing;
using OdooPos.Models;
using OdooPos.Repositories.Interfaces;

namespace OdooPos.Repositories.Printer
{
    class PrinterRepository : IPrinterRepository
    {
        public IEnumerable<Printers> GetPrinter()
        {
            List<Printers> printers = new List<Printers>();
            LocalPrintServer printServer = new LocalPrintServer();
            PrintQueueCollection printQueuesOnLocalServer = printServer.GetPrintQueues(new[] {
                EnumeratedPrintQueueTypes.Local, EnumeratedPrintQueueTypes.Connections
            });
            foreach (PrintQueue printer in printQueuesOnLocalServer)
            {
                printers.Add(new Printers { Name = printer.Name });
                //Debug.WriteLine("\tThe shared printer : " + printer.Name);
            }
            return printers;
        }
    }
}
