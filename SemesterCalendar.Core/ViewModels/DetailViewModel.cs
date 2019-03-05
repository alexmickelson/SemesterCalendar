using MvvmCross.ViewModels;
using SemesterCalendar.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemesterCalendar.Core.ViewModels
{
    public class DetailViewModel : MvxViewModel
    {
        private int num { get; set; }
        private List<CollegeSemester> semesters { get; set; }
        public CollegeSemester Semester {
            get
            {
                return semesters[num++ % 4];
            }
        }

        public DetailViewModel()
        {
            num = 0;
            semesters = new List<CollegeSemester>();

            var cs = new MvxObservableCollection<CollegeClass>();
            var c = new CollegeClass() { Name = "COLLEGE CLASS", Credits=3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            var s = new CollegeSemester()
            {
                Name = "Semester 1",
                Classes = cs
            };
            semesters.Add(s);

            cs = new MvxObservableCollection<CollegeClass>();
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            s = new CollegeSemester()
            {
                Name = "Semester 2",
                Classes = cs
            };
            semesters.Add(s);


            cs = new MvxObservableCollection<CollegeClass>();
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            s = new CollegeSemester()
            {
                Name = "Semester 3",
                Classes = cs
            };
            semesters.Add(s);

            cs = new MvxObservableCollection<CollegeClass>();
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS", Credits = 3 };
            cs.Add(c);
            s = new CollegeSemester()
            {
                Name = "Semester 4",
                Classes = cs
            };
            semesters.Add(s);
        }
    }
}
