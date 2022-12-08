using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Mastermind
{
    public partial class mainForm : Form
    {
        ListBox listbox;
        int ncs;
        Random rnd = new Random();
        public mainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            inputForm myIF = new inputForm();
            myIF.ShowDialog();

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            listbox = new ListBox();
            listbox.Width = 100;
            listbox.Height = 500;
            listbox.Top = 50;
            listbox.Left = 10;
            listbox.Parent = this;
            listbox.Font = new Font("Arial", 20, FontStyle.Regular);
        }

        public void refresh()
        {
            listbox.Items.Add(Engine.x.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refresh(); 
        }

        public void newGame()
        {
            ncs = generateNumber4();
            textBox1.Text = ncs.ToString();
        }
        private void newGameButton_Click(object sender, EventArgs e)
        {
            newGame();
        }

        public int generateNumber1()
        {
            bool ok;
            int x;
            do
            {
                ok = true;
                x = rnd.Next(1000, 10000);
                int c1 = x % 10;
                int c2 = (x / 10) % 10;
                int c3 = (x / 100) % 10;
                int c4 = (x / 1000) % 10;
                if (c1 == c2 || c1 == c3 || c1 == c4 || c2 == c3 || c2 == c4 || c3 == c4)
                    ok = false;
            } while (!ok);
            return x;
        }
        public int generateNumber2()
        {
            int c1 = rnd.Next(1, 10);
            int c2, c3, c4;
            do
            {
                c2 = rnd.Next(10);
            }while(c1 == c2);
            bool ok;
            do
            {
                ok = true;
                c3 = rnd.Next(10);
                if (c1 == c3 || c2 == c3)
                    ok = false;
            } while (!ok);
            do
            {
                ok = true;
                c4 = rnd.Next(10);
                if (c1 == c4 || c2 == c4 || c3 == c4)
                    ok = false;
            } while (!ok);
            return c1 * 1000 + c2 * 100 + c3 * 10 + c4;
        }
        public int generateNumber3()
        {
            int[] v = new int[10];
            int x;
            do
            {
                for (int i = 0; i < 4; i++)
                {
                    v[i] = i + 1;
                }
                for (int i = 0; i < v.Length; i++)
                {
                    int t = rnd.Next(10);
                    int aux = v[i];
                    v[i] = v[t];
                    v[t] = aux;
                }
                 x = 0;
                for (int i = 0; i < v.Length; i++)
                {
                    switch (v[i])
                    {
                        case 1:
                            x += i * 1000;
                            break;
                        case 2:
                            x += i * 100;
                            break;
                        case 3:
                            x += i * 10;
                            break;
                        case 4:
                            x += i;
                            break;
                    }
                }
            } while (x < 1000);
            return x;
        }
        public int generateNumber4()
        {
            List<int> intregi = new List<int>();
            for(int i = 0; i <= 9; i++)
            {
                intregi.Add(i);
            }
            int t = rnd.Next(1, 10);
            int x;
            x = intregi[t] * 1000;
            intregi.RemoveAt(t);
            t = rnd.Next(intregi.Count);
            x += intregi[t]*100;
            intregi.RemoveAt(t);
            t = rnd.Next(intregi.Count);
            x += intregi[t] * 10;
            intregi.RemoveAt(t);
            t = rnd.Next(intregi.Count);
            x += intregi[t];
            return x;
        }

    }
}