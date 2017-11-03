using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Data;
using Ralwey.Models;

namespace Ralwey
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string sendEmail(string senderFrom, string subject, string body)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            connetionString = "Data Source=servername;Initial Catalog=dbname;uid=xxx;pwd=xxx";

            connection = new SqlConnection(connetionString);

            connection.Open();

            adapter.SelectCommand = new SqlCommand("SELECT emailId  from subscribers", connection);//your sql command here      

            adapter.Fill(ds);
            connection.Close();


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string ddds = ds.Tables[0].Rows[1]["emailId"].ToString();
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress(senderFrom);
                Msg.To.Add(ddds);
                Msg.Subject = subject;
                Msg.Body = body;
                Msg.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                NetworkCred.UserName = "your email id here";
                NetworkCred.Password = "your password here";
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(Msg);
            }
            return "Newsletter sent to every one";
        }
    }
}
