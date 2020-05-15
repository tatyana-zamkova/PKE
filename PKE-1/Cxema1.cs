using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PKE_1
{
    class Cxema1 : Cxema
    {
  
      private string  ua;
      private string ia;

    
      public string UA
      {
          get { return ua; }
          set { ua = value; }
      }
      public string IA
      {
          get { return ia; }
          set { ia = value; }
      }
         public Cxema1()
        {

        }
         public Cxema1(string uid, string pke_cxema, string timeTek, string ua, string ia)
             : base( uid, pke_cxema, timeTek)
        {
            this.UID = uid;
            this.Pke_cxema = pke_cxema;
            this.TimeTek = timeTek;
            this.UA = ua;
            this.IA = ia;
          
        }
    }
}
