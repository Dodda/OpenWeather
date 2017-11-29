using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace OpenWeather.iOS
{
    public class FavoriteTableViewSource : UITableViewSource
    {
        List<string> items;
        protected string cellIdentifier = "TableCell";
        public EventHandler<string> SelectedItem;
        public FavoriteTableViewSource(List<string> tblitems)
        {
            items = tblitems;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            cell.TextLabel.Text = items[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return items.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            SelectedItem?.Invoke(this, items[indexPath.Row]);
        }
    }
}
