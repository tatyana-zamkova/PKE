using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PKE_1
{
    class Cxema2 : Cxema
     {
  
      private string  uab;
      private string ubc;

    
      public string UAB
      {
          get { return uab; }
          set { uab = value; }
      }
      public string UBC
      {
          get { return ubc; }
          set { ubc = value; }
      }
         public Cxema2()
        {

        }
         public Cxema2(string uid, string pke_cxema, string timeTek, string uab, string ubc)
             : base( uid, pke_cxema, timeTek)
        {
            this.UID = uid;
            this.Pke_cxema = pke_cxema;
            this.TimeTek = timeTek;
            this.UAB = uab;
            this.UBC = ubc;
          
        }
    }
}

