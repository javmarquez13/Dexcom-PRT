using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dexcom_PRT
{
    class Globals
    {
        public static string PRT_FILE_NAME
        {
            get
            {
                return "4Q PRT Dexcom";
            }
        }


        public static string PATH_PRT
        {
            get
            {
                return @" \\mxchim0nasfs01\Healthcare\DEXCOM\Test Engineering\PTE_Javier Marquez\5.-Metricos\PRT\";
            }
        }



        public static string WEEK_YEAR_FORMAT
        {
            get
            {
                return "w" + Globals.SELECTED_WEEK + "y" + Globals.CURRENT_YEAR_NUM.Substring(2);
            }
        }


        private static int _SelectedWeek;
        public static int SELECTED_WEEK
        {
            get
            {
                //CultureInfo cul = CultureInfo.CurrentCulture;
                //return cul.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday) -1;
                return _SelectedWeek;
            }
            set
            {
                _SelectedWeek = value;
            }



        }


        public static int CURRENT_WEEK_NUM
        {
            get
            {
                CultureInfo cul = CultureInfo.CurrentCulture;
                return cul.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            }
        }

        public static string CURRENT_YEAR_NUM
        {
            get
            {
                CultureInfo cul = CultureInfo.CurrentCulture;
                return cul.Calendar.GetYear(DateTime.Now).ToString();
            }
        }





        public static string[] PLATFORMS
        {
            get
            {
                return new string[] { "AOI", "AXI", "AVI", "FVT" };
            }
        }

        private static string _LastPlatform;
        public static string LAST_PLATFORM
        {
            get
            {
                return _LastPlatform;
            }
            set
            {
                _LastPlatform = value;
            }
        }


        private static string _CurrentPlatform;
        public static string CURRENT_PLATFORM
        {
            get
            {
                return _CurrentPlatform;
            }
            set
            {
                _CurrentPlatform = value;
            }
        }


        private static string _TotalFailReal;
        public static string TOTAL_FAIL_REAL
        {
            get
            {
                return _TotalFailReal;
            }
            set
            {
                _TotalFailReal = value;
            }
        }

        private static string _TotalPzasFalseCall;
        public static string TOTAL_PZAS_FALSE_CALL
        {
            get
            {
                return _TotalPzasFalseCall;
            }
            set
            {
                _TotalPzasFalseCall = value;
            }
        }

        private static string _TotalNoConfirmed;
        public static string TOTAL_NO_CONFIRMED
        {
            get
            {
                return _TotalNoConfirmed;
            }
            set
            {
                _TotalNoConfirmed = value;
            }
        }

        private static string _TotalPassReal;
        public static string TOTAL_PASS_REAL
        {
            get
            {
                return _TotalPassReal;
            }
            set
            {
                _TotalPassReal = value;
            }
        }

        private static int _Total;
        public static int TOTAL
        {
            get
            {
                return Convert.ToInt32(TOTAL_FAIL_REAL) + Convert.ToInt32(TOTAL_PZAS_FALSE_CALL) + Convert.ToInt32(TOTAL_NO_CONFIRMED) + Convert.ToInt32(TOTAL_PASS_REAL); ;
            }
        }

        public static string CONFIG_FILE
        {
            get
            {
                return "4Q PRT Dexcom";
            }
        }



        private static bool _DOCK_MENU = true;
        public static bool DOCK_MENU
        {
            get
            {
                return _DOCK_MENU;
            }
            set
            {
                _DOCK_MENU = value;
            }
        }

    }
}
