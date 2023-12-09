using eCommerceApiWithAdoNet.Models;

namespace eCommerceApiWithAdoNet.Repositories
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetUsuarios();
        Usuario GetUsuarioById(int id);
        void InsertUsuario();
        void UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int id);
    }
}
