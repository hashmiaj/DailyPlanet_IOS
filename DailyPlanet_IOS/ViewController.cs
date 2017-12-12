using System;
using UIKit;

namespace DailyPlanet_IOS
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

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            //var itemsViewController = segue.DestinationViewController as itemsViewController;

        }

        partial void ItemPageBtn_TouchUpInside(UIButton sender)
        {
            
        }

        partial void ScanBtn_TouchUpInside(UIButton sender)
        {
            var scanner = new ZXing.Mobile.MobileBarcodeScanner();
            var result =  scanner.Scan();

            if (result != null)
                Console.WriteLine("Scanned Barcode: " + result.ToString());
            


        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
