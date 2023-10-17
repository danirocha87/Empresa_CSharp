using projeto_empresa.Model;

namespace projeto_empresa.Repositories.Interface
{
    public interface ICategoriaRepository
    {
        CategoriaModel Get(int id);
        List<CategoriaModel> GetAll();
        void Insert(CategoriaModel model);
        void Update(CategoriaModel model);
        void Delete(int id);
    }
}
