using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PKE_1
{
    class Cxema
    {
      private string uid;
      private string  pke_cxema;
      private string  timeTek;
      public List<string> Subordinate { get; set; }
      public string UID
      {
          get { return uid; }
          set { uid = value; }
      }
        public string Pke_cxema
      {
          get { return pke_cxema; }
          set { pke_cxema = value; }
      }
      public string TimeTek
      {
          get { return timeTek; }
          set { timeTek = value; }
      }
     
         public Cxema()
        {

        }
         public Cxema(string uid,  List<string> subordinate)
        {
          this.UID = uid;
          //  this.Pke_cxema = pke_cxema;
          //  this.TimeTek = timeTek;
            this.Subordinate = subordinate;          
        }
    }
}
