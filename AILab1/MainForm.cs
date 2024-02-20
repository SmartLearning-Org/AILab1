using AILab1.services;

namespace AILab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void IdeKnap_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            int alder = (int)AlderBox.Value;
            IdeService service = new IdeService();
            string[] ideer = await service.GetIdeer(alder);
            string ideerTekst = string.Join("\n", ideer);
            IdeLabel.Text = ideerTekst;
            progressBar.Visible = false;
        }

        private void TilfojAlderKnap_Click(object sender, EventArgs e)
        {
            alderListBox.Items.Add((int)tilfojAlderBox.Value);
        }

        private void RensButton_Click(object sender, EventArgs e)
        {
            alderListBox.Items.Clear();
        }

        private async void FlerePersonerHentIdeerKnap_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            int[] aldre = alderListBox.Items.Cast<int>().ToArray();
            IdeService service = new IdeService();
            string[] ideer = await service.GetIdeer(aldre);
            string ideerTekst = string.Join("\n", ideer);
            IdeLabel.Text = ideerTekst;
            progressBar.Visible = false;
        }
    }
}