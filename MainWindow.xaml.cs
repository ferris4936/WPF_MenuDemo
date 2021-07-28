using System.Collections.Generic;
using System.Windows;
  

namespace WPF_MenuDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Assignment> tempScores = new List<Assignment>();

        public MainWindow()
        {
            InitializeComponent();
            lbScores.ItemsSource = tempScores; 
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)  
        {
            //Instantiate a class object
            Student1 st = new Student1();

            //Set the values from our controls into the class
            st.FirstName = tbFirstName.Text;
            st.LastName = tbLastName.Text;
            st.StudentNumber = tbIDNum.Text;
            st.Major = tbMajor.Text;
            List<Assignment> scores = new List<Assignment>();

            
            st.Scores = scores;

            //Set the results from the class into a control on the form
            txbResults.Text = st.ToString();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Assignment assign = new Assignment();
            assign.Title = txbTitle.Text;
            assign.Score = int.Parse(txbScore.Text);
            tempScores.Add(assign);
            lbScores.Items.Refresh();
        }
    }
}
