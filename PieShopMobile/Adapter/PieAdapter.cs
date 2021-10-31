using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using PieShopMobile.Core.Model;
using PieShopMobile.Core.Model.Repository;
using PieShopMobile.Utility;
using PieShopMobile.ViewHolders;

namespace PieShopMobile.Adapter
{
    public class PieAdapter : RecyclerView.Adapter
    {
        private List<Pie> _pies;
        private PieRepository _pieRepository;
        public event EventHandler<int> ViewHolderItemClick;

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.pie_viewholder, parent, false);

            PieViewHolder pieViewHolder = new PieViewHolder(itemView,Listener);

            return pieViewHolder;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if(holder is PieViewHolder pieViewHolder)
            {
                pieViewHolder.PieNameTextView.Text = _pies[position].Name;

                var imageBitmat = ImageHelper.GetImageBitmapFromUrl(_pies[position].ImageThumbnailUrl);
                pieViewHolder.PieImageView.SetImageBitmap(imageBitmat);
            }
        }

        public override int ItemCount => _pies.Count;
        public PieAdapter()
        {
            _pieRepository = new PieRepository();
            _pies = _pieRepository.GetAllPies();
        }

        public void Listener(int position)
        {
            var pieClickedId = _pies[position].PieId;
            ViewHolderItemClick?.Invoke(this, pieClickedId);
        }
    }
}