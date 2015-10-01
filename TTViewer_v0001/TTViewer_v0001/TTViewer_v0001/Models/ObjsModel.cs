using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTViewer_v0001.Models
{
    
    public class ObjsModel
    {
        private List<ObjBase> objList = new List<ObjBase>();
        public List<ObjBase> ObjList
        {
            get
            {
                return objList;
            }

        }

        public async Task<bool> downloadTask()
        {
            for (int i = 0; i < 10; i++)
            {
                objList.Add(new ObjBase("thumb" + i, "title" + i, "author" + i, "summary" + i));
            }

            await Task.Delay(3000);
            return true;
        }

    }

}
