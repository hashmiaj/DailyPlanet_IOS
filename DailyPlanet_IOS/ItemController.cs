using System;

using UIKit;

namespace DailyPlanet_IOS
{
    public partial class ItemController : UIViewController
    {
        /*
         * These strings are created so that they can be accessed 
         * by the ViewController. In the ViewController.cs there
         * are comments on where they are being accessed and 
         * changed. So if you add anything to the itemController.xib
         * and you need to access it from the ViewController then just 
         * add a string and set it below in the ViewDidLoad().
        */


        public string switchText
        {
            get;
            set;
        }

        public string barCodeLableText
        {
            get;
            set;
        }

        public string addLabelText
        {
            get;
            set;
        }

        public string itemCountText
        {
            get;
            set;
        }

        //Here is how the label changes when the switch is toggled
        partial void addSwitchValueChanged(UISwitch sender)
        {
            bool state = ((UISwitch)addSwitch).On;
            if (state)
            {
                addLabel.Text = "Add";
            }
            else
            {
                addLabel.Text = "Remove";
            }
        }

        public ItemController() : base("ItemController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //Here is where we set the actual barcodeLable text
            barcodeLabel.Text = barCodeLableText;


            //And here is where we set the addLable text
            //addLabel.Text = addLabelText;

        }

        partial void SubmitBtn_TouchUpInside(UIButton sender)
        {
            //POP Confirmation Window....
            //Update Database....

            itemCount.Text = "50";
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

