using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace DailyPlanet_IOS
{
    public partial class itemListController : UITableViewController
    {
        List<Item> itemList;

        public itemListController()
        {
        }

        public itemListController (IntPtr handle) : base (handle)
        {
            itemList = new List<Item>();

            itemList.Add(new Item()
            {
                itemName = "Bandage, Adhsv Shr Strp 1x3 (100/bx 24bx/cs) Mgm16",
                itemCode = "466878",
                itemNumber = "15"
            });
            itemList.Add(new Item()
            {
                itemName = "Cover, Probe Oral (500/cs) Kendal",
                itemCode = "649155",
                itemNumber = "12"
            });
            itemList.Add(new Item()
            {
                itemName = "Thermometer, Ear Thermoscan Pro-4000 Wa",
                itemCode = "504790",
                itemNumber = "3"
            });
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return itemList.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            ItemController controller = new ItemController();
            this.NavigationController.PushViewController(controller, true);
            controller.itemNameText = itemList[indexPath.Row].itemName;
            controller.barCodeLableText = itemList[indexPath.Row].itemCode;
            controller.itemNumberText = itemList[indexPath.Row].itemNumber;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("cell_id") as itemCell;
            var data = itemList[indexPath.Row];
            cell.ItemData = data;
            return cell;
        }

    }
}