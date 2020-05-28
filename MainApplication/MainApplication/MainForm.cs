using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace MainApplication
{
    public partial class MainForm : Form
    {
        //lets load our plugin - FOR FELLOW DEVELOPERS KINDLY CHANGE THE PLUGIN PATH
        Assembly plugin = Assembly.LoadFile(@"D:\Projects\C#\YT\SolveEverything.exe\005 - Basic Plugin Form\Plugin\Plugin\bin\Release\Plugin.dll");

        public MainForm()
        {
            InitializeComponent();
        }

        //open the forms based on text of menu strip
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //set the name of form based on text of menu
            String formName = e.ClickedItem.Text + "Form";


            if (formName == "PluginForm")
            {
                //lets open the plugin form

                //use foreach if you have multiple form on plugin
                //foreach (Type type in plugin.GetExportedTypes())
                //{ 
                    
                //}

                //since i used only one form on plugin i can used it straight forward
                Form form = Activator.CreateInstance(plugin.GetExportedTypes()[0]) as Form;

                form.MdiParent = this;
                form.Show();
                form.Location = new Point(0, 0);

                //lets test
            }
            else
            {
                //checked if form is opened
                bool Opened = Application.OpenForms[formName] != null;

                //open the form if no instance found
                if (!Opened)
                {
                    Form form = Activator.CreateInstance(Type.GetType("MainApplication." + formName)) as Form;

                    form.MdiParent = this;
                    form.Show();
                    form.Location = new Point(0, 0);
                }
            }
        }
        //lets test
    }
}
