using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Employees
{
    /// <summary>
    /// Interaction logic for CompDetails.xaml
    /// </summary>
    public partial class CompDetails : Page
    {
        public CompDetails()
        {
            InitializeComponent();
        }

        public CompDetails(Object data) : this()
        {
            this.DataContext = data;

            if (data is Employee)
            {
                Employee emp = (Employee)data;
                string nameStock = "";
                string valueStock= "";

                string nameReport = "";
                string valueReport = "";

                string nameDegree = "";
                string valueDegree = "";

                string nameNOSales = "";
                string valueNOSales = "";

                string nameShift = "";
                string valueShift = "";

                emp.GetSpareProp1(ref nameStock, ref valueStock);
                this.SpareProp1Name.Content = nameStock;
                this.SpareProp1Value.Content = valueStock;
                SpareProp1.Visibility = Visibility.Visible;


                emp.GetSpareProp2(ref nameReport, ref valueReport);
                this.SpareProp2Name.Content = nameReport;
                this.SpareProp2Value.Content = valueReport;
                SpareProp2.Visibility = Visibility.Visible;

                emp.GetSpareProp3(ref nameDegree, ref valueDegree);
                this.SpareProp3Name.Content = nameDegree;
                this.SpareProp3Value.Content = valueDegree;
                SpareProp3.Visibility = Visibility.Visible;


                emp.GetSpareProp4(ref nameNOSales, ref valueNOSales);
                this.SpareProp4Name.Content = nameNOSales;
                this.SpareProp4Value.Content = valueNOSales;
                SpareProp4.Visibility = Visibility.Visible;


                emp.GetSpareProp5(ref nameShift, ref valueShift);
                this.SpareProp5Name.Content = nameShift;
                this.SpareProp5Value.Content = valueShift;
                SpareProp5.Visibility = Visibility.Visible;
            }
        }
    }
}
