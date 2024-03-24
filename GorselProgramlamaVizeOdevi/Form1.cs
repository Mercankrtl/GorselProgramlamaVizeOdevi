namespace GorselProgramlamaVizeOdevi
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btmUyeListele_Click(object sender, EventArgs e)
        {
            UyeListelemefrm uyelistele = new UyeListelemefrm();
            uyelistele.ShowDialog();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            KitapListelemefrm Kitaplistele = new KitapListelemefrm();
            Kitaplistele.ShowDialog();
        }

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            EmanetKitapfrm Emanetkitap = new EmanetKitapfrm();
            Emanetkitap.ShowDialog();
        }
    }
}
