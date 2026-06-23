using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface Irepository<T> where T : class // Removed 'in' to make T invariant
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync(); // Fixed return type to IEnumerable<T> for GetAllAsync
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
// Generic Repository Interface
// Provides common CRUD operations (Create, Read, Update, Delete)
// Generic Repository Interface
// T means any model class (Student, Product, Sale, etc.)
// GetByIdAsync()  -> Get one record by ID
// GetAllAsync()   -> Get all records
// AddAsync()      -> Add a new record
// UpdateAsync()   -> Update an existing record
// DeleteAsync()   -> Delete a record by ID
// Task is used for asynchronous database operations.
// Helps reuse the same CRUD code for different entities.

