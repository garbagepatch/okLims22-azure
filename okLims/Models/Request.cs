using Microsoft.AspNetCore.Mvc.Rendering;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace okLims.Models
{



    public class Request
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int RequestId { get; set; }
        public string Subject { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
        public int ControllerID { get; set; }
        public int SizeID { get; set; }
        public int FilterID { get; set; }
        public int StateId { get; set; }
        public string Description { get; set; }
       
        [ForeignKey("SizeID")]
        public virtual FilterSize FilterSize { get; set; }
        [ForeignKey("FilterID")]
        public virtual FilterType FilterType { get; set; }
        [ForeignKey("ControllerID")]
        public virtual ControllerType ControllerType { get; set; }
        public int LaboratoryId { get; set; }

        public string SpecialDetails { get; set; }
        public string RequesterEmail { get; set; }
        [ForeignKey("LaboratoryId")]
        public virtual Laboratory Laboratory { get; set; }


        public virtual List<RequestLine> RequestLines { get; set; } = new List<RequestLine>();
        [ForeignKey("StateId")]
        public virtual RequestState State { get; set; }
        public int EventFK { get; set; }
        public virtual ScheduleEvent ScheduleEvent { get; set; }
        public Request() {}
    public Request(int id, DateTime start, DateTime end, string description, string email, int sizeId, int filterId, int controllerId, string specialDetails, int laboratoryId)
        {
            this.RequestId = id;
            this.RequesterEmail = email;
            this.Start = start;
            this.End = end;
            this.SizeID = sizeId;
            this.FilterID = filterId;
            this.ControllerID = controllerId;
            this.SpecialDetails = specialDetails;
            this.LaboratoryId = laboratoryId;
            this.Description = description;
        }


    }
  
   
        public class AppointmentData
        {
            public string Time { get; set; }
            public string RequesterEmail { get; set; }
          
            public string Description { get; set; }
            public int RequestId { get; set; }

            public AppointmentData() { }
            public AppointmentData(string Time, string RequesterEmail, string Description, int RequestId)
            {
                this.Time = Time;
             
                this.RequesterEmail = RequesterEmail;
                this.Description = Description;
                this.RequestId = RequestId;
            }
        }

    }

