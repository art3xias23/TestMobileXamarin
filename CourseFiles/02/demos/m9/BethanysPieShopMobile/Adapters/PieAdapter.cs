using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using BethanysPieShopMobile.Core.Model;
using BethanysPieShopMobile.Core.Repository;
using BethanysPieShopMobile.Utility;
using BethanysPieShopMobile.ViewHolders;

namespace BethanysPieShopMobile.Adapters
{
    public class PieAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;
        private List<Pie> _pies;
        public PieAdapter()
        {
            var pieRepository = new PieRepository();
            _pies = pieRepository.GetAllPies();
            //var pieRepository = new PieRepository();
            //_pies = pieRepository.GetAllPies();
        }
        public PieAdapter(Category category)
        {
            _pies = category.Pies;
        }

        public override int ItemCount => _pies.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (holder is PieViewHolder pieViewHolder)
            {
                pieViewHolder.PieNameTextView.Text = _pies[position].Name;

                var imageBitmap = ImageHelper.GetImageBitmapFromUrl(_pies[position].ImageThumbnailUrl);
                pieViewHolder.PieImageView.SetImageBitmap(imageBitmap);
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView =
                LayoutInflater.From(parent.Context).Inflate(Resource.Layout.pie_viewholder, parent, false);

            PieViewHolder pieViewHolder = new PieViewHolder(itemView, OnClick);
            return pieViewHolder;
        }

        void OnClick(int position)
        {
            var pieId = _pies[position].PieId;
            ItemClick?.Invoke(this, pieId);
        }
    }
}