using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfPresentationCreator
{
    public class PageInfo : Page
    {
        public string Title;
        public string Description;

        public PageInfo(string name) : base(name)
        {

        }
    }
}
