using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
        }

        private Store _store = new Store();

        


    }
}
