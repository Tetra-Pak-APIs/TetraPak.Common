using System.Collections.Generic;
using System.Threading.Tasks;

namespace tetrapak.logging
{
    public delegate Task<IEnumerable<ILogEntry>> QueryAsyncDelegate(params LogRank[] ranks);
}