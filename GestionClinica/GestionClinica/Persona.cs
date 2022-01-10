using System;
using System.Collections.Generic;
using System.Text;

namespace modelo
{
    public abstract class Persona
    {
        private int dni;
        private string nombre;
        private string apellido;
      
        private DateTime fecha_nac;

        /// <summary>
        /// Sobrecarga de constructor de la clase Persona
        /// </summary>
        protected Persona()
        {
        }

        protected Persona(int dni, string nombre, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
           
        }

        protected Persona(int dni, string nombre, string apellido, DateTime fecha_nac) : this(dni, nombre, apellido)
        {
            this.fecha_nac = fecha_nac;
        }
        /// <summary>
        /// Propiedades de los atributos.
        /// </summary>
        public int propDni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }
        public string propNombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string propApellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public DateTime propFecha_nac
        {
            get
            {
                return fecha_nac;
            }
            set
            {
                fecha_nac = value;
            }
        }

        /// <summary>
        /// Con la siguiente sobrecarga de operadores se puede averiguar si se ingreso dos veces a una persona
        /// o si hay dos personas con el mismo DNI
        /// </summary>

        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.dni == p2.dni;
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        public override int GetHashCode()
        {
            return dni;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Persona))
                return false;

            return Equals((Persona)obj);
        }

        public bool Equals(Persona other)
        {
            if (dni != other.dni)
                return false;

            return dni == other.dni;
        }


    }
}

