using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaLogi
{
    public class Empleado
    {

        public static List<capaDatos.empleado> Get()
        {
            using (nominaEntities db = new nominaEntities())
            {
                return db.empleado.ToList();
            }
        }
        //metodo para establecer en registro
        public static void establecer(int id, string usuario, string contraseña, string nombreEmpleado, string correoEmpleado, int numeroCelular, string rol)
        {

            using (nominaEntities db = new nominaEntities())
            {
                empleado listado;
                listado = new empleado();

                listado.id = id;
                listado.usuario = usuario;
                listado.contraseña = contraseña;
                listado.nombreEmpleado = nombreEmpleado;
                listado.correoEmpleado = correoEmpleado;
                listado.numeroCelular = numeroCelular;
                listado.rol = rol;

                db.empleado.Add(listado);
                db.SaveChanges();
            }
        }
        //metodo para loguearse
        public static List<eso> loguear(string contraseña, string nombreUsuario)
        {
            using (nominaEntities db = new nominaEntities())
            {
                return db.empleado.Where(C => C.usuario == nombreUsuario && C.contraseña == contraseña).Select(D => new eso{id = D.id,rol = D.rol,nombreEmpleado = D.nombreEmpleado }).ToList();
            }
        }
    }
}
