using MvvmCross.ViewModels;

namespace SemesterCalendar.Core.Models
{
    public class CollegeSemester
    {
        public string Name { get; set; }
        public MvxObservableCollection<CollegeClass> Classes { get; set; }
    }
}
