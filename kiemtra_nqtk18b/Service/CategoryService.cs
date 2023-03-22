using kiemtra_nqtk18b.Model;
using kiemtra_nqtk18b.Repository;

namespace kiemtra_nqtk18b.Service
{
    public class CategoryService
    {
        private readonly Context context;

        public CategoryService(Context _apiContext)
        {
            context = _apiContext;
        }

        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }
    }
}
