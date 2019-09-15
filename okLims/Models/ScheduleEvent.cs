using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace okLims.Models
{
    public class ScheduleEvent
    {
        [Key]
        public int Id { get; set; }
        public int RequestFK { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string CategoryColor { get; set; }
        [ForeignKey("RequestFK")]
        public ICollection<Request> Request { get; set; }
    }
}
