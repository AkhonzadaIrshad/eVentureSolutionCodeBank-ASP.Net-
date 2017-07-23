using System.Collections.Generic;
using System.Web.Mvc;

namespace UpdateForiegnKeyResolverDemo.Model_Helper
{
    public class CommonHelper
    {
        public static List<SelectListItem> ToDropDownList(dynamic list)
        {
            List<SelectListItem> newlist = null;
            if (list != null)
            {
                newlist = new List<SelectListItem>();
                foreach (var item in list)
                {
                    newlist.Add(new SelectListItem()
                    {
                        Text = item.Name,
                        Value = item.Id.ToString()
                    });
                }
            }
            return newlist;
        }

        public static List<SelectListItem> ToDropDownList(List<SelectListItem> list, int id)
        {
            foreach (SelectListItem item in list)
            {
                if (item.Value.Equals(id.ToString()))
                {
                    item.Selected = true;
                }
            }
            return list;
        }
    }
}