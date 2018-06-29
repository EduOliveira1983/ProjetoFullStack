using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFullStack.Testes.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Classe1 _Classe1 = new Classe1();
            _Classe1._Controle._ProgressBar = this.progressBar1;

            _Classe1.editProgressBar();
        }
    }

    public class Classe1
    {
        public Controle _Controle { get; set; }
        public void editProgressBar(int valor = 50)
        {
            _Controle._ProgressBar.Value = valor;
        }
    }

    public class Controle
    {
        public ProgressBar _ProgressBar { get; set; }
    }
}
