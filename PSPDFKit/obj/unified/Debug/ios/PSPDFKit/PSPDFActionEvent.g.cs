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
	public unsafe static partial class PSPDFActionEvent  {
		
		[CompilerGenerated]
		static NSString _ChangeKey;
		[Field ("PSPDFActionEventChangeKey",  "__Internal")]
		public static unsafe NSString ChangeKey {
			get {
				if (_ChangeKey == null)
					_ChangeKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventChangeKey");
				return _ChangeKey;
			}
		}
		[CompilerGenerated]
		static NSString _NameKey;
		[Field ("PSPDFActionEventNameKey",  "__Internal")]
		public static unsafe NSString NameKey {
			get {
				if (_NameKey == null)
					_NameKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventNameKey");
				return _NameKey;
			}
		}
		[CompilerGenerated]
		static NSString _NameValueBlur;
		[Field ("PSPDFActionEventNameValueBlur",  "__Internal")]
		public static unsafe NSString NameValueBlur {
			get {
				if (_NameValueBlur == null)
					_NameValueBlur = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventNameValueBlur");
				return _NameValueBlur;
			}
		}
		[CompilerGenerated]
		static NSString _NameValueCalculate;
		[Field ("PSPDFActionEventNameValueCalculate",  "__Internal")]
		public static unsafe NSString NameValueCalculate {
			get {
				if (_NameValueCalculate == null)
					_NameValueCalculate = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventNameValueCalculate");
				return _NameValueCalculate;
			}
		}
		[CompilerGenerated]
		static NSString _NameValueFocus;
		[Field ("PSPDFActionEventNameValueFocus",  "__Internal")]
		public static unsafe NSString NameValueFocus {
			get {
				if (_NameValueFocus == null)
					_NameValueFocus = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventNameValueFocus");
				return _NameValueFocus;
			}
		}
		[CompilerGenerated]
		static NSString _NameValueFormat;
		[Field ("PSPDFActionEventNameValueFormat",  "__Internal")]
		public static unsafe NSString NameValueFormat {
			get {
				if (_NameValueFormat == null)
					_NameValueFormat = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventNameValueFormat");
				return _NameValueFormat;
			}
		}
		[CompilerGenerated]
		static NSString _NameValueKeystroke;
		[Field ("PSPDFActionEventNameValueKeystroke",  "__Internal")]
		public static unsafe NSString NameValueKeystroke {
			get {
				if (_NameValueKeystroke == null)
					_NameValueKeystroke = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventNameValueKeystroke");
				return _NameValueKeystroke;
			}
		}
		[CompilerGenerated]
		static NSString _NameValueMouseDown;
		[Field ("PSPDFActionEventNameValueMouseDown",  "__Internal")]
		public static unsafe NSString NameValueMouseDown {
			get {
				if (_NameValueMouseDown == null)
					_NameValueMouseDown = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventNameValueMouseDown");
				return _NameValueMouseDown;
			}
		}
		[CompilerGenerated]
		static NSString _NameValueMouseExit;
		[Field ("PSPDFActionEventNameValueMouseExit",  "__Internal")]
		public static unsafe NSString NameValueMouseExit {
			get {
				if (_NameValueMouseExit == null)
					_NameValueMouseExit = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventNameValueMouseExit");
				return _NameValueMouseExit;
			}
		}
		[CompilerGenerated]
		static NSString _NameValueMouseUp;
		[Field ("PSPDFActionEventNameValueMouseUp",  "__Internal")]
		public static unsafe NSString NameValueMouseUp {
			get {
				if (_NameValueMouseUp == null)
					_NameValueMouseUp = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventNameValueMouseUp");
				return _NameValueMouseUp;
			}
		}
		[CompilerGenerated]
		static NSString _NameValueValidate;
		[Field ("PSPDFActionEventNameValueValidate",  "__Internal")]
		public static unsafe NSString NameValueValidate {
			get {
				if (_NameValueValidate == null)
					_NameValueValidate = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventNameValueValidate");
				return _NameValueValidate;
			}
		}
		[CompilerGenerated]
		static NSString _RCKey;
		[Field ("PSPDFActionEventRCKey",  "__Internal")]
		public static unsafe NSString RCKey {
			get {
				if (_RCKey == null)
					_RCKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventRCKey");
				return _RCKey;
			}
		}
		[CompilerGenerated]
		static NSString _SelEndKey;
		[Field ("PSPDFActionEventSelEndKey",  "__Internal")]
		public static unsafe NSString SelEndKey {
			get {
				if (_SelEndKey == null)
					_SelEndKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventSelEndKey");
				return _SelEndKey;
			}
		}
		[CompilerGenerated]
		static NSString _SelStartKey;
		[Field ("PSPDFActionEventSelStartKey",  "__Internal")]
		public static unsafe NSString SelStartKey {
			get {
				if (_SelStartKey == null)
					_SelStartKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventSelStartKey");
				return _SelStartKey;
			}
		}
		[CompilerGenerated]
		static NSString _SourceKey;
		[Field ("PSPDFActionEventSourceKey",  "__Internal")]
		public static unsafe NSString SourceKey {
			get {
				if (_SourceKey == null)
					_SourceKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventSourceKey");
				return _SourceKey;
			}
		}
		[CompilerGenerated]
		static NSString _TargetKey;
		[Field ("PSPDFActionEventTargetKey",  "__Internal")]
		public static unsafe NSString TargetKey {
			get {
				if (_TargetKey == null)
					_TargetKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventTargetKey");
				return _TargetKey;
			}
		}
		[CompilerGenerated]
		static NSString _TargetNameKey;
		[Field ("PSPDFActionEventTargetNameKey",  "__Internal")]
		public static unsafe NSString TargetNameKey {
			get {
				if (_TargetNameKey == null)
					_TargetNameKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventTargetNameKey");
				return _TargetNameKey;
			}
		}
		[CompilerGenerated]
		static NSString _TypeKey;
		[Field ("PSPDFActionEventTypeKey",  "__Internal")]
		public static unsafe NSString TypeKey {
			get {
				if (_TypeKey == null)
					_TypeKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventTypeKey");
				return _TypeKey;
			}
		}
		[CompilerGenerated]
		static NSString _TypeValueField;
		[Field ("PSPDFActionEventTypeValueField",  "__Internal")]
		public static unsafe NSString TypeValueField {
			get {
				if (_TypeValueField == null)
					_TypeValueField = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventTypeValueField");
				return _TypeValueField;
			}
		}
		[CompilerGenerated]
		static NSString _ValueKey;
		[Field ("PSPDFActionEventValueKey",  "__Internal")]
		public static unsafe NSString ValueKey {
			get {
				if (_ValueKey == null)
					_ValueKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventValueKey");
				return _ValueKey;
			}
		}
		[CompilerGenerated]
		static NSString _ValueMouseEnter;
		[Field ("PSPDFActionEventNameValueMouseEnter",  "__Internal")]
		public static unsafe NSString ValueMouseEnter {
			get {
				if (_ValueMouseEnter == null)
					_ValueMouseEnter = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventNameValueMouseEnter");
				return _ValueMouseEnter;
			}
		}
		[CompilerGenerated]
		static NSString _WillCommitKey;
		[Field ("PSPDFActionEventWillCommitKey",  "__Internal")]
		public static unsafe NSString WillCommitKey {
			get {
				if (_WillCommitKey == null)
					_WillCommitKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PSPDFActionEventWillCommitKey");
				return _WillCommitKey;
			}
		}
	} /* class PSPDFActionEvent */
}
