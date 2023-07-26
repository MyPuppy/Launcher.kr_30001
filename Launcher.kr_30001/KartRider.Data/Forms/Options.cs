﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Set_Data;

namespace KartRider
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void UseKartTune_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UseKartTune_CheckBox.Checked == true)
            {
                Set_ETC.KartTune_Use = 1;
            }
            else if (UseKartTune_CheckBox.Checked == false)
            {
                Set_ETC.KartTune_Use = 0;
            }
            Set_ETC.Save_KartTune();
            Set_ETC.Check_KartTune();
        }

        private void UseKartPlant_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UseKartPlant_CheckBox.Checked == true)
            {
                Set_ETC.KartPlant_Use = 1;
            }
            else if (UseKartPlant_CheckBox.Checked == false)
            {
                Set_ETC.KartPlant_Use = 0;
            }
            Set_ETC.Save_KartPlant();
            Set_ETC.Check_KartPlant();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            Set_ETC.Load_ALL2();
        }
    }
}