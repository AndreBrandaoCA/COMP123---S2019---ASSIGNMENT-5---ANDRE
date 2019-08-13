using COMP123___S2019___ASSIGNMENT_5___ANDRE.Data;
using COMP123___S2019___ASSIGNMENT_5___ANDRE.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123___S2019___ASSIGNMENT_5___ANDRE
{
    public static class Program
    {
        public static Product product;

        public static SplashScreen splashScreen;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderInfoForm orderInfoForm;
        public static AboutForm aboutForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            splashScreen = new SplashScreen();
            startForm = new StartForm();
            selectForm = new SelectForm();
            product = new Product();
            productInfoForm = new ProductInfoForm();
            orderInfoForm = new OrderInfoForm();
            aboutForm = new AboutForm();
            Application.Run(splashScreen);
        }
    }
}
