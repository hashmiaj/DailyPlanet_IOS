using System;

using UIKit;

namespace DailyPlanet_IOS
{
    public partial class ItemController : UIViewController
    {

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
            barcodeLable.Text = barCodeLableText;

            addLabel.Text = addLabelText;

            if(!addSwitch.State.ToString().Equals("Normal"))
            {
                addLabel.Text = "Remove";
            }

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

