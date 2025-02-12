using DAM_Leccion_BFA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM_Leccion_BFA.ViewModel
{
    public class MainPageViewModel
    {
        public PersonasModel personasModel { get; set; }

        public MainPageViewModel()
        {
            Consultar();
        }

        public void Consultar()
        {
            personasModel = new PersonasModel()
            {
                Nombre = "Alondra",
                Apellido = "Flores",
                Edad = "20",
            };
        }
    }
}
