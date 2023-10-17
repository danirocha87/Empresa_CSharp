using projeto_empresa.Model;
using projeto_empresa.Models;

namespace projeto_empresa.Services.Inteface
{
    public interface ICategoriaService
    {
        CategoriaModel Get(int id);
        List<CategoriaModel> GetAll();
        void Post(CategoriaDTO dto);
        void Update(int id, CategoriaDTO dto);
        void Delete(int id);
    }
}
