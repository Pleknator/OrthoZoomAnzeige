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
        private ListViewColumnSorter lvwColumnSorter;

        public Form1()
        {
            InitializeComponent();
            textBoxPfad.Text = @"D:\X-Plane Dinge\Tools\Ortho4XP\Tiles";
            lvwColumnSorter = new ListViewColumnSorter();
            this.listViewKacheln.ListViewItemSorter = lvwColumnSorter;
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
                        item.SubItems.Add(verzeichnisGroesse(dir));
                        listViewKacheln.Items.Add(item);
                        break;
                    }
                }
                file.Close();
            }
        }

        string verzeichnisGroesse(string pfad)
        {
            string[] dateien = Directory.GetFiles(pfad, "*.*", SearchOption.AllDirectories);
            long bytes = 0;
            foreach (string name in dateien)
            {
                FileInfo info = new FileInfo(name);
                bytes += info.Length;
            }
            bytes = (bytes / 1024) / 1024;
            return bytes.ToString();
        }

        //sortierung: https://support.microsoft.com/de-de/help/319401/how-to-sort-a-listview-control-by-a-column-in-visual-c
        private void listViewKacheln_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listViewKacheln.Sort();
        }
    }
}
