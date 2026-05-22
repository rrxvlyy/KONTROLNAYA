using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR22
{
    public interface IFilter<T>
    {
        bool Match(T item);
    }
}
