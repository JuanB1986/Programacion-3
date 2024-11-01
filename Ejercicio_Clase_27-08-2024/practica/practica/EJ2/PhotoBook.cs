using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica.EJ2
{
    public class PhotoBook
    {
        protected int numPages { get; set; }
        public int ID { get; set; }


        public PhotoBook(int numPages, int id)
        {
            this.numPages = numPages;
            this.ID = id;
        }

        public PhotoBook(int id)
        {
            this.numPages = 16;
            this.ID = id;
        }

        public int GetNumPages() {
            return this.numPages;
        }

    }
}
