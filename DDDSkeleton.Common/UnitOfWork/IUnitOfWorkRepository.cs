using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDSkeleton.Common.Domain;

namespace DDDSkeleton.Common.UnitOfWork
{
        public interface IUnitOfWorkRepository
        {
            void PersistInsertion(IAggregateRoot aggregateRoot);
            void PersistUpdate(IAggregateRoot aggregateRoot);
            void PersistDeletion(IAggregateRoot aggregateRoot);
        }
}
