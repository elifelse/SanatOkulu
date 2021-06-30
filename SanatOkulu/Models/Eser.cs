using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace SanatOkulu.Models
{
    public class Eser
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }
        public int? Yil { get; set; }

        [MaxLength(255)]
        public string Resim { get; set; }

        // Sanatci + Id : Sanatci enetity'sinin Id'sine referans veren bir FK
        public int SanatciId { get; set; }

        // Bu eserin 1 sanatçısını vardır (1-çok ilişki)
        public virtual Sanatci Sanatci { get; set; }
    }
}
