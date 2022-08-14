using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace HospitalV1
{

    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            TitleBar.MouseLeftButtonDown += TitleBar_MouseLeftButtonDown;
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        /*private void DatabaseDigger(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\s.mohammadi\VSProjects\HospitalV1\HospitalV1\HospitalDatabase.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string commandString = "SELECT * FROM Patients";

                SqlCommand command = new SqlCommand(commandString, connection);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader.GetValue(0) + "," + dataReader.GetValue(1));
                }
            }
        }*/

        private void CloseApp(object sender, RoutedEventArgs e) {
            Close();
        }

        private void MinimizeApp(object sender, RoutedEventArgs e)
        {
            WindowStyle = WindowStyle.ThreeDBorderWindow;
            WindowState = WindowState.Minimized;
        }
        
        protected override void OnActivated(EventArgs e)
        {
            Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() => WindowStyle = WindowStyle.None));
        }
    }
}
