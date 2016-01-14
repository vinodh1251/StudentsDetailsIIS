using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for Class1
/// </summary>
public class GlobalClass
{
    //public Class1()
    //{
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //}

    public static String GetMMddyyyy(String p_strddMMyyyy)
    {
        String[] str = p_strddMMyyyy.Split("/".ToCharArray());
        String strDt = str[1] + "/" + str[0] + "/" + str[2];
        return strDt;
    }
    public static string GetDBDateFormate(string Date)
    {

        string[] stringdate = Date.Split('/'.ToString().ToCharArray());
        //1 mm
        //    2 dd
        //        3 yy

        return stringdate[2] + "-" + stringdate[1] + "-" + stringdate[0];
    }
    /// <summary>
    /// this method using for smileycode convert to images 
    /// </summary>
    /// <param name="desc"></param>
    /// <returns></returns>

    public static string codeReplacetoimgesmiley(string desc)
    {



        desc = desc.Replace(":aln", "<img title='alien'   src='Chat/Smiley/alien1.png'>");

        desc = desc.Replace(":thk", "<img title='thinking' src='Chat/Smiley/annoyed.png'>");

        desc = desc.Replace(":ang", "<img title='angel' src='Chat/Smiley/angel.png'>");

        desc = desc.Replace(":slp", "<img  title='sleep' src='Chat/Smiley/zzz.png'>");

        desc = desc.Replace(":blnk", "<img title='blank face' src='Chat/Smiley/blanco.png'>");

        desc = desc.Replace(":zip", "<img title='Keep Secret' src='Chat/Smiley/zip_it.png'>");

        desc = desc.Replace(":bor", "<img title='boring' src='Chat/Smiley/boring.png'>");

        desc = desc.Replace(":brb", "<img title='be right back' src='Chat/Smiley/brb.png'>");

        desc = desc.Replace(":bsy", "<img title='busy' src='Chat/Smiley/busy.png'>");

        desc = desc.Replace(":heart", "<img title='heart' src='Chat/Smiley/heart.png'>");

        desc = desc.Replace(":cell", "<img title='cell' src='Chat/Smiley/cellphone.png'>");


        desc = desc.Replace(":tp", "<img title='Time Please' src='Chat/Smiley/clock.png' >");



        desc = desc.Replace(":cool", "<img title='cool'  src='Chat/Smiley/cool.png'>");





        desc = desc.Replace(":czy", "<img title='crazy'  src='Chat/Smiley/crazy.png' >");



        desc = desc.Replace(":cry", "<img title='cry' src='Chat/Smiley/cry.png'  >");



        desc = desc.Replace(":dvl", "<img title='devil' src='Chat/Smiley/devil.png' >");





        desc = desc.Replace(":blush", "<img title='blush' src='Chat/Smiley/blush.png' >");



        desc = desc.Replace(":stop", "<img title='Stop'  src='Chat/Smiley/dnd.png' >");



        desc = desc.Replace(":flwr", "<img title='flower'  src='Chat/Smiley/flower.png' >");








        desc = desc.Replace(":geek", "<img title='geek'  src='Chat/Smiley/geek.png' >");



        desc = desc.Replace(":gift", "<img title='gift'  src='Chat/Smiley/gift.png' >");





        desc = desc.Replace(":ill", "<img title='ill'  src='Chat/Smiley/ill.png' >");



        desc = desc.Replace(":love", "<img title='in love'  src='Chat/Smiley/in_love.png' >");



        desc = desc.Replace(":file", "<img title='file'  src='Chat/Smiley/text_file.png' >");





        desc = desc.Replace(":kiss", "<img title='kissy'  src='Chat/Smiley/kissy.png' >");



        desc = desc.Replace(":laugh", "<img title='laugh'  src='Chat/Smiley/laugh.png' >");



        desc = desc.Replace(":mail", "<img title='mail'  src='Chat/Smiley/mail.png' >");





        desc = desc.Replace(":music", "<img title='music2'  src='Chat/Smiley/music2.png' >");



        desc = desc.Replace(":whst", "<img title='Whistle'  src='Chat/Smiley/not_guilty.png'>");



        desc = desc.Replace(":please", "<img title='please'  src='Chat/Smiley/please.png' >");





        desc = desc.Replace(":info", "<img title='info'  src='Chat/Smiley/info.png' >");



        desc = desc.Replace(":sad", "<img title='sad'  src='Chat/Smiley/sad.png' >");



        desc = desc.Replace(":silly", "<img title='silly'  src='Chat/Smiley/silly.png' >");





        desc = desc.Replace(":lol", "<img title='Laugh Out Loud'  src='Chat/Smiley/oh.png' >");



        desc = desc.Replace(":slps", "<img title='speechless'  src='Chat/Smiley/speechless.png' >");



        desc = desc.Replace(":srpd", "<img title='surprised'  src='Chat/Smiley/surprised.png' >");





        desc = desc.Replace(":tease", "<img title='tease'  src='Chat/Smiley/tease.png' >");



        desc = desc.Replace(":wink", "<img title='wink' alt='wink' src='Chat/Smiley/wink.png'  >");



        desc = desc.Replace(":grin", "<img title='Big Grin'  src='Chat/Smiley/xd.png' >");







        return desc;
    }



    //desc = desc.Replace(" ", "<img title="Time Please" alt="clock" src="Chat/Smiley/clock.png" onclick="smiley(this,':tp');" id="11" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="cool" alt="cool" src="Chat/Smiley/cool.png" onclick="smiley(this,':cool');" id="12" style="cursor: pointer">





    //desc = desc.Replace(" ", "<img title="crazy" alt="crazy" src="Chat/Smiley/crazy.png" onclick="smiley(this,':czy');" id="13" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="cry" alt="cry" src="Chat/Smiley/cry.png" onclick="smiley(this,':cry');" id="14" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="devil" alt="devil" src="Chat/Smiley/devil.png" onclick="smiley(this,':dvl');" id="15" style="cursor: pointer">





    //desc = desc.Replace(" ", "<img title="blush" alt="blush" src="Chat/Smiley/blush.png" onclick="smiley(this,':blush');" id="16" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="Stop" alt="dnd" src="Chat/Smiley/dnd.png" onclick="smiley(this,':stop');" id="17" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="flower" alt="flower" src="Chat/Smiley/flower.png" onclick="smiley(this,':flwr');" id="18" style="cursor: pointer">








    //desc = desc.Replace(" ", "<img title="geek" alt="geek" src="Chat/Smiley/geek.png" onclick="smiley(this,':geek');" id="20" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="gift" alt="gift" src="Chat/Smiley/gift.png" onclick="smiley(this,':gift');" id="21" style="cursor: pointer">





    //desc = desc.Replace(" ", "<img title="ill" alt="ill" src="Chat/Smiley/ill.png" onclick="smiley(this,':ill');" id="22" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="in love" alt="in_love" src="Chat/Smiley/in_love.png" onclick="smiley(this,':love');" id="23" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="file" alt="text_file" src="Chat/Smiley/text_file.png" onclick="smiley(this,':file');" id="24" style="cursor: pointer">





    //desc = desc.Replace(" ", "<img title="kissy" alt="kissy" src="Chat/Smiley/kissy.png" onclick="smiley(this,':kiss');" id="25" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="laugh" alt="laugh" src="Chat/Smiley/laugh.png" onclick="smiley(this,':laugh');" id="26" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="mail" alt="mail" src="Chat/Smiley/mail.png" onclick="smiley(this,':mail');" id="27" style="cursor: pointer">





    //desc = desc.Replace(" ", "<img title="music2" alt="music2" src="Chat/Smiley/music2.png" onclick="smiley(this,':music');" id="28" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="Whistle" alt="not_guilty" src="Chat/Smiley/not_guilty.png" onclick="smiley(this,':whst');" id="29" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="please" alt="please" src="Chat/Smiley/please.png" onclick="smiley(this,':please');" id="30" style="cursor: pointer">





    //desc = desc.Replace(" ", "<img title="info" alt="info" src="Chat/Smiley/info.png" onclick="smiley(this,':info');" id="31" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="sad" alt="sad" src="Chat/Smiley/sad.png" onclick="smiley(this,':sad');" id="32" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="silly" alt="silly" src="Chat/Smiley/silly.png" onclick="smiley(this,':silly');" id="33" style="cursor: pointer">





    //desc = desc.Replace(" ", "<img title="Laugh Out Loud" alt="oh" src="Chat/Smiley/oh.png" onclick="smiley(this,':lol');" id="34" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="speechless" alt="speechless" src="Chat/Smiley/speechless.png" onclick="smiley(this,':slps');" id="35" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="surprised" alt="surprised" src="Chat/Smiley/surprised.png" onclick="smiley(this,':srpd');" id="36" style="cursor: pointer">





    //desc = desc.Replace(" ", "<img title="tease" alt="tease" src="Chat/Smiley/tease.png" onclick="smiley(this,':tease');" id="37" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="wink" alt="wink" src="Chat/Smiley/wink.png" onclick="smiley(this,':wink');" id="38" style="cursor: pointer">



    //desc = desc.Replace(" ", "<img title="Big Grin" alt="Big Grin" src="Chat/Smiley/xd.png" onclick="smiley(this,':grin');" id="39" style="cursor: pointer">









    //string exDir = HttpContext.Current.Server.MapPath(@"Chat\Smiley");


    //foreach (string exFile in Directory.GetFiles(exDir))
    //{

    //}
    public static void SendGmail(string mailTo, string commaDelimCCs, string subject, string message, bool isBodyHtml)
    {



        System.Net.Mail.MailMessage msg = new
        System.Net.Mail.MailMessage("hrmsedutel@gmail.com", mailTo,
        subject, message);
        msg.IsBodyHtml = isBodyHtml;
        if (commaDelimCCs != "")
            msg.Bcc.Add(commaDelimCCs);
        System.Net.NetworkCredential cred = new
        System.Net.NetworkCredential("hrmsedutel@gmail.com", "hrmsedutel12");
        System.Net.Mail.SmtpClient mailClient = new
        System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
        mailClient.EnableSsl = true;
        mailClient.UseDefaultCredentials = false;
        mailClient.Credentials = cred;

        mailClient.Send(msg);
    }


    ClassDBInterface ClsDb;
    DataSet Ds;
    string ReturnStatus;

    public string CheckDepartment(string EmpId)
    {
        ClsDb = new ClassDBInterface();
        ClsDb.AddParams("@EmpId", @EmpId, SqlDbType.Int);

        Ds = ClsDb.GetDataSet("Hrms_GetAllUserPermission_Kra", CommandType.StoredProcedure);
        if (Ds.Tables.Count != 0)
        {
            if (Ds.Tables[0].Rows.Count != 0)
            {
                ReturnStatus = Ds.Tables[0].Rows[0][0].ToString();
            }
            else
            { ReturnStatus = ""; }
        }
        else
        { ReturnStatus = ""; }


        return ReturnStatus;

    }


    public string SendScheduleMail()
    {
       System.Net.Mail.MailMessage msg = new
       System.Net.Mail.MailMessage("vinod@edutel.in", "vinod@edutel.in",
       "Birth Day", "Hi");
        msg.IsBodyHtml = true;
        //if (commaDelimCCs != "")
        //    msg.Bcc.Add(commaDelimCCs);
        System.Net.NetworkCredential cred = new
        System.Net.NetworkCredential("vinod@edutel.in", "subrahmanyam*321");
        System.Net.Mail.SmtpClient mailClient = new
        System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
        mailClient.EnableSsl = true;
        mailClient.UseDefaultCredentials = false;
        mailClient.Credentials = cred;
         mailClient.Send(msg);
        return "";
    }
}
