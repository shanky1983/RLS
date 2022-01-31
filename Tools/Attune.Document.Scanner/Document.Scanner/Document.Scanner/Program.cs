using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WIA;


namespace Document.Scanner
{
    class Program
    {

        public static DeviceManager deviceManager;
        public static Scanner device = null;
        public static string FileName="";

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        static void Main(string[] args)
        {
            try
            {
                var handle = GetConsoleWindow();
                ShowWindow(handle, 0);

                if (args == null || args.Length == 0)
                {
                    RegisterAttuneBarcodeProtocol();
                }
                else
                {
                    string[] lstFile = args[0].Replace("attunedocscanner:", "").Split('~');
                    FileName = lstFile[0];


                    
                        deviceManager = new DeviceManager();


                        for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
                        {
                            if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                            {
                                continue;
                            }
                            device = new Scanner(deviceManager.DeviceInfos[i]);
                        }
                        if (device == null)
                        {
                            CLogger.LogInfo("You need to select first an scanner device from the list");
                            return;
                        }
                        StartScanning();
                    
                     
                    Environment.Exit(0);
                }
            }
            catch (Exception e)
            {
                CLogger.LogError("",e);
                Environment.Exit(0);
            }
            
        }

        

        public static void StartScanning()
        {
            string imageExtension =ConfigurationManager.AppSettings["FtileType"];
            string FilePath = ConfigurationManager.AppSettings["FilePath"]; ;


            ImageFile image = new ImageFile();
             

            switch (imageExtension)
            {
                case "png":
                    image = device.ScanPNG();
                    break;
                case "jpg":
                    image = device.ScanJPEG();
                    break;
                case "tiff":
                    image = device.ScanTIFF();
                    break;
                default:
                    image = device.ScanJPEG();
                    imageExtension = "jpg";
                    break;
            }


            var path = string.Format("{0}\\{1}.{2}", FilePath,FileName,imageExtension);

             

            image.SaveFile(path);
            Attune.Document.Scanner.ServiceDocumentScanner.DocumentScannerSoapClient doc = new Attune.Document.Scanner.ServiceDocumentScanner.DocumentScannerSoapClient();
            byte[] bytes = File.ReadAllBytes(path);
            doc.UploadFile(string.Format("{0}.{1}",  FileName, imageExtension), bytes);

            if (File.Exists(path))
            {
                File.Delete(path);
            }




        }

        static void RegisterAttuneBarcodeProtocol()
        {
             
                string myAppPath = AppDomain.CurrentDomain.BaseDirectory + "\\Attune.Document.Scanner.exe";
                RegistryKey key = Registry.ClassesRoot.OpenSubKey("attunedocscanner");

                if (key == null)
                {
                    key = Registry.ClassesRoot.CreateSubKey("attunedocscanner");
                    key.SetValue(string.Empty, "URL:attunedocscanner protocol");
                    key.SetValue("URL Protocol", string.Empty);

                    key = key.CreateSubKey(@"shell\open\command");
                    key.SetValue(string.Empty, myAppPath + " " + "%1");
                }

                key.Close();
            
        }

    }
}
