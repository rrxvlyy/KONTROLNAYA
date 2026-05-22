using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR22
{
    internal class ActiveQuestFilter : IFilter<Quest>
    {
        public bool Match(Quest item)
        {
            if (item.Status == "Active")
            {
                return true;
            }
            return false;
        }
    }
}
