using Android.App;
using Android.Runtime;
using SemesterCalendar.Core;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using System;

namespace SemesterCalendar.Droid
{
    [Application]
    public class MainActivity : MvxAndroidApplication<MvxAndroidSetup<App>, App>
    {
       public MainActivity(IntPtr javaReference, JniHandleOwnership transfer): base(javaReference, transfer)
        {
        }
    }
}