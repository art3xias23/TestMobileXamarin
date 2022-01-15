package crc64ea28df04fd7a3678;


public class CartViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("PieShopMobile.ViewHolders.CartViewHolder, PieShopMobile", CartViewHolder.class, __md_methods);
	}


	public CartViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == CartViewHolder.class)
			mono.android.TypeManager.Activate ("PieShopMobile.ViewHolders.CartViewHolder, PieShopMobile", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
