using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace okLims.Models
{
    public class Instrument
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int InstrumentId { get; set; }
        [Required]
        public string InstrumentName { get; set; }
        public DateTime CalibrationDue { get; set; }
        public DateTime CalibrationDate { get; set;}
        public int CalibrationLength { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public int MaintenanceInterval { get; set; }
        public DateTime MaintenanceDue { get; set; }
        public List<InstrumentLine> InstrumentLines { get; set; }
        public int InstrumentTypeID { get; set; }
        [ForeignKey("InstrumentTypeID")]
        public InstrumentType InstrumentType { get; set; }
    }
}
