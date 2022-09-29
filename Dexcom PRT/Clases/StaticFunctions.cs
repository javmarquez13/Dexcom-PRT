using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Dexcom_PRT
{
    public class StaticFunctions
    {
  

        private static IWebDriver _driver;

        public static void QueryAOI(DateTime _StartDate, DateTime _EndDate)
        {       
            //Click on AOI Efficiency
            _driver.FindElement(By.Id("btnAOI")).Click();

            //Select Customer
            _driver.FindElement(By.Id("ContentPlaceHolder1_ddlWorkCell")).SendKeys("DEXCOM");

            //Disable Automatic Current Day
            _driver.FindElement(By.Id("ContentPlaceHolder1_chkAutomaticToday")).Click();

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

            Thread.Sleep(5000);
        }

        public static void QueryAXI(DateTime _StartDate, DateTime _EndDate) 
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

        public static void QueryAVI(DateTime _StartDate, DateTime _EndDate) 
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

        public static void QueryFVT(DateTime _StartDate, DateTime _EndDate) 
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
        }

        public static void TaskCopyingPRT() 
        {
            string _tempPath = Globals.PATH_PRT + "w" + Globals.SELECTED_WEEK + "y" + Globals.CURRENT_YEAR_NUM.Substring(2);

            if (!Directory.Exists(_tempPath)) 
            {
                Directory.CreateDirectory(_tempPath);

                int _FromLastWeek = Globals.SELECTED_WEEK - 1;
                DirectoryInfo _dirInfo = new DirectoryInfo(Globals.PATH_PRT + "w" + _FromLastWeek + "y" + Globals.CURRENT_YEAR_NUM.Substring(2));

                string _temp4QFile = _dirInfo.FullName + @"\" + Globals.PRT_FILE_NAME + " w" + _FromLastWeek + "y" + Globals.CURRENT_YEAR_NUM.Substring(2) + ".xlsm";

                if (File.Exists(_temp4QFile)) 
                {
                    string _tempNew4QFile = _tempPath + @"\" + Globals.PRT_FILE_NAME + " w" + Globals.SELECTED_WEEK + "y" + Globals.CURRENT_YEAR_NUM.Substring(2) + ".xlsm";

                    if (!File.Exists(_tempNew4QFile)) File.Copy(_temp4QFile, _tempNew4QFile, false);


                    string _tempWeeklyDexcomFolder = _tempPath + @"\Weekly Dexcom Meeting w" + Globals.SELECTED_WEEK + "y" + Globals.CURRENT_YEAR_NUM.Substring(2);
                    if (!Directory.Exists(_tempWeeklyDexcomFolder)) Directory.CreateDirectory(_tempWeeklyDexcomFolder);
                }
            } 
           
        }


    }
}
