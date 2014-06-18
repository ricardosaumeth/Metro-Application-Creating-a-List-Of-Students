using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Alumnos
{
    public class ViewModel : INotifyPropertyChanged
    {
        private List<Alumno> alumnos;
        public List<Alumno> AllAlumnos
        {
            get { return this.alumnos; }
        }

        private int currentAlumno;
        public Command NextAlumno { get; private set; }
        public Command PreviousAlumno { get; private set; }




        public ViewModel()
        {
            currentAlumno = 0;

            this._isAtStart = true;
            this._isAtEnd = false;

            this.NextAlumno = new Command(this.Next, () => { return this.alumnos.Count > 0 && !this._isAtEnd; });
            this.PreviousAlumno = new Command(this.Previous, () => { return this.alumnos.Count > 0 && !this._isAtStart; });

            this.alumnos = DataSource.Alumnos;

        }



        private bool _isAtStart;

        public bool IsAtStart
        {
            get { return _isAtStart; }
            set { _isAtStart = value; this.NotifyPropertyChanged("IsAtStart"); }
        }

        private bool _isAtEnd;

        public bool IsAtEnd
        {
            get { return _isAtEnd; }
            set { _isAtEnd = value; this.NotifyPropertyChanged("IsAtEnd"); }
        }

        public Alumno Current
        {
            get { return this.alumnos[currentAlumno]; }

        }

        private void Next()
        {
            if (this.alumnos.Count - 1 > this.currentAlumno)
            {
                this.currentAlumno++;
                this.NotifyPropertyChanged("Current");
                this.IsAtStart = false;
                this.IsAtEnd = (this.alumnos.Count - 1 == this.currentAlumno);
            }
        }
        private void Previous()
        {
            if (this.currentAlumno > 0)
            {
                this.currentAlumno--;
                this.NotifyPropertyChanged("Current");
                this.IsAtStart = (this.currentAlumno == 0);
                this.IsAtEnd = false;
            }
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
