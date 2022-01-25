using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCoche
{
    public class Rueda
    {
        public Boolean Movimiento { get; set; }

        public Rueda(bool _movimiento)
        {
            this.Movimiento = _movimiento;
        }

        public void Rodar()
        {
            this.Movimiento = true;
        }

        public void Parar()
        {
            this.Movimiento = false;
        }
    }
}
