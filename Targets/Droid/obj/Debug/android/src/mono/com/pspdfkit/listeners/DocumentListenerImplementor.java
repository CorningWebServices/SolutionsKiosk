package mono.com.pspdfkit.listeners;


public class DocumentListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pspdfkit.listeners.DocumentListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onDocumentClick:()Z:GetOnDocumentClickHandler:PSPDFKit.Listeners.IDocumentListenerInvoker, PSPDFKit.Android\n" +
			"n_onDocumentLoadFailed:(Ljava/lang/Throwable;)V:GetOnDocumentLoadFailed_Ljava_lang_Throwable_Handler:PSPDFKit.Listeners.IDocumentListenerInvoker, PSPDFKit.Android\n" +
			"n_onDocumentLoaded:(Lcom/pspdfkit/document/PSPDFDocument;)V:GetOnDocumentLoaded_Lcom_pspdfkit_document_PSPDFDocument_Handler:PSPDFKit.Listeners.IDocumentListenerInvoker, PSPDFKit.Android\n" +
			"n_onPageChanged:(Lcom/pspdfkit/document/PSPDFDocument;I)V:GetOnPageChanged_Lcom_pspdfkit_document_PSPDFDocument_IHandler:PSPDFKit.Listeners.IDocumentListenerInvoker, PSPDFKit.Android\n" +
			"n_onPageClick:(Lcom/pspdfkit/document/PSPDFDocument;ILandroid/view/MotionEvent;Landroid/graphics/PointF;Lcom/pspdfkit/annotations/Annotation;)Z:GetOnPageClick_Lcom_pspdfkit_document_PSPDFDocument_ILandroid_view_MotionEvent_Landroid_graphics_PointF_Lcom_pspdfkit_annotations_Annotation_Handler:PSPDFKit.Listeners.IDocumentListenerInvoker, PSPDFKit.Android\n" +
			"";
		mono.android.Runtime.register ("PSPDFKit.Listeners.IDocumentListenerImplementor, PSPDFKit.Android, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null", DocumentListenerImplementor.class, __md_methods);
	}


	public DocumentListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DocumentListenerImplementor.class)
			mono.android.TypeManager.Activate ("PSPDFKit.Listeners.IDocumentListenerImplementor, PSPDFKit.Android, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onDocumentClick ()
	{
		return n_onDocumentClick ();
	}

	private native boolean n_onDocumentClick ();


	public void onDocumentLoadFailed (java.lang.Throwable p0)
	{
		n_onDocumentLoadFailed (p0);
	}

	private native void n_onDocumentLoadFailed (java.lang.Throwable p0);


	public void onDocumentLoaded (com.pspdfkit.document.PSPDFDocument p0)
	{
		n_onDocumentLoaded (p0);
	}

	private native void n_onDocumentLoaded (com.pspdfkit.document.PSPDFDocument p0);


	public void onPageChanged (com.pspdfkit.document.PSPDFDocument p0, int p1)
	{
		n_onPageChanged (p0, p1);
	}

	private native void n_onPageChanged (com.pspdfkit.document.PSPDFDocument p0, int p1);


	public boolean onPageClick (com.pspdfkit.document.PSPDFDocument p0, int p1, android.view.MotionEvent p2, android.graphics.PointF p3, com.pspdfkit.annotations.Annotation p4)
	{
		return n_onPageClick (p0, p1, p2, p3, p4);
	}

	private native boolean n_onPageClick (com.pspdfkit.document.PSPDFDocument p0, int p1, android.view.MotionEvent p2, android.graphics.PointF p3, com.pspdfkit.annotations.Annotation p4);

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
