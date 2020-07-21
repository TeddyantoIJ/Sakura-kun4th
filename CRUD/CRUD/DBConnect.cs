using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DBConnect
    {
        DBConnect()
        {

        }

        public string getConstring()
        {
            return "integrated security = true; data source = localhost; initial catalog = SakuraData";
        }
    }
}
