using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Data;



namespace Karyabi
{
    public partial class Register : System.Web.UI.Page
    {
        //*********** Start Methods **********
        public void BindJobCategory()
        {
            var ShowCategory = database.tbl_JobCategory.Select(c => c.JobName);
            cmb_CatWork.DataSource = ShowCategory.ToList();
            cmb_CatWork.DataBind();
        }

        public void ClearItmes()
        {
            txt_address.Text = string.Empty;
            txt_birth.Text = string.Empty;
            txt_description.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_fname.Text = string.Empty;
            txt_lname.Text = string.Empty;
            txt_mellicode.Text = string.Empty;
            txt_mobile.Text = string.Empty;
            txt_pass2.Text = string.Empty;
            txt_password.Text = string.Empty;
            txt_tell.Text = string.Empty;
            txt_username.Text = string.Empty;
           
        }
        //*********** End Methods **************
        KaryabiDBEntities2 database = new KaryabiDBEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
         //   if (Page.IsPostBack == false)
        //    {
          //   BindJobCategory();
         //   }
            
            
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
        }
        protected void btn_insert_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                var AlreadyUsername = database.tbl_Customers.Where(c => c.Username == txt_username.Text);
                var AlreadyEmail = database.tbl_Customers.Where(c => c.Email == txt_email.Text);
                var AlreayMelliCode = database.tbl_Customers.Where(i => i.CodeMelli == txt_mellicode.Text);
                //******* Check Username in Database *********
                #region CheckUsername
                if (AlreadyUsername.Count() != 0)
                {
                    lblmessage.ForeColor = Color.Red;
                    lblmessage.Text = "نام کاربری وارد شده تکراری میباشد";
                    return;
                }
                #endregion

                //******* Check Email in Database ************
                #region CheckEmail
                else if (AlreadyEmail.Count() != 0)
                {
                    lblmessage.ForeColor = Color.Red;
                    lblmessage.Text = "ایمیل وارد شده تکراری میباشد";
                    return;
                }
                #endregion

                //******* Check MelliCode in Database *******
                #region CheckMeliCode
                else if (AlreayMelliCode.Count() != 0)
                {
                    lblmessage.ForeColor = Color.Red;
                    lblmessage.Text = "کد ملی وارد شده تکراری میباشد";
                    return;
                }
                #endregion

                else
                {
                  /*  string showvalue = "select * from tbl_JobCategory Where JobName='" +cmb_CatWork.SelectedItem.Text +"' ";
                    DataTable dt = new DataTable();
                    dt = Function.DoQuery(showvalue); */
                    
                    var FullRegister = from a in database.tbl_JobCategory where a.JobName == cmb_CatWork.SelectedItem.Text && a.Tedad == 0 select a;
                    if (FullRegister.Count() != 0 )
                    {
                        lblmessage.ForeColor = Color.Red;
                    //    lblmessage.Text = "ثبت نام در این گروه"+ dt.Rows[0]["JobName"]+" به حد اکثر رسیده است";
                        lblmessage.Text = " ثبت نام در این گروه " + "[" + "" + cmb_CatWork.SelectedItem.Text + "  " + "]" + "به حد اکثر رسیده است";
                        return;
                    }

                    if (FileUpload1.FileName.Length > 0)
                    {
                        string Fex = Path.GetExtension(FileUpload1.FileName).ToLower();
                        if (Fex != ".jpg" && Fex != ".jpeg" && Fex != ".png")
                        {

                            System.Windows.Forms.MessageBox.Show("پسوند عکس انتخاب شده مجاز به اپلود نیست", "خطا", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            return;
                        }

                    }
                    if (FileUpload1.FileBytes.Length / 1024 > 500)
                    {
                        System.Windows.Forms.MessageBox.Show("حجم عکس انتخاب شده بیش از 500 کیلوبایت میباشد", "خطا", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                        return;
                    }
                    string serverPath = Server.MapPath(Request.ApplicationPath) +
                        @"\Images\UserImages\";
                    string picFilename = serverPath + txt_username.Text + ".jpg";
                    try
                    {
                        FileUpload1.SaveAs(picFilename);
                    }
                    catch (Exception ex)
                    {
                        global::System.Windows.Forms.MessageBox.Show(ex.ToString());
                    }

                    string text = txt_description.Text;
                    string text1 = text;
                    string text11 = text1;
                    tbl_Customers table = new tbl_Customers()
                    {
                        Username = txt_username.Text,
                        Password = txt_password.Text,
                        Name = txt_fname.Text,
                        Family = txt_lname.Text,
                        Birth = txt_birth.Text,
                        CodeMelli = txt_mellicode.Text,
                        Tell = txt_tell.Text,
                        Mobile = txt_mobile.Text,
                        Email = txt_email.Text,
                        WorkName = cmb_CatWork.SelectedItem.Text,
                        MaritalStatus = cmb_MaritalStatus.Text,
                        Address = txt_address.Text,
                        Image = txt_username.Text + ".jpg",
                        Description = text11,
                        State = false,
                        FlagAdmin=false,
                        OfficerValid="",

                  
                        
                    };

                    
                    database.tbl_Customers.Add(table);
                    database.SaveChanges();
                    
                    DataSet1TableAdapters.tbl_JobCategoryTableAdapter tbl_job = new DataSet1TableAdapters.tbl_JobCategoryTableAdapter();
                    tbl_job.LowCount(cmb_CatWork.Text);

                    lblmessage.ForeColor = Color.Green;
                    lblmessage.Text = "اطلاعات شما با موفقیت در سیستم ذخیره گردید";

                    ClearItmes();
                }

            }

        }

        protected void btnUpload_Click1(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                int filesize = FileUpload1.FileBytes.Length / 1024;
                string fname = FileUpload1.FileName;
                string extension = Path.GetExtension(FileUpload1.FileName).ToLower();
                if (filesize > 700)
                {
                    lbl_info.Text = "Invalid File Size";
                    return;
                }
                if (extension != ".jpg" && extension != ".jpeg" && extension != ".png")
                {
                    lbl_info.Text = "invalid File Format";
                    return;
                }
                string masir = Server.MapPath(Request.ApplicationPath) +
                    @"\DataFiles\" + fname;
                FileUpload1.SaveAs(masir);
                Image1.ImageUrl = @"/DataFiles/" + fname;
                // lbl_info.Text = string.Format("Filename : {0},FileSize : {1} KB , Extension : {2}" ,fname,filesize,extension );
                lbl_info.ForeColor = Color.Green;
                lbl_info.Text = "Image Successfully Upload";
            }
            else
            {
                lbl_info.ForeColor = Color.Red;
                lbl_info.Text = "No File";
            }
        }

    

        protected void txt_email_TextChanged(object sender, EventArgs e)
        {


        }

        protected void cmb_CatWork_SelectedIndexChanged1(object sender, EventArgs e)
        {

          
        }

    }
}