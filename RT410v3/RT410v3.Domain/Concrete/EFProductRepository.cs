using RT410v3.Domain.Abstract;
using RT410v3.Domain.Entities;
using System.Collections.Generic;

namespace RT410v3.Domain.Concrete {

    public class EFProductRepository : IProductRepository {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products {
            get { return context.Products; }
        }
    }
}