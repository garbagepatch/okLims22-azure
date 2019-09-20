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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    
        [Key]
        public int Id { get; set; }
       
        public string Subject { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool? AllDay { get; set; }
        public int StateId { get; set; }
        public string CategoryColor { get; set; }
        
        [ForeignKey("StateId")]
        public RequestState Status { get; set; }

        public List<ScheduleEvent> GetScheduleData()
        {
            List<ScheduleEvent> appData = new List<ScheduleEvent>();

            appData.Add(new ScheduleEvent
            {

                Subject = "Surgery - Andrew",
                Description = "Confirmed",
                StartTime = new DateTime(2018, 2, 12, 9, 0, 0, 0),
                EndTime = new DateTime(2018, 2, 12, 10, 0, 0)
            });
            appData.Add(new ScheduleEvent
            {

                Subject = "Consulting - John",
                Description = "Confirmed",
                StartTime = new DateTime(2018, 2, 12, 10, 0, 0),
                EndTime = new DateTime(2018, 2, 12, 11, 30, 0)
            });
            appData.Add(new ScheduleEvent
            {

                Subject = "Therapy - Robert",
                Description = "Requested",
                StartTime = new DateTime(2018, 2, 12, 11, 30, 0),
                EndTime = new DateTime(2018, 2, 12, 12, 30, 0)
            });
        

            return appData;
        }
    }
}

