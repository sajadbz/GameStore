using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Core.ViewModels.Games
{
    public class FilterGroup
    {
        public FilterGroup()
        {
            Page = 1;
            PageSize = 2;
        }
        public string Title { get; set; }
        public int PageSize { get; set; }
        public int Page { get; set; }
    }
}
