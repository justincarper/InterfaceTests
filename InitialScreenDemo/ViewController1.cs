using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace InitialScreenDemo
{
	partial class ViewController1 : UIViewController
	{
		public ViewController1 (IntPtr handle) : base (handle)
		{
		}

		partial void InitialButtonTouched (UIButton sender)
		{
			aButton.Hidden = true;  
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			if (ParentViewController != null) {
				aButton.Hidden = true;
			}
		}
	}
}
