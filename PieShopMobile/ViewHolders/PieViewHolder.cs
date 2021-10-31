using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Runtime.Remoting.Channels;
using Android.Support.V7.Widget;

namespace PieShopMobile.ViewHolders
{
    public class PieViewHolder : RecyclerView.ViewHolder
    {

        public ImageView PieImageView { get; set; }
        public TextView PieNameTextView { get; set; }
        private Action<int> _listener;
        public PieViewHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public PieViewHolder(View itemView,Action<int> listener) : base(itemView)
        {
            PieImageView = itemView.FindViewById<ImageView>(Resource.Id.pieImageView);
            PieNameTextView = itemView.FindViewById<TextView>(Resource.Id.pieNameTextView);

            itemView.Click += ItemViewClick;

            _listener = listener;

        }

        public void ItemViewClick(object s, EventArgs e)
        {
            _listener(base.LayoutPosition);
        }
    }
}