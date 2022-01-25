using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCoche
{
    public class Motor
    {
        public Boolean Estado { get; set; }

        public Motor(bool _estado)
        {
            this.Estado = _estado;
        }

        public void Arrancar()
        {
            this.Estado = true;
        }

        public void Parar()
        {
            this.Estado = false;
        }
    }
}
