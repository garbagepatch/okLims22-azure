using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace okLims.Models
{
    public class RequestState
    {
        [Key]
        public int StateId { get; set; }
        public string State { get; set; }
        public ICollection<Request> Request { get; set; }
        public static RequestState[] RequestStates()
        {
            RequestState submitted = new RequestState { StateId = 0, State = "Submitted" };
            RequestState opened = new RequestState { StateId = 1, State = "Opened" };
            RequestState completed = new RequestState() { StateId = 2, State = "Completed" };
            RequestState deleted = new RequestState() { StateId = 3, State = "Deleted" };

            return new RequestState[] { submitted, opened, completed, deleted };
        }
    }
}
