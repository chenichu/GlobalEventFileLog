using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDSkeleton.Common.Repository;

namespace GlobalEventFileLog.Domain
{
    public interface IEventFileRepository: IRepository<EventFile, int>
    {
        IEnumerable<EventFile> FindAll();
    }
}
