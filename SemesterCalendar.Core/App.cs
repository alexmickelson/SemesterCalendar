using MvvmCross.ViewModels;
using SemesterCalendar.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemesterCalendar.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            RegisterAppStart<ListViewModel>();
        }
    }
}
