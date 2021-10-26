using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using Android.Support.V7.Widget;

namespace PieShopMobile.ViewHolders
{
    public class PieViewHolder : RecyclerView.ViewHolder
    {

        public ImageView PieImageView { get; set; }
        public TextView PieNameTextView { get; set; }
        public PieViewHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public PieViewHolder(View itemView) : base(itemView)
        {
            PieImageView = itemView.FindViewById<ImageView>(Resource.Id.pieImageView);
            PieNameTextView = itemView.FindViewById<TextView>(Resource.Id.pieNameTextView);
        }
    }
}