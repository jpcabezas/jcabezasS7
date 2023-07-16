using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite; //aqui usamos la libreria del SQlite
using System.IO; // aqui consumimos el system para hacer imput y ouput
using jcabezasS7.Droid;

[assembly:Xamarin.Forms.Dependency(typeof(clienteAndroid))]
namespace jcabezasS7.Droid
{
    public class clienteAndroid : DataBase
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var ruta = (System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments)); // aquí definimos la ruta donde se guardará la BBDD
            var rutaBase = Path.Combine(ruta,"uisrael.db3"); // aquí usamos la ruta y colocamos el nombre de la BBDD
            return new SQLiteAsyncConnection(rutaBase); // Aquí retornamos la BBDD
        }
    }
}