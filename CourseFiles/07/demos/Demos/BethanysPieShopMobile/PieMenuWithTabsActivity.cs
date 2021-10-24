using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using BethanysPieShopMobile.Adapters;

namespace BethanysPieShopMobile
{
    [Activity(Label = "PieMenuWithTabsActivity")]
    public class PieMenuWithTabsActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pie_menu_tabs);
            // Create your application here

            CategoryFragmentAdapter categoryFragmentAdapter = new CategoryFragmentAdapter(SupportFragmentManager);

            ViewPager viewPager = FindViewById<ViewPager>(Resource.Id.piePager);
            viewPager.Adapter = categoryFragmentAdapter;
        }
    }
}