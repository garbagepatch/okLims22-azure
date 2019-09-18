using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace okLims.Models
{
    public class InstrumentType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int InstrumentTypeId { get; set; }
        public string instrumentType { get; set; }
        public int InstrumentFK { get; set; }

        [ForeignKey("InstrumentFK")]
        public ICollection<Instrument> Instrument { get; set; }
    }
}
