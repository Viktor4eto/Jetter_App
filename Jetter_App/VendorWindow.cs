using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jetter_App
{
    public partial class VendorWindow : Form
    {
        private Vendor vendor;
        public VendorWindow(Vendor vendor)
        {
            InitializeComponent();
            this.vendor = vendor;
        }
    }
}
