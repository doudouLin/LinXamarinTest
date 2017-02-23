using System;
using System.Collections.Generic;
using System.Text;

namespace LinXamarinTest.ViewModel
{
    public class PageModel
    {
        public int PageModelId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Picture { get; set; }

        public PageModel(int id, string fn, string ln, string pic) {
            PageModelId = id;
            FirstName = fn;
            LastName = ln;
            Picture = pic;
        }
    }
}
