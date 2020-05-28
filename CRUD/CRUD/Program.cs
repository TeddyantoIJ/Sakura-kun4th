﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SupplierMaster());
            //Application.Run(new CustomerMaster());
            //Application.Run(new AlatKerjaMaster());
            //pplication.Run(new KomponenSupplier());
            //Application.Run(new AlatSupplier());

            //Application.Run(new UpdateSupplier());
            //Application.Run(new UpdateCustomer());
            //Application.Run(new UpdateAlatKerja());
            //Application.Run(new UpdateAlatKomponenSupplier());

            Application.Run(new Home());
        }
    }
}
