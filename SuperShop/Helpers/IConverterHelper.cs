using SuperShop.Data.Entities;
using SuperShop.Models;
using System;

namespace SuperShop.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, Guid guid, bool isNew);

        ProductViewModel ToProductViewModel(Product product);
    }
}
