﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form3 : Form
    {
        private string[] pos3 = new string[] { "Isolate", "Vent", "Feed"};
        private string[] pos2 = new string[] { "Open", "Close" };
        private string[] vname = new string[] { "FV1", "FV2", "FV3", "OV1", "OV2", "OV3", "PV", "NV1", "NV2" };

        public string ValveName;
        public string ValvePosition;
        public string Format;

        private void Form3_Load(object sender, EventArgs e)
        {
            cbValveName.Items.AddRange(vname);
        }

        public Form3()
        {
            InitializeComponent();
        }

        // Methods
        private void AddValvePositions()
        {
            if (Convert.ToString(cbValveName.SelectedItem) == "FV1" || Convert.ToString(cbValveName.SelectedItem) == "OV1")
            {
                cbValvePosition.Items.AddRange(pos3);
            }
            else
            {
                cbValvePosition.Items.AddRange(pos2);
            }
        }

        // Button Events
        private void cbValveName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbValvePosition.Items.Clear();
            AddValvePositions();
        }
        public void btnActuate_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            double number;
            ValveName = cbValveName.GetItemText(cbValveName.SelectedItem);
            Format = cbFormat.GetItemText(cbFormat.SelectedItem);
            ValvePosition = cbValvePosition.GetItemText(cbValvePosition.SelectedItem);
            if (Format.Contains("Degrees"))
            {
                if (Double.TryParse(ValvePosition, out number))
                {
                    number = 0;
                }
                else
                {
                    ValvePosition = null; 
                    MessageBox.Show("Please fill in a valid degree value.");
                    cbValvePosition.Text = " ";
                    this.Show();
                }
            }
            else
            {
                ValvePosition = ValvePosition.Substring(0, 1);
            }
        }
        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbValvePosition.Items.Clear(); 
            string option = cbFormat.GetItemText(cbFormat.SelectedItem);
            if (option.Contains("Degrees"))
            {
                cbValvePosition.DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                cbValvePosition.DropDownStyle = ComboBoxStyle.DropDownList;
                AddValvePositions();
            }
        }
    }
}
