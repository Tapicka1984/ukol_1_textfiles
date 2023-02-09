using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            file.ShowDialog();

            int vysledek = 0;
            int sudy = 0;
            int lichy = 0;

            string cislo;

            StreamReader ctenar = new StreamReader(file.FileName);
            while(!ctenar.EndOfStream)
            {
                cislo = ctenar.ReadLine();
                int cislo_ = int.Parse(cislo);
                vysledek += cislo_;
                if((cislo_)%2==0)
                {
                    sudy++;
                }
                else
                {
                    lichy++;
                }
            }
            MessageBox.Show("vysledky jsou? " + sudy + "   " + lichy + "    " + vysledek);
        }
    }
}