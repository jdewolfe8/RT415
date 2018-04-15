using System.Collections.Generic;
using RT410v3.Domain.Entities;

namespace RT410v3.Domain.Abstract {
    public interface IProductRepository {

        IEnumerable<Product> Products { get; }
    }
}