package md547d34cffa36765bad5123b9f67b48815;


public class SelfDisposingAsyncDrawable
	extends md547d34cffa36765bad5123b9f67b48815.SelfDisposingBitmapDrawable
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("FFImageLoading.Drawables.SelfDisposingAsyncDrawable, FFImageLoading.Droid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", SelfDisposingAsyncDrawable.class, __md_methods);
	}


	public SelfDisposingAsyncDrawable (android.content.res.Resources p0, android.graphics.Bitmap p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == SelfDisposingAsyncDrawable.class)
			mono.android.TypeManager.Activate ("FFImageLoading.Drawables.SelfDisposingAsyncDrawable, FFImageLoading.Droid, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Res.Resources, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Graphics.Bitmap, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}

	java.util.ArrayList refList;
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
