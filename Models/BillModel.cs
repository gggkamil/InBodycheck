using System.ComponentModel;

namespace InBodycheck.Models
{
    public class BillModel
    {
        public int ReceiptID { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Opis")]
        public string Description { get; set; }
        public bool  Done { get; set; }
        public int Fat { get; set; }
        public DateTime Date { get; set; }
    }
}
