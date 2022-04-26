using Datos.Interfaces;
using Datos.Repositorios;
using Examen3Parcial.Data;
using Examen3Parcial.Interfaces;
using Modelos;

namespace Examen3Parcial.Servicios;

public class UsuarioServicio : IUsuarioServicio
{
    private readonly MySQLConfiguration _configuration;
    private IUsuarioRepositorio usuarioRepositorio;
    public UsuarioServicio(MySQLConfiguration configuration)
    {
        _configuration = configuration;
        usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
    }

    public Task<bool> Actualizar(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Usuario>> GetLista()
    {
        return await usuarioRepositorio.GetLista();
    }

    public Task<Usuario> GetPorCodigo(string codigo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Nuevo(Usuario usuario)
    {
        throw new NotImplementedException();
    }
}
