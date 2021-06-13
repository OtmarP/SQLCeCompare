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

namespace SQLCe
{
    public partial class Form1 : Form
    {
        int _index1 = -1;
        int _index2 = -1;
        bool _doNotBackSynch = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ################################### History, letzter oben
            // Fr.25.09.2020 19:22:29 -op- v:20200925.1929 mit ***DEBUG*** im Title
            // Mo.09.03.2020 10:35:41 -op- Umstellung auf .NET FW 4.7.1 / Any CPU (war 4.7.2)
            // Fr.06.03.2020 10:08:56 -op- v:20200306.1618 OpenFileDialog, Detail mit Diff-HighLight, SwapFiles
            //                             SQLCe-Info (Version, FileSize, ...), Dump To File
            //                             DumpSchema (Table, Col, Index)
            //                             Sync Listbox
            // Di.03.03.2020 13:58:46 -op- mit WaitCursor, Data Source='xx' zusammenbauen,
            //                             nur ungleiche anzeigen
            // Mo.30.12.2019 Init Git (KaJourWin)
            // ??? Cr. (.NET FW 4.7.2 / Any CPU)
            // ###################################
            this.Top = 50;
            this.Left = 50;

            this.Text = "SQLCe-Tool v:20200925.1929";
#if DEBUG
            this.Text += "   ***DEBUG***";
#endif
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainerMain.Dock = DockStyle.Fill;
            this.listBox1.Dock = DockStyle.Fill;
            this.listBox2.Dock = DockStyle.Fill;
            this.splitContainer2.Dock = DockStyle.Fill;
            this.splitContainer2.SplitterDistance = this.splitContainer2.Height / 2;
            this.richTextBoxDetail1.Dock = DockStyle.Fill;
            this.richTextBoxDetail2.Dock = DockStyle.Fill;

            this.toolStripStatusLabel1.Text = "";

            this.checkBoxOnlyDif.Checked = true;

            //C:\Users\SFP8X01\Documents\Visual Studio 2017\Projects\WindowsFormsApp2\WindowsFormsApp2\DATA\KAJOUR4.sdf
            this.textBoxSQLCePath1.Text = @"C:\Users\SFP8X01\Documents\Visual Studio 2017\Projects\WindowsFormsApp2\WindowsFormsApp2\DATA\KAJOUR4.sdf";
            this.textBoxSQLCePath2.Text = @"C:\Users\SFP8X01\Documents\Visual Studio 2017\Projects\WindowsFormsApp2\WindowsFormsApp2\DATA\KAJOUR4.sdf";
            //                                            C:\DevOP\otmarp.visualstudio.com\Samples\WindowsFormsApp2\WindowsFormsApp2\DATA\KAJOUR4.sdf

#if DEBUG
            this.textBoxSQLCePath1.Text = @"C:\temp\TestDATA\C1\KAJOUR4.sdf";
            this.textBoxSQLCePath2.Text = @"C:\temp\TestDATA\KAJOUR4.sdf";

            this.textBoxSQLCePath1.Text = @"C:\temp\TestDATA\C\KAJOUR4.sdf";
            this.textBoxSQLCePath2.Text = @"C:\temp\TestDATA\D\KAJOUR4.sdf";

            //this.textBoxSQLCePath1.Text = @"C:\DevOP\otmarp.visualstudio.com\KaJourWin\KaJour\DB\Empty.sdf";
            //this.textBoxSQLCePath2.Text = @"C:\DevOP\otmarp.visualstudio.com\KaJourWin\KaJour\DB\Empty2.sdf";

            if (Environment.MachineName== "OPMEDION14B")
            {
                // OPMEDION14B
                this.textBoxSQLCePath1.Text = @"C:\temp\KaJour\KAJOUR4.sdf";
                this.textBoxSQLCePath2.Text = @"C:\temp\KaJour\TestDATA\KAJOUR4.sdf";
            }
#else
            // KaJour
            this.textBoxSQLCePath1.Text = @"C:\DATA\OPDOM\K\AProd\KJourWin\DATA\KAJOUR4.sdf";
            this.textBoxSQLCePath2.Text = @"D:\OpToshiba12b\DATA\OPDOM\K\AProd\KJourWin\DATA\KAJOUR4.sdf";
#endif

            // <package id="Microsoft.SqlServer.Compact" version="4.0.8876.1" targetFramework="net472" />
            //Microsoft.SqlServer.com
            //System.Data.SqlServerCe
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Exit
            this.Close();
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            // Compare
            this.SetUI(false, "Compare...", Cursors.WaitCursor);

            //"Data Source = MyDatabase.sdf; Password ='<pwd>'"
            string cs1 = "Data Source='" + this.textBoxSQLCePath1.Text+ "'";
            string cs2 = "Data Source='" + this.textBoxSQLCePath2.Text+ "'";

            if (cs1 != cs2)
            {
                this.SQLCeCompare(cs1, cs2);
            }
            else {
                MessageBox.Show("SQLCe1 = SQLCe2");
            }

            this.SetUI(true, "fertig.", Cursors.Default);
        }

        private void buttonDumpData_Click(object sender, EventArgs e)
        {
            this.SetUI(false, "DumpData...", Cursors.WaitCursor);

            //"Data Source = MyDatabase.sdf; Password ='<pwd>'"
            string cs1 = "Data Source='" + this.textBoxSQLCePath1.Text + "'";
            string cs2 = "Data Source='" + this.textBoxSQLCePath2.Text + "'";

            if (cs1 != cs2)
            {
                this.SQLCeDumpData(cs1, cs2);
            }
            else
            {
                MessageBox.Show("SQLCe1 = SQLCe2");
            }

            this.SetUI(true, "fertig.", Cursors.Default);
        }

        private void buttonDumpSchema_Click(object sender, EventArgs e)
        {
            this.SetUI(false, "DumpSchema...", Cursors.WaitCursor);

            //"Data Source = MyDatabase.sdf; Password ='<pwd>'"
            string cs1 = "Data Source='" + this.textBoxSQLCePath1.Text + "'";
            string cs2 = "Data Source='" + this.textBoxSQLCePath2.Text + "'";

            if (cs1 != cs2)
            {
                this.SQLCeDumpSchema(cs1, cs2);
            }
            else
            {
                MessageBox.Show("SQLCe1 = SQLCe2");
            }

            this.SetUI(true, "fertig.", Cursors.Default);
        }

        private void buttonOpen1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = this.textBoxSQLCePath1.Text;
            openFileDialog.Filter = "SQLCe (*.sdf)|*.sdf|Alle Dateien (*.*)|*.*";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                this.textBoxSQLCePath1.Text = openFileDialog.FileName;
            }
        }

        private void buttonOpen2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = this.textBoxSQLCePath2.Text;
            openFileDialog.Filter = "SQLCe (*.sdf)|*.sdf|Alle Dateien (*.*)|*.*";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.textBoxSQLCePath2.Text = openFileDialog.FileName;
            }
        }

        private void buttonSwapFiles_Click(object sender, EventArgs e)
        {
            string swap1 = this.textBoxSQLCePath1.Text;
            string swap2 = this.textBoxSQLCePath2.Text;

            this.textBoxSQLCePath1.Text = swap2;
            this.textBoxSQLCePath2.Text = swap1;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            //this.richTextBoxDetail1.Text = "";
            //this.richTextBoxDetail1.Text = this.listBox1.SelectedItem.ToString();

            //RTBHighLight();
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            //this.richTextBoxDetail2.Text = "";
            //this.richTextBoxDetail2.Text = this.listBox2.SelectedItem.ToString();

            //RTBHighLight();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.checkBoxSync.Checked) {
                if (!_doNotBackSynch) {
                    if (_index1 != -1)
                    {
                        int offset = listBox1.SelectedIndex - _index1;
                        _doNotBackSynch = true;
                        if (offset == 1)
                        {
                            if (listBox2.SelectedIndex >= 0)
                            {
                                try
                                {
                                    listBox2.SelectedIndex = listBox2.SelectedIndex + 1;
                                }
                                catch (Exception)
                                {
                                }
                            }
                        }
                        if (offset == -1)
                        {
                            try
                            {
                                listBox2.SelectedIndex = listBox2.SelectedIndex - 1;
                            }
                            catch (Exception)
                            {
                            }
                        }
                        _doNotBackSynch = false;
                    }
                }
            }
            _index1 = listBox1.SelectedIndex;

            this.richTextBoxDetail1.Text = "";
            this.richTextBoxDetail1.Text = this.listBox1.SelectedItem.ToString();

            RTBHighLight();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.checkBoxSync.Checked)
            {
                if (!_doNotBackSynch) {
                    if (_index2 != -1)
                    {
                        int offset = listBox2.SelectedIndex - _index2;
                        _doNotBackSynch = true;
                        if (offset == 1)
                        {
                            if (listBox1.SelectedIndex >= 0)
                            {
                                try
                                {
                                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                                }
                                catch (Exception)
                                {
                                }
                            }
                        }
                        if (offset == -1)
                        {
                            if (listBox1.SelectedIndex >= 0)
                            {
                                try
                                {
                                    listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
                                }
                                catch (Exception)
                                {
                                }
                            }
                        }
                        _doNotBackSynch = false;
                    }
                }
            }
            _index2 = listBox2.SelectedIndex;

            this.richTextBoxDetail2.Text = "";
            this.richTextBoxDetail2.Text = this.listBox2.SelectedItem.ToString();

            RTBHighLight();
        }

        // ##################################################
        // Functions
        // ##################################################

        private void SetUI(bool enabled,string label, Cursor cursor) {
            this.buttonExit.Enabled = enabled;

            this.buttonCompare.Enabled = enabled;
            this.buttonDumpData.Enabled = enabled;
            this.buttonDumpSchema.Enabled = enabled;
            this.buttonSwapFiles.Enabled = enabled;

            this.checkBoxDumpToFile.Enabled = enabled;
            this.checkBoxOnlyDif.Enabled = enabled;
            this.checkBoxDispInfo.Enabled = enabled;

            this.textBoxSQLCePath1.Enabled = enabled;
            this.textBoxSQLCePath2.Enabled = enabled;
            this.buttonOpen1.Enabled = enabled;
            this.buttonOpen2.Enabled = enabled;

            this.SetStatusLabel(label);

            this.Cursor = cursor;

            Application.DoEvents();
        }

        private void RTBHighLight() {
            // Clear
            richTextBoxDetail1.SelectAll();
            //richTextBoxDetail1.SelectionColor = Color.Black;
            richTextBoxDetail1.SelectionBackColor = Color.White;
            richTextBoxDetail1.SelectionLength = 0;

            richTextBoxDetail2.SelectAll();
            //richTextBoxDetail2.SelectionColor = Color.Black;
            richTextBoxDetail2.SelectionBackColor = Color.White;
            richTextBoxDetail2.SelectionLength = 0;

            bool doHighLight = true;
            if (richTextBoxDetail1.Text.Length == 0) { doHighLight = false; }
            if (richTextBoxDetail2.Text.Length == 0) { doHighLight = false; }
            if (doHighLight) {
                int length = (richTextBoxDetail1.Text.Length > richTextBoxDetail2.Text.Length) ? richTextBoxDetail2.Text.Length : richTextBoxDetail1.Text.Length;
                for (int i = 0; i < length; i++)
                {
                    if (richTextBoxDetail1.Text[i] != richTextBoxDetail2.Text[i])
                    {
                        /* and then start your highlight selection here, 
                        this is where some difference between the two rich 
                        text boxes begins */

                        Color backColor = System.Drawing.Color.LightGreen;

                        richTextBoxDetail1.Select(i, 1);
                        //richTextBoxDetail1.SelectionColor = System.Drawing.Color.Yellow;
                        richTextBoxDetail1.SelectionBackColor = backColor;

                        richTextBoxDetail2.Select(i, 1);
                        //richTextBoxDetail2.SelectionColor = System.Drawing.Color.Yellow;
                        richTextBoxDetail2.SelectionBackColor = backColor;
                    }
                }
            }
        }

        private void SQLCeCompare(string SQLCeCS1, string SQLCeCS2)
        {
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();

            this.richTextBoxDetail1.Text = "";
            this.richTextBoxDetail2.Text = "";

            var list1 = this.SQLCeListTablesWithRec("SQLCe1", SQLCeCS1);
            var list2 = this.SQLCeListTablesWithRec("SQLCe2", SQLCeCS2);

            if (this.checkBoxOnlyDif.Checked)
            {
                this.RemoveFromList(list1, list2);
            }
            else {
                // do nothing
            }

            foreach (var item in list1)
            {
                this.listBox1.Items.Add(item);
            }
            foreach (var item in list2)
            {
                this.listBox2.Items.Add(item);
            }
        }

        private void RemoveFromList(List<string> list1, List<string> list2) {
            List<string> removeList1 = new List<string>();
            foreach (var item1 in list1)
            {
                // search in list2
                foreach (var searchItem2 in list2)
                {
                    if (item1 == searchItem2)
                    {
                        list2.Remove(searchItem2);
                        removeList1.Add(item1);
                        //list1.Remove(item1);
                        break;  // =====================>
                    }
                }
            }
            foreach (var item in removeList1)
            {
                list1.Remove(item);
            }

            List<string> removeList2 = new List<string>();
            foreach (var item2 in list2)
            {
                // search in list1
                foreach (var searchItem1 in list1)
                {
                    if (item2 == searchItem1)
                    {
                        list1.Remove(searchItem1);
                        removeList2.Add(item2);
                        //list2.Remove(item2);
                        break;  // =====================>
                    }
                }
            }
            foreach (var item in removeList2)
            {
                list2.Remove(item);
            }
        }

        private List<string> SQLCeListTablesWithRec(string info, string SQLCeCS)
        {
            List<string> list = new List<string>();

            try
            {
                SQLCe sQLCe = new SQLCe();
                sQLCe.Connect(SQLCeCS);

                if (this.checkBoxDispInfo.Checked){
                    var infos = sQLCe.GetInfos(info);
                    foreach (var info1 in infos)
                    {
                        list.Add(info1);
                    }
                }

                var tables = sQLCe.GetTables();
                foreach (var table in tables)
                {
                    this.SetStatusLabel(info + " " + table);
                    var recCount = sQLCe.GetRecCount(table);

                    list.Add(table + "    " + recCount.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            this.SetStatusLabel(info + " fertig.");

            return list;
        }

        private void SQLCeDumpData(string SQLCeCS1, string SQLCeCS2)
        {
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();

            this.richTextBoxDetail1.Text = "";
            this.richTextBoxDetail2.Text = "";

            var list1 = this.SQLCeDumpDataToList("SQLCe1", SQLCeCS1);
            var list2 = this.SQLCeDumpDataToList("SQLCe2", SQLCeCS2);

            if (this.checkBoxOnlyDif.Checked)
            {
                this.RemoveFromList(list1, list2);
            }
            else
            {
                // do nothing
            }

            foreach (var item in list1)
            {
                this.listBox1.Items.Add(item);
            }
            foreach (var item in list2)
            {
                this.listBox2.Items.Add(item);
            }

            // md c:\temp
            try
            {
                System.IO.Directory.CreateDirectory("c:\temp");
            }
            catch (Exception)
            {
            }
            // write to File
            if (this.checkBoxDumpToFile.Checked) {
                string filename1 = @"c:\temp\SQLCeDumpData1.txt";
                using (TextWriter tw = new StreamWriter(filename1))
                {
                    foreach (String s in list1)
                        tw.WriteLine(s);
                }

                string filename2 = @"c:\temp\SQLCeDumpData2.txt";
                using (TextWriter tw = new StreamWriter(filename2))
                {
                    foreach (String s in list2)
                        tw.WriteLine(s);
                }
            }
        }

        private void SQLCeDumpSchema(string SQLCeCS1, string SQLCeCS2){
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();

            this.richTextBoxDetail1.Text = "";
            this.richTextBoxDetail2.Text = "";

            var list1 = this.SQLCeDumpSchemaToList("SQLCe1", SQLCeCS1);
            var list2 = this.SQLCeDumpSchemaToList("SQLCe2", SQLCeCS2);

            if (this.checkBoxOnlyDif.Checked)
            {
                this.RemoveFromList(list1, list2);
            }
            else
            {
                // do nothing
            }

            foreach (var item in list1)
            {
                this.listBox1.Items.Add(item);
            }
            foreach (var item in list2)
            {
                this.listBox2.Items.Add(item);
            }

            // md c:\temp
            try
            {
                System.IO.Directory.CreateDirectory("c:\temp");
            }
            catch (Exception)
            {
            }
            // write to File
            if (this.checkBoxDumpToFile.Checked)
            {
                string filename1 = @"c:\temp\SQLCeDumpSchema1.txt";
                using (TextWriter tw = new StreamWriter(filename1))
                {
                    foreach (String s in list1)
                        tw.WriteLine(s);
                }

                string filename2 = @"c:\temp\SQLCeDumpSchema2.txt";
                using (TextWriter tw = new StreamWriter(filename2))
                {
                    foreach (String s in list2)
                        tw.WriteLine(s);
                }
            }
        }

        private List<string> SQLCeDumpDataToList(string info, string SQLCeCS)
        {
            List<string> list = new List<string>();

            try
            {
                SQLCe sQLCe = new SQLCe();
                sQLCe.Connect(SQLCeCS);

                if (this.checkBoxDispInfo.Checked)
                {
                    var infos = sQLCe.GetInfos(info);
                    foreach (var info1 in infos)
                    {
                        list.Add(info1);
                    }
                }

                var tables = sQLCe.GetTables();
                foreach (var table in tables)
                {
                    this.SetStatusLabel(info + " " + table);
                    var rowList = sQLCe.DumpData(table, "| ");

                    foreach (var row in rowList)
                    {
                        list.Add(table + "| " + row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            this.SetStatusLabel(info + " fertig.");

            return list;
        }

        private List<string> SQLCeDumpSchemaToList(string info, string SQLCeCS)
        {
            List<string> list = new List<string>();

            try
            {
                SQLCe sQLCe = new SQLCe();
                sQLCe.Connect(SQLCeCS);

                if (this.checkBoxDispInfo.Checked)
                {
                    var infos = sQLCe.GetInfos(info);
                    foreach (var info1 in infos)
                    {
                        list.Add(info1);
                    }
                }

                var schemas = sQLCe.GetSchemas();
                foreach (var table in schemas)
                {
                    this.SetStatusLabel(info + " " + table);
                    var rowList = sQLCe.DumpData(table, "| ");

                    foreach (var row in rowList)
                    {
                        list.Add(table + "| " + row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            this.SetStatusLabel(info + " fertig.");

            return list;
        }

        private void SetStatusLabel(string info)
        {
            this.toolStripStatusLabel1.Text = info;
            Application.DoEvents();
        }
    }
}
