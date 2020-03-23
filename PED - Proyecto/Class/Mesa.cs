using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED___Proyecto.Class
{
    public class Mesa
    {
        private Cliente silla1;
        private Cliente silla2;

       
        public Cliente Silla1
        {
            get { return silla1; }
            set { silla1 = value; }
        }
        public Cliente Silla2
        {
            get { return silla2; }
            set { silla2 = value; }
        }
        
    }
}
