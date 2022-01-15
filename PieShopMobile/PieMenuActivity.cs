using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V4.Content.Res;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using PieShopMobile.Adapter;

namespace PieShopMobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]

    public class PieMenuActivity : AppCompatActivity
    {
        private RecyclerView _pieRecyclerView;
        private RecyclerView.LayoutManager _pieLayoutManager;
        private PieAdapter _pieAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.pie_menu);
            _pieRecyclerView = FindViewById<RecyclerView>(Resource.Id.pieMenuRecyclerView);

            _pieAdapter = new PieAdapter();
            _pieAdapter.ItemClick += PieAdapter_ItemClick;

            _pieLayoutManager = new LinearLayoutManager(this);
            _pieRecyclerView.SetLayoutManager(_pieLayoutManager);
            _pieRecyclerView.SetAdapter(_pieAdapter);
        }

        private void PieAdapter_ItemClick(object sender, int e)
        {
            var intent = new Intent();
            intent.SetClass(this, typeof(PieDetailActivity));
            intent.PutExtra("selectedPieId", e);
            StartActivity(intent);
        }
    }
}