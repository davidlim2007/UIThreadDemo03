using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIThreadDemo03
{
    public partial class Form1 : Form
    {
        private Thread m_ui_thread;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateUIThread_Click(object sender, EventArgs e)
        {
            // The following button handler will initiate a new thread
            // with UIThread() being the entry point method.
            m_ui_thread = new Thread(new ThreadStart(UIThread));
            m_ui_thread.Start();
        }

        // UIThread() is the entry point method for a thread.
        private void UIThread()
        {
            try
            {
                // Note that inside the try block, Application.Run()
                // is called with a new instance of Form2.
                // This will start a message loop for the current thread
                // and will set a new instance of Form2 as the main form
                // of the thread.
                // Application.Run() will not return until the instance
                // of Form2 is closed.
                Application.Run(new Form2());
            }
            catch (ThreadAbortException taex)
            {
                // If Thread.Abort() is called on this thread,
                // A ThreadAbortException exception will be
                // thrown inside this thread.
                MessageBox.Show(taex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Exiting thread.");
            }
        }

        private void btnAbortThread_Click(object sender, EventArgs e)
        {
            if (m_ui_thread != null && m_ui_thread.IsAlive == true)
            {
                m_ui_thread.Abort();
            }
        }
    }
}
