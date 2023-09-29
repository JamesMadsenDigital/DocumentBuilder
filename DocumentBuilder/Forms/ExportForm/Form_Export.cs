using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentBuilder.Builder;

namespace DocumentBuilder.Forms.ExportForm
{
    public partial class Form_Export : Form
    {
        // The document that we're going to export.
        private Document document;


        /// <summary>
        /// Form constructor.
        /// </summary>
        public Form_Export()
        {
            InitializeComponent();
        }
    }
}
