using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlcOutputCsvAppLibrary;


namespace PlcOutputCsvApp.DeskApp
{
    public partial class MainForm : Form
    {
        IPlcTcp Plc;
        string SettingFile = $"{Application.StartupPath}\\Setting.ini";
        public MainForm()
        {
            InitializeComponent();

            UIControlInitial();

            Plc = new ModbusTcp();//change protocol change here
        }

        private void UIControlInitial()
        {
            MaskedTextBoxIp.ValidatingType = typeof(System.Net.IPAddress);

            if(File.Exists(SettingFile))
            {
                var myIni = new IniHelper(SettingFile);
                MaskedTextBoxIp.Text = myIni.Read("IpAddress", "Connection");
                textBoxPort.Text = myIni.Read("Port", "Connection");
            }

        }

        private void btnConnectionState_Click(object sender, EventArgs e)
        {
            try
            {
                if (Plc.IsConnected == false)
                {
                    SaveTcpSetting();
                    if (int.TryParse(textBoxPort.Text, out int port) == true)
                    {
                        Plc.Connected(MaskedTextBoxIp.Text, port);
                    }
                    else
                    {
                        MessageBox.Show("Check Port Number");
                    }
                }
                else
                {
                    Plc.Disconnect();
                }

                if(Plc.IsConnected == true)
                {
                    btnConnectionState.Text = "Is Connected!";
                }
                else
                {
                    btnConnectionState.Text = "Is Disconnected!";
                }
                

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
           
        }

        private void SaveTcpSetting()
        {
            var myIni = new IniHelper(SettingFile);
            myIni.Write("IpAddress", MaskedTextBoxIp.Text, "Connection");
            myIni.Write("Port", textBoxPort.Text, "Connection");
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Column","PlcAddress");
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = 130;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnRemoveColumn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count-1);
        }

        private void btnSaveGride_Click(object sender, EventArgs e)
        {
            SaveFile(ReadAllGrideData());
        }

        private string ReadAllGrideData()
        {
            string output = string.Empty;

            if(dataGridView1.Rows.Count<=1)
            {
                return output;
            }

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                string line = string.Empty;
                foreach(DataGridViewCell cell in row.Cells)
                {
                    line += $",{cell.Value}";
                }
                line = line.Remove(0,1);
                output += $"{line}{Environment.NewLine}";
            }

            return output;
        }

        private void LoadGride_Click(object sender, EventArgs e)
        {
            string contain = string.Empty;

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";

            ofd.FilterIndex = 1;

            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Columns.Clear();

                contain = File.ReadAllText(ofd.FileName);

                List<string> lines = contain.Split(new char[] {'\r','\n' },StringSplitOptions.RemoveEmptyEntries).ToList();

                if(lines.Count>0)
                {
                    int columnsCount = lines[0].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Count();
                    for(int i = 0; i < columnsCount; i++)
                    {
                        dataGridView1.Columns.Add("Column", "PlcAddress");
                    }
                }

                foreach(var line in lines)
                {
                    var linedata = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    dataGridView1.Rows.Add(linedata);
                }
            }

            
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            try
            {
                string addressContain = ReadAllGrideData();

                string csvContain = string.Empty;

                foreach(var line in addressContain.Split(new char[] {'\r','\n' },StringSplitOptions.RemoveEmptyEntries))
                {
                    string csvLine = string.Empty;
                    foreach(var data in line.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
                    {
                        int addressIndex = int.Parse(data);
                        csvLine += $",{Plc.ReadHoldingRegisters(addressIndex, 1).First()}";
                    }
                    csvLine = csvLine.Remove(0, 1);
                    csvContain += csvLine;
                }

                SaveFile(csvContain);



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void SaveFile(string contain)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";

            sfd.FilterIndex = 1;

            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, contain);
            }
        }
    }
}
