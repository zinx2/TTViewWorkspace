using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTViewer_v0001.Models
{
    public class ChildListItemModel
    {
        private List<ChildListItem> childItemList = new List<ChildListItem>();
        public List<ChildListItem> ChildItemList
        {
            get
            {
                return childItemList;
            }
        }

        public async Task<bool> downloadTask()
        {
            for (int i = 0; i < 10; i++)
            {
                childItemList.Add(new ChildListItem("thumb" + i, "title" + i, "url" + i));
            }

            await Task.Delay(3000);
            return true;
        }

    }
}
