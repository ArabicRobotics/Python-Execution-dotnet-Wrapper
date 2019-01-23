using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NAO.NET
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnMovement_Click(object sender, EventArgs e)
        {
            frmMove MoveForm = new frmMove();
            MoveForm.Show();
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            frmPicture CameraForm = new frmPicture();
            CameraForm.Show();
        }
    }
}
