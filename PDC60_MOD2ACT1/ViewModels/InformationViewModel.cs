using PDC60_MOD2ACT1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace PDC60_MOD2ACT1.ViewModels
{
    class InformationViewModel
    {
        public Information InfoSet { get; set; }
        public InformationViewModel()
        {
            InfoSet = new Information
            {
                StudentID = 160280393,
                Name = "David, Ariza Kaila C.",
                CourseCode = "BSIT",
                CourseTitle = "Information Technology",
                NumberOfUnits = 15,
                DateOfAttendance = "August 26, 2021",
            };
        }
    }
}
