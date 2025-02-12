using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DAM_Leccion_BFA.Model
{
    public class PersonaModel : INotifyPropertyChanged
    {
        // Atributos privados
        private string? nombre;
        private string? apellido;
        private int? edad;  // Cambio a int?

        // Propiedades con verificación de cambios
        public string? Nombre
        {
            get => nombre;
            set
            {
                if (nombre != value)  // Solo notifica si hay un cambio real
                {
                    nombre = value;
                    OnPropertyChanged();
                }
            }
        }

        public string? Apellido
        {
            get => apellido;
            set
            {
                if (apellido != value)
                {
                    apellido = value;
                    OnPropertyChanged();
                }
            }
        }

        public int? Edad  // Cambio de string? a int?
        {
            get => edad;
            set
            {
                if (edad != value)
                {
                    edad = value;
                    OnPropertyChanged();
                }
            }
        }

        // Implementación de INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
