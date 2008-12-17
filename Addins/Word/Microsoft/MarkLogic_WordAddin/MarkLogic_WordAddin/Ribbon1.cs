﻿/*Copyright 2002-2008 Mark Logic Corporation.  All Rights Reserved*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace MarkLogic_WordAddin
{
    public partial class Ribbon1 : OfficeRibbon
    {
        public Ribbon1()
        {
            InitializeComponent();
        }

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void viewTaskPaneButton_Click(object sender, RibbonControlEventArgs e)
        {
            if (!Globals.ThisAddIn.mlPaneDisplayed)
            {
                Globals.ThisAddIn.AddAllTaskPanes();
            }
            else
            {
                Globals.ThisAddIn.RemoveAllTaskPanes();
            }

        }

    }

 
}
