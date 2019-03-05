using MvvmCross.ViewModels;
using SemesterCalendar.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemesterCalendar.Core.ViewModels
{
    public class ListViewModel : MvxViewModel
    {
        public ListViewModel()
        {
            Years = new MvxObservableCollection<CollegeYear>();

            var year = new CollegeYear() { Name="FRESHMAN" };
            

            var cs = new MvxObservableCollection<CollegeClass>();
            var c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            var s = new CollegeSemester()
            {
                Name = "Semester 1",
                Classes = cs
            };
            year.Semester1 = s;

            cs = new MvxObservableCollection<CollegeClass>();
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            s = new CollegeSemester()
            {
                Name = "Semester 2",
                Classes = cs
            };
            year.Semester2 = s;
            Years.Add(year);

            year = new CollegeYear() { Name = "SOPHMORE" };


            cs = new MvxObservableCollection<CollegeClass>();
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            s = new CollegeSemester()
            {
                Name = "Semester 1",
                Classes = cs
            };
            year.Semester1 = s;

            cs = new MvxObservableCollection<CollegeClass>();
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            c = new CollegeClass() { Name = "COLLEGE CLASS" };
            cs.Add(c);
            s = new CollegeSemester()
            {
                Name = "Semester 2",
                Classes = cs
            };
            year.Semester2 = s;
            Years.Add(year);

            
        }

        public MvxObservableCollection<CollegeYear> Years { get; set; }
    }
}
