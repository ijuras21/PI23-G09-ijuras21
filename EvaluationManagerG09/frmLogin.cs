﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManagerG09 {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (txtusername.Text == "") {
                MessageBox.Show("Korisničko ime nije unešeno", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
