package mono.com.pspdfkit.media;


public class MediaViewListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pspdfkit.media.MediaViewListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onContentError:()V:GetOnContentErrorHandler:PSPDFKit.Media.IMediaViewListenerInvoker, PSPDFKit.Android\n" +
			"n_onContentReady:()V:GetOnContentReadyHandler:PSPDFKit.Media.IMediaViewListenerInvoker, PSPDFKit.Android\n" +
			"";
		mono.android.Runtime.register ("PSPDFKit.Media.IMediaViewListenerImplementor, PSPDFKit.Android, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null", MediaViewListenerImplementor.class, __md_methods);
	}


	public MediaViewListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MediaViewListenerImplementor.class)
			mono.android.TypeManager.Activate ("PSPDFKit.Media.IMediaViewListenerImplementor, PSPDFKit.Android, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onContentError ()
	{
		n_onContentError ();
	}

	private native void n_onContentError ();


	public void onContentReady ()
	{
		n_onContentReady ();
	}

	private native void n_onContentReady ();

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
