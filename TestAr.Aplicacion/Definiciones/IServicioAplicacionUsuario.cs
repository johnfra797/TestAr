using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAr.DTO;

namespace TestAr.Aplicacion.Definiciones
{
    public interface IServicioAplicacionUsuario
    {
        bool Guardar(Usuario usuario);
        bool Eliminar(int idUsuario);
        UsuarioDTO Obtener(int idUsuario);
        List<UsuarioDTO> ObtenerTodos();
    }
}
