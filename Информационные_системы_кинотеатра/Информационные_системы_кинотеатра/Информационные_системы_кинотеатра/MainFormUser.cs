﻿using System;
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
    public partial class MainFormUser : Form
    {
        public MainFormUser()
        {
            InitializeComponent();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            SearchFilm searchBook = new SearchFilm();
            searchBook.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FilmOFClienta booksOfReader = new FilmOFClienta();
            booksOfReader.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void MainFormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainFormUser_Load(object sender, EventArgs e)
        {

        }
    }
}
