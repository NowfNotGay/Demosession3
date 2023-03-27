using FlowerShop.Models.Interface;

namespace FlowerShop.Models.Service;

public class CategoryService : ICategoryService
{
    private readonly DatabaseContext _databaseContext;

    public CategoryService(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }
    public List<Category> GetCategory()=>_databaseContext.Categories.ToList();
}
