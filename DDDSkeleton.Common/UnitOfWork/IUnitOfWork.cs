using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDSkeleton.Common.Domain;

namespace DDDSkeleton.Common.UnitOfWork
{
    class IUnitOfWork
    {
        void RegisterUpdate(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository);
        void RegisterInsertion(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository);
        void RegisterDeletion(IAggregateRoot aggregateRoot, IUnitOfWorkRepository repository);
        void Commit();
    }
}
