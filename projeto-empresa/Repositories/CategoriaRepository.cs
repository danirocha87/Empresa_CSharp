using Dapper;
using Microsoft.Data.SqlClient;
using projeto_empresa.Model;
using projeto_empresa.Repositories.Interface;
using System.Reflection;

namespace projeto_empresa.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public void Delete(int id)
        {
            var query = "DELETE dbo.Categoria WHERE Id = @id";

            var connectionString = "Data Source=DESKTOP-6RD81MV\\SQLEXPRESS;Database=empresa;Trusted_Connection=True;MultipleActiveResultSets=True;;TrustServerCertificate=true";
            using (var db = new SqlConnection(connectionString))
            {
                db.Open();
                db.Execute(query,
                    new { id });

                db.Close();
            }
        }

        public CategoriaModel Get(int id)
        {
            var categoria = new CategoriaModel();
            var query = @"
                SELECT Id, 
                Nome,
                DataCriacao
                FROM dbo.Categoria WHERE Id = @id";

            var connectionString = "Data Source=DESKTOP-6RD81MV\\SQLEXPRESS;Database=empresa;Trusted_Connection=True;MultipleActiveResultSets=True;;TrustServerCertificate=true";
            using (var db = new SqlConnection(connectionString))
            {
                db.Open();
                categoria  = db.QueryFirstOrDefault<CategoriaModel>(query, new { id });

                db.Close();
            }

            return categoria;
        }

        public List<CategoriaModel> GetAll()
        {
            var categoriaLista = new List<CategoriaModel>();
            var query = @"
                SELECT Id, 
                Nome,
                DataCriacao
                FROM dbo.Categoria";

            var connectionString = "Data Source=DESKTOP-6RD81MV\\SQLEXPRESS;Database=empresa;Trusted_Connection=True;MultipleActiveResultSets=True;;TrustServerCertificate=true";
            using (var db = new SqlConnection(connectionString))
            {
                db.Open();
                categoriaLista = db.Query<CategoriaModel>(query).ToList();

                db.Close();
            }

            return categoriaLista;
        }

        public void Insert(CategoriaModel model)
        {
            var query = @"
                INSERT INTO dbo.Categoria
                (Nome, DataCriacao)
                VALUES (@nome, @dataCriacao)";

            var connectionString = "Data Source=DESKTOP-6RD81MV\\SQLEXPRESS;Database=empresa;Trusted_Connection=True;MultipleActiveResultSets=True;;TrustServerCertificate=true";
            using (var db = new SqlConnection(connectionString))
            {
                db.Open();
                db.Execute(query,
                    new { @nome = model.Nome, dataCriacao = model.DataCriacao });

                db.Close();
            }
        }

        public void Update(CategoriaModel model)
        {
            var query = "UPDATE dbo.Categoria SET Nome = @nome WHERE id = @id";

            var connectionString = "Data Source=DESKTOP-6RD81MV\\SQLEXPRESS;Database=empresa;Trusted_Connection=True;MultipleActiveResultSets=True;;TrustServerCertificate=true";
            using (var db = new SqlConnection(connectionString))
            {
                db.Open();
                db.Execute(query, 
                    new { @nome = model.Nome, @id = model.Id });

                db.Close();
            }
        }
    }
}
