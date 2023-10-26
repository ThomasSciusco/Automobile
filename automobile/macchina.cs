using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automobile
{
    public class amacchina
    {
        private bool MotoreOn = false;
        private int velocita = 0;
        private int marcia = 0;

        public void AccendiSpegni()
        {
            this.MotoreOn = MotoreOn;
        }
        public void accelerare()
        {
            if (MotoreOn && marcia < 5)
            {
                velocita += 10;
            }
        }
        public void decelerare()
        {

            if (MotoreOn && velocita > 0)
            {
                velocita -= 10;
            }
        }
        public void aumentamarcia()
        {
            if (MotoreOn && marcia < 5)
            {
                marcia++;
            }
        }
        public void diminuiremarcia()
        {
            if (MotoreOn && marcia > 0)
            {
                marcia--;
            }
        }

        public int Getvelocita()
        {
            return velocita;
        }

        public int Getmarcia()
        {
            return marcia;
        }
    }
}


