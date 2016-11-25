using System.Collections.Generic;

namespace TestViewComponent.ViewModels
{
    public class NoticiaViewModel 
    {
        private IList<ArchivoViewModel> _archivos = new List<ArchivoViewModel>();

        public IList<ArchivoViewModel> Archivos { get { return _archivos; } set { _archivos = value; } }

        public NoticiaViewModel()
        {
        }
    }
}
