using System;
using System.Windows.Forms;

namespace SGSclient
{
    public partial class LoginForm : Form
    {
        public string strName;

        public LoginForm()
        {
            InitializeComponent();
        }

        private Action<object> ConnectCallback()
        {
            return (o) =>
            {
                if(o is DialogResult)
                    DialogResult = (DialogResult)o;
            };
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Program.client = new SClient(ConnectCallback());
            Program.client.Connect(txtServerIP.Text, txtName.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false; //???
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 && txtServerIP.Text.Length > 0)
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }

        private void txtServerIP_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 && txtServerIP.Text.Length > 0)
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }
    }
}