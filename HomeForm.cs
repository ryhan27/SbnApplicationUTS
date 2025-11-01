
using SampleUTS.Design;
using SbnApplication2.Design;

namespace SampleUTS
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnBuyer_Click(object sender, EventArgs e)
        {
            BuyerForm formBuyer = new BuyerForm();
            formBuyer.setVisible(true);
        }

        private void btnSBN_Click(object sender, EventArgs e)
        {
            SbnForm formSBN = new SbnForm(); // buat objek form baru
            formSBN.setVisible(true);
        }

    }
}
