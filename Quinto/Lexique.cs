using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quinto
{
    public partial class Lexique : Form
    {
        private Lexique()
        {
            InitializeComponent();
        }

        private static Lexique singleLexique = null;

        public static Lexique Instance()
        {
            if (singleLexique == null)
            {
               singleLexique = new Lexique();
            }
            return singleLexique;
        }
    }
}
