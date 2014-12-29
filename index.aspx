<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>大学在线考试系统</title>
    <link href="../css/Common.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #main
        {
            width: 945px;
            height: 520px;
            margin: 0px auto;
            background: url(image/login.jpg) no-repeat;
        }
        #head
        {
            width: 945px;
            height: 170px;
        }
        #content
        {
            width: 350px;
            height: 300px;
            margin: 30px 0px 0px 20px;
            float: left;
        }
        #login
        {
            height: 110px;
            margin-left: 35px;
            margin-top: 70px;
            width: 300px;
        }
        #left
        {
            width: 350px;
            height: 270px;
            float: left;
            margin: 50px 0px 0px 25px;
            text-align: center;
        }
        body
        {
            margin: 0px;
        }
        .ct
        {
            height: 20px;
            line-height: 20px;
            margin-top: 12px;
        }
        .ct_right
        {
            width: 130px;
            float: left;
        }
        .ct_left
        {
            width: 80px;
            float: left;
        }
        .login_btn
        {
            width: 100px;
            height: 25px;
            margin-left: 115px;
        }
        .footer
        {
            width: 945px;
            margin: 0px auto;
            height: 40px;
            margin-top: 50px;
            text-align: center;
        }
        .yanzheng
        {
            margin-top: 12px;
            height: 20px;
            line-height: 20px;
        }
        .yanzheng_left
        {
            width: 80px;
            float: left;
        }
        .yanzheng_right
        {
            width: 200px;
            float: left;
        }
        .yanzheng_right_left
        {
            width: 70px;
            float: left;
        }
        .yanzhrng_right_right
        {
            width: 40px;
            float: left;
        }
        .head_1
        {
            text-align: right;
            height: 50px;
            margin-top: 0px;
        }
        .head_1 a
        {
            height: 50px;
            color: white;
            text-decoration: none;
            font-size: 12px;
        }
        a
        {
            text-decoration: none;
            color: Black;
        }
        #Image1
        {
            margin-top: 1px;
        }
        #DropDownList1
        {
            margin-top: 2px;
            text-align: center;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <div id="head">
            <div class="head_1">
                <a href="User/zhuce.aspx">注册</a> <span style="color: white;">|</span> <a href="User/getpwd1.aspx">
                    忘记密码?</a>
            </div>
        </div>
        <div id="left">
            <img src="image/1111.png" />
        </div>
        <div id="content">
            <div id="login">
                <div class="ct">
                    <div class="ct_left">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="21px" Width="70px">
                            <asp:ListItem Value="1">学生</asp:ListItem>
                            <asp:ListItem Value="2">管理员</asp:ListItem>
                            <asp:ListItem Value="3">教师</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="ct_right">
                        <asp:TextBox ID="TextBox5" runat="server" Width="130px"></asp:TextBox>
                    </div>
                </div>
                <div class="ct">
                    <div class="ct_left">
                        <span style="color: #5b5b5b; font-size: 12px; float: right;">密码：</span>
                    </div>
                    <div class="ct_right">
                        <asp:TextBox ID="TextBox6" runat="server" Width="130px" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
                <div class="yanzheng">
                    <div class="yanzheng_left">
                        <span style="color: #5b5b5b; font-size: 12px; float: right;">验证码：</span>
                    </div>
                    <div class="yanzheng_right">
                        <div class="yanzheng_right_left">
                            <asp:TextBox ID="TextBox7" runat="server" Width="60px"></asp:TextBox></div>
                        <div class="yanzhrng_right_right">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/code.aspx" />
                        </div>
                       
                    </div>
                </div>
            </div>
            <div class="login_btn">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/login.png" OnClick="ImageButton1_Click" />
            </div>
        </div>
    </div>
    <div class="footer">
        <p style="font-size: 12px; color: #575757">
            Copyright©2013 All rights reserved</p>
    </div>
    </form>
</body>
</html>
