package mono.com.pspdfkit.listeners;


public class TextSelectionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.pspdfkit.listeners.TextSelectionListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onTextSelectionChanged:(Lcom/pspdfkit/document/PSPDFDocument;III)V:GetOnTextSelectionChanged_Lcom_pspdfkit_document_PSPDFDocument_IIIHandler:PSPDFKit.Listeners.ITextSelectionListenerInvoker, PSPDFKit.Android\n" +
			"n_onTextSelectionEnded:(I)V:GetOnTextSelectionEnded_IHandler:PSPDFKit.Listeners.ITextSelectionListenerInvoker, PSPDFKit.Android\n" +
			"n_onTextSelectionStarted:(Lcom/pspdfkit/document/PSPDFDocument;III)Z:GetOnTextSelectionStarted_Lcom_pspdfkit_document_PSPDFDocument_IIIHandler:PSPDFKit.Listeners.ITextSelectionListenerInvoker, PSPDFKit.Android\n" +
			"";
		mono.android.Runtime.register ("PSPDFKit.Listeners.ITextSelectionListenerImplementor, PSPDFKit.Android, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null", TextSelectionListenerImplementor.class, __md_methods);
	}


	public TextSelectionListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TextSelectionListenerImplementor.class)
			mono.android.TypeManager.Activate ("PSPDFKit.Listeners.ITextSelectionListenerImplementor, PSPDFKit.Android, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onTextSelectionChanged (com.pspdfkit.document.PSPDFDocument p0, int p1, int p2, int p3)
	{
		n_onTextSelectionChanged (p0, p1, p2, p3);
	}

	private native void n_onTextSelectionChanged (com.pspdfkit.document.PSPDFDocument p0, int p1, int p2, int p3);


	public void onTextSelectionEnded (int p0)
	{
		n_onTextSelectionEnded (p0);
	}

	private native void n_onTextSelectionEnded (int p0);


	public boolean onTextSelectionStarted (com.pspdfkit.document.PSPDFDocument p0, int p1, int p2, int p3)
	{
		return n_onTextSelectionStarted (p0, p1, p2, p3);
	}

	private native boolean n_onTextSelectionStarted (com.pspdfkit.document.PSPDFDocument p0, int p1, int p2, int p3);

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
