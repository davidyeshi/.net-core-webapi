using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.Domain.Repositories
{
    // We should save our changes into the database ony after everything finishes.
    // To do this, we have to use a transaction, that is basically a feature most 
    // databases implement to save data only after a complex operation finishes.

    // A common patter to handle this issue is the Unit of Work Pattern.
    // This pattern consists of a class that receives our AppDbContext instance as a
    // dependency and exposes methods to start, complete or abort transactions.
    public interface IUnitOfWork
    {
        // Only exposes a method that will asynchronously complete
        // data management operations.
        Task CompleteAsync();
    }
}
