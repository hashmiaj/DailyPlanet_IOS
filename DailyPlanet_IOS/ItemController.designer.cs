// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DailyPlanet_IOS
{
    [Register ("ItemController")]
    partial class ItemController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel addLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch addSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel barcodeLable { get; set; }

        [Action ("addSwitchValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void addSwitchValueChanged (UIKit.UISwitch sender);

        void ReleaseDesignerOutlets ()
        {
            if (addLabel != null) {
                addLabel.Dispose ();
                addLabel = null;
            }

            if (addSwitch != null) {
                addSwitch.Dispose ();
                addSwitch = null;
            }

            if (barcodeLable != null) {
                barcodeLable.Dispose ();
                barcodeLable = null;
            }
        }
    }
}