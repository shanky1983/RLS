using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Text;
using Attune.Podium.BusinessEntities;
using Attune.Podium.FileUpload;
using Attune.Solution.BusinessComponent;
using System.Data;
using Attune.Podium.Common;
using Attune.Podium.BillingEngine;
using System.Drawing;
using System.Web.UI.HtmlControls;
using System.IO;

public partial class FileHandlers_ShowOldNoteImages : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        long returnCode = -1;
        Blob blob = new Blob();
        int fileID = 0;

        try
        {
            FileUploadManager obj = new FileUploadManager(base.ContextInfo);

            if (Int32.TryParse(Request.QueryString["fileID"].ToString(), out fileID))
            {
                returnCode = obj.GetFile(fileID, out blob);

                if (returnCode == 0)
                {
                    string fpath = Uploadpath + blob.FileURL;

                    System.IO.FileStream fs;
                    fs = File.Open(fpath, FileMode.Open, FileAccess.Read, FileShare.None);
                    byte[] bImage = new byte[fs.Length];

                    fs.Read(bImage, 0, bImage.Length);

                    //bImage = (byte[])dt.Rows[0].ItemArray[1];
                    Response.ContentType = blob.MIMEType;
                    Response.BinaryWrite((byte[])bImage);
                }

            }
        }
        catch (System.IO.FileNotFoundException fnfe)
        {
            Response.ContentType = "text/html";
            Response.Write(@"<b>File unavailable: Could be a virus infected file.</B> 
                            <br><br> Virus affected files are automatically deleted in the server. Please re-upload the file.");
            CLogger.LogError("Error Loading file " + fileID.ToString() + ":", fnfe);
            returnCode = 0;
        }
        catch (Exception ex)
        {
            CLogger.LogError("Error Loading file " + fileID.ToString() + ":", ex);
        }
    }
}
