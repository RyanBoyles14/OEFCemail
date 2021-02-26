﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace OEFCemail
{

    public partial class ThisAddIn
    {

        private IntakeControl1 myIntakeControl1;
        private Microsoft.Office.Tools.CustomTaskPane intakeTaskPane;


        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            myIntakeControl1 = new IntakeControl1();
            intakeTaskPane = this.CustomTaskPanes.Add(myIntakeControl1, "My Task Pane");
            intakeTaskPane.VisibleChanged += new EventHandler(IntakeTaskPane_VisibleChanged);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion

        private void IntakeTaskPane_VisibleChanged(object sender, System.EventArgs e)
        {
            Globals.Ribbons.IntakeRibbon.toggleButtonIntakeDisplay.Checked =
                intakeTaskPane.Visible;
        }

        public Microsoft.Office.Tools.CustomTaskPane TaskPane
        {
            get
            {
                return intakeTaskPane;
            }
        }
    }
}
