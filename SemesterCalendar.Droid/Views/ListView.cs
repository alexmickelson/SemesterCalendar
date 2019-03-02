using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using SemesterCalendar.Core.ViewModels;

namespace SemesterCalendar.Droid.Views
{
    [Activity (Label ="SemesterList", MainLauncher =true)]
    class ListView : MvxActivity<ListViewModel>
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //TODO: BarLayout
            SetContentView(Resource.Layout.SemesterList);
        }

        
    }
}