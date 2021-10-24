
using Android.App;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Support.V7.App;


namespace BethanysPieShopMobile
{
    [Activity(Label = "MapActivity")]
    public class MapActivity : AppCompatActivity, IOnMapReadyCallback
    {
        private readonly LatLng _bethanysPieShopLocation = new LatLng(50.850346, 4.351721);
        GoogleMap _googleMap;

        public void OnMapReady(GoogleMap map)
        {
            _googleMap = map;

            _googleMap.UiSettings.ZoomControlsEnabled = true;
            _googleMap.UiSettings.CompassEnabled = true;
            _googleMap.UiSettings.MyLocationButtonEnabled = false;
            AddMarker();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.bethany_map);

            var mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);
        }

        void AddMarker()
        {
            var marker = new MarkerOptions();
            marker.SetPosition(_bethanysPieShopLocation)
                               .SetTitle("Bethany's Pie Shop");
            _googleMap.AddMarker(marker);

            var cameraUpdate = CameraUpdateFactory.NewLatLngZoom(_bethanysPieShopLocation, 15);
            _googleMap.MoveCamera(cameraUpdate);
        }
    }
}