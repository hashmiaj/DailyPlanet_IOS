using System;

using UIKit;

namespace DailyPlanet_IOS
{
    public partial class itemTableViewController : UIViewController
    {
        public itemTableViewController() : base("itemTableViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

