﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace Kursach
{
    public partial class Form9 : MetroForm
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "KursachDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.ЗаказыTableAdapter.Fill(this.KursachDataSet.Заказы);

            this.reportViewer1.RefreshReport();
        }
    }
}
