﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FRS
{
    public partial class FacultyDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GenrateStudentAttendanceReportButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("GenerateStudentAttendanceReport.aspx");
        }

        protected void GenrateBatchWiseReportButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("GenrateBatchWiseAttendance.aspx");
        }
    }
}