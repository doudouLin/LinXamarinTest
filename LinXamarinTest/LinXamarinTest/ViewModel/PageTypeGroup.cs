using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace LinXamarinTest.ViewModel
{
    public class PageTypeGroup : List<PageModel>
    {
        public int PageTypeGroupId { get; set; }

        public string Title { get; set; }

        public string ShortName { get; set; }

        //public static IList<PageTypeGroup> all { get; set; }

        public PageTypeGroup(int id, string title, string shortName)
        {
            PageTypeGroupId = id;
            Title = title;
            ShortName = shortName;
        }

        //static PageTypeGroup()
        //{
        //    List<PageTypeGroup> groups = new List<PageTypeGroup>
        //    {
        //        new PageTypeGroup("Alfa", "A")
        //        {
        //            new PageModel("Amelia", "Cedar", ""),
        //            new PageModel("Alfie", "Spruce", ""),
        //            new PageModel("Ava", "Pine", "")
        //        },
        //        new PageTypeGroup("Beta", "B")
        //        {
        //            new PageModel("Bella", "Desire", ""),
        //            new PageModel("Ben", "Chocolate", "")
        //        }
        //    };

        //    all = groups;
        //}
    }
}
