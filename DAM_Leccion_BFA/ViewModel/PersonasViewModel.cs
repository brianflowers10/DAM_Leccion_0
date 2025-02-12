using DAM_Leccion_BFA.Model;
using FoundationStandard.ObjectHydrator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAM_Leccion_BFA.ViewModel
{
    public class PersonasViewModel
    {
        public ObservableCollection<PersonasModel> Personas { get; set; }
        public PersonasViewModel()
        {
            Consultar();
        }

        public void Consultar()
        {
            var listado = new Hydrator<PersonasModel>().WithFirstName(n => n.Nombre);
            Personas = new ObservableCollection<PersonasModel>(listado.GetList(20));
        }
    }
}
