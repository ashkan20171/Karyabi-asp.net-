<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/RegisterMaterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Karyabi.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphlogin" runat="server">
    <p>
        r
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphmain" runat="server">

    <asp:Label ID="lblmessage" runat="server" Text="Meeasge"></asp:Label>
    <p>

        <table style="border-style: dotted; border-radius: 5px; border-width: medium; width: 90%; text-align: center; background-color: #CCCCCC; float: right">
            <tr>
                <td style="width: 179px; height: 38px">نام کاربری : </td>
                <td style="height: 38px">
                    <asp:TextBox ID="txt_username" runat="server" Height="23px" Width="175px" CssClass="TextBox"></asp:TextBox>

                    <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txt_username"
                        EnableClientScript="true" Display="Dynamic" Text="نام کاربری را وارد کنید"
                        SetFocusOnError="true" CssClass="validation" />
                    <asp:RegularExpressionValidator ID="revUsername" runat="server"
                        ControlToValidate="txt_username" EnableClientScript="true"
                        Display="Dynamic" ValidationExpression="[a-zA-Z0-9]{6,20}"
                        SetFocusOnError="true" Text="نام کاربری وارد شده صحیح نیست " CssClass="validation" />

                </td>

            </tr>
            <tr>
                <td style="width: 179px">رمز عبور : </td>
                <td>
                    <asp:TextBox ID="txt_password" runat="server" Height="23px" Width="175px" CssClass="TextBox"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txt_password"
                        EnableClientScript="true" Display="Dynamic" Text="رمز عبور را را وارد کنید"
                        SetFocusOnError="true" CssClass="validation" />

                    <asp:RegularExpressionValidator ID="revPassword" runat="server"
                        ControlToValidate="txt_password" EnableClientScript="true"
                        Display="Dynamic" ValidationExpression="[a-zA-Z0-9]{6,20}"
                        SetFocusOnError="true" Text="رمز عبور صحیح نمی باشد " CssClass="validation" />
                </td>

            </tr>

            <tr>
                <td style="width: 179px">تکرار رمز عبور : </td>
                <td>
                    <asp:TextBox ID="txt_pass2" runat="server" Height="23px" Width="175px" CssClass="TextBox"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPass2" runat="server" ControlToValidate="txt_pass2"
                        EnableClientScript="true" Display="Dynamic" Text="تکرار رمز عبور را وارد کنید"
                        SetFocusOnError="true" CssClass="validation" />
                    <asp:CompareValidator ID="cpvPass2" runat="server"
                        ControlToValidate="txt_pass2" EnableClientScript="true"
                        Display="Dynamic" ControlToCompare="txt_password"
                        SetFocusOnError="true" CssClass="validation" Text="رمز عبور با هم مطابقت ندارد " CultureInvariantValues="true" />
                </td>

            </tr>
            <tr>
                <td style="width: 179px">نام : </td>
                <td>
                    <asp:TextBox ID="txt_fname" runat="server" Height="23px" Width="175px" CssClass="TextBox"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFame" runat="server" ControlToValidate="txt_fname"
                        EnableClientScript="true" Display="Dynamic" Text="نام را وارد کنید"
                        SetFocusOnError="true" CssClass="validation" />
                </td>

            </tr>
            <tr>
                <td style="width: 179px">نام خانوادگی : </td>
                <td>
                    <asp:TextBox ID="txt_lname" runat="server" Height="23px" Width="175px" CssClass="TextBox"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvLname" runat="server" ControlToValidate="txt_lname"
                        EnableClientScript="true" Display="Dynamic" Text="نام خانوادگی را وارد کنید"
                        SetFocusOnError="true" CssClass="validation" />
                </td>

            </tr>
            <tr>
                <td style="width: 179px">تاریخ تولد : </td>
                <td>
                    <asp:TextBox ID="txt_birth" runat="server" Height="23px" Width="175px" CssClass="TextBox"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td style="width: 179px">کد ملی : </td>
                <td>
                    <asp:TextBox ID="txt_mellicode" runat="server" Height="23px" Width="175px" CssClass="TextBox"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvMelli" runat="server" ControlToValidate="txt_mellicode"
                        EnableClientScript="true" Display="Dynamic" Text="کد ملی را وارد کنید"
                        SetFocusOnError="true" CssClass="validation" />
                    <asp:RegularExpressionValidator ID="revMelli" runat="server"
                        ControlToValidate="txt_mellicode" EnableClientScript="true"
                        Display="Dynamic" ValidationExpression="[0-9]{10}"
                        SetFocusOnError="true" CssClass="validation" Text="کد ملی صحیح نمی باشد " />
                </td>

            </tr>
            <tr>
                <td style="width: 179px">تلفن : </td>
                <td>
                    <asp:TextBox ID="txt_tell" runat="server" Height="23px" Width="175px" CssClass="TextBox "></asp:TextBox>

                    <asp:RequiredFieldValidator ID="rfvTell" runat="server" ControlToValidate="txt_tell"
                        EnableClientScript="true" Display="Dynamic" Text="تلفن را وارد کنید"
                        SetFocusOnError="true" CssClass="validation" />

                </td>

            </tr>
            <tr>
                <td style="width: 179px">موبایل:</td>
                <td>
                    <asp:TextBox ID="txt_mobile" runat="server" Height="23px" Width="175px" CssClass="TextBox "></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvMobile" runat="server" ControlToValidate="txt_mobile"
                        EnableClientScript="true" Display="Dynamic" Text="موبایل را وارد کنید"
                        SetFocusOnError="true" CssClass="validation" />

                </td>

            </tr>
            <tr>
                <td style="width: 179px">ایمیل :</td>
                <td>
                    <asp:TextBox ID="txt_email" runat="server" Height="23px" Width="175px" CssClass="TextBox " OnTextChanged="txt_email_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txt_email"
                        Display="Dynamic" EnableClientScript="true" SetFocusOnError="true"
                        Text="ایمیل را وارد کنید"  CssClass="validation"/>

                    <asp:RegularExpressionValidator ID="revEmail" runat="server"
                        ControlToValidate="txt_email" Display="Dynamic" EnableClientScript="true"
                        SetFocusOnError="true" Text="فرمت ایمیل صحیح نمیباشد "
                        ValidationExpression="\w+@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="validation" />
                </td>

            </tr>
            <tr>
                <td style="width: 179px">گروه کاری : </td>
                <td>
                    <asp:DropDownList ID="cmb_CatWork" runat="server" DataSourceID="EntityDataSource1" DataTextField="JobName" DataValueField="JobName" OnSelectedIndexChanged="cmb_CatWork_SelectedIndexChanged1">
                    </asp:DropDownList>
                                            <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=KaryabiDBEntities" DefaultContainerName="KaryabiDBEntities" EnableFlattening="False" EntitySetName="tbl_JobCategory" Select="it.[JobName]">
                    </asp:EntityDataSource>

                </td>

            </tr>
            <tr>
                <td style="width: 179px">وضعیت تاهل : </td>
                <td>
                    <asp:DropDownList ID="cmb_MaritalStatus" runat="server">
                        <asp:ListItem>مجرد</asp:ListItem>
                        <asp:ListItem>متاهل</asp:ListItem>
                    </asp:DropDownList>
                &nbsp;</td>

            </tr>
            <tr>
                <td style="width: 179px; height: 97px">ادرس : </td>
                <td style="height: 97px">
                    <asp:TextBox ID="txt_address" runat="server" Height="64px" TextMode="MultiLine" Width="243px" CssClass="TextBox "></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td style="width: 179px; height: 80px">درباره توانایی خود چیزی بنوسید : </td>
                <td style="height: 80px">
                    <asp:TextBox ID="txt_description" runat="server" Height="50px" TextMode="MultiLine" Width="227px" CssClass="TextBox "></asp:TextBox>

                </td>

            </tr>
            <tr>
                <td style="width: 179px; height: 54px">انتخاب عکس :</td>
                <td style="height: 54px">
                    <asp:FileUpload ID="FileUpload1" runat="server" Height="22px" />
                    <br />
                    <asp:Label ID="lbl_info" runat="server" Text="---"></asp:Label>
                    <br />
                    <asp:Button ID="btnUpload" runat="server" Text="اپلود عکس" OnClick="btnUpload_Click1" />
                    <br />
                    <asp:Image ID="Image1" runat="server" Width="145px" />
                    <br />

                </td>

            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_insert" runat="server" Text="ثبت نام" OnClick="btn_insert_Click" CssClass="Button" />
                    <input id="Reset1" type="reset" value="Reset Items"  /></td>


            </tr>


        </table>
    </p>

</asp:Content>
