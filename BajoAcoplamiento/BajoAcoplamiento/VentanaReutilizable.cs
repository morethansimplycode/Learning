using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BajoAcoplamiento
{
    public partial class VentanaReutilizable : Form
    {
        public String Text { get; set; }
        public Func<VentanaReutilizable, Boolean> IsInputValid { get; set; }

        private Action<String> onAccept;
        public Action<String> OnAccept
        {
            get { return onAccept; }
            set { onAccept = value; }
        }

        private Action<String> onCancel;
        public Action<String> OnCancel
        {
            get { return onCancel; }
            set { onCancel = value; }
        }

        public VentanaReutilizable()
        {
            InitializeComponent();
        }
    }
}
