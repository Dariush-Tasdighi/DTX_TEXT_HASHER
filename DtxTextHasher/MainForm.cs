using System.Linq;

namespace MyApplication
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			txtText.Focus();
		}

		private void txtText_Enter(object sender, System.EventArgs e)
		{
			txtText.SelectAll();
		}

		private void txtText_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtText.Text))
			{
				txtMD5.Text = string.Empty;
				txtSha1.Text = string.Empty;
			}
			else
			{
				txtMD5.Text = Dtx.Security.Hashing.GetMD5(txtText.Text);
				txtSha1.Text = Dtx.Security.Hashing.GetSha1(txtText.Text);

			}
		}
	}
}
