using System;

using UIKit;

namespace XamariniOSBackgroundColor
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}



		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}



		partial void BtnRed_TouchUpInside(UIButton sender)
		{
			View.BackgroundColor = UIColor.Red;
		}
		partial void BtnBlue_TouchUpInside(UIButton sender)
		{
			View.BackgroundColor = UIColor.Blue;

		}
		partial void BtnGreen_TouchUpInside(UIButton sender)
		{
			View.BackgroundColor = UIColor.Green;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
