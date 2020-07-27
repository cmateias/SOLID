using System;

namespace SOLID.InterfaceSegregationPrinciple.With
{
    public class LaserJetPrinter : IPrinterTasks, IFaxTasks,
        IPrintDuplexTasks
    {
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }

        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }

        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }
}