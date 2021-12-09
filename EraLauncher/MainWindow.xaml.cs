﻿using System;
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
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace EraLauncher
{

    public partial class MainWindow : Window
    {
        //  public List<FV> Versions
        //{
        //     get; set;
        //}

        public string CurrentLauncherDetails = "Project Era | By danii";
        public MovieData CurrentVersion;
        public MainWindow()
        {
            InitializeComponent();

            this.LauncherInformation.Content = CurrentLauncherDetails;

            this.TvBox.ItemsSource = new MovieData[]
{
            new MovieData{Id=3.2F},
            new MovieData{Id=4.1F}
};
            if(CurrentVersion == null)
            {

            }
    //        CurrentVersion = new MovieData { Id = 5.1F};
    //        ExecuteVersionPure(CurrentVersion.Id);
        }

        // Start Versions code ---------------------------------------
        public void AddVersion()
        {
            this.TvBox.ItemsSource = new MovieData[]
            {
            new MovieData{Id=0}
            };
        }

        private void ExecuteVersion_Event(object sender, RoutedEventArgs e)
        {
            var Version = (Button)sender;
            string abc = Version.Content.ToString();
            float aID = float.Parse(abc);
            ExecuteVersionPure(aID);
        }

        private void ExecuteVersionPure(float ID)
        {
            string StringF = ID.ToString();
            string StringEF = StringF.Replace(",", ".");
            this.GameVersion.Content = StringEF;
        }

        // End versions code ---------------------------------------


        // Internal
        private void GridBG_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();

              
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddVersion();
        }

        private void Close_Button_Event(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minimalize_Button_Event(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
    public class MovieData
    {
        private float _Id;
        public float Id
        {
            get { return this._Id; }
            set { this._Id = value; }
        }



    }
}