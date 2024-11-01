using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica.EJ2
{
    public class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook(int id) : base(id)
        {
            this.numPages = 64;  
        }

    }
}
