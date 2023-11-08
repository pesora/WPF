using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfStudy.Models;
using WpfStudy.Views;

namespace WpfStudy.ViewModels
{
    class MainViewModel:INotifyPropertyChanged
    {
        private int progressValue;
        public ICommand TestClick { get; set; }
        public ICommand SecondShow { get; set; }
        public ICommand SelectClick { get; set; }
        public ICommand InsertClick { get; set; }

        private List<USERINFO> myListUser = new List<USERINFO>();

        private string name;
        private int age;
        private string img;

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }


        public string Img
        {
            get { return img; }
            set 
            {
                img = value;
                NotifyPropertyChanged(nameof(Img));
            }
        }


        public int Age
        {
            get { return age; }
            set 
            { 
                age = value;
                NotifyPropertyChanged(nameof(Age));
            }
        }



        public List<USERINFO> MyListUser
        {
            get { return myListUser; }
            set { 
                myListUser = value;
                NotifyPropertyChanged(nameof(MyListUser));
            }
        }


        public MainViewModel()
        {
            //TestClick = new RelayCommand<object>(ExecuteMyButton, CanMyButton);
            TestClick = new AsyncRelayCommand(ExecuteMyButton2);
            SecondShow = new AsyncRelayCommand(ExecuteMyButton3);
            SelectClick = new AsyncRelayCommand(SelectDatabase);
            InsertClick = new AsyncRelayCommand(InsertDatabase);
            //Task t= ExecuteMyButton2();
        }

        public int ProgressValue
        {
            get { return progressValue; }
            set { 
                progressValue = value;
                NotifyPropertyChanged(nameof(ProgressValue));
            }
        }

        bool CanMyButton(object param)
        {
            if(param==null)
            {
                return true;
            }

            return param.ToString().Equals("ABC")? true: false;
        }


        void ExecuteMyButton(object param)
        {
            int w = 0;
            Task task1 = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    ProgressValue = i;
                }
            });

            Task rtn2 = Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    ProgressValue = i;
                    w = i;
                    Thread.Sleep(2000);
                }
            });

            //rtn2.Wait();
            MessageBox.Show(w+"");
        }

        public async Task ExecuteMyButton2()
        {
            int w = 0;

            Task<int> rtn2 = Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    ProgressValue = i;
                    w = i;
                    Thread.Sleep(2000);
                }
                int j = 5;
                return j;
            });

            w=await rtn2;

            MessageBox.Show(w + "");
        }
        public async Task ExecuteMyButton3()
        {
            SecondView secondView = new SecondView();
            SecondVIewModel aa = new SecondVIewModel();
            aa.ProgressValue = 70;
            secondView.DataContext = aa;

            secondView.ShowDialog();

            await Task.Delay(0);
        }
        public async Task SelectDatabase()
        {
            DataSet ds = new DataSet();
            List<USERINFO> listUserTemp = new List<USERINFO>();
            Exception exectpion = null;

            Task t = Task.Run(() =>
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionStr))
                    {

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                        sqlDataAdapter.SelectCommand = new SqlCommand("SELECT * FROM USERINFO;",sqlConnection);
                        sqlDataAdapter.Fill(ds);
                    }

                    if (ds.Tables.Count!=0)
                    {
                        DataTable dt = ds.Tables[0];

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            USERINFO userInfo = new USERINFO();
                            userInfo.USERNAME = dt.Rows[i]["USERNAME"].ToString();
                            userInfo.USERIMG = dt.Rows[i]["USERIMG"].ToString();
                            userInfo.USERAGE = Int32.Parse(dt.Rows[i]["USERAGE"].ToString());

                            listUserTemp.Add(userInfo);
                        }

                    }

                }
                catch (Exception ex)
                {
                    exectpion = ex;
                }
            });

            await t;

            if (exectpion!=null)
            {
                MessageBox.Show(exectpion.Message.ToString());
            }

            MyListUser = listUserTemp;
        }
        public async Task InsertDatabase()
        {

            DataSet ds = new DataSet();
            List<USERINFO> listUserTemp = new List<USERINFO>();
            Exception exectpion = null;

            Task t = Task.Run(() =>
            {

                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionStr))
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = sqlConnection.CreateCommand();
                        sqlCommand.CommandText = "UPDATE USERINFO SET USERAGE = "+ Age + " WHERE USERNAME = '"+Name+"';";
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    exectpion = ex;
                }
            });

            await t;

            if (exectpion != null)
            {
                MessageBox.Show(exectpion.Message.ToString());
            }

            await SelectDatabase();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        

    }
}
