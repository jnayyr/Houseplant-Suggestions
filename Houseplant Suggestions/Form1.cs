﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Houseplant_Suggestions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trkTemp_Scroll(object sender, EventArgs e)
        {
            lblTemp.Text = trkTemp.Value.ToString("# F");
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            int homeTemp = trkTemp.Value;
            bool southFacingWindowAvailable = chkSouthFacing.Checked;

            // Call's method, use return value
            string suggestedPlant = GenerateSuggestion(homeTemp, southFacingWindowAvailable);

            lblSuggestion.Text = suggestedPlant;
        }

        private string GenerateSuggestion(int temp, bool southFacing)
        {
            if(southFacing)
            {
                if (temp > 65)
                {
                    return "Peace Lily"; // cool with light
                }
                else
                {
                    return "Spider Plant"; // warm with light
                }
            }
            else
            {
                if (temp>65)
                {
                    return "Dragon Tree"; // warm with low light
                }
                else
                {
                    return "Ivy"; // cool with low light
                }
            }
        }
    }
}