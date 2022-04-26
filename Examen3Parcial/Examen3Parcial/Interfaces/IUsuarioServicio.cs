﻿using Modelos;

namespace Examen3Parcial.Interfaces;

public interface IUsuarioServicio
{
    Task<bool> Nuevo(Usuario usuario);
    Task<bool> Actualizar(Usuario usuario);
    Task<bool> Eliminar(Usuario usuario);
    Task<IEnumerable<Usuario>> GetLista();
    Task<Usuario> GetPorCodigo(string codigo);
}
