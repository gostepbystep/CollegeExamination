﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin1_Default : System.Web.UI.Page
{
    Datacon db = new Datacon();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            db.ecDropDownList(ddlCourse, "select * from Course where teacher_id='" + Session["ID"] + "'", "c_name", "c_id");          //初始化考试科目下拉列表框          

        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
      
            if (cblAnswer.Items[0].Selected == true && cblAnswer.Items[1].Selected == true && cblAnswer.Items[2].Selected == true && cblAnswer.Items[3].Selected == true)
            {
                string strr1 = "ABCD";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr1 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
            if (cblAnswer.Items[0].Selected == true && cblAnswer.Items[1].Selected == true && cblAnswer.Items[2].Selected == true && cblAnswer.Items[3].Selected == false)
            {
                string strr2 = "ABC";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr2 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
            if (cblAnswer.Items[0].Selected == true && cblAnswer.Items[1].Selected == true && cblAnswer.Items[2].Selected == false && cblAnswer.Items[3].Selected == false)
            {
                string strr3 = "AB";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr3 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
            if (cblAnswer.Items[0].Selected == true && cblAnswer.Items[1].Selected == false && cblAnswer.Items[2].Selected == false && cblAnswer.Items[3].Selected == false)
            {
                string strr4 = "A";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr4 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
            if (cblAnswer.Items[0].Selected == false && cblAnswer.Items[1].Selected == true && cblAnswer.Items[2].Selected == false && cblAnswer.Items[3].Selected == false)
            {
                string strr5 = "B";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr5 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
            if (cblAnswer.Items[0].Selected == false && cblAnswer.Items[1].Selected == true && cblAnswer.Items[2].Selected == true && cblAnswer.Items[3].Selected == false)
            {
                string strr6 = "BC";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr6 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
            if (cblAnswer.Items[0].Selected == false && cblAnswer.Items[1].Selected == true && cblAnswer.Items[2].Selected == false && cblAnswer.Items[3].Selected == true)
            {
                string strr7 = "BD";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr7 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
            if (cblAnswer.Items[0].Selected == false && cblAnswer.Items[1].Selected == true && cblAnswer.Items[2].Selected == true && cblAnswer.Items[3].Selected == true)
            {
                string strr8 = "BCD";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr8 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
            if (cblAnswer.Items[0].Selected == true && cblAnswer.Items[1].Selected == false && cblAnswer.Items[2].Selected == false && cblAnswer.Items[3].Selected == true)
            {
                string strr9 = "AD";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr9 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
            if (cblAnswer.Items[0].Selected == false && cblAnswer.Items[1].Selected == false && cblAnswer.Items[2].Selected == true && cblAnswer.Items[3].Selected == true)
            {
                string strr10 = "CD";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr10 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
            if (cblAnswer.Items[0].Selected == true && cblAnswer.Items[1].Selected == false && cblAnswer.Items[2].Selected == true && cblAnswer.Items[3].Selected == false)
            {
                string strr11 = "AC";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr11 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
            if (cblAnswer.Items[0].Selected == true && cblAnswer.Items[1].Selected == true && cblAnswer.Items[2].Selected == false && cblAnswer.Items[3].Selected == true)
            {
                string strr12 = "ABD";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr12 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
            if (cblAnswer.Items[0].Selected == true && cblAnswer.Items[1].Selected == false && cblAnswer.Items[2].Selected == true && cblAnswer.Items[3].Selected == true)
            {
                string strr13 = "ACD";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr13 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
            if (cblAnswer.Items[0].Selected == false && cblAnswer.Items[1].Selected == false && cblAnswer.Items[2].Selected == true && cblAnswer.Items[3].Selected == false)
            {
                string strr14 = "C";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr14 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
            if (cblAnswer.Items[0].Selected == false && cblAnswer.Items[1].Selected == false && cblAnswer.Items[2].Selected == false && cblAnswer.Items[3].Selected == true)
            {
                string strr15 = "D";
                db.eccom("insert into MultiProblem(c_id,Title,AnswerA,AnswerB,AnswerC,AnswerD,Answer) values('" + Request["ddlCourse"] + "','" + this.txtTitle.Text + "','" + this.txtAnswerA.Text + "','" + this.txtAnswerB.Text + "','" + this.txtAnswerC.Text + "','" + this.txtAnswerD.Text + "','" + strr15 + "')");
                Response.Write("<script>alert('添加成功！')</script>");

            }
  
    }
}