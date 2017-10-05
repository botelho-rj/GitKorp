using System;

namespace Eventos.IO.Aplication.ViewModels
{

    public class CategoriaViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public SelectList Categorias()
        {
            return new SelectList(ListarCategorias(), "Id", "Nome");
        }

        public List<CategoriaViewModel> ListarCategorias()
        {
            var categoriasList = new List<CategoriaViewModel>()
            {
                new CategoriaViewModel() {Id = new Guid("123"), Nome = "Basquete"},
                new CategoriaViewModel() {Id = new Guid("147"), Nome = "Boxe"},
                new CategoriaViewModel() {Id = new Guid("645"), Nome = "Futebol"}
            };

            return categoriasList;
        }
    }
}
