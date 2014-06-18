using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Alumnos
{
    public class Alumno : INotifyPropertyChanged
    {
        private int _alumnoID;

        public int AlumnoID
        {
            get { return _alumnoID; }
            set { _alumnoID = value; NotifyPropertyChanged("AlumnoID"); }
        }
        private string _curso;

        public string Curso
        {
            get { return _curso; }
            set { _curso = value; NotifyPropertyChanged("Curso"); }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; NotifyPropertyChanged("Nombre"); }
        }
        private string _apellidos;

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; NotifyPropertyChanged("Apellidos"); }
        }
        private string _direccionEmail;

        public string DireccionEmail
        {
            get { return _direccionEmail; }
            set { _direccionEmail = value; NotifyPropertyChanged("DireccionEmail"); }
        }
        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; NotifyPropertyChanged("Telefono"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property. 
        // The CallerMemberName attribute that is applied to the optional propertyName 
        // parameter causes the property name of the caller to be substituted as an argument. 
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
