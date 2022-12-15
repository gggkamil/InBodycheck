using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InBodycheck.Models
{
    [Table("Bills")]
    public class BillModel
    {
        [Key]
        public int ReceiptID { get; set; }
        [DisplayName("Nazwa")]
        [Required(ErrorMessage ="Pole nazwa jest wymagane.")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Opis")]
        [MaxLength(2000)]
        [Required(ErrorMessage = "Pole opis jest wymagane.")]
        public string Description { get; set; }
        public bool  Done { get; set; }
        public int Fat { get; set; }
        
    }
}
