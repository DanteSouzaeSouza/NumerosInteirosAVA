﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosInteirosAVA
{
    public partial class FrmNums : Form
    {
        public FrmNums()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            //limpa o ListBox
            lstNums.Items.Clear();

            //declaração da variável controladora do laço
            int i;

            for (i = 0; i <= 100; i++)
            {
                //acrescenta o valor da variável i no ListBox
                lstNums.Items.Add(i);
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            //limpa o ListBox
            lstNums.Items.Clear();

            //declara e inicializa a variável controladora do laço
            int i = 1;

            while (i <= 100)
            {
                //acrescenta o valor da variável i no ListBox
                lstNums.Items.Add(i);

                //incrementa a variável controladora
                i++;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            //limpa o ListBox
            lstNums.Items.Clear();

            //declara e inicializa a variável controladora do laço
            int i = 1;

            do
            {
                //acrescenta o valor da variável i no ListBox
                lstNums.Items.Add(i);

                //incrementa a variável controladora
                i++;

            } while (i <= 100);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar os itens do ListBox
            lstNums.Items.Clear();
        }
    }
}
