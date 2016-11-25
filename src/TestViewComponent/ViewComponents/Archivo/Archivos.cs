using TestViewComponent.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace TestViewComponent.ViewComponents.Archivo
{
    [ViewComponent(Name = "Archivos")]
    public class Archivos : ViewComponent
    {
        public const string Detalle = "Detalle";
        public const string Listado = "Listado";
        public const string Nuevo = "Nuevo";
        

        public IViewComponentResult Invoke()
        {
            object vista;
            object archivos;
            object titulo;
    
            if (ViewComponentContext.Arguments.TryGetValue("vista", out vista) && ViewComponentContext.Arguments.TryGetValue("archivos", out archivos) && ViewComponentContext.Arguments.TryGetValue("titulo", out titulo))
            {
                ViewBag.TituloArchivos = (string)titulo;
                return View((string)vista, (ICollection<ArchivoViewModel>)archivos);
            }                        
            else if (ViewComponentContext.Arguments.TryGetValue("vista", out vista))
            {
                return View((string)vista);             
            }
            else
            {
                throw new Exception("Los parámetros enviados no se corresponden con los definidos");
            }

        }
    }
}