using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjDBHomework.Models
{
    public class TextModel
    {
        public List<Gallery> gallry { get; set; }
        public List<Art> art { get; set; }
        public List<Collects> collects { get; set; }
        public List<Member> member { get; set; }

        public List<Visits> visits { get; set; }



    }
}