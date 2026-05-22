using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR22
{
    internal class ExpensiveQuestFilter : IFilter<Quest>
    {
        public bool Match(Quest item)
        {
            if (item.Reward >= 200)
            {
                return true;
            }
            return false;
        }
    }
}
