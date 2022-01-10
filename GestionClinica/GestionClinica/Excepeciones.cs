using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaPrivadaCABA.Modelo
{
    [Serializable]
    public class NotFoundException : Exception
    {
        public string id { get; }
        public NotFoundException() { }

        public NotFoundException(string message)
            : base(message) { }

        public NotFoundException(string message, Exception inner)
            : base(message, inner) { }
        public NotFoundException(string message, string id)
    : this(message)
        {
            this.id = id;
        }
    }
}
