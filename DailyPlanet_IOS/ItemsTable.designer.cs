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
    [Register ("ItemsTable")]
    partial class ItemsTable
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel itemDescriptionLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel itemNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ItemNumberLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (itemDescriptionLabel != null) {
                itemDescriptionLabel.Dispose ();
                itemDescriptionLabel = null;
            }

            if (itemNameLabel != null) {
                itemNameLabel.Dispose ();
                itemNameLabel = null;
            }

            if (ItemNumberLabel != null) {
                ItemNumberLabel.Dispose ();
                ItemNumberLabel = null;
            }
        }
    }
}