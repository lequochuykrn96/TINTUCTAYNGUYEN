using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using TINTUCTAYNGUYEN.Models;

namespace TINTUCTAYNGUYEN
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<KhuVuc> GetKhuVucs([QueryString("id")] int? TinhId)
        {
            var _db = new TINTUCTAYNGUYEN.Models.LKgiaCF();
            IQueryable<KhuVuc> query = _db.KhuVucs;
            if (TinhId.HasValue && TinhId > 0)
            {
                query = query.Where(p => p.TinhID == TinhId);
            }
            return query;
        }
    }
}