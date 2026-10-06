package pe.edu.pucp.softprog.dao;

import java.util.List;

public interface IDao<T> {
    int insertar(T obejto);
    int modificar(T objeto);
    int eliminar(int idObjeto);
    T buscarPorId(int idObjeto);
    List<T> listarTodos();
}
