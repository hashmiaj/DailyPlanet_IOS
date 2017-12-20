// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace DailyPlanet_IOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton itemPageBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton scanBtn { get; set; }

        [Action ("ItemPageBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ItemPageBtn_TouchUpInside (UIKit.UIButton sender);

        [Action ("ScanBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ScanBtn_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (itemPageBtn != null) {
                itemPageBtn.Dispose ();
                itemPageBtn = null;
            }

            if (scanBtn != null) {
                scanBtn.Dispose ();
                scanBtn = null;
            }
        }
    }
}