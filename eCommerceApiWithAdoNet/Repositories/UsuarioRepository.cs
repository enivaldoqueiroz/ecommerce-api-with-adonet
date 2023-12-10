using eCommerceApiWithAdoNet.Models;

namespace eCommerceApiWithAdoNet.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private static List<Usuario> _db = new List<Usuario>()
        {
            new Usuario(){Id = 1, Nome = "Enivaldo Queiroz", Email = "enivaldo@gmail.com"},
            new Usuario(){Id = 2, Nome = "Lana Queiroz", Email = "lana@gmail.com"},
            new Usuario(){Id = 3, Nome = "Enivaldo Filho Queiroz", Email = "enivaldofilho@gmail.com"},
        };

        public List<Usuario> GetUsuarios()
        {
            return _db;
        }

        public Usuario GetUsuarioById(int id)
        {
            return _db.FirstOrDefault(a => a.Id == id);
        }

        public void InsertUsuario(Usuario usuario)
        {
            _db.Add(usuario);
        }

        public void UpdateUsuario(Usuario usuario)
        {
            _db.Remove(_db.FirstOrDefault(a => a.Id == usuario.Id));

            _db.Add(usuario);
        }

        public void DeleteUsuario(int id)
        {
            _db.Remove(_db.FirstOrDefault(a => a.Id == id));
        }
    }
}
