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
	public delegate NSData PSPDFCacheDecryptFromPathHandler (PSPDFKit.PSPDFDocument document, string path);
	public delegate void PSPDFCacheEncryptDataHandler (PSPDFKit.PSPDFDocument document, NSMutableData data);
	public delegate void PSPDFRenderJobCompletionHandler (PSPDFKit.PSPDFRenderJob renderJob, PSPDFKit.PSPDFRenderQueue renderQueue);
	public delegate bool PSPDFFileManagerErrorHandler (NSUrl url, NSError error);
	public delegate bool PSPDFDownloadManagerPredicateHandler (NSObject obj, nuint index, bool stop);
	public delegate void PSPDFDownloadManagerDelegateAuthCompletionHandler (NSUrlSessionAuthChallengeDisposition disposition, NSUrlCredential credential);
	public delegate void PSPDFRemoteFileObjectRemoteObjectHandler (PSPDFKit.IPSPDFRemoteContentObject remoteObject);
	public delegate UIImage PSPDFAnnotationGroupItemConfigurationHandler (PSPDFKit.PSPDFAnnotationGroupItem item, NSObject container, UIColor tintColor);
	public delegate void PSPDFProcessorPdfFromUrlHandler (NSUrl fileUrl, NSError error);
	public delegate void PSPDFProcessorPdfFromUrlNsdataHandler (NSData fileData, NSError error);
	public delegate void PSPDFProcessorProgressHandler (nuint currentPage, nuint numberOfProcessedPages, nuint totalPages);
	public delegate NSInputStream PSPDFXFDFAnnotationProviderStreamHandler (PSPDFKit.PSPDFXFDFAnnotationProvider provider);
	public delegate void PSPDFPKCS12UnlockHandler (PSPDFKit.PSPDFX509 x509, PSPDFKit.PSPDFRSAKey pk, NSError error);
	public delegate void PSPDFPKCS12SignerSignHandler (bool success, PSPDFKit.PSPDFDocument document, NSError error);
	public delegate void PSPDFErrorViewFormatterHandler (NSError error, string outTitle, string outSubtitle);
	public delegate void PSPDFRemoteContentObjectDispositionHandler (NSUrlSessionAuthChallengeDisposition disposition, NSUrlCredential credential);
	public delegate void PSPDFRemoteContentObjectAuthHandler (NSUrlAuthenticationChallenge challenge, PSPDFKit.PSPDFRemoteContentObjectDispositionHandler dispHandler);
	public delegate void PSPDFRemoteContentObjectRemoteObjectHandler (PSPDFKit.PSPDFRemoteContentObject obj);
	public delegate NSObject PSPDFRemoteContentObjectTransformerHandler (NSUrl location);
}

