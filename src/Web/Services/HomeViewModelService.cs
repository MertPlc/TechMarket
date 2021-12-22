using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Web.Services
{
    public class HomeViewModelService
    {
        private readonly IRepository<Product> _productRepository;

        public HomeViewModelService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
