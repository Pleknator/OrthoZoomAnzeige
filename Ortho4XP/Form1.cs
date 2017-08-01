using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ortho4XP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxPfad.Text = @"D:\X-Plane Dinge\Tools\Ortho4XP\Tiles";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zeile1 = "# Tile specific";
            string zeile2 = "default_website='";
            string zeile3 = "default_zl=";
            
            listViewKacheln.Items.Clear();
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(textBoxPfad.Text));
                
            foreach (var dir in dirs)
            {
                ListViewItem item = new ListViewItem();
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(dir + @"\Ortho4XP.cfg");
                while ((line = file.ReadLine()) != null)
                {
                        
                    if (line.Contains(zeile1))
                    {
                        item.Text = line.Substring(30);
                    }
                    else if (line.Contains(zeile2))
                    {
                        item.SubItems.Add(line.Substring(16));
                    }
                    else if (line.Contains(zeile3))
                    {
                        item.SubItems.Add(line.Substring(11));
                    }
                    else
                    {
                        listViewKacheln.Items.Add(item);
                        break;
                    }
                }
                file.Close();
            }          
        }
    }
}
