using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPeliculas.Shared.Entidades;

namespace BlazorPeliculas.Client.Repositorios
{
    public interface IRepositorio
    {
        List<Pelicula> ObtenerPeliculas();
    }
}
