using System.Xml.Serialization;

namespace TiendaArreglos.Client.Model
{
    public class TiendaArreglosConfig
    {
        [XmlElement]
        public int LastPrintedNumber { get; set; }

        [XmlElement]
        public int NumberOfTicketsToPrint { get; set; }
    }
}