﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using UIKit;
using ZXing.Mobile;

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

            //var itemsViewController = segue.DestinationViewController as ItemController;


        }

        partial void ItemPageBtn_TouchUpInside(UIButton sender)
        {
            
        }

        partial void ScanBtn_TouchUpInside(UIButton sender)
        {
            /*
             * Below is Database code. You'll notice if you try using it
             * it wont work on the actual iphone but will connect to the
             * database when using the simulator. I think I know the solution
             * but I have to do a bit more research.

            */


            /*
            MySqlConnection sqlconn;
            string connsqlstring = "Server=127.0.0.1;Port=3306;database=test;User Id=root;Password=password;charset=utf8";
            sqlconn = new MySqlConnection();
            sqlconn.ConnectionString = connsqlstring;
            sqlconn.Open();
            string queryString = "select * from test.itemTable";
            MySqlCommand sqlcmd = new MySqlCommand(queryString, sqlconn);
            String result = sqlcmd.ExecuteScalar().ToString();
            scanBarcode(result);
            sqlconn.Close();
            */

            scanBarcode();
        }

        private async Task scanBarcode()
        {
            //Creates the barcode scanner and adds camera 
            var options = new ZXing.Mobile.MobileBarcodeScanningOptions
            {
                CameraResolutionSelector = HandleCameraResolutionSelectorDelegate
            };

            options.PossibleFormats = new List<ZXing.BarcodeFormat>(){
                ZXing.BarcodeFormat.EAN_8, ZXing.BarcodeFormat.EAN_13
            };

            var scanner = new ZXing.Mobile.MobileBarcodeScanner(this);
            scanner.AutoFocus();

            //Grabs the scanner result and displays it in the new page
            //The new page is the itemController
            var result = await scanner.Scan(options, true);
            string code = result.Text;
            if (result != null)
            {
                /*
                 * Here is where we create a new item page every time 
                 * something is scanned. You'll see this is where we
                 * also set the strings we created in ItemController
                 * so we can set it to what we want. Later we will set
                 * it to whatever the database data is.
                */


                ItemController controller = new ItemController();
                this.NavigationController.PushViewController(controller, true);
                controller.barCodeLableText = code;
                //controller.addLabelText = query;

                Console.WriteLine("Scanned Barcode: " + result.Text);
            }

        }

        //Sets camera resolution. Not sure what it really does lol 
        CameraResolution HandleCameraResolutionSelectorDelegate(List<CameraResolution> availableResolutions)
        {
            //Don't know if this will ever be null or empty
            if (availableResolutions == null || availableResolutions.Count < 1)
                return new CameraResolution() { Width = 800, Height = 600 };

            //Debugging revealed that the last element in the list
            //expresses the highest resolution. This could probably be more thorough.
            return availableResolutions[availableResolutions.Count - 1];
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}