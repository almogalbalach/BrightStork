using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace TaskManager
{
    public partial class Form1 : Form
    {
       public Process m_Process = null;
       private WindowsFormsSynchronizationContext m_GuiThread = null; // this is in order to switch beetwen threads
       private Thread m_RefreshThread = null; /// in order to close the thread when the application exit's
       private bool _StopRefreshThread = false; // so refreshh until application exits could run 
       private Process[] m_process = Process.GetProcesses();
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            refreshTaskList();
            if (m_GuiThread == null)
            {
                m_GuiThread = new WindowsFormsSynchronizationContext(); //rembers that the gui thread is this because we init it from the c'tor            
            }
            m_RefreshThread = new Thread(RefreshTaskListThread);//so the thread now which function to activeted once he stratredd
            m_RefreshThread.Start();   
        }


        private void refreshTaskList()
        {
            Process maximumProcess = FindMaximumProcessMemorySize();
            listboxTasks.Items.Clear();
            foreach (Process process in Process.GetProcesses())
            {
               // process.OutputDataReceived += process_OutputDataReceived;
                listboxTasks.Items.Add(process.ProcessName + " | " + process.Id + " | " + process.PrivateMemorySize64 / 1000 + " kB");
            }
            labelTopTask.Text = maximumProcess.ProcessName + "\n" + maximumProcess.PrivateMemorySize64 / 1000 + " kb";
            labelTaskPeakNumber.Text = (maximumProcess.PeakPagedMemorySize64 / 1000).ToString() + " kb";
            labelAllocatedMemoryNumber.Text = (maximumProcess.WorkingSet64 / 1000).ToString() + " kb";   

        }

        //void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        //{
        //    //u can try play with delegate  \ threds \ i gave u the tools

        //    if (sender is Process)
        //    {
        //        //write your code here
        //        //let checks if it works

        //    }
        //}
        public void RefreshTaskListThread() // fuck lol :)
        {
            while(!_StopRefreshThread) // one of many methods to syncronize beetwen threads , reminder thread is "fire and forrget" opretion  async - task!
            {
                if (listboxTasks.Items.Count != 0)
                {
                    m_GuiThread.Send((object sender1) =>
                        {
                            //sec, lets close visual and restrust?
                            // almog always preform null and 0 checks if when u dont need , prevent bugs תודה
                            Process maximumProcess = FindMaximumProcessMemorySize();
                            listboxTasks.Items.Clear();
                            foreach (Process process in Process.GetProcesses())
                            {
                                listboxTasks.Items.Add(process.ProcessName + " | " + process.Id + " | " + process.PrivateMemorySize64 / 1000 + " kB");
                             //   process.OutputDataReceived!!!//you seee? nice!
                                    //so this is the processes listhener? yes its called an event e.g when outdatarecived it tells everyone look what you can do for example
                            }
                            labelTopTask.Text = maximumProcess.ProcessName + "\n" + maximumProcess.PrivateMemorySize64 / 1000 + " kb";
                            labelTaskPeakNumber.Text = (maximumProcess.PeakPagedMemorySize64 / 1000).ToString() + " kb";
                            labelAllocatedMemoryNumber.Text = (maximumProcess.WorkingSet64 / 1000).ToString() + " kb";
                            
                        }, null); //this is method to swtich beetwen Current thread  to gui thread //basacily thread not built to switch but thisthe best workaround 
                    //using lambda expresions
                    Thread.Sleep(5000);
                    //bravo! is there a way to stop the flickring?
                    //at the windows task manager - its refreshing without flickers or list reload.
                    //asking from ceriosity, i gussing there orking in diffrent , you should worl with better controler than this, sometimes changiing the control is less expensive, i guessing that each proccer have a delegate(listner) to man it's change and each procces uptades by his owen ! lets check!
                }
                else
                {
                    Thread.Sleep(1000); // sleep here is good desgin because it's PART of the algorthinm
                }
            }
        }

        public void killTask(string[] i_ArrayOfTasks, string i_StringTask, int i_TaskId)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName == i_StringTask && process.Id == i_TaskId)
                {
                    try
                    {
                        process.Kill();
                        MessageBox.Show(process.ProcessName + " terminated.\n" + "Memory cleared: " + (process.PrivateMemorySize64 / 1000).ToString() + " kb", "Bright Stork");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Bright Stork");
                    }
                }
            }

            refreshTaskList();
        }

        private void buttonEndTask_Click(object sender, EventArgs e)
        {
           string[] arrayOfTasks = listboxTasks.SelectedItem.ToString().Split('|');
           string stringTask = arrayOfTasks[0].Trim();
           int taskId = Convert.ToInt32(arrayOfTasks[1]);
           MessageBox.Show(stringTask);
           killTask(arrayOfTasks, stringTask, taskId);
        }
    
    public Process FindMaximumProcessMemorySize()
    {    
        long maximumMemory = 0;
        Process maximumProcess = null;

        foreach(Process process in Process.GetProcesses())
        { 
            if (process.PrivateMemorySize64 > maximumMemory)
            {
                maximumMemory = process.PrivateMemorySize64;
                maximumProcess = process;
            }
        }

        return maximumProcess;
    }

        

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        // if you have thread in you programs YOU MUST AND I REPEAT YOU MUST! TO CLOSE AND STOP ALL running thread!
        //sometimes . and sometimes it will cause your application to cruch  + it the right wait to program , not closing all thread is bad programing practice!>
        //and why doing a special function and not inside destructor?
        // u can not call disrctur and you never know when the called + it not a function its an event it listen  to the application , got it!!
        // ok code 
        if (!_StopRefreshThread)
        {
            _StopRefreshThread = true;
            m_RefreshThread.Join(); //join method  let there be  2 thread A and B if B called join  method thread A waits! for thread b to finish and than cont. this is sync opretion!
        }
    }
  }
}
