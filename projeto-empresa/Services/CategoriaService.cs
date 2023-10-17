using projeto_empresa.Model;
using projeto_empresa.Models;
using projeto_empresa.Repositories.Interface;
using projeto_empresa.Services.Inteface;

namespace projeto_empresa.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public CategoriaModel Get(int id)
        {
            return _repository.Get(id);
        }

        public List<CategoriaModel> GetAll()
        {
            var list = _repository.GetAll();
            return list;
        }

        public void Post(CategoriaDTO dto)
        {
            var model = new CategoriaModel();

            model.Nome = dto.Nome;
            model.DataCriacao = DateTime.Now;
            _repository.Insert(model);
        }

        public void Update(int id, CategoriaDTO dto)
        {
            //primeira:
            //var model = new CategoriaModel();
            //model.Id = id;
            //model.Nome = dto.Nome;
            //_repository.Update(model);

            //segunda opção

            var categoriaModel = Get(id);
            if (categoriaModel == null)
            {
                throw new Exception("Categoria não encontrada");
            }

            categoriaModel.Nome = dto.Nome;
            _repository.Update(categoriaModel);
        }
    }
}
