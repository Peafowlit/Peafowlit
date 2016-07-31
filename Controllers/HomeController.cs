using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace PeafowlIT_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult SendMail()
        {
            //MailMessage email = new MailMessage();
            //email.From = new MailAddress(" caashishpedhadiya@gmail.com"); //Enter sender email address
            //email.To.Add(" caashishpedhadiya@gmail.com"); //Destination Recipient e-mail address.
            //email.Subject = "WebSite Feedback:";//Subject for your request
            //email.Body = "Hi,<br/>First Name: " + fname.Text + "<br/><br/>Last Name: " + lname.Text + "<br/><br/>Email Id :" + emailid.Text + "<br/><br/> Contact No." + contactno.Text + "<br/><br/> Message : " + msg.Text + "<br/>";
            //email.IsBodyHtml = true;
            ////SMTP SERVER DETAILS
            //SmtpClient smtpc = new SmtpClient("smtp.gmail.com");
            //smtpc.Port = 587;
            //smtpc.UseDefaultCredentials = false;
            //smtpc.EnableSsl = true;
            //Label1.Text = " caashishpedhadiya@gmail.com"; //<--Enter your gmail id here
            //Label2.Text = "Ashish1987";//<--Enter gmail password here
            ////Label3.Text = "msdotnet website"; //Subject for your website
            ////Label4.Text = "webcome to http://msdotnet.co.in. please share this website to your friends"; //Message body
            //smtpc.Credentials = new NetworkCredential(Label1.Text, Label2.Text);
            //smtpc.Send(email);
            //Label2.Visible = true;

            ////Label2.Text = "Your Feedback Submitted Succesfully.";
            ////fname.Text = "";
            ////lname.Text = "";
            ////msg.Text = "";
            ////emailid.Text = "";
            ////contactno.Text = "";
            return RedirectToAction("Contact", "Home");
            //return View();
        }
    }
}

