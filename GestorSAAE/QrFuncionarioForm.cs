using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestorSAAE
{
    public partial class QrFuncionarioForm : Form
    {
        public Image qrContato;
        public QrFuncionarioForm()
        {
            InitializeComponent();
        }

        private void QrFuncionarioForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = qrContato;
        }
    }
}
