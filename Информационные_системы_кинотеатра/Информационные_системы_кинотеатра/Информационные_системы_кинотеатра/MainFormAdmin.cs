using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Информационные_системы_кинотеатра
{
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddFilm addBook = new AddFilm();
            addBook.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SearchFilm searchBook = new SearchFilm();
            searchBook.ShowDialog();
        }

        private void РегистрацияЧитателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationUser registrationUser = new RegistrationUser();
            registrationUser.ShowDialog();
        }

        private void КарточкаЧитателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsPersonalAccount cartOfReader = new ClientsPersonalAccount();
            cartOfReader.ShowDialog();
        }

        private void ДобавитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFilm addBook = new AddFilm();
            addBook.ShowDialog();
        }

        private void ВыдатьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionTicket giveOutBook = new SessionTicket();
            giveOutBook.ShowDialog();
        }

        private void ВыданныеКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionTicket booksOnHands = new SessionTicket();
            booksOnHands.ShowDialog();
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
