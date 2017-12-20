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

        public ItemController() : base("ItemController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //Here is where we set the actual barcodeLable text
            barcodeLable.Text = barCodeLableText;

            //And here is where we set the addLable text
            addLabel.Text = addLabelText;

            //I was messing around trying to change the label when
            //you switch the addSwitch on and off.
            if(!addSwitch.State.ToString().Equals("Normal"))
            {
                addLabel.Text = "Remove";
            }

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

