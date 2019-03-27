using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf1_participation1
{
    class EntryForm
    {
        public string Namebox { set; get; }
        public string Addressbox { set; get; }
        public int ZipCode { set; get; }



        public EntryForm()
        {
            Namebox = "";
            Addressbox = "";
            ZipCode = 0;
        }

        public EntryForm(string name, string address, int zipcode)
        {
            Namebox = name;
            Addressbox = address;
            ZipCode = zipcode;
        }


        public override string ToString()
        {
            string entryForm = ($"{Namebox} lives at {Addressbox} {ZipCode}");
            return entryForm;
        }
    }



}
