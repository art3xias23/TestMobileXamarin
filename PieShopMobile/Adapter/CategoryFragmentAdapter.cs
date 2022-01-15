using Android.Support.V4.App;
using PieShopMobile.Core.Model;
using PieShopMobile.Core.Model.Repository;
using PieShopMobile.Fragments;
using System;
using System.Collections.Generic;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace PieShopMobile.Adapter
{
    public class CategoryFragmentAdapter : FragmentPagerAdapter
    {
        private List<Category> _categories;
        public override int Count => _categories.Count;

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            PieCategoryFragment pieCategoryFragment = new PieCategoryFragment(_categories[position]);
            return pieCategoryFragment;
        }

        public CategoryFragmentAdapter(FragmentManager fm) : base(fm)
        {
            var pieRepository = new PieRepository();
            _categories = pieRepository.GetCategoriesWithPies();
        }

        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(_categories[position].CategoryName);
        }
    }
}