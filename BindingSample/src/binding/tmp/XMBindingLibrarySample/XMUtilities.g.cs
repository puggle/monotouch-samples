//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace XMBindingLibrarySample {
	[Register("XMUtilities", true)]
	public unsafe partial class XMUtilities : NSObject {
		[CompilerGenerated]
		const string selEcho_ = "echo:";
		static readonly IntPtr selEcho_Handle = Selector.GetHandle ("echo:");
		[CompilerGenerated]
		const string selHello_ = "hello:";
		static readonly IntPtr selHello_Handle = Selector.GetHandle ("hello:");
		[CompilerGenerated]
		const string selAddAnd_ = "add:and:";
		static readonly IntPtr selAddAnd_Handle = Selector.GetHandle ("add:and:");
		[CompilerGenerated]
		const string selMultiplyAnd = "multiply:and";
		static readonly IntPtr selMultiplyAndHandle = Selector.GetHandle ("multiply:and");
		[CompilerGenerated]
		const string selSetCallback_ = "setCallback:";
		static readonly IntPtr selSetCallback_Handle = Selector.GetHandle ("setCallback:");
		[CompilerGenerated]
		const string selInvokeCallback_ = "invokeCallback:";
		static readonly IntPtr selInvokeCallback_Handle = Selector.GetHandle ("invokeCallback:");
		[CompilerGenerated]
		const string selSurface_ = "surface:";
		static readonly IntPtr selSurface_Handle = Selector.GetHandle ("surface:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("XMUtilities");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public XMUtilities () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::XMBindingLibrarySample.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public XMUtilities (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::XMBindingLibrarySample.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public XMUtilities (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::XMBindingLibrarySample.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public XMUtilities (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::XMBindingLibrarySample.Messaging.this_assembly;
		}

		[Export ("echo:")]
		[CompilerGenerated]
		public static string Echo (string message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			string ret;
			ret = NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selEcho_Handle, nsmessage));
			NSString.ReleaseNative (nsmessage);
			
			return ret;
		}
		
		[Export ("hello:")]
		[CompilerGenerated]
		public virtual string Hello (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selHello_Handle, nsname));
			} else {
				ret = NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selHello_Handle, nsname));
			}
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("add:and:")]
		[CompilerGenerated]
		public virtual int Add (int operandUn, int operandDeux)
		{
			if (IsDirectBinding) {
				return XMBindingLibrarySample.Messaging.int_objc_msgSend_int_int (this.Handle, selAddAnd_Handle, operandUn, operandDeux);
			} else {
				return XMBindingLibrarySample.Messaging.int_objc_msgSendSuper_int_int (this.SuperHandle, selAddAnd_Handle, operandUn, operandDeux);
			}
		}
		
		[Export ("multiply:and")]
		[CompilerGenerated]
		public virtual int Multiply (int operandUn, int operandDeux)
		{
			if (IsDirectBinding) {
				return XMBindingLibrarySample.Messaging.int_objc_msgSend_int_int (this.Handle, selMultiplyAndHandle, operandUn, operandDeux);
			} else {
				return XMBindingLibrarySample.Messaging.int_objc_msgSendSuper_int_int (this.SuperHandle, selMultiplyAndHandle, operandUn, operandDeux);
			}
		}
		
		[Export ("setCallback:")]
		[CompilerGenerated]
		public unsafe virtual void SetCallback ([BlockProxy (typeof (MonoTouch.ObjCRuntime.Trampolines.NIDXMUtilityCallback))]XMUtilityCallback callback)
		{
			if (callback == null)
				throw new ArgumentNullException ("callback");
			BlockLiteral *block_ptr_callback;
			BlockLiteral block_callback;
			block_callback = new BlockLiteral ();
			block_ptr_callback = &block_callback;
			block_callback.SetupBlock (Trampolines.SDXMUtilityCallback.Handler, callback);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCallback_Handle, (IntPtr) block_ptr_callback);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCallback_Handle, (IntPtr) block_ptr_callback);
			}
			block_ptr_callback->CleanupBlock ();
			
		}
		
		[Export ("invokeCallback:")]
		[CompilerGenerated]
		public virtual void InvokeCallback (NSString message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInvokeCallback_Handle, message.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selInvokeCallback_Handle, message.Handle);
			}
		}
		
		[Export ("surface:")]
		[CompilerGenerated]
		public virtual NSString Surface (SampleProtocol target)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSString> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selSurface_Handle, target.Handle));
			} else {
				return  Runtime.GetNSObject<NSString> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selSurface_Handle, target.Handle));
			}
		}
		
	} /* class XMUtilities */
	public delegate void XMUtilityCallback (string message);
}
