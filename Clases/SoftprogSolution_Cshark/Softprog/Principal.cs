using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using SoftprogDomain.RRHH;
using SoftprogDAO.RRHH.Impl;
using SoftprogDAO.RRHH.DAO;
using SoftprogBusinessLogic.RRHH.BOI;
using SoftprogBusinessLogic.RRHH.BO;

public class Principal
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello, World!");
        Area area = new Area();
        System.Console.Write("Ingrese el nombre del" +
            " area a registrar: ");
        area.Nombre =
        System.Console.ReadLine();
        IAreaBO boArea = new AreaBOImpl();
        try
        {
            int resultado = boArea.Insertar(area);
            if (resultado != 0)
                Console.WriteLine("Se registro con exito..");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }

        List<Area> areas
            = boArea.ListarTodos();
        foreach (Area a in areas)
        {
            Console.WriteLine(a.IdArea + ". " +
                a.Nombre);
        }
    }
}
