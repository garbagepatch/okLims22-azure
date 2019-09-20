using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace okLims.Models
{
    public class GridViewModel
    {
        public class FilterTypeViewModel: FilterType
        {
            public IEnumerable<FilterType> FilterType { get; set; }
        }
        public class FilterSizeViewModel: FilterSize
        {
            public IEnumerable<FilterSize> FilterSize { get; set; }
        }
        public class ControllerTypeViewModel: ControllerType
        {
            public IEnumerable<ControllerType> ControllerType { get; set; }
        }
        public class LaboratoryViewModel: Laboratory
        {
            public IEnumerable<Laboratory> Laboratory { get; set; }
        }
    }
}
