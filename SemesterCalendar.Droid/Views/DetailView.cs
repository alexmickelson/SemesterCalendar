using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;
using SemesterCalendar.Core.ViewModels;
using MvvmCross.Droid.Support.V7.RecyclerView;
using Android.Support.V7.Widget;

namespace SemesterCalendar.Droid.Views
{
    [Activity(Label = "SemesterDetail", MainLauncher = false)]
    public class DetailView : MvxActivity<DetailViewModel>
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //TODO: BarLayout
            SetContentView(Resource.Layout.SemesterDetailView);

            try
            {
                MvxRecyclerView layoutManager = FindViewById<MvxRecyclerView>(Resource.Id.ClassRecView);
                layoutManager.SetLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.Horizontal, false));
            }
            catch (Exception e)
            { }


            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.InflateMenu(Resource.Menu.scroll_right);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            base.OnCreateOptionsMenu(menu);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.InflateMenu(Resource.Menu.scroll_right);
            return true;
        }
    }
}