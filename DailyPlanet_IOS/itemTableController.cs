using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace DailyPlanet_IOS
{
    public partial class itemTableController : UIViewController
    {
        public itemTableController() : base("itemTableController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var items = new List<Item>
            {
                new Item
                {
                    itemName = "Bandage, Adhsv Shr Strp 1x3 (100/bx 24bx/cs) Mgm16",
                    itemCode = "466878",
                    itemNumber = "15"
                },
                new Item
                {
                    itemName = "Cover, Probe Oral (500/cs) Kendal",
                    itemCode = "649155",
                    itemNumber = "12"
                },
                new Item
                {
                    itemName = "Thermometer, Ear Thermoscan Pro-4000 Wa",
                    itemCode = "504790",
                    itemNumber = "3"
                }
            };

            itemTableView.Source = new ItemTVS(items);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

