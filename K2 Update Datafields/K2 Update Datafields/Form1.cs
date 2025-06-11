using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SourceCode.Hosting.Client;
using SourceCode.Workflow.Client;
using SourceCode.Workflow.Management;
using System.IO;

namespace K2_Update_Datafields
{
    public partial class frmMain : Form
    {
        public string _serverName;
        public string _K2Label;
        public string _Username;
        public string _Domain;
        public string _Password;
        public uint _ClientPort;
        public uint _ManPoart;
        public bool _Restore = false;
        public int _NumOfRecords = 0;
        public bool _returnAll = false;

        public frmMain()
        {
            InitializeComponent();
        }

        public void buildColumns()
        {
            lstProcessInstances.Clear();
            lstProcessInstances.ResetText();
            lstProcessInstances.View = System.Windows.Forms.View.Details;
            lstProcessInstances.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstProcessInstances.FullRowSelect = true;
            lstProcessInstances.AutoArrange = true;
            lstProcessInstances.AllowColumnReorder = false;
            lstProcessInstances.HideSelection = false;
            lstProcessInstances.AllowDrop = false;
            lstProcessInstances.LabelEdit = false;
            lstProcessInstances.GridLines = true;
            lstProcessInstances.MultiSelect = false;

            lstProcessInstances.Columns.Add("ID", 50);
            lstProcessInstances.Columns.Add("Folio", 240);
            lstProcessInstances.Columns.Add("Version", 60);
            lstProcessInstances.Columns.Add("Correct", 60);
            lstProcessInstances.Columns.Add("Update", 60);
        }

        public void buildColumnsRestore()
        {
            lstProcessInstances.Clear();
            lstProcessInstances.ResetText();
            lstProcessInstances.View = System.Windows.Forms.View.Details;
            lstProcessInstances.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstProcessInstances.FullRowSelect = true;
            lstProcessInstances.AutoArrange = true;
            lstProcessInstances.AllowColumnReorder = false;
            lstProcessInstances.HideSelection = false;
            lstProcessInstances.AllowDrop = false;
            lstProcessInstances.LabelEdit = false;
            lstProcessInstances.GridLines = true;
            lstProcessInstances.MultiSelect = false;

            lstProcessInstances.Columns.Add("ID", 50);
            lstProcessInstances.Columns.Add("OldValue", 180);
            lstProcessInstances.Columns.Add("NewValue", 180);
            lstProcessInstances.Columns.Add("Name", 60);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buildColumns();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult myResult;
            myResult = MessageBox.Show("Are you sure you want to Exit?", "Exit Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                //do nothing
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Connecting to K2 Management Server...";
            string strManConnection = string.Empty;
            if (chkUseConnectionString.Checked)
            {
                strManConnection = txtConnectionString.Text;

                Log("==================== STARTING ====================");
                Log("");
                Log("Connecting with ConnectionString: " + txtConnectionString.Text);
            }
            else
            {
                _serverName = txtServerName.Text;
                _K2Label = txtLabel.Text;
                _Username = txtUsername.Text;
                _Domain = txtDomain.Text;
                _Password = txtPassword.Text;
                _ClientPort = uint.Parse(txtCPort.Text);
                _ManPoart = uint.Parse(txtMPort.Text);

                Log("==================== STARTING ====================");
                Log("");
                Log("Connecting to server: " + _serverName + ":" + _ManPoart);
                Log("As user: " + _K2Label + ":" + _Domain + "\\" + _Username);

                strManConnection = CreateManagementConnection();

                Log("Management Connection: " + strManConnection);
            }

            

            SourceCode.Workflow.Management.WorkflowManagementServer wms = new SourceCode.Workflow.Management.WorkflowManagementServer();

            try
            {
                wms.Open(strManConnection);

                ProcessSets procSets = wms.GetProcSets();

                foreach (ProcessSet procSet in procSets)
                {
                    ddlProcesses.Items.Add(procSet.FullName);
                }
                lblStatus.Text = "Processes Retrieved...";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                wms.Connection.Close();
            }
        }

        public string CreateClientConnection()
        {
            SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder connectionString = new SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder();

            connectionString.Authenticate = true;
            connectionString.Host = _serverName;
            connectionString.Integrated = true;
            connectionString.IsPrimaryLogin = true;
            connectionString.Port = _ClientPort;
            connectionString.UserID = _Username;
            connectionString.WindowsDomain = _Domain;
            connectionString.Password = _Password;
            connectionString.SecurityLabelName = _K2Label;

            return connectionString.ToString();
        }

        public string CreateManagementConnection()
        {
            SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder connectionString = new SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder();

            connectionString.Authenticate = true;
            connectionString.Host = _serverName;
            connectionString.Integrated = true;
            connectionString.IsPrimaryLogin = true;
            connectionString.Port = _ManPoart;
            connectionString.UserID = _Username;
            connectionString.WindowsDomain = _Domain;
            connectionString.Password = _Password;
            connectionString.SecurityLabelName = _K2Label;

            return connectionString.ToString();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            
            _NumOfRecords = int.Parse(txtNumOfRecords.Text);
            if (_NumOfRecords == 0)
                _returnAll = true;

            buildColumns();
            bgRetrieve.RunWorkerAsync();
            while (bgRetrieve.IsBusy)
            {
                lblStatus.Text = @"Busy Retrieving...Please Wait...";
                Application.DoEvents();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult myResult;
            myResult = MessageBox.Show("Are you sure you want to Update the Datafields?", "Update Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                bgWorker.RunWorkerAsync();
                while (bgWorker.IsBusy)
                {
                    lblStatus.Text = @"Busy Updating...Please Wait...";
                    Application.DoEvents();
                }
            }
            else
            {
                //do nothing
            }
        }

        private void Update(string dfName, string dfValue, string dfOldValue)
        {
            int numb = 0;
            string strClientConnection = string.Empty;
            if (!_Restore)
            {
                Log("");
                Log("==================== UPDATING INSTANCES ====================");
                Log("");

                Log("Updating Datafield: " + dfName);

                DateTime dtRetrieveStart = DateTime.Now;
                SourceCode.Workflow.Client.Connection connection = new Connection();
                try
                {
                    SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder connectionString = new SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder();
                    if (chkUseConnectionString.Checked)
                    {
                        strClientConnection = txtK2ClientConnection.Text;
                    }
                    else
                    {
                        strClientConnection = CreateClientConnection();
                    }
                    
                    
                    connection.Open(_serverName, strClientConnection);

                    foreach (ListViewItem item in lstProcessInstances.Items)
                    {
                        try
                        {
                            //connection.Open(_serverName, strClientConnection);

                            LogBackup(item.SubItems[0].Text + "#" + dfOldValue + "#" + dfValue + "#" + dfName, "Datafield");
                            Log("Updating Process Instance ID: " + item.SubItems[0].Text + "\t\tDatafield Name: " + dfName + "\t\tValue: " + dfValue);

                            SourceCode.Workflow.Client.ProcessInstance pi = connection.OpenProcessInstance(int.Parse(item.SubItems[0].Text));
                            pi.DataFields[dfName].Value = dfValue;
                            pi.Update();

                            item.BackColor = Color.LightGreen;
                        }
                        catch (Exception ex)
                        {
                            item.BackColor = Color.LightCoral;
                            Log("Error Updating Process Instance ID: " + item.SubItems[0].Text + " - " + ex.Message);
                        }
                        finally
                        {
                            //connection.Close();
                        }
                        numb++;
                    }

                    DateTime dtRetrieveEnd = DateTime.Now;
                    TimeSpan executionTime = dtRetrieveEnd - dtRetrieveStart;

                    Log("Execution Time: " + executionTime.Minutes.ToString() + ":" + executionTime.Seconds.ToString() + ":" + executionTime.Milliseconds.ToString());
                    Log("");
                    Log("==================== UPDATING INSTANCES - DONE ====================");
                    Log("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                DateTime dtRetrieveStart = DateTime.Now;

                lblStatus.Text = "Restoring Datafield: " + txtDatafieldName.Text;
                Log("");
                Log("==================== RESTORING INSTANCES ====================");
                Log("");
                Log("Restoring Datafield: " + txtDatafieldName.Text);

                try
                {
                    SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder connectionString = new SourceCode.Hosting.Client.BaseAPI.SCConnectionStringBuilder();
                    if (chkUseConnectionString.Checked)
                    {
                        strClientConnection = txtK2ClientConnection.Text;
                    }
                    else
                    {
                        strClientConnection = CreateClientConnection();
                    }
                    SourceCode.Workflow.Client.Connection connection = new Connection();

                    foreach (ListViewItem item in lstProcessInstances.Items)
                    {
                        try
                        {
                            Log("Restoring Process Instance ID: " + item.SubItems[0].Text + "\t\tDatafield Name: " + txtDatafieldName.Text + "\t\tValue: " + txtDatafieldValue.Text);

                            connection.Open(_serverName, strClientConnection);

                            SourceCode.Workflow.Client.ProcessInstance pi = connection.OpenProcessInstance(int.Parse(item.SubItems[0].Text));
                            pi.DataFields[item.SubItems[3].Text].Value = item.SubItems[1].Text;
                            pi.Update();

                            item.BackColor = Color.LightBlue;
                        }
                        catch (Exception ex)
                        {
                            item.BackColor = Color.LightCoral;
                            Log("Error Restoring Process Instance ID : " + item.SubItems[0].Text + " - " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                            
                        }
                    }

                    DateTime dtRetrieveEnd = DateTime.Now;
                    TimeSpan executionTime = dtRetrieveEnd - dtRetrieveStart;

                    Log("Restored: " + lstProcessInstances.Items.Count + "Execution Time: " + executionTime.Minutes.ToString() + ":" + executionTime.Seconds.ToString() + ":" + executionTime.Milliseconds.ToString());
                    Log("");
                    Log("==================== RESTORING INSTANCES - DONE ====================");
                    Log("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                _Restore = false;
            }

        }
        private void Retrieve(string strProcess, string dfName, string dfOldValue)
        {
            string strManConnection = string.Empty;
            string strClientConnection = string.Empty;
            DateTime dtRetrieveStart = DateTime.Now;
            int iStartID = int.Parse(txtProcInstID.Text);
            int iEndID = int.Parse(txtProcInstEnd.Text);
            
            if (iEndID == 0)
                iEndID = int.MaxValue;

            int iProcSetID = 0;
            int Number = 0;
            if (chkUseConnectionString.Checked)
            {
                strManConnection = txtConnectionString.Text;
                strClientConnection = txtK2ClientConnection.Text;
            }
            else
            {

                strManConnection = CreateManagementConnection();
                strClientConnection = CreateClientConnection();
            }

            SourceCode.Workflow.Management.WorkflowManagementServer wms = new SourceCode.Workflow.Management.WorkflowManagementServer();
            SourceCode.Workflow.Client.Connection cConn = new Connection();

            

            try
            {
                wms.Open(strManConnection);

                SourceCode.Workflow.Management.ProcessSets procSets = wms.GetProcSets();
                foreach (SourceCode.Workflow.Management.ProcessSet ps in procSets)
                {
                    if (ps.FullName == strProcess)
                    {
                        iProcSetID = ps.ProcSetID;
                        break;
                    }
                }
                Log("");
                Log("==================== RETRIEVING PROCESSES ====================");
                Log("");
                Log("Retrieving current process information...");

                SourceCode.Workflow.Management.ProcessSet processSet = wms.GetProcSet(iProcSetID);

                SourceCode.Workflow.Management.Processes procecsses = wms.GetProcesses(processSet.ProcSetID);

                foreach (SourceCode.Workflow.Management.Process process in procecsses)
                {
                    SourceCode.Workflow.Management.ProcessInstances procInstances = wms.GetProcessInstances(process.ProcID);
                    
                    foreach (SourceCode.Workflow.Management.ProcessInstance pi in procInstances)
                    {
                        if (pi.ID >= iStartID && pi.ID <= iEndID)
                        {
                            Log("Comparing Process Instance: " + pi.ID);
                            cConn.Open(_serverName, strClientConnection);

                            SourceCode.Workflow.Client.ProcessInstance cPI = cConn.OpenProcessInstance(pi.ID);
                            if (cPI.DataFields[dfName].Value.ToString() == dfOldValue)
                            {
                                ListViewItem item = new ListViewItem(pi.ID.ToString());
                                item.SubItems.Add(pi.Folio);
                                item.SubItems.Add(pi.ExecutingProcID.ToString());
                                item.SubItems.Add("FALSE");
                                item.SubItems.Add("TRUE");

                                lstProcessInstances.Items.Add(item);

                                Log("Retrieved Process Instance ID : " + pi.ID.ToString() + "\t\tFolio: " + pi.Folio + "\t\tDatafield Name: " + dfName + "\t\tValue: " + dfOldValue);
                                Number++;
                            }

                            cConn.Close();

                            if (Number == _NumOfRecords && _returnAll == false)
                                break;

                            //if (iEndID == pi.ID)
                            //    break;
                        }
                    }
                }

                DateTime dtRetrieveEnd = DateTime.Now;
                TimeSpan executionTime = dtRetrieveEnd - dtRetrieveStart;

                Log("");
                Log("Total Number of instances: " + lstProcessInstances.Items.Count + " Execution Time: " + executionTime.Minutes.ToString() + ":" + executionTime.Seconds.ToString() + ":" + executionTime.Milliseconds.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                wms.Connection.Close();
            }
        }

        static public void LogBackup(string content, string FileName)
        {
            DateTime dtNow = DateTime.Now;

            System.IO.FileStream stream = new System.IO.FileStream(FileName + "_Bakup.txt", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(stream);

            writeStream(streamWriter, content);

            streamWriter.Close();
        }

        static public void Log(string content)
        {
            DateTime dtNow = DateTime.Now;

            System.IO.FileStream stream = new System.IO.FileStream("K2 Update Datafiels_log.log", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(stream);

            writeStream(streamWriter, content);

            streamWriter.Close();
        }

        static private void writeStream(System.IO.StreamWriter sw, string content)
        {
            sw.BaseStream.Seek(0L, System.IO.SeekOrigin.End);
            sw.WriteLine(content);
            sw.Flush();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            buildColumnsRestore();
            _Restore = true;
            foreach (string line in File.ReadLines(@"Datafield_Bakup.txt", Encoding.UTF8))
            {
                string[] ss = line.Split('#');

                ListViewItem item = new ListViewItem(ss[0]);
                item.SubItems.Add(ss[1]);
                item.SubItems.Add(ss[2]);
                item.SubItems.Add(ss[3]);

                lstProcessInstances.Items.Add(item);
            }
            lblStatus.Text = lstProcessInstances.Items.Count.ToString() + " Items Found";
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                Update(txtDatafieldName.Text, txtDatafieldValue.Text, txtOldDatafieldValue.Text);
                
            });
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Updating Datafields Completed";
            Log("Successfully updated: " + lstProcessInstances.Items.Count);
            procBar.Visible = false;
        }

        private void bgRetrieve_DoWork(object sender, DoWorkEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                Retrieve(ddlProcesses.Text, txtDatafieldName.Text, txtOldDatafieldValue.Text);
            });
        }

        private void bgRetrieve_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Process Instances Retrieved (" + lstProcessInstances.Items.Count + ")";
            Log("Successfully Retrieved: " + lstProcessInstances.Items.Count);
            procBar.Visible = false;
        }

        private void bgRetrieve_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //procBar.Value = e.ProgressPercentage;
            //lblStatus.Text = @"Busy Retrieving...Please Wait...("+ e.ProgressPercentage + ")";
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
          // procBar.Value = e.ProgressPercentage;
        }

        private void chkUseConnectionString_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseConnectionString.Checked)
            {
                txtConnectionString.Enabled = true;
                txtK2ClientConnection.Enabled = true;

                txtUsername.Enabled = false;
                txtLabel.Enabled = false;
                txtDomain.Enabled = false;
                txtPassword.Enabled = false;
            }
            else if (!chkUseConnectionString.Checked)
            {
                txtConnectionString.Enabled = false;
                txtK2ClientConnection.Enabled = false;

                txtUsername.Enabled = true;
                txtLabel.Enabled = true;
                txtDomain.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
