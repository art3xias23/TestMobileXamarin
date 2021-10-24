using System.Collections.Generic;

using Android.App;
using Android.Support.V4.App;
using BethanysPieShopMobile.Core.Model;
using BethanysPieShopMobile.Core.Repository;
using BethanysPieShopMobile.Fragments;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace BethanysPieShopMobile.Adapters
{
    public class CategoryFragmentAdapter : FragmentPagerAdapter
    {
        private readonly List<Category> _categories;

        public CategoryFragmentAdapter(FragmentManager fm) : base(fm)
        {

            var pieRepository = new PieRepository();
            _categories = pieRepository.GetCategoriesWithPies();

        }
        public override int Count => _categories.Count;

        public override Fragment GetItem(int position)
        {
            PieCategoryFragment pieCategoryFragment = new PieCategoryFragment(_categories[position]);
            return pieCategoryFragment;
        }

        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(_categories[position].CategoryName);
        }
    }
}