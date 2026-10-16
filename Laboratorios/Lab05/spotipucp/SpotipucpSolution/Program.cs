using Microsoft.Extensions.Configuration;
using SpotipucpBO;      
using SpotipucpBO.Clases.BO;
using SpotipucpBO.Clases.BOI;
using SpotipucpDBManager;
using SpotipucpDomain.Clases;
using System;
using System.Collections.Generic;

public class Programa
{
    public static void Main(string[] args)
    {
        IConfiguration configuracion
            = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").Build();

        string? cadenaConexion = configuracion.
            GetConnectionString("MySqlConnection");

        DBManager.Instance.Inicializar(cadenaConexion);

        IUsuarioBO usuarioBO = new UsuarioBOImpl();
        ICancionBO cancionBO = new CancionBOImpl();
        IPlaylistBO playlistBO = new PlaylistBOImpl();

        foreach (Usuario usuario in usuarioBO.listarTodos())
        {
            List<Cancion> canciones = cancionBO.seleccionarCancionesAleatorias();
            string nombre = "Playlist de " + usuario.Codigo;
            playlistBO.crearPlaylistConCanciones(usuario, nombre, canciones);
        }

        foreach (Playlist playlist in playlistBO.listarTodos())
        {
            imprimirPlaylist(playlist);
        }
    }

    private static void imprimirPlaylist(Playlist playlist)
    {
        Console.WriteLine(playlist.Nombre + " - " + playlist.Usuario.Nombre);
        foreach (PlaylistCancion detalle in playlist.Canciones)
        {
            Cancion cancion = detalle.Cancion;
            Console.WriteLine($"  {detalle.Orden}. {cancion.Titulo} - {cancion.Artista}");
        }
    }
}
