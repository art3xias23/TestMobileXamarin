using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace BethanysPieShopMobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _cartButton;
        private Button _orderButton;
        private Button _aboutButton;
        private Button _tabsOrderButton;
        private Button _googleMapsButton;
        private Button _mapsButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            FindViews();
            LinkEventHandlers();
        }

        private void LinkEventHandlers()
        {
            _orderButton.Click += OrderButton_Click;
            _cartButton.Click += CartButton_Click;
            _aboutButton.Click += AboutButton_Click;
            _tabsOrderButton.Click += TabsOrderButton_Click;
            _googleMapsButton.Click += GoogleMapsButton_Click;
            _mapsButton.Click += MapsButton_Click;

        }

        private void FindViews()
        {
            _orderButton = FindViewById<Button>(Resource.Id.orderButton);
            _cartButton = FindViewById<Button>(Resource.Id.cartButton);
            _aboutButton = FindViewById<Button>(Resource.Id.aboutButton);
            _tabsOrderButton = FindViewById<Button>(Resource.Id.tabsOrderButton);
            _googleMapsButton = FindViewById<Button>(Resource.Id.googleMapsButton);
            _mapsButton = FindViewById<Button>(Resource.Id.mapsButton);

        }

        private void MapsButton_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MapActivity));
            StartActivity(intent);
        }

        private void GoogleMapsButton_Click(object sender, System.EventArgs e)
        {
            var geolocation = Android.Net.Uri.Parse("geo:50.850346,4.351721");
            var googleMapsIntent = new Intent(Intent.ActionView, geolocation);
            StartActivity(googleMapsIntent);
        }

        private void OrderButton_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(PieMenuActivity));
            StartActivity(intent);
        }

        private void AboutButton_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(AboutActivity));
            StartActivity(intent);
        }
        private void CartButton_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }

        private void TabsOrderButton_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(PieMenuWithTabsActivity));
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


    }
}