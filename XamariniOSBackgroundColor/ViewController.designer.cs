// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamariniOSBackgroundColor
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnBlue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnGreen { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRed { get; set; }

        [Action ("BtnBlue_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnBlue_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnGreen_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnGreen_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnRed_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnRed_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnBlue != null) {
                btnBlue.Dispose ();
                btnBlue = null;
            }

            if (btnGreen != null) {
                btnGreen.Dispose ();
                btnGreen = null;
            }

            if (btnRed != null) {
                btnRed.Dispose ();
                btnRed = null;
            }
        }
    }
}