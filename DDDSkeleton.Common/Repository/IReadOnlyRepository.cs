using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDSkeleton.Common.Domain;

namespace DDDSkeleton.Common.Repository
{
    public interface IReadOnlyRepository<AggregateType, IdType> where AggregateType : IAggregateRoot
    {
        AggregateType FindBy(IdType id);
        IEnumerable<AggregateType> FindAll();
    }
}
