using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemesterCalendar.Core.Models
{
    public class CollegeYear
    {
        public string Name { get; set; }
        public CollegeSemester Semester1 { get; set; }
        public CollegeSemester Semester2 { get; set; }
    }
}
