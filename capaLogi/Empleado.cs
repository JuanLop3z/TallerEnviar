using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaLogi
{
    public class Empleado
    {

        public static List<users> Get()
        {
            using (nominaEntities db = new nominaEntities())
            {
                return (from d in db.empleado
                        select new users()
                        {
                            nombreEmpleado = d.nombreEmpleado,
                            correoEmpleado = d.correoEmpleado,
                            numeroCelular = d.numeroCelular,
                            rol = d.rol,
                            
                        }).ToList();
            }
        }
        //metodo para establecer en registro
        public static void establecer(int id, string usuario, string contraseña, string nombreEmpleado, string correoEmpleado, int numeroCelular, string rol)
        {

            using (nominaEntities db = new nominaEntities())
            {

                byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(contraseña);
                byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
                


                empleado listado;
                listado = new empleado();

                listado.id = id;
                listado.usuario = usuario;
                listado.contraseña = Convert.ToBase64String(tmpHash);
                listado.nombreEmpleado = nombreEmpleado;
                listado.correoEmpleado = correoEmpleado;
                listado.numeroCelular = numeroCelular;
                listado.rol = rol;

                db.empleado.Add(listado);
                db.SaveChanges();
            }
        }
        //metodo para loguearse
        public static List<log> loguear(string contraseña, string nombreUsuario)
        {
            using (nominaEntities db = new nominaEntities())
            {
                byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(contraseña);
                byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
                String contrasena = Convert.ToBase64String(tmpHash);
                return db.empleado.Where(C => C.usuario == nombreUsuario && C.contraseña == contrasena).Select(D => new log{id = D.id,rol = D.rol,nombreEmpleado = D.nombreEmpleado }).ToList();
            }
        }
    }
}
