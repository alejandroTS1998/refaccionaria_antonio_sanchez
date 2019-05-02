using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using proyecto_refaccionaria;
using proyecto_refaccionaria.BD;


namespace pruebasRefaccionaria
{
    [TestClass]
    public class basedatosTest
    {
        [TestMethod]
        public void Testconectar()
        {
            basedatos instance = new basedatos();
            instance.Conectar();
            Assert.AreEqual(instance.Conectar(),true);
        }
        [TestMethod]
        public void testejectutarActualizacion()
        {
            basedatos instance = new basedatos();
            String SQL = "delete  from producto where id_producto='?1'";
            instance.ejecutarActualizacion(SQL);
            Assert.AreEqual(instance.ejecutarActualizacion(SQL), false);
        }
       /* public void testejecutarconsulta()
        {
            basedatos instance = new basedatos();
            String SQL = "select * from producto";
            instance.ejecutarConsulta(SQL);
            Assert.AreEqual(instance.ejecutarConsulta(SQL), true);
        }*/
    }
}
