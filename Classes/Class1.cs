using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Classes
{
    public class Class1
    {
        public void BridgeAdding(Bridge bridge)
        {
            bridgeEntities db = new bridgeEntities();

            db.Bridges.Add(bridge);
            db.SaveChanges();


            //return "bridge was added";
        }
    }
}