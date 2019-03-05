using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using SemesterCalendar.Core.ViewModels;
using MvvmCross.Droid.Support.V7.RecyclerView;
using Android.Support.V7.Widget;
using System;

namespace SemesterCalendar.Droid.Views
{
    [Activity (Label ="SemesterList", MainLauncher =false)]
    class ListView : MvxActivity<ListViewModel>
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //TODO: BarLayout
            SetContentView(Resource.Layout.SemesterList);

            try
            {
                MvxRecyclerView layoutManager = FindViewById<MvxRecyclerView>(Resource.Id.SemesterRecView);
                layoutManager.SetLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.Horizontal, false));
            }
            catch (Exception e)
            { }
        }
    }
}