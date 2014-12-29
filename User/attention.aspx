<%@ Page Language="C#" AutoEventWireup="true" CodeFile="attention.aspx.cs" Inherits="User_attention" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/Common.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .head
        {
            width: 900px;
            margin: 0px auto;
            height: 110px;
            background: url(../image/main_03.jpg);
        }
        .content
        {
            width: 900px;
            margin: 0px auto;
            height: 400px;
        }
        .footer
        {
            width: 900px;
            margin: 0px auto;
            height: 50px;
            text-align: center;
        }
        .top
        {
            height: 22px;
            margin: 0px auto;
            background: url(../image/answer.png);
        }
        .top_content
        {
            height: 20px;
            margin: 0px auto;
            width: 900px;
            margin-top: 6px;
        }
        .c_left
        {
            width: 200px;
            height: 100%;
            float: left;
        }
        .c_right
        {
            width: 190px;
            height: 100%;
            float: left;
        }
        .c_center
        {
            width: 500px;
            height: 100%;
            float: left;
        }
        .c_c_head
        {
            width: 500px;
            height: 30px;
            border-bottom: 3px solid #369aff;
            line-height: 30px;
            text-align: left;
            color: #d8730d;
            font-weight: bold;
        }
        .c_c_text
        {
            width: 500px;
            height: 265px;
            text-align: left;
            border-bottom: 1px dashed #bbb;
        }
        .c_c_text p
        {
            color: #35496a;
        }
        .c_c_btn
        {
            width: 500px;
            height: 27px;
            text-align: center;
            margin-top: 5px;
            line-height: 27px;
        }
        #bottom
        {
            margin: 0px auto;
            height: 78px;
            background: url(../image/footer.png);
            border-top: 1px solid #c0c1c1;
            margin-top: 25px;
        }
        .image
        {
            margin-top: 200px;
            float: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="top">
        <div class="top_content">
            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/image/home1.gif" />
        </div>
    </div>
    <div class="head">
    </div>
    <div class="content">
        <div class="c_left">
        </div>
        <div class="c_center">
            <div class="c_c_head">
                考试规则</div>
            <div class="c_c_text">
                <p>
                    一、考生在每场考试前20分钟凭准考证进入考场，对号入座。入座后将准考证放在桌面醒目位置，同时，随身携带身份证等有效证件，以备查对。
                </p>
                <p>
                    二、考生入座不得携带任何书籍、笔记、纸张、字典、计算器、电子记事本、寻呼机、手机等，不得携带任何存储设备（包括软盘、移动硬盘、光盘、U盘、MP3、掌上电脑）。书包、雨伞、大衣等物一律放在考场指定位置。</p>
                <p>
                    三、考试前10分钟，根据监考人员的提示，考生双击考生机桌面上的考试系统图标，启动考试系统客户端，按照《上机考试注意事项》的要求，录入考生姓名、准考证号、身份证号（或其它有效证件号）等信息，进入考试系统。考试铃响后考生开始答题。</p>
                <p>
                    四、考生按照计算机软件考试系统的要求答题并保存答题结果。除完成题目要求的内容外，不得在答卷内填写其它任何与考生身份有关的标记，否则答卷作废。</p>
                <p>
                    五、没有按照要求进行登录、答题、保存、交卷的考生，考试系统将不能正确记录信息，后果由考生承担。</p>
            </div>
            <div class="c_c_btn">
                <asp:CheckBox ID="CheckBox1" runat="server" ForeColor="#0066FF" Text="同意所有《考试规则》" />
            </div>
            <div class="c_c_btn">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/Submit.GIF" OnClick="ImageButton1_Click" />
            </div>
        </div>
        <div class="c_right">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/image/b.jpg" CssClass="image" Height="137px"
                Width="154px" />
        </div>
    </div>
    <div id="bottom">
        <div class="footer">
            <p style="font-size: 12px; color: #575757">
                Copyright @2013 版权所有</p>
        </div>
    </div>
    </form>
</body>
</html>
