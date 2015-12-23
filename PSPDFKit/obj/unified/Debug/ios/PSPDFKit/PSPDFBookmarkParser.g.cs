//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace PSPDFKit {
	[Register("PSPDFBookmarkParser", true)]
	public unsafe partial class PSPDFBookmarkParser : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFBookmarkParser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PSPDFBookmarkParser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PSPDFBookmarkParser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDocument:")]
		[CompilerGenerated]
		public PSPDFBookmarkParser (PSPDFDocument document)
			: base (NSObjectFlag.Empty)
		{
			if (document == null)
				throw new ArgumentNullException ("document");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDocument:"), document.Handle), "initWithDocument:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDocument:"), document.Handle), "initWithDocument:");
			}
		}
		
		[Export ("addBookmark:")]
		[CompilerGenerated]
		public virtual bool AddBookmark (PSPDFBookmark bookmark)
		{
			if (bookmark == null)
				throw new ArgumentNullException ("bookmark");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addBookmark:"), bookmark.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addBookmark:"), bookmark.Handle);
			}
		}
		
		[Export ("addBookmarkForPage:")]
		[CompilerGenerated]
		public virtual bool AddBookmark (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("addBookmarkForPage:"), page);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("addBookmarkForPage:"), page);
			}
		}
		
		[Export ("bookmarkForPage:")]
		[CompilerGenerated]
		public virtual PSPDFBookmark BookmarkForPage (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PSPDFBookmark> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("bookmarkForPage:"), page));
			} else {
				return  Runtime.GetNSObject<PSPDFBookmark> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("bookmarkForPage:"), page));
			}
		}
		
		[Export ("clearAllBookmarksWithError:")]
		[CompilerGenerated]
		internal virtual bool ClearAllBookmarksWithError (global::System.IntPtr error)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("clearAllBookmarksWithError:"), error);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("clearAllBookmarksWithError:"), error);
			}
		}
		
		[Export ("loadBookmarksWithError:")]
		[CompilerGenerated]
		internal virtual PSPDFBookmark[] LoadBookmarksWithError (global::System.IntPtr error)
		{
			if (IsDirectBinding) {
				return NSArray.ArrayFromHandle<PSPDFBookmark>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadBookmarksWithError:"), error));
			} else {
				return NSArray.ArrayFromHandle<PSPDFBookmark>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadBookmarksWithError:"), error));
			}
		}
		
		[Export ("removeBookmarkForPage:")]
		[CompilerGenerated]
		public virtual bool RemoveBookmark (global::System.nuint page)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("removeBookmarkForPage:"), page);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("removeBookmarkForPage:"), page);
			}
		}
		
		[Export ("saveBookmarksWithError:")]
		[CompilerGenerated]
		internal virtual bool SaveBookmarksWithError (global::System.IntPtr error)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("saveBookmarksWithError:"), error);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("saveBookmarksWithError:"), error);
			}
		}
		
		[CompilerGenerated]
		public virtual string BookmarkPath {
			[Export ("bookmarkPath")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bookmarkPath")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bookmarkPath")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Bookmarks_var;
		[CompilerGenerated]
		public virtual PSPDFBookmark[] Bookmarks {
			[Export ("bookmarks", ArgumentSemantic.Copy)]
			get {
				PSPDFBookmark[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<PSPDFBookmark>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bookmarks")));
				} else {
					ret = NSArray.ArrayFromHandle<PSPDFBookmark>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bookmarks")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Bookmarks_var = ret;
				return ret;
			}
			
			[Export ("setBookmarks:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBookmarks:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBookmarks:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_Bookmarks_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Document_var;
		[CompilerGenerated]
		public virtual PSPDFDocument Document {
			[Export ("document", ArgumentSemantic.Weak)]
			get {
				PSPDFDocument ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("document")));
				} else {
					ret =  Runtime.GetNSObject<PSPDFDocument> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("document")));
				}
				MarkDirty ();
				__mt_Document_var = ret;
				return ret;
			}
			
			[Export ("setDocument:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDocument:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDocument:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_Document_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Bookmarks_var = null;
				__mt_Document_var = null;
			}
		}
	} /* class PSPDFBookmarkParser */
}
