using kiemtra_nqtk18b.Model;

namespace kiemtra_nqtk18b.Service
{
    public class ImageService
    {
        private readonly Context context;

        public ImageService(Context _apiContext)
        {
            context = _apiContext;
        }

        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }
    }
}
