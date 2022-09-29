using Microsoft.Win32;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Dexcom_PRT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //IWebDriver _driver;
        ChromeDriver _driver;
        DirectoryInfo _directoryInfo;


        public MainWindow()
        {
            InitializeComponent();

            FileSystemWatcher watcher_1 = new FileSystemWatcher(@"C:\Users\MarquezFr\Downloads\");
            watcher_1.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher_1.Changed += DetectDownloadedFiles;
            watcher_1.Filter = "*.*";
            watcher_1.IncludeSubdirectories = true;
            watcher_1.EnableRaisingEvents = true;

            lblWeekNumber.Content = "Current Week Number: " + Globals.CURRENT_WEEK_NUM.ToString();


            DockMenu.Width = 0;
            btnOpenPRT.Visibility = Visibility.Hidden;
        }

        void QueryAOI(DateTime _StartDate, DateTime _EndDate)
        {
            //Clear Start Date DateTime Picker
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtStarDateDiag")).Clear();

            //Set Date on Date Time Picker Start
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtStarDateDiag")).SendKeys(_StartDate.ToString("MM/dd/yyyy"));

            //Clear End Date DateTime Picker
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtEndDateDiag")).Clear();

            //Set Date on Date Time Picker End
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtEndDateDiag")).SendKeys(_EndDate.ToString("MM/dd/yyyy"));

            //Set End Hou in ComboBox ddlHorsEnd
            _driver.FindElement(By.Id("ContentPlaceHolder1_ddlHrsEnd")).SendKeys("18");

            //Select RadioButton Platform
            _driver.FindElement(By.Id("ContentPlaceHolder1_rbtnAOI")).Click();

            //Update information in TestPerformance
            _driver.FindElement(By.Id("ContentPlaceHolder1_btnUpdate")).Click();

            //Get Totales
            Globals.TOTAL_FAIL_REAL = _driver.FindElement(By.Id("ContentPlaceHolder1_txtTotalFailReal")).GetAttribute("Value");
            Globals.TOTAL_PZAS_FALSE_CALL = _driver.FindElement(By.Id("ContentPlaceHolder1_txtTotalPzasFalseCall")).GetAttribute("Value");
            Globals.TOTAL_NO_CONFIRMED = _driver.FindElement(By.Id("ContentPlaceHolder1_txtTotalNoConfirmed")).GetAttribute("Value");
            Globals.TOTAL_PASS_REAL = _driver.FindElement(By.Id("ContentPlaceHolder1_txtTotalPassReal")).GetAttribute("Value");

            //Download Excel File
            _driver.FindElement(By.Id("ContentPlaceHolder1_ibtnExportExcel")).Click();
        }

        void QueryAXI(DateTime _StartDate, DateTime _EndDate)
        {
            //Click on AOI Efficiency
            _driver.FindElement(By.Id("btnAOI")).Click();

            //Select Customer
            _driver.FindElement(By.Id("ContentPlaceHolder1_ddlWorkCell")).SendKeys("DEXCOM");

            //Disable Automatic Current Day
            //_driver.FindElement(By.Id("ContentPlaceHolder1_chkAutomaticToday")).Click();

            //Clear Start Date DateTime Picker
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtStarDateDiag")).Clear();

            //Set Date on Date Time Picker Start
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtStarDateDiag")).SendKeys(_StartDate.ToString("MM/dd/yyyy"));

            //Clear End Date DateTime Picker
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtEndDateDiag")).Clear();

            //Set Date on Date Time Picker End
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtEndDateDiag")).SendKeys(_EndDate.ToString("MM/dd/yyyy"));

            //Set End Hou in ComboBox ddlHorsEnd
            _driver.FindElement(By.Id("ContentPlaceHolder1_ddlHrsEnd")).SendKeys("18");

            //Select RadioButton Platform
            _driver.FindElement(By.Id("ContentPlaceHolder1_rbtnAXI")).Click();

            //Update information in TestPerformance
            _driver.FindElement(By.Id("ContentPlaceHolder1_btnUpdate")).Click();

            //Get Totales
            Globals.TOTAL_FAIL_REAL = _driver.FindElement(By.Id("ContentPlaceHolder1_txtTotalFailReal")).GetAttribute("Value");
            Globals.TOTAL_PZAS_FALSE_CALL = _driver.FindElement(By.Id("ContentPlaceHolder1_txtTotalPzasFalseCall")).GetAttribute("Value");
            Globals.TOTAL_NO_CONFIRMED = _driver.FindElement(By.Id("ContentPlaceHolder1_txtTotalNoConfirmed")).GetAttribute("Value");
            Globals.TOTAL_PASS_REAL = _driver.FindElement(By.Id("ContentPlaceHolder1_txtTotalPassReal")).GetAttribute("Value");

            //Download Excel File
            _driver.FindElement(By.Id("ContentPlaceHolder1_ibtnExportExcel")).Click();

            Thread.Sleep(5000);
        }

        void QueryAVI(DateTime _StartDate, DateTime _EndDate)
        {
            //Click on AOI Efficiency
            _driver.FindElement(By.Id("btnAOI")).Click();

            //Select Customer
            _driver.FindElement(By.Id("ContentPlaceHolder1_ddlWorkCell")).SendKeys("DEXCOM");

            //Disable Automatic Current Day
            //_driver.FindElement(By.Id("ContentPlaceHolder1_chkAutomaticToday")).Click();

            //Clear Start Date DateTime Picker
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtStarDateDiag")).Clear();

            //Set Date on Date Time Picker Start
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtStarDateDiag")).SendKeys(_StartDate.ToString("MM/dd/yyyy"));

            //Clear End Date DateTime Picker
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtEndDateDiag")).Clear();

            //Set Date on Date Time Picker End
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtEndDateDiag")).SendKeys(_EndDate.ToString("MM/dd/yyyy"));

            //Set End Hou in ComboBox ddlHorsEnd
            _driver.FindElement(By.Id("ContentPlaceHolder1_ddlHrsEnd")).SendKeys("18");

            //Select RadioButton Platform
            _driver.FindElement(By.Id("ContentPlaceHolder1_rbtnAVI")).Click();

            //Update information in TestPerformance
            _driver.FindElement(By.Id("ContentPlaceHolder1_btnUpdate")).Click();

            //Get Totales
            Globals.TOTAL_FAIL_REAL = _driver.FindElement(By.Id("ContentPlaceHolder1_txtTotalFailReal")).GetAttribute("Value");
            Globals.TOTAL_PZAS_FALSE_CALL = _driver.FindElement(By.Id("ContentPlaceHolder1_txtTotalPzasFalseCall")).GetAttribute("Value");
            Globals.TOTAL_NO_CONFIRMED = _driver.FindElement(By.Id("ContentPlaceHolder1_txtTotalNoConfirmed")).GetAttribute("Value");
            Globals.TOTAL_PASS_REAL = _driver.FindElement(By.Id("ContentPlaceHolder1_txtTotalPassReal")).GetAttribute("Value");

            //Download Excel File
            _driver.FindElement(By.Id("ContentPlaceHolder1_ibtnExportExcel")).Click();

            Thread.Sleep(5000);
        }

        void QueryFVT(DateTime _StartDate, DateTime _EndDate)
        {
            //btnDiagnostic
            _driver.FindElement(By.Id("btnDiagnostic")).Click();

            //Select Customer
            _driver.FindElement(By.Id("ContentPlaceHolder1_ddlWorkCellDiag")).SendKeys("DEXCOM");

            //Disable Automatic Current Day
            //_driver.FindElement(By.Id("ContentPlaceHolder1_chkAutomaticToday")).Click();

            //Clear Start Date DateTime Picker
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtStarDateDiag")).Clear();

            //Set Date on Date Time Picker Start
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtStarDateDiag")).SendKeys(_StartDate.ToString("MM/dd/yyyy"));

            //Clear End Date DateTime Picker
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtEndDateDiag")).Clear();

            //Set Date on Date Time Picker End
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtEndDateDiag")).SendKeys(_EndDate.ToString("MM/dd/yyyy"));

            //Set End Hou in ComboBox ddlHorsEnd
            _driver.FindElement(By.Id("ContentPlaceHolder1_ddlHrsEnd")).SendKeys("18");


            //Update information in TestPerformance
            _driver.FindElement(By.Id("ContentPlaceHolder1_btnUpdate")).Click();

            //Download Excel File
            _driver.FindElement(By.Id("ContentPlaceHolder1_btnExportarExcel")).Click();

            Thread.Sleep(5000);


            //btnTestPerformance
            _driver.FindElement(By.Id("Button1")).Click();

            //Select Customer
            _driver.FindElement(By.Id("ContentPlaceHolder1_ddlWorkCell")).SendKeys("DEXCOM");

            //Disable Automatic Current Day
            _driver.FindElement(By.Id("ContentPlaceHolder1_chkAutomaticToday")).Click();

            //Clear Start Date DateTime Picker
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtStartDate")).Clear();

            //Set Date on Date Time Picker Start
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtStartDate")).SendKeys(_StartDate.ToString("MM/dd/yyyy"));

            //Clear End Date DateTime Picker
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtEndDate")).Clear();

            //Set Date on Date Time Picker End
            _driver.FindElement(By.Id("ContentPlaceHolder1_txtEndDate")).SendKeys(_EndDate.ToString("MM/dd/yyyy"));

            //Set End Hou in ComboBox ddlHorsEnd
            _driver.FindElement(By.Id("ContentPlaceHolder1_ddlHrsEnd")).SendKeys("18");

            //CLick on update button
            _driver.FindElement(By.Id("ContentPlaceHolder1_btnUpdate")).Click();

            //Get Totales
            Globals.TOTAL_FAIL_REAL = "0";
            Globals.TOTAL_PZAS_FALSE_CALL = "0";
            Globals.TOTAL_NO_CONFIRMED = "0";
            Globals.TOTAL_PASS_REAL = _driver.FindElement(By.Id("ContentPlaceHolder1_tbFVTTested")).GetAttribute("Value");

            Thread.Sleep(2000);
        }

        void GetInformationFromTP(string _Platform)
        {
            DateTime _StartDate = (DateTime)DPickerStart.SelectedDate;
            DateTime _EndDate = (DateTime)DPickerEnd.SelectedDate;

            if (_Platform == "AOI") 
            {
                QueryAOI(_StartDate, _EndDate);
                DetectDownloadedFiles2();
            }


            if (_Platform == "AXI") 
            {
                QueryAXI(_StartDate, _EndDate);
                DetectDownloadedFiles2();
            }


            if (_Platform == "AVI") 
            {
                QueryAVI(_StartDate, _EndDate);
                DetectDownloadedFiles2();
            }

            if (_Platform == "FVT") 
            {
                QueryFVT(_StartDate, _EndDate);
                DetectDownloadedFiles2();
            }
            
            Globals.LAST_PLATFORM = Globals.CURRENT_PLATFORM;
            CreateTotalAmountFile();
        }


        void DetectDownloadedFiles2() 
        {
            _directoryInfo = new DirectoryInfo(@"C:\Users\MarquezFr\Downloads\");
            FileInfo[] _files = _directoryInfo.GetFiles("*.xls").OrderByDescending(fi => fi.CreationTime).ToArray();
            _files[0].CopyTo(Globals.PATH_PRT + Globals.WEEK_YEAR_FORMAT + @"\" + Globals.CURRENT_PLATFORM + Globals.WEEK_YEAR_FORMAT + ".xls", true);
        }


        void CreateTotalAmountFile() 
        {
            string _FilePath = Globals.PATH_PRT + Globals.WEEK_YEAR_FORMAT + @"\" + Globals.LAST_PLATFORM + " Totales.txt";
           
            using (StreamWriter _SW = File.CreateText(_FilePath))
            {
                _SW.WriteLine("Totales Fail Real: " + Globals.TOTAL_FAIL_REAL.ToString());
                _SW.WriteLine("Totales False Call: " + Globals.TOTAL_PZAS_FALSE_CALL.ToString());
                _SW.WriteLine("Totales No Confirmed: " + Globals.TOTAL_NO_CONFIRMED.ToString());
                _SW.WriteLine("Totales Pass Real: " + Globals.TOTAL_PASS_REAL.ToString());
                _SW.WriteLine("Total: " + Globals.TOTAL.ToString());
                _SW.Close();
            }
        }


        private void DetectDownloadedFiles(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed) return;

            //_directoryInfo = new DirectoryInfo(@"C:\Users\MarquezFr\Downloads\");
            //FileInfo[] _files = _directoryInfo.GetFiles("*.xls").OrderByDescending(fi => fi.CreationTime).ToArray();

            //switch (Globals.LAST_PLATFORM)
            //{
            //    case "AOI":

            //        _files[0].CopyTo(@"C:\tryout\AOI w31y22.xls", true);

            //        break;

            //    case "AXI":

            //        _files[0].CopyTo(@"C:\tryout\AXI w31y22.xls", true);

            //        break;

            //    case "AVI":

            //        _files[0].CopyTo(@"C:\tryout\AVI w31y22.xls", true);

            //        break;


            //    case "FVT":

            //        _files[0].CopyTo(@"C:\tryout\FVT w31y22.xls", true);

            //        break;


            //    default:

            //        break;
            //}
        }


        private void btnQuery_Click(object sender, RoutedEventArgs e)
        {
            //ThreadStart ts1 = new ThreadStart(GetInformationFromTP);
            //Thread t1 = new Thread(ts1);
            //t1.Start();



            try
            {
                DateTime _StartDate = (DateTime)DPickerStart.SelectedDate;
                DateTime _EndDate = (DateTime)DPickerEnd.SelectedDate;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("ERROR DE SELECCION \n \n NO ES POSIBLE DETERMINAR LAS FECHAS", "Dexcom Tools", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
  

            if (!Directory.Exists(Globals.PATH_PRT + Globals.WEEK_YEAR_FORMAT)) 
            {
                MessageBoxResult result = MessageBox.Show("SE EJECUTARA LA TAREA DE COPIADO PARA PRT \n \n"+
                                                          "ESTAS DE ACUERDO?","Dexcom Tools", MessageBoxButton.OKCancel, MessageBoxImage.Question);

                if (result == MessageBoxResult.OK)
                {
                    StaticFunctions.TaskCopyingPRT();

                    ChromeOptions options = new ChromeOptions();
                    //options.AddArgument("headless");
                    //options.AddArgument("no-sandbox");
                    //_driver = new ChromeDriver(options);
                    _driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromSeconds(250));

                    _driver.Manage().Window.Maximize();
                    _driver.Url = "http://mxchim0svn08/TestPerformance/TETestPerformanceWeb.aspx";

                    //Click on AOI Efficiency
                    _driver.FindElement(By.Id("btnAOI")).Click();

                    //Select Customer
                    _driver.FindElement(By.Id("ContentPlaceHolder1_ddlWorkCell")).SendKeys("DEXCOM");

                    //Disable Automatic Current Day
                    _driver.FindElement(By.Id("ContentPlaceHolder1_chkAutomaticToday")).Click();

                    foreach (string _Platform in Globals.PLATFORMS)
                    {
                        Globals.CURRENT_PLATFORM = _Platform;
                        GetInformationFromTP(Globals.CURRENT_PLATFORM);
                    }
                    Thread.Sleep(5000);
                    _driver.Close();
                }              
            }
            else 
            {
                MessageBox.Show("LA TAREA NO SE EJECUTARA, YA EXISTE EL FOLDER \n \n" +
                                Globals.PATH_PRT + Globals.WEEK_YEAR_FORMAT, "DEXCOM TOOLS", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void WaitNSeconds(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                DoEvents();
            }
        }

        public static void DoEvents()
        {
            Application.Current.Dispatcher.Invoke(DispatcherPriority.Background,
                                                  new Action(delegate { }));
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            if (Globals.DOCK_MENU)
            {
                Thickness _temp = Grid_1.Margin;
                _temp.Left = 160f;
                Grid_1.Margin = _temp;
                btnOpenPRT.Visibility = Visibility.Visible;

                Globals.DOCK_MENU = false;
                DockMenu.Width = 160;
                return;
            }

            if (!Globals.DOCK_MENU)
            {
                Thickness _temp = Grid_1.Margin;
                _temp.Left = 0f;
                Grid_1.Margin = _temp;
                btnOpenPRT.Visibility = Visibility.Hidden;

                Globals.DOCK_MENU = true;
                DockMenu.Width = 0;
                return;
            }
        }

        private void btnOpenPRT_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"\\mxchim0nasfs01\Healthcare\DEXCOM\Test Engineering\PTE_Javier Marquez\5.-Metricos\PRT\";        
            
            if(openFileDialog.ShowDialog() == true) Process.Start(openFileDialog.FileName);

            btnMenu_Click(sender, e);
        }

        private void DPickerStart_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime _StartDate = (DateTime)DPickerStart.SelectedDate;
            CultureInfo cul = CultureInfo.CurrentCulture;          
            Globals.SELECTED_WEEK = cul.Calendar.GetWeekOfYear(_StartDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday);

            lblWeekNumber.Content = "Current Week Number: " + Globals.SELECTED_WEEK;
        }

        private void txtSN_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter) 
            {
                string TXSN = new GetTXSNdll.getTXSN().TXSNtoSN(txtSN.Text);               
            }
        }
    }
}
