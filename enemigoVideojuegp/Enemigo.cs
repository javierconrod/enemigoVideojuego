using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enemigoVideojuegp
{
    class Enemigo
    {
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }

        public int cantidadGolpes;

        public int _puntosGanados;
        public int PuntosGanados
        {
            get
            {
                return _puntosGanados;
            }
            set
            {
                if(cantidadGolpes==1)
                {
                    _puntosGanados = 250;
                }
                else if(cantidadGolpes==2)
                {
                    _puntosGanados = 200;
                }
                else if(cantidadGolpes>2)
                {
                    _puntosGanados = 150;
                }
            }
        }

        //moverse
        public void moverse()
        {

        }
        //disparar
        public void disparar()
        {

        }
        //explotar
        public void explotar()
        {

        }
        //golpeado
        public void golpeado(int cantidadDano)
        {

        }

    }
}
