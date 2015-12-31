package mono.com.pspdfkit.listeners;


public class PageListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pspdfkit.listeners.PageListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/MotionEvent;Landroid/graphics/PointF;Lcom/pspdfkit/annotations/Annotation;)Z:GetOnClick_Landroid_view_MotionEvent_Landroid_graphics_PointF_Lcom_pspdfkit_annotations_Annotation_Handler:PSPDFKit.Listeners.IPageListenerInvoker, PSPDFKit.Android\n" +
			"";
		mono.android.Runtime.register ("PSPDFKit.Listeners.IPageListenerImplementor, PSPDFKit.Android, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null", PageListenerImplementor.class, __md_methods);
	}


	public PageListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PageListenerImplementor.class)
			mono.android.TypeManager.Activate ("PSPDFKit.Listeners.IPageListenerImplementor, PSPDFKit.Android, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onClick (android.view.MotionEvent p0, android.graphics.PointF p1, com.pspdfkit.annotations.Annotation p2)
	{
		return n_onClick (p0, p1, p2);
	}

	private native boolean n_onClick (android.view.MotionEvent p0, android.graphics.PointF p1, com.pspdfkit.annotations.Annotation p2);

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
