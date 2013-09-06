// 
//  Copyright 2012  abhatia
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System;
using System.Linq;
using MonoTouch.Dialog;
using MonoTouch.Foundation;
using XMBindingLibrarySample;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;
using System.Runtime.InteropServices;

namespace Xamarin.XMBindingLibrarySample
{
	public class MyDialogViewController : DialogViewController {
		public MyDialogViewController(RootElement r, bool x)
			: base(r, x)
		{

		}
		[Export ("run:")]
		public virtual void Run ([BlockProxy (typeof (NIDActionArity1V1))] Action<string> postBack)
		{
		}

	}

	public class UtilitiesViewController : MyDialogViewController
	{
		XMUtilityCallback callback;
		XMUtilities Utility;
		
		public UtilitiesViewController()
			: base(new RootElement("XMUtilities Binding"), true)
		{
			
		}
		
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
		
		public override void LoadView()
		{
			base.LoadView();
			
			Utility = new XMUtilities();
			
			Utility.SetCallback (new XMUtilityCallback (OurCallback));
			
			var operandSection = new Section("Operands") {
				new EntryElement("Name: ", "", ""),
				new EntryElement("Operand One: ", "", ""),
				new EntryElement("Operand Two: ", "", ""),
			};
			
			var operationSection = new Section("Operations") {
				new StringElement("Add", Handle_AddOperation),
				new StringElement("Multiply", Handle_MultiplyOperation),
				new StringElement("Hello", Handle_HelloOperation),
				new StringElement("Invoke Callback", Handle_InvokeCallback),
				new StringElement("ObjC->C#->ObjC block callback", PostResultToObjectiveC),
			};
			
			var resultSection = new Section("Result") {
				new StringElement(@"")
			};
			
			var customViewSection = new Section("More Bindings") {
				new StringElement("Go to CustomView!", () => { 
					var c = new CustomViewController();
					
					this.NavigationController.PushViewController(c, true);
				})
			};
			
			this.Root.Add(new Section[] { operandSection, operationSection, resultSection, customViewSection });
		}
		
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
		}
		
		public override void ViewWillLayoutSubviews()
		{
			base.ViewWillLayoutSubviews();
		}
		
		void OurCallback (string message)
		{
			SetResultElementValue(message);
		}
		
		public void Handle_InvokeCallback ()
		{
			using (NSString message = new NSString ("Callback invoked!")) {
				Utility.InvokeCallback (message);
			}
		}
				
		public void Handle_AddOperation()
		{
			var one = Root[0][1] as EntryElement;
			var two = Root[0][2] as EntryElement;
			
			int un;
			int deux;
			if(int.TryParse(one.Value, out un) && int.TryParse(two.Value, out deux)) {
				SetResultElementValue(string.Format(@"{0}", un + deux));
			}
			
		}

		public void Handle_MultiplyOperation()
		{
			var one = Root[0][1] as EntryElement;
			var two = Root[0][2] as EntryElement;
			
			int un;
			int deux;
			if(int.TryParse(one.Value, out un) && int.TryParse(two.Value, out deux)) {
				SetResultElementValue(string.Format(@"{0}", un * deux));
			}
		}
		
		public void Handle_HelloOperation()
		{
			var nameElement = Root[0][0] as EntryElement;
			SetResultElementValue(Utility.Hello(nameElement.Value));
		}
		
		public void SetResultElementValue(string @value)
		{	
			using(var pool = new NSAutoreleasePool()) {
				pool.BeginInvokeOnMainThread(() => {
					var e = Root[2][0] as StringElement;
					if(e != null) {
						e.Caption = value;
						this.TableView.ReloadData();
					}
				});
			}
		}

		// 
		// This merely invokes a method in Objective-C that will in turn call back into the
		// Run method below.  This method in turn takes an Action<NSString> which we use
		// to post back a result
		//
		public void PostResultToObjectiveC ()
		{
			var myDelegate = new TheDelegate ();
			var result = Utility.Surface (myDelegate);
			SetResultElementValue (result);
		}

		class TheDelegate : SampleProtocol {
			public override void Run (XMUtilityCallback postBack)
			{
				postBack ("hello world");
			}
		}


	}

	internal class NIDActionArity1V1 {
		IntPtr blockPtr;
		DActionArity1V1 invoker;

		[Preserve (Conditional=true)]
		public unsafe NIDActionArity1V1 (BlockLiteral *block)
		{
			blockPtr = (IntPtr) block;
			IntPtr x = block->invoke;
			invoker = (DActionArity1V1) Marshal.GetDelegateForFunctionPointer (block->invoke, typeof (DActionArity1V1));
		}
		[Preserve (Conditional=true)]
		public unsafe static global::System.Action<string> Create (IntPtr block)
		{
			Console.WriteLine ("On Create");
			return new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
		}

		[Preserve (Conditional=true)]
		void Invoke (string obj)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			var nsobj = NSString.CreateNative (obj);

			invoker (blockPtr, nsobj);
			NSString.ReleaseNative (nsobj);

		}


	} /* class NIDActionArity1V1 */
	internal delegate void DActionArity1V1 (IntPtr block, IntPtr obj);

}

