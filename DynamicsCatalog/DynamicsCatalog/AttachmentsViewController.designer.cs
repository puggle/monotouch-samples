// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace DynamicsCatalog
{
	[Register ("AttachmentsViewController")]
	partial class AttachmentsViewController
	{
		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIView blueSquare { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIView redSquare { get; set; }

		[Outlet]
		[GeneratedCodeAttribute ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIView square { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (redSquare != null) {
				redSquare.Dispose ();
				redSquare = null;
			}

			if (square != null) {
				square.Dispose ();
				square = null;
			}

			if (blueSquare != null) {
				blueSquare.Dispose ();
				blueSquare = null;
			}
		}
	}
}
