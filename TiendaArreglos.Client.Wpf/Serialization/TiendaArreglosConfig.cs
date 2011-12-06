using System.Xml.Serialization;

namespace TiendaArreglos.Client.Wpf.Serialization
{
    public class TiendaArreglosConfig
    {
        [XmlElement]
        public int LastPrintedNumber { get; set; }
        [XmlElement]
        public int NumberOfTicketsToPrint { get; set; }
    }
}