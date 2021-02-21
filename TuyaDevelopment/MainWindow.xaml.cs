using System;
using System.Windows;
using System.Windows.Threading;
using static TuyaDevelopment.DeviceInfoProp;

namespace TuyaDevelopment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

            Hide();

            contextMenu1 = new System.Windows.Forms.ContextMenu();
            menuItem3 = new System.Windows.Forms.MenuItem();
            contextMenu1.MenuItems.AddRange(
                new System.Windows.Forms.MenuItem[] { menuItem3 });

            

            menuItem3.Index = 2;
            menuItem3.Text = "Exit";
            menuItem3.Click += new System.EventHandler(this.menuItem2_Click);

            m_notifyIcon = new System.Windows.Forms.NotifyIcon();
            m_notifyIcon.BalloonTipText = "Your Message";
            m_notifyIcon.BalloonTipTitle = "Your Title";
            m_notifyIcon.Text = "The Sensor";
            m_notifyIcon.Icon = new System.Drawing.Icon(AppDomain.CurrentDomain.BaseDirectory + "\\Images\\bulb_off.ico");
            m_notifyIcon.ContextMenu = contextMenu1;


            if (m_notifyIcon != null)
                m_notifyIcon.Visible = true;

            m_notifyIcon.ShowBalloonTip(1000);
            

            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0,0,1000);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
           
           bool state = CheckLastState(DeviceInfoProp.device_id_sensor);
          // Console.WriteLine(state);
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            m_notifyIcon.Dispose();
            m_notifyIcon = null;

            Window.GetWindow(this).Close();
        }

    }
}
