﻿// Decompiled with JetBrains decompiler
// Type: AutoLeadGUI.frmMain
// Assembly: AutoLeadGUI, Version=2.8.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8777AC84-8195-4D0C-9461-40AEA2B2DD99
// Assembly location: C:\Users\Nguyen Van Dai\Downloads\3.2.1\Debug\AutoLeadGUI.exe

using AutoLead;
using AutoLeadGUI.dv;
using AutoLeadGUI.Properties;
using ControliPhone;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using soft;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace AutoLeadGUI
{
  public class frmMain : Form
  {
    public static bool rrsselect = false;
    public static bool sttconnect = true;
    private static int _runLimit = 0;
    public static int idRRS = 0;
    public static List<ListScript> ScriptListRep = new List<ListScript>();
    public static List<Listapp> ListappInstall = new List<Listapp>();
    private static List<Listapp> ListAppkill = new List<Listapp>();
    public static string fullsub = (string) null;
    private static int count = 0;
    public static List<IME> ListIME = new List<IME>();
    public static string ipIphone = (string) null;
    public static string ipreconnect = (string) null;
    public static string keyreconnect = (string) null;
    public static string exeDir = (string) null;
    public static string serial = (string) null;
    private static command cmd = new command();
    public static commandResult cmdResult = new commandResult();
    public static List<Dataclearformiphone> ListDataClear = new List<Dataclearformiphone>();
    public static bool bool_checkRunAppstore = false;
    public static bool bool_usingchrome = false;
    public static bool bool_chkonly10_3_1 = false;
    public static bool bool_TouchSF = false;
    public static bool bool_loopip = false;
    public static bool bool_startloop = false;
    public static string Xsf = "";
    public static string Ysf = "";
    public static string Xapp = "";
    public static string Yapp = "";
    public static bool bool_sml = false;
    public static bool bool_fakegeo = true;
    public static bool bool_fakescreen = false;
    public static bool bool_detectapp = true;
    public static bool bool_tryopenapp = false;
    public static bool bool_fakecoresystem = false;
    public static bool bool_fakeUA = true;
    public static bool bool_fakelangnoIP = false;
    public static string tokenvip = (string) null;
    public static string langnoIP = (string) null;
    public static int numberLoadurlAgain = 0;
    public static bool bool_iphone7 = false;
    public static bool bool_onlymail = false;
    public static bool bool_chkmailfile = false;
    public static bool bool_sub = false;
    public static string patchfileMail = (string) null;
    public static List<ssh> SSHListLive = new List<ssh>();
    public static JavaScriptSerializer jssfakeSP = new JavaScriptSerializer();
    public static Dictionary<string, object> dictfakeSP = new Dictionary<string, object>();
    public static string AppnameDefault = (string) null;
    public static string Appid = (string) null;
    public static string ipdv = (string) null;
    public static string portFake = (string) null;
    public static string ipfake = (string) null;
    public static List<BkList> ListVitriBk = new List<BkList>();
    public static string linkoff = "";
    private static int getUptimewait = 0;
    private static bool bool_nextstep = true;
    public static string idappRRS = (string) null;
    public static int totalRRSSelectRemove = 0;
    public static int dayrrs = 0;
    public static int ptRRS = 0;
    public static int i_ptRRS = 0;
    public static int i_limitptRRS = 0;
    public static string sttScript2 = "";
    public static bool BoolstartTimer1 = false;
    internal static string svali = "198.11.136.1";
    private string IP = "45.76.147.100";
    private string previousSelectedScriptName = (string) null;
    private int _width = 0;
    private int _RestoreIndex = -1;
    private int _currentIndex = -1;
    private int _runState = -1;
    private Thread _bwLeadThread = (Thread) null;
    private Thread _bwRSSThread = (Thread) null;
    private List<Operation> _currentOpsList = (List<Operation>) null;
    private Operation _currentWaitOp = (Operation) null;
    private Thread changeIPThread = (Thread) null;
    private DownloadProgress downloadform = new DownloadProgress();
    public List<vipuse> ListUseVip = new List<vipuse>();
    private Process bitproc = new Process();
    private bool ActiveportPorxy = false;
    private bool needToChangeIP = false;
    private IContainer components = (IContainer) null;
    private byte[] downloadedData;
    private Socket _clientSocket;
    private byte[] _buffer;
    private ConnectionInfo ConnNfo;
    public static SftpClient sftpclient;
    private static Operation operation;
    private FolderBrowserDialog folderBrowserDialog1;
    private TabControl tcMain;
    private TabPage tpAutoLead;
    private TabPage tpProxy;
    private TabPage tpRSS;
    private TabPage tpSupport;
    private TabPage tpSettings;
    private TabPage tpContact;
    private GroupBox gbDevice;
    private Label lbDeviceIP;
    private Button btConnect;
    private CheckBox cbAutoReconnect;
    private ListView lvAutoLead;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader0;
    private Button btAddOffer;
    private Button btRemoveAll;
    private Button btnEdit;
    private Button btnRemove;
    private Label lbBackup;
    private Label lbRun;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Button btnRefreshSSH;
    private Button btnDeleteAll;
    private Button btnDeleteSSH;
    private ListView lvSSH;
    private Button btnExportSSH;
    private Button btnImportSSHFromCB;
    private Button btnImportSSHFromFile;
    private Label lbDead;
    private Label lbLive;
    private Label lbUnCheck;
    private Label lbTotalSSH;
    private Button btnCheckLive;
    private Label label15;
    private NumericUpDown numThreadCount;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;
    private ColumnHeader columnHeader8;
    private ColumnHeader columnHeader9;
    private ListView lvVip72;
    private ColumnHeader columnHeader10;
    private ColumnHeader columnHeader11;
    private Button btnDeleteVip72;
    private Button btnCheckVip72;
    private Button btnAddVip72;
    private ListView lvRSS;
    private ColumnHeader columnHeader12;
    private ColumnHeader columnHeader13;
    private ColumnHeader columnHeader14;
    private ColumnHeader columnHeader15;
    private ColumnHeader columnHeader16;
    private ColumnHeader columnHeader17;
    private Label label18;
    private TextBox tbRSSComment;
    private Button btnSaveRSSComment;
    private Button btnRestoreRSS;
    private Button btnSaveRSS;
    private Button btnRemoveRSS;
    private Button btnRemoveAllRSS;
    private Label lbSelectedRSS;
    private Label lbTotalRSS;
    private ColumnHeader columnHeader19;
    private Button btnResetRSS;
    private Button btnStartRSS;
    private Label label21;
    private NumericUpDown numWaitTime;
    private GroupBox groupBox2;
    private Label label22;
    private Button btnOpenURL;
    private TextBox tbURL;
    private GroupBox gbScript;
    private ComboBox cbApps;
    private Button tbnOpenApp;
    private TextBox tbScript;
    private Button btnSaveScript;
    private Button btnWipe;
    private Button btnRecordEvent;
    private GroupBox groupBox4;
    private GroupBox groupBox5;
    private GroupBox groupBox8;
    private Button btnActivate;
    private ListView lvRegisteredList;
    private ColumnHeader columnHeader20;
    private ColumnHeader columnHeader21;
    private Label label25;
    private GroupBox groupBox7;
    private TextBox tbFakeDeviceName;
    private ComboBox combFakeDeviceModel;
    private ComboBox combFakeIOSVersion;
    private CheckBox cbFakeDeviceFromFile;
    private ComboBox combFakeCarrier;
    private ComboBox combFakeTimezone;
    private Label label27;
    private Label label26;
    private CheckBox cbFakeGPS;
    private ComboBox combFakeLang;
    private ComboBox combFakeRegion;
    private CheckBox cbFakeLang;
    private CheckBox cbFakeRegion;
    private CheckBox cbFakeCarrier;
    private CheckBox cbFakeTimeZone;
    private CheckBox cbAutoFakeLocation;
    private BackgroundWorker connectToDeviceWorker;
    private Panel pnDeviceInfo;
    private Label lbLicensed;
    private Label lbDeviceVersion;
    private Label lbDeviceSN;
    private Label lbModelName;
    private Button btnDisconnect;
    private ColumnHeader columnHeader22;
    private ColumnHeader columnHeader23;
    private Button btnReset;
    private Button btnStart;
    private GroupBox gbStart;
    private Button btnRecord2;
    private Button btnRecord1;
    private TextBox tbAppStore;
    private CheckBox cbAppStore;
    private TextBox tbSafari;
    private CheckBox cbSafari;
    private TextBox tbComment;
    private Label label7;
    private Label label6;
    private NumericUpDown numRunLimit;
    private CheckBox cbBackup;
    private CheckBox cbFullWipe;
    private Button btRefresh;
    private TextBox tbScriptName;
    private Button btnHelp;
    private GroupBox groupBox9;
    private RadioButton rbCustomScript;
    private RadioButton rbScriptForApp;
    private Button btnDeleteScript;
    private Button btnAddScript;
    private ListView lvAllScripts;
    private ColumnHeader columnHeader24;
    private Button btnTestScript;
    private ColumnHeader columnHeader25;
    private BackgroundWorker sshImport;
    private ColumnHeader columnHeader26;
    private ColumnHeader columnHeader27;
    private BackgroundWorker bwLead;
    private StatusStrip ssMain;
    private ToolStripStatusLabel lbStatus;
    private Label label10;
    private NumericUpDown numURLLoadTime;
    private System.Windows.Forms.Timer lbStatusCountDown;
    private ColumnHeader columnHeader28;
    private GroupBox groupBox1;
    private RadioButton rbThisScript;
    private RadioButton rbButtonRandomScript;
    private RadioButton rbButtonNoScript;
    private ComboBox cbScriptList;
    private TextBox tbKeyActivation;
    private BackgroundWorker bwRSS;
    private TextBox numLong;
    private TextBox numLat;
    private Button btnDeleteDead;
    private TextBox ipcDeviceIP;
    private Label lbCheckLiveStatus;
    private CheckBox cbChangeIPWhenCheckIPReturnsFalse;
    private CheckBox cbAutoChangeIPRRS;
    private System.Windows.Forms.Timer changeIPTimer;
    private System.Windows.Forms.Timer changeIPTimer2;
    private BackgroundWorker bwRestoreRSS;
    private Label lbUsed;
    private Label label8;
    private NumericUpDown numSSHtimeout;
    private CheckBox cbRefreshSSH;
    private Label label9;
    private NumericUpDown numSSHWait;
    private Label label11;
    private NumericUpDown numSSHWaitTimeRRS;
    private CheckBox cbiOS9;
    private CheckBox cbiOS8;
    private CheckBox cbiPodTouch;
    private CheckBox cbiPad;
    private CheckBox cbiPhone;
    private CheckBox cbRandomName;
    private Label label14;
    private Label label13;
    private Label label12;
    private GroupBox gbFD;
    private NumericUpDown nmAppStoreXy;
    private NumericUpDown nmSafariXy;
    private Label label16;
    private NumericUpDown cboptbackup;//combox phan tram back up
    private CheckBox cbiOS10;
    private CheckBox cbcheckrunappstore;
    private System.Windows.Forms.Timer timer1;
    private Button button1;
    private Panel panel1;
    private Button btnBKSP;
    private System.Windows.Forms.Timer timerConnectRealtime;
    private Label sttEunRRS;
    private Button btApply;
    private ComboBox cbTool;
    private Label lbTool;
    private ComboBox cbCountries;
    private Label label2;
    private Label label3;
    private Label label4;
    private Button btnChangeIP;
    private Label label1;
    private Label lbSelectedIP;
    private TextBox tbProxyURL;
    private Label label5;
    private TextBox ipcMyIP;
    public Label lbProxyStatus;
    private CheckBox txtexclusivevip72;
    private GroupBox gbProxy;
    private NumericUpDown nbportfake;
    private GroupBox groupBox3;
    private Label label19;
    private NumericUpDown numericUpDown1;
    private Button button2;
    private Label label17;
    private ComboBox comboBox1;
    private RichTextBox richTextBox1;
    private Button button4;
    private Button button3;
    private Label label20;
    private ComboBox comboBox2;
    private CheckBox chkgameupdate;
    private Button button6;
    private Button button7;
    private CheckBox chkrunsml;
    private ComboBox cboscript_openurl;
    private CheckBox chkuserscript_openurl;
    private Button button5;
    private Label label24;
    private NumericUpDown timeloadAppstrore;
    private GroupBox groupBox6;
    private CheckBox chkipused;
    private Button button9;
    private Button button8;
    private CheckBox chkfakeGeo;
    private CheckBox chkfakecoresystem;
    private CheckBox chkfakeUA;
    private CheckBox chkfakescreen;
    private CheckBox chkdetectapp;
    private ProgressBar progressBar1;
    private TabPage tprrsmanager;
    private NumericUpDown numLoadagainUrl;
    private CheckBox chkloadurlagain;
    private Button button10;
    private Button button11;
    private CheckBox chkPortRd;
    private CheckBox checkiPhone7;
    private Button button12;
    private Button btnupdateVip;
    private TextBox token;
    private Label label23;
    private TextBox tbVip72Password;
    private Label label28;
    private TextBox tbVip72ID;
    private Label label29;
    private ComboBox cbostt;
    private Label label30;
    private CheckBox chkonlymail;
    private CheckBox chkmailfile;
    private TextBox txtnumsub;
    private TextBox txtsub;
    private CheckBox chksub;
    private Label label31;
    private ColumnHeader columnHeader18;
    private Button button13;
    private ListView lvsrrsmanager;
    private ColumnHeader columnHeader29;
    private ColumnHeader columnHeader30;
    private ColumnHeader columnHeader31;
    private ColumnHeader columnHeader32;
    private ColumnHeader columnHeader33;
    private ColumnHeader columnHeader34;
    private ColumnHeader columnHeader35;
    private ColumnHeader columnHeader36;
    private ColumnHeader columnHeader37;
    private Label label33;
    private ComboBox cborrsmnName;
    private Label label32;
    private ComboBox cborrsmnDay;
    private Label label34;
    private ComboBox cborrsmnCountry;
    private Button button14;
    private Button button15;
    private Button button16;
    private Button button17;
    private TextBox txtfileMail;
    private Button button18;
    private Panel panel3;
    private ComboBox cboregion;
    private ComboBox cbocity;
    private Panel panel4;
    private Label label35;
    private Button button19;
    private TabPage tpExIm;
    private Button button21;
    private Button button20;
    private GroupBox groupBox10;
    private Button button24;
    private Button button22;
    private Button button23;
    private Button button25;
    private Button button26;
    private Button button27;
    private SaveFileDialog saveFileDialog1;
    private Button button29;
    private Button button28;
    private TextBox textBox1;
    private RichTextBox richTextBox2;
    private Button button30;
    private TextBox textBox2;
    private CheckBox usingchrome;
    private CheckBox chkloopip;
    private NumericUpDown numloopip;
    private CheckBox chkonly10_3_1;
    private SplitContainer splitContainer1;
    private SplitContainer splitContainer2;
    private Label sellectoff;
    private Label label36;
    private NumericUpDown num_sleepBfurl;
    private TextBox textBox3;
    private CheckBox cbiOS11;

    public frmMain()
    {
      this.InitializeComponent();
    }

    public void DisplayOutput(string output)
    {
    }

    private void SetCanGoForward(bool canGoForward)
    {
    }

    private void SetIsLoading(bool isLoading)
    {
    }

    private void HandleToolStripLayout()
    {
    }

    private void SetCanGoBack(bool canGoBack)
    {
    }

    private void button2_Click(object sender, EventArgs e)
    {
      frmAddOffer frmAddOffer = new frmAddOffer();
      frmAddOffer.FormClosed += new FormClosedEventHandler(this.frmAddOfferClosed);
      int num = (int) frmAddOffer.ShowDialog();
    }

    private void frmAddOfferClosed(object sender, FormClosedEventArgs e)
    {
      this.reloadOffers();
    }

    private void btConnect_Click(object sender, EventArgs e)
    {
      this.connectToDeviceWorker.RunWorkerAsync();
    }

    private void updateDeviceInfo(string device_info)
    {
      Dictionary<string, object> dictionary = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(device_info);
      this.pnDeviceInfo.Visible = true;
      this.pnDeviceInfo.BringToFront();
      this.lbModelName.Text = dictionary["model"].ToString() + "(" + dictionary["name"] + ")";
      this.lbDeviceVersion.Text = (string) dictionary["version"];
      if (!((string) dictionary["license"]).Equals("Licensed"))
        this.lbLicensed.ForeColor = Color.Red;
      else
        this.lbLicensed.ForeColor = Color.Green;
      this.lbLicensed.Text = (string) dictionary["license"];
      this.lbDeviceSN.Text = (string) dictionary["serial"];
    }

    public string GetLocalIPAddress()
    {
      foreach (IPAddress address in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
      {
        if (address.AddressFamily == AddressFamily.InterNetwork)
          return address.ToString();
      }
      return "0.0.0.0";
    }

    private void setupDefaultSettings()
    {
      if (LocalConfig.getCurrentConfig().getObjectForKey("Country") == null)
        LocalConfig.getCurrentConfig().setObjectForKey((object) "NETHERLANDS", "Country");
      if (LocalConfig.getCurrentConfig().getObjectForKey("ProxyTool") == null)
        LocalConfig.getCurrentConfig().setObjectForKey((object) "SSH", "ProxyTool");
      int port = 12500;
      while (port <= 30000 && !GlobalConfig.isPortAvailable(port))
        ++port;
    }

    private void reloadRSSList()
    {
      this.cborrsmnName.Items.Clear();
      this.cborrsmnDay.Items.Clear();
      this.comboBox2.Items.Clear();
      this.comboBox1.Items.Clear();
      this.cborrsmnCountry.Items.Clear();
      switch (LocalConfig.getCurrentConfig().getInt32ForKey("RSSScriptType"))
      {
        case 0:
          this.rbButtonNoScript.Checked = true;
          break;
        case 1:
          this.rbButtonRandomScript.Checked = true;
          break;
        case 2:
          this.rbThisScript.Checked = true;
          break;
      }
      int num1 = LocalConfig.getCurrentConfig().getInt32ForKey("WaitTime");
      if (num1 == 0)
        num1 = 20;
      this.numWaitTime.Value = (Decimal) num1;
      ArrayList arrayList = LocalConfig.getCurrentConfig().allRSSs();
      this.lvRSS.Items.Clear();
      this.lvRSS.CheckBoxes = true;
      this.lvsrrsmanager.Items.Clear();
      this.lvsrrsmanager.CheckBoxes = true;
      this.lbSelectedRSS.Tag = (object) 0;
      if (arrayList != null)
      {
        for (int index = 0; index < arrayList.Count; ++index)
        {
          Dictionary<string, object> dictionary = (Dictionary<string, object>) arrayList[index];
          int num2 = index + 1;
          ListViewItem listViewItem1 = new ListViewItem(num2.ToString() + "|" + dictionary["fn"].ToString());
          num2 = index + 1;
          ListViewItem listViewItem2 = new ListViewItem(num2.ToString() + "|" + dictionary["fn"].ToString());
          bool flag = false;
          if (dictionary.ContainsKey("selected"))
            flag = Convert.ToBoolean(dictionary["selected"]);
          listViewItem1.SubItems.Add(((DateTime) dictionary["cd"]).ToString());
          listViewItem1.SubItems.Add(((DateTime) dictionary["md"]).ToString());
          listViewItem1.SubItems.Add(Convert.ToString(dictionary["rt"]));
          listViewItem1.SubItems.Add(dictionary["an"].ToString());
          listViewItem1.SubItems.Add(dictionary["ct"].ToString());
          listViewItem1.SubItems.Add(dictionary["ip"].ToString());
          listViewItem1.SubItems.Add(dictionary["cm"].ToString());
          try
          {
            listViewItem1.SubItems.Add(dictionary["sub"].ToString());
          }
          catch
          {
          }
          this.lvRSS.Items.Add(listViewItem1);
          listViewItem2.SubItems.Add(((DateTime) dictionary["cd"]).ToString());
          listViewItem2.SubItems.Add(((DateTime) dictionary["md"]).ToString());
          listViewItem2.SubItems.Add(Convert.ToString(dictionary["rt"]));
          listViewItem2.SubItems.Add(dictionary["an"].ToString());
          listViewItem2.SubItems.Add(dictionary["ct"].ToString());
          listViewItem2.SubItems.Add(dictionary["ip"].ToString());
          listViewItem2.SubItems.Add(dictionary["cm"].ToString());
          try
          {
            listViewItem2.SubItems.Add(dictionary["sub"].ToString());
          }
          catch
          {
          }
          this.lvsrrsmanager.Items.Add(listViewItem2);
          DateTime dateTime = Convert.ToDateTime(dictionary["cd"].ToString());
          string s1 = dateTime.Month.ToString() + "/" + (object) dateTime.Day + "/" + (object) dateTime.Year;
          if (this.comboBox1.FindString(s1) < 0)
          {
            this.comboBox1.Items.Add((object) s1);
            this.comboBox2.Items.Add((object) s1);
            this.cborrsmnDay.Items.Add((object) s1);
          }
          string s2 = dictionary["an"].ToString();
          if (this.cborrsmnName.FindString(s2) < 0)
            this.cborrsmnName.Items.Add((object) s2);
          string s3 = dictionary["ct"].ToString();
          if (this.cborrsmnCountry.FindString(s3) < 0)
            this.cborrsmnCountry.Items.Add((object) s3);
        }
        this.lbTotalRSS.Text = "Total RSS: " + (object) arrayList.Count;
        this.lbSelectedRSS.Text = "Enabled: " + this.lbSelectedRSS.Tag;
      }
      else
      {
        this.lbSelectedRSS.Tag = (object) 0;
        this.lbTotalRSS.Text = "Total RSS: " + (object) 0;
        this.lbSelectedRSS.Text = "Enabled: 0";
      }
    }

    private void loadMainUI()
    {
      this.tcMain.TabPages.Clear();
      this.tcMain.TabPages.Add(this.tpAutoLead);
      this.tcMain.TabPages.Add(this.tpProxy);
      this.tcMain.TabPages.Add(this.tpRSS);
      this.tcMain.TabPages.Add(this.tpSupport);
      this.tcMain.TabPages.Add(this.tpSettings);
      this.tcMain.TabPages.Add(this.tprrsmanager);
      this.tcMain.TabPages.Add(this.tpExIm);
      this.tcMain.TabPages.Add(this.tpContact);
      this.reloadLicenseKeys();
      this.tcMain.Enabled = true;
      this.gbProxy.Enabled = true;
      string text = this.lbDeviceSN.Text;
      string model = "iPhone";
      Directory.CreateDirectory(GlobalConfig.executableDirectory() + "\\" + text);
      LocalConfig.SetLog(text);
      if (this.lbModelName.Text.StartsWith("iPhone"))
        model = "iPhone";
      else if (this.lbModelName.Text.StartsWith("iPad"))
        model = "iPad";
      else if (this.lbModelName.Text.StartsWith("iPod"))
        model = "iPod";
      GlobalConfig.setupLocalConfigWithDeviceSN(text, model, this.lbDeviceVersion.Text.Replace("iOS", "").Trim());
      this.setupDefaultSettings();
      this.combFakeTimezone.Items.AddRange((object[]) Split.tachchuoi(ResourceList.Timezones, "\r\n"));
      this.combFakeCarrier.Items.AddRange((object[]) Split.tachchuoi(ResourceList.Operators, "\r\n"));
      this.combFakeRegion.Items.AddRange((object[]) Split.tachchuoi(ResourceList.Regions, "\r\n"));
      this.combFakeLang.Items.AddRange((object[]) Split.tachchuoi(ResourceList.IOSLanguageCode, "\r\n"));
      if (LocalConfig.getCurrentConfig().getObjectForKey("FiOS") == null)
        LocalConfig.getCurrentConfig().setObjectForKey((object) GlobalConfig.stringSplit(LocalConfig.getCurrentConfig().currentDeviceVersion, ".")[0].Trim(), "FiOS");
      if (LocalConfig.getCurrentConfig().getObjectForKey("FiPhone") == null)
      {
        string currentModel = LocalConfig.getCurrentConfig().currentModel;
        LocalConfig.getCurrentConfig().setObjectForKey((object) false, "FiPhone");
        LocalConfig.getCurrentConfig().setObjectForKey((object) false, "FiPad");
        LocalConfig.getCurrentConfig().setObjectForKey((object) false, "FiPod");
        LocalConfig.getCurrentConfig().setObjectForKey((object) true, "F" + currentModel);
      }
      if (LocalConfig.getCurrentConfig().getObjectForKey("FRandName") == null)
        LocalConfig.getCurrentConfig().setObjectForKey((object) true, "FRandName");
      if (LocalConfig.getCurrentConfig().getObjectForKey("nmSafariXy") == null)
      {
        LocalConfig.getCurrentConfig().setObjectForKey((object) 10, "nmSafariXy");
        LocalConfig.getCurrentConfig().setObjectForKey((object) 10, "nmAppStoreXy");
      }
      this.nmSafariXy.Value = (Decimal) LocalConfig.getCurrentConfig().getInt32ForKey("nmSafariXy");
      this.nmAppStoreXy.Value = (Decimal) LocalConfig.getCurrentConfig().getInt32ForKey("nmAppStoreXy");
      this.reloadRandName();
      this.reloadVersionCheckbox();
      this.reloadVersionList();
      this.reloadModelListCheckbox();
      this.reloadModelList();
      if (LocalConfig.getCurrentConfig().getObjectForKey("FakeLocationFromIP") == null)
      {
        LocalConfig.getCurrentConfig().setObjectForKey((object) true, "FakeLocationFromIP");
        LocalConfig.getCurrentConfig().setObjectForKey((object) true, "FakeDeviceFromFile");
        LocalConfig.getCurrentConfig().setObjectForKey((object) 0, "fakeRegion");
        LocalConfig.getCurrentConfig().setObjectForKey((object) false, "fakeRegionEnable");
        LocalConfig.getCurrentConfig().setObjectForKey((object) 0, "fakeLang");
        LocalConfig.getCurrentConfig().setObjectForKey((object) false, "fakelangEnable");
        LocalConfig.getCurrentConfig().setObjectForKey((object) 0, "fakeTz");
        LocalConfig.getCurrentConfig().setObjectForKey((object) false, "fakeTzEnable");
        LocalConfig.getCurrentConfig().setObjectForKey((object) "", "fakeLocationLat");
        LocalConfig.getCurrentConfig().setObjectForKey((object) "", "fakeLocationLong");
        LocalConfig.getCurrentConfig().setObjectForKey((object) false, "fakeLocationEnable");
        LocalConfig.getCurrentConfig().setObjectForKey((object) 0, "fakeModel");
        LocalConfig.getCurrentConfig().setObjectForKey((object) false, "fakeModelEnable");
        LocalConfig.getCurrentConfig().setObjectForKey((object) 0, "fakeVersion");
        LocalConfig.getCurrentConfig().setObjectForKey((object) false, "fakeVersionEnable");
        LocalConfig.getCurrentConfig().setObjectForKey((object) "", "fakeName");
        LocalConfig.getCurrentConfig().setObjectForKey((object) false, "fakeNameEnable");
        LocalConfig.getCurrentConfig().setObjectForKey((object) 0, "fakeCa");
        LocalConfig.getCurrentConfig().setObjectForKey((object) false, "fakeCaEnable");
      }
      this.cbFakeCarrier.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("fakeCaEnable");
      this.cbFakeGPS.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("fakeLocationEnable");
      this.cbFakeLang.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("fakelangEnable");
      this.cbFakeRegion.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("fakeRegionEnable");
      this.cbFakeTimeZone.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("fakeTzEnable");
      int num1 = LocalConfig.getCurrentConfig().getInt32ForKey("ConnectionTime");
      if (num1 == 0)
      {
        num1 = 20;
        LocalConfig.getCurrentConfig().setObjectForKey((object) num1, "ConnectionTime");
      }
      this.numSSHWait.Value = (Decimal) num1;
      this.numSSHWaitTimeRRS.Value = (Decimal) num1;
      int int32ForKey1 = LocalConfig.getCurrentConfig().getInt32ForKey("sshTimeout");
      int int32ForKey2 = LocalConfig.getCurrentConfig().getInt32ForKey("sshThreadCount");
      this.numSSHtimeout.Value = (Decimal) (int32ForKey1 > 0 ? int32ForKey1 : 30);
      this.numThreadCount.Value = (Decimal) (int32ForKey2 > 0 ? int32ForKey2 : 20);
      GlobalConfig.SSHThreadCount = int32ForKey2 > 0 ? int32ForKey2 : 20;
      GlobalConfig.SSHTimeout = int32ForKey1 > 0 ? int32ForKey1 : 30;
      bool flag = LocalConfig.getCurrentConfig().getBooleanForKey("sshRefresh");
      if (LocalConfig.getCurrentConfig().getObjectForKey("sshRefresh") == null)
        flag = true;
      this.cbRefreshSSH.Checked = flag;
      this.combFakeCarrier.SelectedIndex = LocalConfig.getCurrentConfig().getInt32ForKey("fakeCa");
      this.combFakeLang.SelectedIndex = LocalConfig.getCurrentConfig().getInt32ForKey("fakeLang");
      this.combFakeRegion.SelectedIndex = LocalConfig.getCurrentConfig().getInt32ForKey("fakeRegion");
      this.combFakeTimezone.SelectedIndex = LocalConfig.getCurrentConfig().getInt32ForKey("fakeTz");
      this.numLong.Text = LocalConfig.getCurrentConfig().getStringForKey("fakeLocationLong");
      this.numLat.Text = LocalConfig.getCurrentConfig().getStringForKey("fakeLocationLat");
      this.tbFakeDeviceName.Text = LocalConfig.getCurrentConfig().getStringForKey("fakeName");
      bool booleanForKey = LocalConfig.getCurrentConfig().getBooleanForKey("FakeLocationFromIP");
      this.cbFakeDeviceFromFile.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("FakeDeviceFromFile");
      this.cbAutoFakeLocation.Checked = booleanForKey;
      this.updateVip72List();
      this.reloadSSHsList();
      this.reloadRSSList();
      this.tbComment.Text = LocalConfig.getCurrentConfig().getStringForKey("Comment");
      try
      {
        this.numericUpDown1.Value = (Decimal) LocalConfig.getCurrentConfig().getInt32ForKey("ptRRSRemove");
        this.cboptbackup.Value = (Decimal) LocalConfig.getCurrentConfig().getInt32ForKey("cbobkpt");
        this.nbportfake.Value = (Decimal) LocalConfig.getCurrentConfig().getInt32ForKey("portfakelee");
        this.cbcheckrunappstore.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkrunAppstore");
        this.chkgameupdate.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkgameupdate");
        this.chkrunsml.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkrunsml");
        this.chkuserscript_openurl.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkuserscript_openurl");
        this.cboscript_openurl.Text = LocalConfig.getCurrentConfig().getStringForKey("cboscript_openurl");
        this.chkipused.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkipused");
        this.chkfakeGeo.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkfakeGeo");
        this.chkfakeUA.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkfakeUA");
        this.chkfakescreen.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkfakescreen");
        this.txtexclusivevip72.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkvipnrieng");
        this.chkdetectapp.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkdetectapp");
        this.numLoadagainUrl.Value = (Decimal) LocalConfig.getCurrentConfig().getInt32ForKey("numLoadagainUrl");
        this.chkloadurlagain.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkloadurlagain");
        this.chkPortRd.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkPortRd");
        this.checkiPhone7.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("checkiPhone7");
        this.chkonly10_3_1.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkonly10_3_1");
        this.chkonlymail.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkonlymail");
        this.chkmailfile.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkmailfile");
        this.chksub.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chksub");
        this.usingchrome.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("usingchrome");
        this.chkloopip.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkloopip");
        this.numloopip.Value = (Decimal) LocalConfig.getCurrentConfig().getInt32ForKey("numloopip");
        this.txtnumsub.Text = LocalConfig.getCurrentConfig().getStringForKey("txtnumsub");
        if (this.chksub.Checked)
          this.txtsub.Enabled = true;
        else
          this.txtsub.Enabled = false;
        this.txtsub.Text = LocalConfig.getCurrentConfig().getStringForKey("txtsub");
        this.txtfileMail.Text = LocalConfig.getCurrentConfig().getStringForKey("txtfileMail");
        this.chkonly10_3_1.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("chkonly10_3_1");
        this.num_sleepBfurl.Value = (Decimal) LocalConfig.getCurrentConfig().getInt32ForKey("num_sleepBfurl");
        this.timeloadAppstrore.Value = (Decimal) LocalConfig.getCurrentConfig().getInt32ForKey("timeloadAppstrore");
      }
      catch
      {
      }
      this.cbFullWipe.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("FullWipe");
      this.cbBackup.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("DoBackup");
      this.cbChangeIPWhenCheckIPReturnsFalse.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("AutoChangeIP");
      this.cbAutoChangeIPRRS.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("AutoChangeIPRRS");
      int num2 = LocalConfig.getCurrentConfig().getInt32ForKey("LeadRunTime");
      if (num2 == 0)
        num2 = 200;
      this.numRunLimit.Value = (Decimal) num2;
      int num3 = LocalConfig.getCurrentConfig().getInt32ForKey("URLLoadTime");
      if (num3 == 0)
        num3 = 30;
      this.numURLLoadTime.Value = (Decimal) num3;
      this.cbSafari.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("cbSafari");
      this.cbAppStore.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("cbAppStore");
      this.tbSafari.Text = LocalConfig.getCurrentConfig().getStringForKey("SafariXY");
      this.tbAppStore.Text = LocalConfig.getCurrentConfig().getStringForKey("AppStoreXY");
      this.richTextBox1.Text = LocalConfig.getCurrentConfig().getStringForKey("NoteRRS");
      this.reloadAllScripts();
      this.ipcMyIP.Text = this.GetLocalIPAddress();
      LocalConfig.getCurrentConfig().myIP = this.ipcMyIP.Text;
      this.reloadCountriesList();
      this.reloadOffers();
      if (AutoLeadClientHelper.reloadNetworklee(this.nbportfake.Value.ToString()) != 1)
        return;
      this.lbProxyStatus.Text = "Proxy configured";
      this.lbProxyStatus.ForeColor = Color.Green;
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      this.folderBrowserDialog1 = new FolderBrowserDialog();
      this.btnCheckVip72.Hide();
      this.Checkversion();
      this.ReplaceVersion();
      this.LoadIME();
      frmMain.loadcountrycodeiOS();
      Control.CheckForIllegalCrossThreadCalls = false;
      Control.CheckForIllegalCrossThreadCalls = false;
      Control.CheckForIllegalCrossThreadCalls = false;
      Control.CheckForIllegalCrossThreadCalls = false;
      this._width = this.Width;
      string location = Assembly.GetEntryAssembly().Location;
      Process[] processesByName = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(location));
      int num = 0;
      for (int index = 0; index < processesByName.Length; ++index)
      {
        Console.WriteLine(processesByName[index].MainModule.FileName);
        if (processesByName[index].MainModule.FileName.Equals(location))
          ++num;
      }
      this.tcMain.TabPages.Clear();
      this.tcMain.TabPages.Add(this.tpContact);
      this.reloadLicenseKeys();
      if (num > 1)
      {
        this.Close();
      }
      else
      {
        this.ipcDeviceIP.Text = Settings.Default["DeviceIP"].ToString();
        this.cbAutoReconnect.Checked = Convert.ToBoolean(Settings.Default["Reconnect"]);
        if (this.cbAutoReconnect.Checked)
          this.connectToDeviceWorker.RunWorkerAsync();
      }
    }

    private void ReplaceVersion()
    {
      if (!(AppDomain.CurrentDomain.FriendlyName == "_AutoLeadGUI.exe"))
        return;
      Thread.Sleep(100);
      Process[] processesByName = Process.GetProcessesByName("AutoLeadGUI");
      while (((IEnumerable<Process>) processesByName).Count<Process>() > 0)
      {
        foreach (Process process in processesByName)
        {
          try
          {
            process.Kill();
          }
          catch (Exception ex)
          {
          }
        }
        processesByName = Process.GetProcessesByName("AutoLeadGUI");
        Thread.Sleep(100);
      }
      System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory + "AutoLeadGUI.exe");
      System.IO.File.Copy(AppDomain.CurrentDomain.BaseDirectory + "_AutoLeadGUI.exe", AppDomain.CurrentDomain.BaseDirectory + "AutoLeadGUI.exe", true);
      Process.Start(new ProcessStartInfo()
      {
        FileName = "AutoLeadGUI.exe",
        WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory
      });
      Application.Exit();
      Environment.Exit(0);
    }

    private void Checkversion()
    {
      try
      {
        if (!(Application.ProductVersion != new WebClient().DownloadString("http://45.76.144.71/version.txt")) || MessageBox.Show("Đã có phiên bản mới, bạn có muốn update không?", Application.ProductName, MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        using (WebClient webClient = new WebClient())
        {
          try
          {
            webClient.Credentials = (ICredentials) CredentialCache.DefaultNetworkCredentials;
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.client_DownloadProgressChanged);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(this.downloadcompleted);
            webClient.DownloadFileAsync(new Uri("http://45.76.144.71/AutoLeadGUI"), AppDomain.CurrentDomain.BaseDirectory + "_AutoLeadGUI.exe");
          }
          catch
          {
          }
          int num = (int) this.downloadform.ShowDialog();
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("Can't connect to server !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        Application.Exit();
        Environment.Exit(0);
      }
    }

    private void downloadcompleted(object sender, AsyncCompletedEventArgs e)
    {
      if (e.Error == null)
      {
        Process.Start(new ProcessStartInfo()
        {
          FileName = "_AutoLeadGUI.exe",
          WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory
        });
        Application.Exit();
        Environment.Exit(0);
      }
      else
      {
        int num = (int) MessageBox.Show("Can't download file, please try again", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.downloadform.Hide();
      }
    }

    private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
      this.downloadform.progressBar1.Value = int.Parse(Math.Truncate(double.Parse(e.BytesReceived.ToString()) / double.Parse(e.TotalBytesToReceive.ToString()) * 100.0).ToString());
      this.downloadform.progressBar1.Refresh();
    }

    private static void loadcountrycodeiOS()
    {
      string str1 = "AD\r\nAE|ar\r\nAF\r\nAG|en\r\nAI\r\nAL|ar\r\nAM\r\nAO\r\nAQ\r\nAR|es\r\nAS\r\nAT|de\r\nAU|en-AU\r\nAW\r\nAX\r\nAZ\r\nBA\r\nBB\r\nBD\r\nBE\r\nBF\r\nBG\r\nBH|ar\r\nBI\r\nBJ\r\nBL\r\nBM\r\nBN\r\nBO|es\r\nBQ\r\nBR|pt-BR\r\nBS\r\nBT\r\nBV\r\nBW\r\nBY\r\nBZ\r\nCA|en\r\nCC\r\nCD|ar\r\nCF\r\nCG\r\nCH|de\r\nCI\r\nCK\r\nCL|es\r\nCM\r\nCN|zh-Hant\r\nCO|es\r\nCR|es\r\nCU\r\nCV\r\nCW\r\nCX\r\nCY\r\nCZ|cs\r\nDE|de\r\nDJ\r\nDK|da\r\nDM\r\nDO|es\r\nDZ|ar\r\nEC|es\r\nEE\r\nEG|ar\r\nEH\r\nER\r\nES|es\r\nET\r\nFI|fi\r\nFJ\r\nFK\r\nFM\r\nFO\r\nFR|fr\r\nGA\r\nGB|en-GB\r\nGD\r\nGE\r\nGF\r\nGG\r\nGH\r\nGI\r\nGL\r\nGM\r\nGN\r\nGP\r\nGQ\r\nGR|el\r\nGS\r\nGT|es\r\nGU\r\nGW\r\nGY\r\nHK|zh-HK\r\nHM\r\nHN|es\r\nHR|hr\r\nHT\r\nHU|hu\r\nID|id\r\nIE\r\nIL|he\r\nIM\r\nIN|en-IN\r\nIO\r\nIQ|ar\r\nIR\r\nIS\r\nIT|it\r\nJE\r\nJM\r\nJO|ar\r\nJP|ja\r\nKE|en\r\nKG\r\nKH\r\nKI\r\nKM\r\nKN\r\nKP\r\nKR|ko\r\nKW|ar\r\nKY\r\nKZ\r\nLA\r\nLB|ar\r\nLC\r\nLI\r\nLK\r\nLR\r\nLS\r\nLT\r\nLU|fr\r\nLV\r\nLY\r\nMA|ar\r\nMC|fr\r\nMD\r\nME\r\nMF\r\nMG\r\nMH\r\nMK\r\nML\r\nMM\r\nMN\r\nMO|zh-Hant\r\nMP\r\nMQ\r\nMR\r\nMS\r\nMT\r\nMU\r\nMV\r\nMW\r\nMX|es-MX\r\nMY|ms\r\nMZ\r\nNA\r\nNC\r\nNE\r\nNF\r\nNG\r\nNI|es\r\nNL|nl\r\nNO|nb\r\nNP\r\nNR\r\nNU\r\nNZ\r\nOM|ar\r\nPA|es\r\nPE|es\r\nPF\r\nPG\r\nPH\r\nPK\r\nPL|pl\r\nPM\r\nPN\r\nPR|es\r\nPS\r\nPT|pt\r\nPW\r\nPY|es\r\nQA|ar\r\nRE\r\nRO|ro\r\nRS\r\nRU|ru\r\nRW\r\nSA|ar\r\nSB\r\nSC\r\nSD\r\nSE|sv\r\nSG|zh-Hant\r\nSH\r\nSI\r\nSJ\r\nSK|sk\r\nSL\r\nSM\r\nSN\r\nSO\r\nSR\r\nSS\r\nST\r\nSV|es\r\nSX\r\nSY|ar\r\nSZ\r\nTC\r\nTD\r\nTF\r\nTG\r\nTH|th\r\nTJ\r\nTK\r\nTL\r\nTM\r\nTN|ar\r\nTO\r\nTR|tr\r\nTT\r\nTV\r\nTW|zh-Hant\r\nTZ\r\nUA|uk\r\nUG\r\nUM\r\nUS|en\r\nUY|es\r\nUZ\r\nVA\r\nVC\r\nVE|es\r\nVG\r\nVI\r\nVN|vi\r\nVU\r\nWF\r\nWS\r\nYE|ar\r\nYT\r\nZA|ar\r\nZM\r\nZW";
      string[] separator = new string[1]{ "\r\n" };
      int num = 0;
      foreach (string str2 in str1.Split(separator, (StringSplitOptions) num))
      {
        try
        {
          string[] strArray = str2.Split(new string[1]
          {
            "|"
          }, StringSplitOptions.None);
          RegionInfo regionInfo = new RegionInfo(strArray[0]);
          countrycodeiOS countrycodeiOs = new countrycodeiOS()
          {
            countrycode = strArray[0],
            countryname = regionInfo.EnglishName
          };
          countrycodeiOs.languageCode = ((IEnumerable<string>) strArray).Count<string>() == 1 ? "en" : strArray[1];
          countrycodeiOs.currency = regionInfo.ISOCurrencySymbol;
          FakeInfoCore.listcountrycodeiOS.Add(countrycodeiOs);
        }
        catch (Exception ex)
        {
        }
      }
    }

    private void LoadIME()
    {
      frmMain.ListIME.Clear();
      foreach (string readAllLine in System.IO.File.ReadAllLines(GlobalConfig.executableDirectory() + "\\IMEbylee.list"))
      {
        string str1 = Split.tachchuoi(readAllLine, "|")[0];
        string str2 = Split.tachchuoi(readAllLine, "|")[1];
        frmMain.ListIME.Add(new IME()
        {
          ime = str1,
          serial = str2
        });
      }
    }

    private void reloadOffers()
    {
      if (this.textBox3.Text != null || this.textBox3.Text != "")
      {
        this.lvAutoLead.Items.Clear();
        ArrayList arrayList = LocalConfig.getCurrentConfig().allOffers();
        if (arrayList == null)
          return;
        Array array = (Array) arrayList.ToArray();
        for (int index = 0; index < array.Length; ++index)
        {
          Dictionary<string, object> dictionary = (Dictionary<string, object>) array.GetValue(index);
          if (dictionary["app"].ToString().ToLower().IndexOf(this.textBox3.Text.ToLower()) >= 0)
          {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Checked = Convert.ToBoolean(dictionary["enable"]);
            listViewItem.SubItems.Add((index + 1).ToString() + "-" + dictionary["name"].ToString());
            listViewItem.SubItems.Add(dictionary["url"].ToString());
            if (dictionary.ContainsKey("app") && dictionary["app"] != null)
            {
              string text = GlobalConfig.stringSplit(dictionary["app"].ToString())[0];
              listViewItem.SubItems.Add(text);
            }
            else
            {
              dictionary["app"] = (object) "Unknown App | unknown.app.id";
              string text = GlobalConfig.stringSplit(dictionary["app"].ToString())[0];
              listViewItem.SubItems.Add(text);
            }
            listViewItem.SubItems.Add(Convert.ToInt32(dictionary["appTime"]).ToString() + " s");
            if (Convert.ToBoolean(dictionary["random"]))
              listViewItem.SubItems.Add(dictionary["asMin"].ToString() + " - " + dictionary["asMax"] + " s");
            else
              listViewItem.SubItems.Add(dictionary["asTime"].ToString() + " s");
            bool boolean1 = Convert.ToBoolean(dictionary["useURLScript"]);
            bool boolean2 = Convert.ToBoolean(dictionary["useScript"]);
            listViewItem.SubItems.Add(boolean1 ? "Yes" : "No");
            listViewItem.SubItems.Add(boolean2 ? "Yes" : "No");
            this.lvAutoLead.Items.Add(listViewItem);
          }
        }
      }
      else
      {
        this.lvAutoLead.Items.Clear();
        ArrayList arrayList = LocalConfig.getCurrentConfig().allOffers();
        if (arrayList != null)
        {
          Array array = (Array) arrayList.ToArray();
          for (int index = 0; index < array.Length; ++index)
          {
            Dictionary<string, object> dictionary = (Dictionary<string, object>) array.GetValue(index);
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Checked = Convert.ToBoolean(dictionary["enable"]);
            listViewItem.SubItems.Add((index + 1).ToString() + "-" + dictionary["name"].ToString());
            listViewItem.SubItems.Add(dictionary["url"].ToString());
            if (dictionary.ContainsKey("app") && dictionary["app"] != null)
            {
              string text = GlobalConfig.stringSplit(dictionary["app"].ToString())[0];
              listViewItem.SubItems.Add(text);
            }
            else
            {
              dictionary["app"] = (object) "Unknown App | unknown.app.id";
              string text = GlobalConfig.stringSplit(dictionary["app"].ToString())[0];
              listViewItem.SubItems.Add(text);
            }
            listViewItem.SubItems.Add(Convert.ToInt32(dictionary["appTime"]).ToString() + " s");
            if (Convert.ToBoolean(dictionary["random"]))
              listViewItem.SubItems.Add(dictionary["asMin"].ToString() + " - " + dictionary["asMax"] + " s");
            else
              listViewItem.SubItems.Add(dictionary["asTime"].ToString() + " s");
            bool boolean1 = Convert.ToBoolean(dictionary["useURLScript"]);
            bool boolean2 = Convert.ToBoolean(dictionary["useScript"]);
            listViewItem.SubItems.Add(boolean1 ? "Yes" : "No");
            listViewItem.SubItems.Add(boolean2 ? "Yes" : "No");
            this.lvAutoLead.Items.Add(listViewItem);
          }
        }
      }
    }

    private void disableConnectToDevice(bool disable)
    {
      this.btConnect.Enabled = !disable;
      this.ipcDeviceIP.Enabled = !disable;
      this.cbAutoReconnect.Enabled = !disable;
      this.lbDeviceIP.Enabled = !disable;
    }

        private void connectToDeviceWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            frmMain.ipdv = this.ipcDeviceIP.Text;
            this.btnStart.Invoke(new Action(delegate
            {
                this.lbStatus.Text = "Connecting to " + this.ipcDeviceIP.Text + " ...";
                this.disableConnectToDevice(true);
            }));
            string ip = null;
            string key = null;
            this.ipcDeviceIP.Invoke(new Action(delegate
            {
                frmMain.ipIphone = (ip = this.ipcDeviceIP.Text);
                key = this.tbKeyActivation.Text;
                bool flag6 = key == null || key.Length != 24;
                if (flag6)
                {
                    MessageBox.Show("Invalid or empty license key", "Error", MessageBoxButtons.OK);
                    this.disableConnectToDevice(false);
                }
            }));
            bool flag = key == null || key.Length != 24;
            if (!flag)
            {
                int error = 0;
                string sn = "";
                frmMain.ipreconnect = ip;
                frmMain.keyreconnect = key;
                bool frm = !AutoLeadClient.connect(ip, key, out error, out sn);
                if (frm)
                {
                    this.btnStart.Invoke(new Action(delegate
                    {
                        bool obj = error == -2;
                        if (obj)
                        {
                            this.lbStatus.Text = "";
                            MessageBox.Show("Could not connect to device. License Required [SN: " + sn + "]", "Error", MessageBoxButtons.OK);
                            this.disableConnectToDevice(false);
                        }
                        else
                        {
                            this.lbStatus.Text = "";
                            MessageBox.Show("Could not connect to device. Please check your network settings", "Error", MessageBoxButtons.OK);
                            this.disableConnectToDevice(false);
                        }
                    }));
                }
                else
                {
                    bool connected = AutoLeadClient.connected;
                    if (connected)
                    {
                        Dictionary<string, object> dictionary = new Dictionary<string, object>();
                        dictionary["cmd"] = "device_info";
                        dictionary["signature"] = AutoLeadClientHelper.signature;
                        JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                        bool flag2 = AutoLeadClient.send(javaScriptSerializer.Serialize(dictionary));
                        if (flag2)
                        {
                            string result = AutoLeadClient.receive();
                            bool flag3 = result != null;
                            if (flag3)
                            {
                                JavaScriptSerializer javaScriptSerializer2 = new JavaScriptSerializer();
                                Dictionary<string, object> dictionary2 = javaScriptSerializer2.Deserialize<Dictionary<string, object>>(result);
                                frmMain.exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                                frmMain.serial = dictionary2["serial"].ToString();
                                this.Text = "AutoLead Helper v2.8 | " + frmMain.ipdv + " | " + frmMain.exeDir;
                                this.btnStart.Invoke(new Action(delegate
                                {
                                    this.DownRRSFtp(frmMain.exeDir, frmMain.serial);
                                    this.updateDeviceInfo(result);
                                }));
                            }
                            this.btnStart.Invoke(new Action(delegate
                            {
                                this.lbStatus.Text = "Connected";
                                bool @checked = this.cbAutoReconnect.Checked;
                                Settings.Default["Reconnect"] = @checked;
                                Settings.Default["DeviceIP"] = this.ipcDeviceIP.Text;
                                Settings.Default.Save();
                                this.loadMainUI();
                            }));
                            bool flag4 = AutoLeadClient.send("{\"cmd\":\"apps\"}");
                            if (flag4)
                            {
                                string result2 = AutoLeadClient.receive();
                                bool flag5 = result2 != null;
                                if (flag5)
                                {
                                    this.cbApps.Invoke(new Action(delegate
                                    {
                                        this.updateAppsList(result2);
                                    }));
                                    this.BACKUP_DataiPhone();
                                }
                            }
                        }
                        else
                        {
                            AutoLeadClient.close();
                            this.btnStart.Invoke(new Action(delegate
                            {
                                this.lbStatus.Text = "";
                                MessageBox.Show("Could not connect to device. Please check your network settings", "Error", MessageBoxButtons.OK);
                                this.disableConnectToDevice(false);
                            }));
                        }
                    }
                    else
                    {
                        this.btnStart.Invoke(new Action(delegate
                        {
                            this.lbStatus.Text = "";
                            MessageBox.Show("Could not connect to device. Please check your network settings", "Error", MessageBoxButtons.OK);
                            this.disableConnectToDevice(false);
                        }));
                    }
                }
            }
        }

    internal static void UpRRSFtp()
    {
      string str1 = "ftp://45.76.144.71";
      string path = frmMain.exeDir + "\\" + frmMain.serial + "\\rss.list";
      string str2 = frmMain.serial + "-rss.list";
      string userName = "root";
      string password = "Ntdtttt19955";
      FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(str1 + "/" + str2);
      ftpWebRequest.Method = "STOR";
      ftpWebRequest.Credentials = (ICredentials) new NetworkCredential(userName, password);
      ftpWebRequest.UsePassive = true;
      ftpWebRequest.UseBinary = true;
      ftpWebRequest.KeepAlive = false;
      FileStream fileStream = System.IO.File.OpenRead(path);
      byte[] buffer = new byte[fileStream.Length];
      fileStream.Read(buffer, 0, buffer.Length);
      fileStream.Close();
      Stream requestStream = ftpWebRequest.GetRequestStream();
      requestStream.Write(buffer, 0, buffer.Length);
      requestStream.Close();
      Thread.Sleep(1000);
    }

    private void DownRRSFtp(string exeDir, string serial)
    {
      this.downloadedData = new byte[0];
      string str1 = "ftp://45.76.144.71";
      string str2 = exeDir + "\\" + serial + "\\rss.list";
      string str3 = serial + "-rss.list";
      string userName = "root";
      string password = "Ntdtttt19955";
      try
      {
        System.IO.File.Copy(str2, str2 + "bk");
      }
      catch
      {
      }
      try
      {
        Application.DoEvents();
        FtpWebRequest ftpWebRequest1 = WebRequest.Create(str1 + "/" + str3) as FtpWebRequest;
        Application.DoEvents();
        ftpWebRequest1.Method = "SIZE";
        ftpWebRequest1.Credentials = (ICredentials) new NetworkCredential(userName, password);
        ftpWebRequest1.UsePassive = true;
        ftpWebRequest1.UseBinary = true;
        ftpWebRequest1.KeepAlive = true;
        int contentLength = (int) ftpWebRequest1.GetResponse().ContentLength;
        Application.DoEvents();
        FtpWebRequest ftpWebRequest2 = WebRequest.Create(str1 + "/" + str3) as FtpWebRequest;
        ftpWebRequest2.Method = "RETR";
        ftpWebRequest2.Credentials = (ICredentials) new NetworkCredential(userName, password);
        ftpWebRequest2.UsePassive = true;
        ftpWebRequest2.UseBinary = true;
        ftpWebRequest2.KeepAlive = false;
        this.progressBar1.Value = 0;
        this.progressBar1.Maximum = contentLength;
        FtpWebResponse response = ftpWebRequest2.GetResponse() as FtpWebResponse;
        Stream responseStream = response.GetResponseStream();
        MemoryStream memoryStream = new MemoryStream();
        byte[] buffer = new byte[1024];
        while (true)
        {
          Application.DoEvents();
          int count = responseStream.Read(buffer, 0, buffer.Length);
          if (count != 0)
          {
            memoryStream.Write(buffer, 0, count);
            if (this.progressBar1.Value + count <= this.progressBar1.Maximum)
            {
              this.progressBar1.Value += count;
              this.progressBar1.Refresh();
              Application.DoEvents();
            }
          }
          else
            break;
        }
        this.progressBar1.Value = this.progressBar1.Maximum;
        Application.DoEvents();
        this.downloadedData = memoryStream.ToArray();
        responseStream.Close();
        memoryStream.Close();
        response.Close();
        FileStream fileStream = new FileStream(str2, FileMode.Create);
        fileStream.Write(this.downloadedData, 0, this.downloadedData.Length);
        fileStream.Close();
      }
      catch (Exception ex)
      {
      }
      string empty1 = string.Empty;
      string empty2 = string.Empty;
    }

    internal void Showtext(string op)
    {
      try
      {
        this.lbStatus.Text = op;
      }
      catch (Exception ex)
      {
      }
    }

    private void SendCallBack(IAsyncResult AR)
    {
      try
      {
        this._clientSocket.EndSend(AR);
      }
      catch (Exception ex)
      {
      }
    }

    private void Send(byte[] buffer)
    {
      try
      {
        this._clientSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(this.SendCallBack), (object) null);
      }
      catch (SocketException ex)
      {
      }
      catch (Exception ex)
      {
      }
    }

    private void ConnectDV()
    {
      frmMain.cmd.sendControl = new command.SendControl(this.Send);
      this._clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
      this._clientSocket.BeginConnect((EndPoint) new IPEndPoint(IPAddress.Parse(frmMain.ipIphone), 2409), new AsyncCallback(this.ConnectCallback), (object) null);
    }

    private void ReceiveCallBack(IAsyncResult AR)
    {
      try
      {
        Array.Resize<byte>(ref this._buffer, this._clientSocket.EndReceive(AR));
        string str = Encoding.Unicode.GetString(this._buffer);
        if (str == "")
          return;
        if (str.IndexOf("SPgetSignature") >= 0)
          frmMain.cmdResult.signature = str.Split(new string[1]
          {
            "{||}"
          }, StringSplitOptions.None)[0].Replace("SPgetSignature=", "");
        Array.Resize<byte>(ref this._buffer, this._clientSocket.ReceiveBufferSize);
        this._clientSocket.BeginReceive(this._buffer, 0, this._buffer.Length, SocketFlags.None, new AsyncCallback(this.ReceiveCallBack), (object) null);
      }
      catch (SocketException ex)
      {
      }
      catch (Exception ex)
      {
      }
    }

    private void ConnectCallback(IAsyncResult AR)
    {
        try
        {
            this._clientSocket.EndConnect(AR);
            this._buffer = new byte[this._clientSocket.ReceiveBufferSize];
            this._clientSocket.BeginReceive(this._buffer, 0, this._buffer.Length, SocketFlags.None, new AsyncCallback(this.ReceiveCallBack), null);
            Thread.Sleep(200);
            base.Invoke(new MethodInvoker(delegate
            {
                frmMain.cmd.getproxy();
                frmMain.cmd.getDeviceInfo();
                frmMain.cmd.getAppList();
            }));
        }
        catch (SocketException)
        {
        }
    }

        internal static void WipeOlRRSlee(string namerrs)
    {
      frmMain.Cmdrequest("rm -rf /private/var/mobile/Documents/AutoLead/" + namerrs);
    }

    internal static void RestoreRRS(string namerrs)
    {
      if (!AutoLeadClient.send(Operation.jss.Serialize((object) new Dictionary<string, object>()
      {
        ["cmd"] = (object) nameof (RestoreRRS),
        [nameof (namerrs)] = (object) namerrs
      })))
        return;
      AutoLeadClient.receive();
    }

    internal static void Cmdrequest(string request)
    {
      if (!AutoLeadClient.send(Operation.jss.Serialize((object) new Dictionary<string, object>()
      {
        ["cmd"] = (object) "Commandlinerequest",
        [nameof (request)] = (object) request
      })))
        return;
      AutoLeadClient.receive();
    }

    internal static void BKSP(string namebk, string __g_var_appName, string __g_var_appId)
    {
      if (AutoLeadClient.send(Operation.jss.Serialize((object) new Dictionary<string, object>()
      {
        ["cmd"] = (object) "BKRRS",
        [nameof (namebk)] = (object) namebk
      })))
        AutoLeadClient.receive();
      ArrayList arrayList = LocalConfig.getCurrentConfig().allRSSs();
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      dictionary["ip"] = (object) GlobalConfig.currentPublicIP;
      dictionary["lo"] = (object) GlobalConfig.currentPublicIPWithLocationInfo;
      dictionary["cd"] = (object) DateTime.Now;
      dictionary["md"] = (object) DateTime.Now;
      dictionary["rt"] = (object) 1;
      dictionary["tz"] = (object) frmMain.dictfakeSP["tz"].ToString();
      dictionary["locale"] = (object) frmMain.dictfakeSP["locale"].ToString();
      dictionary["lang"] = (object) frmMain.dictfakeSP["lang"].ToString();
      dictionary["carrier"] = (object) frmMain.dictfakeSP["carrier"].ToString();
      dictionary["mcc"] = (object) frmMain.dictfakeSP["mnc"].ToString();
      dictionary["mnc"] = (object) frmMain.dictfakeSP["mcc"].ToString();
      dictionary["BSSID"] = (object) frmMain.dictfakeSP["BSSID"].ToString();
      dictionary["iso"] = (object) frmMain.dictfakeSP["iso"].ToString();
      dictionary["location_x"] = (object) frmMain.dictfakeSP["location_x"].ToString();
      dictionary["location_y"] = (object) frmMain.dictfakeSP["location_y"].ToString();
      dictionary["name"] = (object) frmMain.dictfakeSP["name"].ToString();
      dictionary["systemVersion"] = (object) frmMain.dictfakeSP["systemVersion"].ToString();
      dictionary["buildversion"] = (object) frmMain.dictfakeSP["buildversion"].ToString();
      dictionary["model"] = (object) frmMain.dictfakeSP["model"].ToString();
      dictionary["machine"] = (object) frmMain.dictfakeSP["machine"].ToString();
      dictionary["ua"] = (object) frmMain.dictfakeSP["ua"].ToString();
      dictionary["serial"] = (object) frmMain.dictfakeSP["serial"].ToString();
      dictionary["imei"] = (object) frmMain.dictfakeSP["imei"].ToString();
      dictionary["modelVersion"] = (object) frmMain.dictfakeSP["modelVersion"].ToString();
      dictionary["ModemVersion"] = (object) frmMain.dictfakeSP["ModemVersion"].ToString();
      try
      {
        dictionary["yearcpr"] = (object) frmMain.dictfakeSP["yearcpr"].ToString();
        dictionary["setfakegeo"] = (object) frmMain.dictfakeSP["setfakegeo"].ToString();
        dictionary["setfakeUa"] = (object) frmMain.dictfakeSP["setfakeUa"].ToString();
        dictionary["setfakescreen"] = (object) frmMain.dictfakeSP["setfakescreen"].ToString();
      }
      catch
      {
      }
      dictionary["fn"] = (object) namebk;
      dictionary["app"] = (object) __g_var_appId;
      dictionary["cm"] = (object) ("Support test " + __g_var_appName);
      dictionary["an"] = (object) __g_var_appName;
      dictionary["ct"] = (object) frmMain.dictfakeSP["locale"].ToString();
      dictionary["to"] = (object) "Vip72";
      dictionary["an"] = (object) __g_var_appName;
      dictionary["ai"] = (object) __g_var_appId;
      dictionary["app"] = (object) __g_var_appId;
      if (GlobalConfig.currentSSH != null)
        dictionary["ssh"] = (object) GlobalConfig.currentSSH;
      arrayList.Add((object) dictionary);
      LocalConfig.getCurrentConfig().saveRSSsList();
    }

    internal static void BKRRS(string namebk, bool boolrrsbk)
    {
      if (AutoLeadClient.send(Operation.jss.Serialize((object) new Dictionary<string, object>()
      {
        ["cmd"] = (object) nameof (BKRRS),
        [nameof (namebk)] = (object) namebk
      })))
        AutoLeadClient.receive();
      if (boolrrsbk)
        return;
      for (int index = 0; index < frmMain.ListVitriBk.Count; ++index)
      {
        if (frmMain.ListVitriBk[index].vitri == frmMain._runLimit)
        {
          ArrayList arrayList = LocalConfig.getCurrentConfig().allRSSs();
          Dictionary<string, object> dictionary = new Dictionary<string, object>();
          dictionary["ip"] = (object) GlobalConfig.currentPublicIP;
          dictionary["lo"] = (object) GlobalConfig.currentPublicIPWithLocationInfo;
          dictionary["cd"] = (object) DateTime.Now;
          dictionary["md"] = (object) DateTime.Now;
          dictionary["rt"] = (object) 1;
          dictionary["tz"] = (object) Operation.dict["tz"].ToString();
          dictionary["locale"] = (object) Operation.dict["locale"].ToString();
          dictionary["lang"] = (object) Operation.dict["lang"].ToString();
          dictionary["carrier"] = (object) Operation.dict["carrier"].ToString();
          dictionary["mnc"] = (object) Operation.dict["mnc"].ToString();
          dictionary["BSSID"] = (object) Operation.dict["BSSID"].ToString();
          dictionary["mcc"] = (object) Operation.dict["mcc"].ToString();
          dictionary["iso"] = (object) Operation.dict["iso"].ToString();
          dictionary["location_x"] = (object) Operation.dict["location_x"].ToString();
          dictionary["location_y"] = (object) Operation.dict["location_y"].ToString();
          dictionary["name"] = (object) Operation.dict["name"].ToString();
          dictionary["systemVersion"] = (object) Operation.dict["systemVersion"].ToString();
          dictionary["buildversion"] = (object) Operation.dict["buildversion"].ToString();
          dictionary["model"] = (object) Operation.dict["model"].ToString();
          dictionary["machine"] = (object) Operation.dict["machine"].ToString();
          dictionary["ua"] = (object) Operation.dict["ua"].ToString();
          dictionary["serial"] = (object) Operation.dict["serial"].ToString();
          dictionary["imei"] = (object) Operation.dict["imei"].ToString();
          dictionary["modelVersion"] = (object) Operation.dict["modelVersion"].ToString();
          dictionary["ModemVersion"] = (object) Operation.dict["ModemVersion"].ToString();
          dictionary["AppleLocale"] = (object) Operation.dict["AppleLocale"].ToString();
          dictionary["AppleLanguages"] = (object) Operation.dict["AppleLanguages"].ToString();
          dictionary["sub"] = (object) frmMain.fullsub;
          try
          {
            dictionary["yearcpr"] = (object) Operation.dict["yearcpr"].ToString();
            dictionary["setfakegeo"] = (object) Operation.dict["setfakegeo"].ToString();
            dictionary["setfakeUa"] = (object) Operation.dict["setfakeUa"].ToString();
            dictionary["setfakescreen"] = (object) Operation.dict["setfakescreen"].ToString();
          }
          catch
          {
          }
          if (frmMain.operation != null)
          {
            dictionary["fn"] = frmMain.operation.userInfo["fn"];
            dictionary["app"] = frmMain.operation.userInfo["ai"];
            dictionary["cm"] = frmMain.operation.userInfo["cm"];
            dictionary["an"] = frmMain.operation.userInfo["an"];
            dictionary["ct"] = frmMain.operation.userInfo["ct"];
            dictionary["to"] = frmMain.operation.userInfo["to"];
          }
          dictionary["an"] = (object) Operation.__g_var_appName;
          dictionary["ai"] = (object) Operation.__g_var_appId;
          dictionary["app"] = (object) Operation.__g_var_appId;
          if (GlobalConfig.currentSSH != null)
            dictionary["ssh"] = (object) GlobalConfig.currentSSH;
          arrayList.Add((object) dictionary);
          LocalConfig.getCurrentConfig().saveRSSsList();
          break;
        }
      }
    }

    private void btnDisconnect_Click(object sender, EventArgs e)
    {
      if (this._runState == -1)
      {
        if (MessageBox.Show("Will disconnect. Please confirm ?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        AutoLeadClient.close();
        this.pnDeviceInfo.Visible = false;
        this.tcMain.TabPages.Clear();
        this.tcMain.TabPages.Add(this.tpContact);
        this.gbProxy.Enabled = false;
        this.disableConnectToDevice(false);
        this.lbStatus.Text = "Disconnected";
        this.sellectoff.Text = "Sellect off : ";
      }
      else
      {
        int num = (int) MessageBox.Show("Please stop/reset current operation first", "Error", MessageBoxButtons.OK);
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      frmAddOffer frmAddOffer = new frmAddOffer();
      ListView.SelectedIndexCollection selectedIndices = this.lvAutoLead.SelectedIndices;
      if (selectedIndices.Count <= 0)
        return;
      int num1 = Convert.ToInt32(Split.tachchuoi(this.lvAutoLead.Items[selectedIndices[0]].SubItems[1].Text, "-")[0]) - 1;
      frmAddOffer.index = num1;
      frmAddOffer.FormClosed += new FormClosedEventHandler(this.frmAddOfferClosed);
      int num2 = (int) frmAddOffer.ShowDialog();
    }

    private void lvAutoLead_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.lvAutoLead.SelectedIndices.Count > 0)
      {
        this.btnEdit.Enabled = true;
        this.btnRemove.Enabled = true;
      }
      else
      {
        this.btnEdit.Enabled = false;
        this.btnRemove.Enabled = false;
      }
    }

    private void lvAutoLead_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      int index = Convert.ToInt32(Split.tachchuoi(this.lvAutoLead.Items[e.Index].SubItems[1].Text, "-")[0]) - 1;
      Dictionary<string, object> dictionary = (Dictionary<string, object>) LocalConfig.getCurrentConfig().allOffers().ToArray().GetValue(index);
      if (dictionary != null)
      {
        dictionary["enable"] = (object) Convert.ToBoolean((object) e.NewValue);
        if (Convert.ToBoolean((object) e.NewValue))
        {
          this.lvAutoLead.Items[e.Index].BackColor = Color.Yellow;
          this.sellectoff.Text = this.sellectoff.Text + "\r\n" + (object) (index + 1) + "-" + dictionary["name"].ToString() + " : " + dictionary["url"].ToString();
        }
        else
        {
          this.lvAutoLead.Items[e.Index].BackColor = Color.White;
          this.sellectoff.Text = this.sellectoff.Text.Replace("\r\n" + (object) (index + 1) + "-" + dictionary["name"].ToString() + " : " + dictionary["url"].ToString(), "");
        }
      }
      LocalConfig.getCurrentConfig().saveOffersList();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("This operation will remove this offer. Please confirm ?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      ListView.SelectedIndexCollection selectedIndices = this.lvAutoLead.SelectedIndices;
      if (selectedIndices.Count > 0)
      {
        LocalConfig.getCurrentConfig().allOffers().RemoveAt(Convert.ToInt32(Split.tachchuoi(this.lvAutoLead.Items[selectedIndices[0]].SubItems[1].Text, "-")[0]) - 1);
        LocalConfig.getCurrentConfig().saveOffersList();
        this.reloadOffers();
      }
    }

    private void btRemoveAll_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("This operation will remove all offers. Please confirm ?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      LocalConfig.getCurrentConfig().allOffers().Clear();
      LocalConfig.getCurrentConfig().saveOffersList();
      this.reloadOffers();
    }

    public void ConnectDeviceAgain()
    {
      int error = 0;
      string serial = (string) null;
      do
        ;
      while (!AutoLeadClient.connect(frmMain.ipreconnect, frmMain.keyreconnect, out error, out serial));
      frmMain.sttconnect = true;
    }

    private void btnOpenURL_Click(object sender, EventArgs e)
    {
      if (!AutoLeadClient.connected)
        return;
      if (AutoLeadClient.send(new JavaScriptSerializer().Serialize((object) new Dictionary<string, object>()
      {
        ["cmd"] = (object) "openURL",
        ["url"] = (object) this.tbURL.Text
      })))
        AutoLeadClient.receive();
    }

    private void btnRecord1_Click(object sender, EventArgs e)
    {
      if (AutoLeadClient.connected)
      {
        frmUE frmUe = new frmUE();
        frmUe.lbText.Text = "Please touch on your device to get Safari(X,Y)";
        frmUe.type = 1;
        int num = (int) frmUe.ShowDialog();
        if (frmUe.result == null)
          return;
        Dictionary<string, object> dictionary = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(frmUe.result);
        if (Convert.ToInt32(dictionary["type"]) >= 0)
        {
          this.tbSafari.Text = Convert.ToDouble(dictionary["x1"]).ToString() + "," + (object) Convert.ToDouble(dictionary["y1"]);
          LocalConfig.getCurrentConfig().setObjectForKey((object) this.tbSafari.Text, "SafariXY");
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Please connect to device first", "Error", MessageBoxButtons.OK);
      }
    }

    private void btnRecord2_Click(object sender, EventArgs e)
    {
      if (AutoLeadClient.connected)
      {
        frmUE frmUe = new frmUE();
        frmUe.lbText.Text = "Please touch on your device to get AppStore(X,Y)";
        frmUe.type = 1;
        int num = (int) frmUe.ShowDialog();
        if (frmUe.result == null)
          return;
        Dictionary<string, object> dictionary = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(frmUe.result);
        if (Convert.ToInt32(dictionary["type"]) >= 0)
        {
          this.tbAppStore.Text = Convert.ToDouble(dictionary["x1"]).ToString() + "," + (object) Convert.ToDouble(dictionary["y1"]);
          LocalConfig.getCurrentConfig().setObjectForKey((object) this.tbAppStore.Text, "AppStoreXY");
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Please connect to device first", "Error", MessageBoxButtons.OK);
      }
    }

    private void tbSafari_TextChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.tbSafari.Text, "SafariXY");
    }

    private void tbAppStore_TextChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.tbAppStore.Text, "AppStoreXY");
    }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            bool FTPAddress = AutoLeadClient.connected;
            if (FTPAddress)
            {
                bool savefile = AutoLeadClient.send("{\"cmd\":\"apps\"}");
                if (savefile)
                {
                    string result = AutoLeadClient.receive();
                    bool username = result != null;
                    if (username)
                    {
                        this.cbApps.Invoke(new Action(delegate
                        {
                            this.updateAppsList(result);
                        }));
                    }
                }
            }
        }

        private void updateAppsList(string list)
    {
      try
      {
        Array array = (Array) ((ArrayList) new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(list)["apps"]).ToArray();
        this.cbApps.Items.Clear();
        for (int index = 0; index < array.Length; ++index)
        {
          Dictionary<string, object> dictionary = (Dictionary<string, object>) array.GetValue(index);
          this.cbApps.Items.Add((object) (dictionary["name"].ToString() + " | " + dictionary["id"]));
          frmMain.ListappInstall.Add(new Listapp()
          {
            app_id = dictionary["id"].ToString(),
            app_name = dictionary["name"].ToString()
          });
        }
        if (array.Length <= 0)
          return;
        this.cbApps.SelectedIndex = 0;
      }
      catch
      {
      }
    }

    private void tbnOpenApp_Click(object sender, EventArgs e)
    {
      if (AutoLeadClient.connected)
      {
        if (this.cbApps.SelectedIndex >= 0)
        {
          if (!AutoLeadClient.send("{\"cmd\":\"open_app\", \"id\":\"" + GlobalConfig.stringSplit(this.cbApps.SelectedItem.ToString())[1] + "\"}"))
            return;
          Console.WriteLine(AutoLeadClient.receive());
        }
        else
        {
          int num1 = (int) MessageBox.Show("Please select an app to open", "Error", MessageBoxButtons.OK);
        }
      }
      else
      {
        int num2 = (int) MessageBox.Show("Please connect to device first", "Error", MessageBoxButtons.OK);
      }
    }

    private void btnHelp_Click(object sender, EventArgs e)
    {
      int num = (int) new frmHelp().ShowDialog();
    }

    private void btnRecordEvent_Click(object sender, EventArgs e)
    {
      frmUEScript frmUeScript = new frmUEScript();
      frmUeScript.lbText.Text = "Recording event ...";
      frmUeScript.type = 0;
      int num = (int) frmUeScript.ShowDialog();
      if (frmUeScript.result == null)
        return;
      this.tbScript.Text += "\r\n;begin autogen script\r\n";
      this.tbScript.Text += frmUeScript.result;
      this.tbScript.Text += ";end autogen script\r\n";
      this.tbScript.Focus();
      this.tbScript.SelectionStart = this.tbScript.Text.Length;
      this.tbScript.ScrollToCaret();
    }

    private void btnSaveScript_Click(object sender, EventArgs e)
    {
      string path = LocalConfig.getCurrentConfig().configDirectory() + "\\Scripts";
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      if (!Directory.Exists(path))
      {
        int num = (int) MessageBox.Show("Could not create directory " + path, "Error", MessageBoxButtons.OK);
      }
      else if (this.rbScriptForApp.Checked)
      {
        string text = this.lvAllScripts.SelectedItems[0].Text;
        string str = GlobalConfig.stringSplit(this.cbApps.SelectedItem.ToString())[0];
        System.IO.File.WriteAllText(path + "\\" + str, this.tbScript.Text);
        this.btnSaveScript.Enabled = false;
        if (!text.Equals(str))
          System.IO.File.Delete(path + "\\" + text);
        this.reloadAllScripts();
        for (int itemIndex = 0; itemIndex < this.lvAllScripts.Items.Count; ++itemIndex)
        {
          if (this.lvAllScripts.Items[itemIndex].Text.Equals(str))
          {
            this.lvAllScripts.SelectedIndices.Clear();
            this.lvAllScripts.SelectedIndices.Add(itemIndex);
            break;
          }
        }
      }
      else
      {
        string text1 = this.lvAllScripts.SelectedItems[0].Text;
        string text2 = this.tbScriptName.Text;
        System.IO.File.WriteAllText(path + "\\" + text2, this.tbScript.Text);
        this.btnSaveScript.Enabled = false;
        if (!text1.Equals(text2))
          System.IO.File.Delete(path + "\\" + text1);
        this.reloadAllScripts();
        for (int itemIndex = 0; itemIndex < this.lvAllScripts.Items.Count; ++itemIndex)
        {
          if (this.lvAllScripts.Items[itemIndex].Text.Equals(text2))
          {
            this.lvAllScripts.SelectedIndices.Clear();
            this.lvAllScripts.SelectedIndices.Add(itemIndex);
            break;
          }
        }
      }
    }

    private void tbScript_TextChanged(object sender, EventArgs e)
    {
      this.btnSaveScript.Enabled = true;
    }

    private void reloadAllScripts()
    {
      string stringForKey = LocalConfig.getCurrentConfig().getStringForKey("SelectedScriptForRSS");
      string path = LocalConfig.getCurrentConfig().configDirectory() + "\\Scripts";
      if (!Directory.Exists(path))
        return;
      string[] files = Directory.GetFiles(path);
      if (files != null)
      {
        this.lvAllScripts.Items.Clear();
        this.cbScriptList.Items.Clear();
        this.cboscript_openurl.Items.Clear();
        Array.Sort<string>(files, (IComparer<string>) StringComparer.InvariantCultureIgnoreCase);
        for (int index = 0; index < files.Length; ++index)
        {
          string fileName = Path.GetFileName(files[index]);
          this.lvAllScripts.Items.Add(new ListViewItem()
          {
            Text = fileName
          });
          this.cbScriptList.Items.Add((object) fileName);
          this.cboscript_openurl.Items.Add((object) fileName);
          if (stringForKey.Length > 0 && stringForKey.Equals(fileName))
            this.cbScriptList.SelectedIndex = index;
        }
      }
    }

    private void tbScriptName_TextChanged(object sender, EventArgs e)
    {
      this.btnSaveScript.Enabled = true;
    }

    private void cbApps_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.btnSaveScript.Enabled = true;
    }

    private void lvAllScripts_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.btnSaveScript.Enabled && this.previousSelectedScriptName != null)
      {
        if (MessageBox.Show("Do you want to save changes ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          string path = LocalConfig.getCurrentConfig().configDirectory() + "\\Scripts";
          if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
          if (!Directory.Exists(path))
          {
            int num = (int) MessageBox.Show("Could not create directory " + path, "Error", MessageBoxButtons.OK);
          }
          else if (this.rbScriptForApp.Checked)
          {
            string str1 = this.previousSelectedScriptName;
            string str2 = GlobalConfig.stringSplit(this.cbApps.SelectedItem.ToString())[0];
            System.IO.File.WriteAllText(path + "\\" + str2, this.tbScript.Text);
            this.btnSaveScript.Enabled = false;
            if (!str1.Equals(str2))
            {
              System.IO.File.Delete(path + "\\" + str1);
              str1 = str2;
            }
            for (int index = 0; index < this.lvAllScripts.Items.Count; ++index)
            {
              ListViewItem listViewItem = this.lvAllScripts.Items[index];
              if (listViewItem.Text.Equals(this.previousSelectedScriptName))
                listViewItem.Text = str1;
            }
          }
          else
          {
            string str = this.previousSelectedScriptName;
            string text = this.tbScriptName.Text;
            System.IO.File.WriteAllText(path + "\\" + text, this.tbScript.Text);
            this.btnSaveScript.Enabled = false;
            if (!str.Equals(text))
            {
              System.IO.File.Delete(path + "\\" + str);
              str = text;
            }
            for (int index = 0; index < this.lvAllScripts.Items.Count; ++index)
            {
              ListViewItem listViewItem = this.lvAllScripts.Items[index];
              if (listViewItem.Text.Equals(this.previousSelectedScriptName))
                listViewItem.Text = str;
            }
          }
        }
        this.btnSaveScript.Enabled = false;
      }
      this.previousSelectedScriptName = (string) null;
      this.btnDeleteScript.Enabled = true;
      if (this.lvAllScripts.SelectedIndices.Count > 0)
      {
        ListViewItem selectedItem = this.lvAllScripts.SelectedItems[0];
        this.previousSelectedScriptName = selectedItem.Text;
        string path = LocalConfig.getCurrentConfig().configDirectory() + "\\Scripts" + "\\" + selectedItem.Text;
        this.tbScript.Text = System.IO.File.ReadAllText(path);
        string fileName = Path.GetFileName(path);
        bool flag = false;
        for (int index = 0; index < this.cbApps.Items.Count; ++index)
        {
          if (GlobalConfig.stringSplit(this.cbApps.Items[index].ToString())[0].Equals(fileName))
          {
            this.rbScriptForApp.Checked = true;
            this.cbApps.SelectedIndex = index;
            flag = true;
            break;
          }
        }
        if (!flag)
        {
          this.tbScriptName.Text = fileName;
          this.rbCustomScript.Checked = true;
        }
        this.gbScript.Enabled = true;
        this.btnSaveScript.Enabled = false;
      }
      else
      {
        this.gbScript.Enabled = false;
        this.rbScriptForApp.Checked = true;
        this.tbScript.Text = "";
        this.tbScriptName.Text = "";
        this.btnSaveScript.Enabled = false;
        this.btnDeleteScript.Enabled = false;
      }
    }

    private void btnDeleteScript_Click(object sender, EventArgs e)
    {
      if (this.lvAllScripts.SelectedIndices.Count <= 0)
        return;
      int itemIndex = this.lvAllScripts.SelectedIndices[0];
      System.IO.File.Delete(LocalConfig.getCurrentConfig().configDirectory() + "\\Scripts" + "\\" + this.lvAllScripts.SelectedItems[0].Text);
      this.reloadAllScripts();
      if (this.lvAllScripts.Items.Count > 0)
      {
        if (itemIndex > this.lvAllScripts.Items.Count - 1)
          itemIndex = this.lvAllScripts.Items.Count - 1;
        this.lvAllScripts.SelectedIndices.Clear();
        this.lvAllScripts.SelectedIndices.Add(itemIndex);
      }
      else
      {
        this.gbScript.Enabled = false;
        this.tbScript.Text = "";
        this.tbScriptName.Text = "";
        this.rbScriptForApp.Checked = true;
      }
    }

    private void btnAddScript_Click(object sender, EventArgs e)
    {
      string path1 = LocalConfig.getCurrentConfig().configDirectory() + "\\Scripts";
      if (!Directory.Exists(path1))
        Directory.CreateDirectory(path1);
      if (!Directory.Exists(path1))
      {
        int num1 = (int) MessageBox.Show("Could not create directory " + path1, "Error", MessageBoxButtons.OK);
      }
      else
      {
        string str = "New Script";
        string path2 = path1 + "\\" + str;
        int num2 = 1;
        while (System.IO.File.Exists(path2))
        {
          path2 = path1 + "\\" + str + " " + (object) num2;
          ++num2;
        }
        string fileName = Path.GetFileName(path2);
        System.IO.File.WriteAllText(path2, "");
        this.btnSaveScript.Enabled = true;
        this.reloadAllScripts();
        for (int itemIndex = 0; itemIndex < this.lvAllScripts.Items.Count; ++itemIndex)
        {
          if (this.lvAllScripts.Items[itemIndex].Text.Equals(fileName))
          {
            this.lvAllScripts.SelectedIndices.Clear();
            this.lvAllScripts.SelectedIndices.Add(itemIndex);
            break;
          }
        }
        this.btnSaveScript.Enabled = false;
      }
    }

    private void rbScriptForApp_CheckedChanged(object sender, EventArgs e)
    {
      this.btnSaveScript.Enabled = true;
    }

    private void rbCustomScript_CheckedChanged(object sender, EventArgs e)
    {
      this.btnSaveScript.Enabled = true;
    }

    private void btnTestScript_Click(object sender, EventArgs e)
    {
      frmMain.patchfileMail = this.txtfileMail.Text;
      frmMain.ScriptListRep.Clear();
      if (AutoLeadClient.connected)
      {
        int num1 = (int) new frmTestScript()
        {
          scripts = this.tbScript.Text
        }.ShowDialog();
      }
      else
      {
        int num2 = (int) MessageBox.Show("Please connect to device first", "Error", MessageBoxButtons.OK);
      }
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      frmMain.bool_startloop = false;
      frmMain.patchfileMail = this.txtfileMail.Text;
      frmMain.bool_nextstep = true;
      frmMain.bool_chkonly10_3_1 = this.chkonly10_3_1.Checked;
      frmMain.bool_loopip = this.chkloopip.Checked;
      frmMain.bool_usingchrome = this.usingchrome.Checked;
      frmMain.bool_sub = this.chksub.Checked;
      frmMain.bool_chkmailfile = this.chkmailfile.Checked;
      frmMain.bool_onlymail = this.chkonlymail.Checked;
      frmMain.bool_iphone7 = this.checkiPhone7.Checked;
      frmMain.bool_detectapp = this.chkdetectapp.Checked;
      if (this.cbFakeLang.Checked)
      {
        frmMain.bool_fakelangnoIP = true;
        frmMain.langnoIP = this.combFakeLang.Text;
      }
      else
        frmMain.bool_fakelangnoIP = false;
      frmMain.bool_fakeUA = this.chkfakeUA.Checked;
      frmMain.bool_fakecoresystem = this.chkfakecoresystem.Checked;
      frmMain.bool_fakegeo = this.chkfakeGeo.Checked;
      frmMain.bool_sml = this.chkrunsml.Checked;
      frmMain.bool_checkRunAppstore = this.cbcheckrunappstore.Checked;
      frmMain.bool_fakescreen = this.chkfakescreen.Checked;
      if (this.cbSafari.Checked)
      {
        frmMain.bool_TouchSF = true;
        string[] strArray = Split.tachchuoi(this.tbSafari.Text, ",");
        frmMain.Xsf = strArray[0];
        frmMain.Ysf = strArray[1];
      }
      else
        frmMain.bool_TouchSF = false;
      if (this.cbAppStore.Checked)
      {
        string[] strArray = Split.tachchuoi(this.tbAppStore.Text, ",");
        frmMain.Xapp = strArray[0];
        frmMain.Yapp = strArray[1];
      }
      this.UpdateRunVip();
      if (this._runState == -1 || this._runState == 0)
      {
        if (this._runState == -1)
          frmMain._runLimit = Convert.ToInt32(this.numRunLimit.Value);
        this.btnStart.Text = "PAUSE";
        this.bwLead.RunWorkerAsync();
        this.btnReset.Enabled = true;
      }
      else
      {
        if (this._runState != 1 || this._bwLeadThread == null)
          return;
        this.btnStart.Text = "RESUME";
        this._bwLeadThread.Abort();
      }
    }

    private void UpdateRunVip()
    {
      this.ListUseVip.Clear();
      Array array = (Array) LocalConfig.getCurrentConfig().allVip72s().ToArray();
      if (array == null)
        return;
      for (int index = 0; index < array.Length; ++index)
      {
        Dictionary<string, object> dictionary = (Dictionary<string, object>) array.GetValue(index);
        dictionary["status"].ToString();
        try
        {
          this.ListUseVip.Add(new vipuse()
          {
            uname = dictionary["username"].ToString(),
            passs = dictionary["password"].ToString(),
            stt = dictionary["status"].ToString(),
            token = dictionary["token"].ToString()
          });
        }
        catch
        {
        }
      }
    }

    private void btnAddVip72_Click(object sender, EventArgs e)
    {
      if (this.tbVip72ID.Text == null || this.tbVip72Password.Text == null || this.token.Text == null)
        return;
      string str = this.cbostt.Text == "Yes" ? "1" : "0";
      string path = LocalConfig.getCurrentConfig().configDirectory() + "/vip72accounts.list";
      ArrayList arrayList = LocalConfig.getCurrentConfig().allVip72s();
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      dictionary["username"] = (object) this.tbVip72ID.Text;
      dictionary["password"] = (object) this.tbVip72Password.Text;
      dictionary["status"] = (object) str;
      dictionary["token"] = (object) this.token.Text;
      if (arrayList == null)
        arrayList = new ArrayList();
      arrayList.Add((object) dictionary);
      string contents = new JavaScriptSerializer().Serialize((object) arrayList);
      System.IO.File.WriteAllText(path, contents);
      this.updateVip72List();
    }

    private void updateVip72List()
    {
      this.UpdateRunVip();
      ArrayList arrayList = LocalConfig.getCurrentConfig().allVip72s();
      if (arrayList == null)
        return;
      this.lvVip72.Items.Clear();
      Array array = (Array) arrayList.ToArray();
      for (int index = 0; index < array.Length; ++index)
      {
        Dictionary<string, object> dictionary = (Dictionary<string, object>) array.GetValue(index);
        ListViewItem listViewItem = new ListViewItem();
        listViewItem.Text = dictionary["username"].ToString();
        listViewItem.SubItems.Add(dictionary["password"].ToString());
        if (dictionary.ContainsKey("status"))
          listViewItem.SubItems.Add(dictionary["status"].ToString());
        else
          listViewItem.SubItems.Add("");
        this.lvVip72.Items.Add(listViewItem);
      }
    }

    private void lvVip72_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.lvVip72.SelectedIndices.Count > 0)
      {
        this.btnDeleteVip72.Enabled = true;
        this.btnCheckVip72.Enabled = true;
        Dictionary<string, object> allVip72 = (Dictionary<string, object>) LocalConfig.getCurrentConfig().allVip72s()[this.lvVip72.SelectedIndices[0]];
        this.tbVip72ID.Text = allVip72["username"].ToString();
        this.tbVip72Password.Text = allVip72["password"].ToString();
        this.token.Text = allVip72["token"].ToString();
        this.cbostt.Text = allVip72["status"].ToString() == "1" ? "Yes" : "No";
      }
      else
      {
        this.btnCheckVip72.Enabled = false;
        this.btnDeleteVip72.Enabled = false;
        this.tbVip72ID.Clear();
        this.tbVip72Password.Clear();
        this.token.Clear();
      }
    }

    private void btnDeleteVip72_Click(object sender, EventArgs e)
    {
      if (this.lvVip72.SelectedIndices.Count <= 0 || MessageBox.Show("Will delete selected Vip72 account. please confirm ?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      string path = LocalConfig.getCurrentConfig().configDirectory() + "/vip72accounts.list";
      int num = this.lvVip72.SelectedIndices[0];
      ArrayList arrayList = LocalConfig.getCurrentConfig().allVip72s();
      arrayList.RemoveAt(num);
      string contents = new JavaScriptSerializer().Serialize((object) arrayList);
      System.IO.File.WriteAllText(path, contents);
      this.updateVip72List();
      if (arrayList.Count > 0)
      {
        if (num >= arrayList.Count)
          num = arrayList.Count - 1;
        this.lvVip72.SelectedIndices.Add(num);
      }
    }

    private void btnCheckVip72_Click(object sender, EventArgs e)
    {
      if (this.lvVip72.SelectedIndices.Count <= 0)
        return;
      int index = this.lvVip72.SelectedIndices[0];
      Dictionary<string, object> allVip72 = (Dictionary<string, object>) LocalConfig.getCurrentConfig().allVip72s()[index];
      Process[] processesByName = Process.GetProcessesByName("vip72socks");
      IntPtr handle = new IntPtr(-1);
      if ((uint) processesByName.Length > 0U)
        processesByName[0].Kill();
      string str1 = allVip72["username"].ToString();
      string str2 = allVip72["password"].ToString();
      Process process = Process.Start(new ProcessStartInfo()
      {
        WorkingDirectory = GlobalConfig.executableDirectory() + "/Tools/vip72socks",
        FileName = GlobalConfig.executableDirectory() + "/Tools/vip72socks/vip72socks.exe",
        Arguments = "-login;" + str1 + ":" + str2 + ";"
      });
      while (handle.ToInt32() <= 0)
      {
        handle = process.MainWindowHandle;
        Thread.Sleep(200);
      }
      Console.WriteLine((object) handle);
      Vip72Handle vip72Handle = new Vip72Handle(handle);
      Thread.Sleep(200);
      vip72Handle.SendLeftClickToWindow(Vip72Handle.Vip72Window.Login);
      bool flag = false;
      string str3 = (string) null;
      while (!flag)
      {
        IntPtr windowHandle = vip72Handle.GetWindowHandle(Vip72Handle.Vip72Window.Status);
        if (windowHandle.ToInt32() > 0)
        {
          string controlText = Vip72Handle.GetControlText(windowHandle);
          if (controlText.Length > 0)
          {
            if (controlText.Contains("ERROR") || controlText.Contains("DISCONNECT"))
            {
              str3 = controlText;
              flag = true;
              vip72Handle.SendLeftClickToWindow(Vip72Handle.Vip72Window.Exit);
            }
            else if (controlText.Contains("ready"))
            {
              str3 = Vip72Handle.GetControlText(vip72Handle.GetWindowHandle(Vip72Handle.Vip72Window.Info));
              flag = true;
              vip72Handle.SendLeftClickToWindow(Vip72Handle.Vip72Window.Exit);
            }
          }
          Thread.Sleep(200);
        }
        else
          flag = true;
      }
      if (str3 != null)
      {
        this.lvVip72.Items[index].SubItems[1].Text = str3;
        ArrayList arrayList = LocalConfig.getCurrentConfig().allVip72s();
        ((Dictionary<string, object>) arrayList.ToArray().GetValue(index))["status"] = (object) "1";
        System.IO.File.WriteAllText(LocalConfig.getCurrentConfig().configDirectory() + "/vip72accounts.list", new JavaScriptSerializer().Serialize((object) arrayList));
        this.updateVip72List();
        if (arrayList.Count > 0)
        {
          if (index >= arrayList.Count)
            index = arrayList.Count - 1;
          this.lvVip72.SelectedIndices.Add(index);
        }
      }
    }

    private void reloadSSHListInfo()
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      ArrayList arrayList = LocalConfig.getCurrentConfig().allSSHs();
      if (arrayList != null)
      {
        Array array = (Array) arrayList.ToArray();
        for (int index = 0; index < array.Length; ++index)
        {
          Dictionary<string, object> dictionary = (Dictionary<string, object>) array.GetValue(index);
          if (dictionary.ContainsKey("status"))
          {
            if (Convert.ToInt32(dictionary["status"]) == 0)
              ++num2;
            else
              ++num1;
          }
          else
            ++num4;
          if (dictionary.ContainsKey("used") && Convert.ToInt32(dictionary["used"]) == 0)
            ++num3;
        }
      }
      this.lbTotalSSH.Text = "Total SSH : " + (object) this.lvSSH.Items.Count;
      this.lbUnCheck.Text = "Unchecked : " + (object) num4;
      this.lbLive.Text = "Live : " + (object) num1;
      this.lbDead.Text = "Dead : " + (object) num2;
      this.lbLive.Tag = (object) num1;
      this.lbDead.Tag = (object) num2;
      this.lbUnCheck.Tag = (object) num4;
    }

    private void reloadCountriesList()
    {
      this.cbTool.SelectedItem = (object) LocalConfig.getCurrentConfig().getStringForKey("ProxyTool");
      if (this.cbTool.Text.Equals("SSH"))
      {
        ArrayList arrayList = LocalConfig.getCurrentConfig().allSSHs();
        List<string> stringList = new List<string>();
        for (int index = 0; index < arrayList.Count; ++index)
        {
          Dictionary<string, object> dictionary = (Dictionary<string, object>) arrayList[index];
          string str = dictionary["country"].ToString();
          if (dictionary.ContainsKey("status") && Convert.ToInt32(dictionary["status"]) == 1)
          {
            if (!stringList.Contains(str))
              stringList.Add(str.ToUpper());
          }
          else if (!dictionary.ContainsKey("status") && !stringList.Contains(str))
            stringList.Add(str.ToUpper());
        }
        this.cbCountries.Items.Clear();
        if (GlobalConfig.executableDirectory() != null)
        {
          string[] strArray = Split.tachchuoi(ResourceList.Countries, "\r\n");
          for (int index = 0; index < strArray.Length; ++index)
          {
            string str = GlobalConfig.stringSplit(strArray[index])[0];
            if (stringList.Contains(str))
            {
              this.cbCountries.Items.Add((object) strArray[index]);
              if (str.Equals(LocalConfig.getCurrentConfig().getStringForKey("Country")))
                this.cbCountries.SelectedIndex = this.cbCountries.Items.Count - 1;
            }
          }
        }
        if (this.cbCountries.Items.Count <= 0 || this.cbCountries.SelectedIndex > 0 && this.cbCountries.SelectedIndex < this.cbCountries.Items.Count)
          return;
        this.cbCountries.SelectedIndex = 0;
      }
      else if (GlobalConfig.executableDirectory() != null)
      {
        string[] strArray = Split.tachchuoi(ResourceList.Countries, "\r\n");
        this.cbCountries.Items.Clear();
        this.cbCountries.Items.AddRange((object[]) strArray);
        this.cbTool.SelectedItem = (object) LocalConfig.getCurrentConfig().getStringForKey("ProxyTool");
        for (int index = 0; index < strArray.Length; ++index)
        {
          if (GlobalConfig.stringSplit(strArray[index])[0].Equals(LocalConfig.getCurrentConfig().getStringForKey("Country")))
          {
            this.cbCountries.SelectedIndex = index;
            break;
          }
        }
      }
    }

    private void reloadSSHsList()
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      ArrayList arrayList = LocalConfig.getCurrentConfig().allSSHs();
      if (arrayList != null)
      {
        Array array = (Array) arrayList.ToArray();
        this.lvSSH.Items.Clear();
        for (int index = 0; index < array.Length; ++index)
        {
          Dictionary<string, object> dictionary = (Dictionary<string, object>) array.GetValue(index);
          string str = GlobalConfig.stringSplit(this.cbCountries.Text)[0];
          ListViewItem listViewItem = new ListViewItem();
          listViewItem.Text = dictionary["host"].ToString();
          listViewItem.SubItems.Add(dictionary["port"].ToString());
          listViewItem.SubItems.Add(dictionary["username"].ToString());
          listViewItem.SubItems.Add(dictionary["password"].ToString());
          if (dictionary.ContainsKey("country"))
            listViewItem.SubItems.Add(dictionary["country"].ToString());
          if (dictionary.ContainsKey("region"))
            listViewItem.SubItems.Add(dictionary["region"].ToString());
          if (dictionary.ContainsKey("status"))
          {
            if (Convert.ToInt32(dictionary["status"]) == 0)
            {
              ++num2;
              listViewItem.BackColor = Color.Red;
            }
            else
            {
              ++num1;
              listViewItem.BackColor = Color.Green;
            }
          }
          else
          {
            ++num4;
            listViewItem.BackColor = Color.White;
          }
          if (dictionary.ContainsKey("used") && Convert.ToBoolean(dictionary["used"]))
          {
            ++num3;
            listViewItem.BackColor = Color.Blue;
          }
          this.lvSSH.Items.Add(listViewItem);
        }
      }
      this.lbTotalSSH.Text = "Total SSH : " + (object) this.lvSSH.Items.Count;
      this.lbUnCheck.Text = "Unchecked : " + (object) num4;
      this.lbLive.Text = "Live : " + (object) num1;
      this.lbDead.Text = "Dead : " + (object) num2;
      this.lbUsed.Text = "Used : " + (object) num3;
      this.lbLive.Tag = (object) num1;
      this.lbDead.Tag = (object) num2;
      this.lbUnCheck.Tag = (object) num4;
      this.lbUsed.Tag = (object) num3;
    }

    private void btnImportSSHFromFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      int num = (int) new frmSSHImport()
      {
        filePath = openFileDialog.FileName
      }.ShowDialog();
      this.reloadSSHsList();
      this.reloadCountriesList();
    }

    private void sshImport_DoWork(object sender, DoWorkEventArgs e)
    {
    }

    private void deleteSelected(ListView lisView)
    {
      int num = this.lvSSH.SelectedIndices[0];
      ArrayList arrayList = LocalConfig.getCurrentConfig().allSSHs();
      int index1 = -1;
      for (int index2 = 0; index2 < arrayList.Count; ++index2)
      {
        Dictionary<string, object> dictionary = (Dictionary<string, object>) arrayList[index2];
        ++index1;
        if (index1 == num)
        {
          index1 = index2;
          break;
        }
      }
      if (index1 < arrayList.Count && index1 >= 0)
      {
        arrayList.RemoveAt(index1);
        this.lvSSH.Items.RemoveAt(num);
        LocalConfig.getCurrentConfig().saveSSHsList();
        if (this.lvSSH.Items.Count > 0)
        {
          if (num >= this.lvSSH.Items.Count)
            num = this.lvSSH.Items.Count - 1;
          this.lvSSH.SelectedIndices.Add(num);
        }
      }
      this.reloadSSHListInfo();
    }

    private void deleteAll(ListView lisView)
    {
      ArrayList arrayList = LocalConfig.getCurrentConfig().allSSHs();
      for (int index = arrayList.Count - 1; index >= 0; --index)
      {
        Dictionary<string, object> dictionary = (Dictionary<string, object>) arrayList[index];
        arrayList.RemoveAt(index);
      }
      LocalConfig.getCurrentConfig().saveSSHsList();
      this.reloadSSHsList();
    }

    private void btnDeleteSSH_Click(object sender, EventArgs e)
    {
      this.deleteSelected(this.lvSSH);
      this.reloadCountriesList();
    }

    private void btnDeleteAll_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Will delete all items. Please confirm ?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      this.deleteAll(this.lvSSH);
      this.reloadCountriesList();
    }

    private void btnRefreshSSH_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Will freresh. Please confirm ?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      ArrayList arrayList = LocalConfig.getCurrentConfig().allSSHs();
      for (int index = 0; index < arrayList.Count; ++index)
      {
        string str = GlobalConfig.stringSplit(this.cbCountries.Text)[0];
        Dictionary<string, object> dictionary = (Dictionary<string, object>) arrayList[index];
        dictionary.Remove("status");
        dictionary.Remove("used");
      }
      LocalConfig.getCurrentConfig().saveSSHsList();
      LocalConfig.getCurrentConfig().refreshLiveSSHs();
      this.reloadSSHsList();
      this.reloadCountriesList();
    }

    private void btnCheckLive_Click(object sender, EventArgs e)
    {
      if (this.btnCheckLive.Text.Equals("Stop"))
      {
        this.btnCheckLive.Text = "Check live";
        this.lbCheckLiveStatus.Text = "Stopped";
        this.btnDeleteAll.Enabled = true;
        this.btnDeleteSSH.Enabled = true;
        this.btnCheckLive.Enabled = true;
        this.btnRefreshSSH.Enabled = true;
        this.btnDeleteDead.Enabled = true;
        this.numThreadCount.Enabled = true;
        this.btnImportSSHFromCB.Enabled = true;
        this.btnImportSSHFromFile.Enabled = true;
        this.lbCheckLiveStatus.Text = "Done";
        SSHTest.stopTestSSHConnections();
        this.reloadCountriesList();
      }
      else
      {
        int int32 = Convert.ToInt32(this.numThreadCount.Value);
        int count = 0;
        this.btnDeleteAll.Enabled = false;
        this.btnDeleteSSH.Enabled = false;
        this.btnRefreshSSH.Enabled = false;
        this.btnDeleteDead.Enabled = false;
        this.numThreadCount.Enabled = false;
        this.btnImportSSHFromCB.Enabled = false;
        this.btnImportSSHFromFile.Enabled = false;
        this.lbCheckLiveStatus.Text = "Checking ...";
        this.btnCheckLive.Text = "Stop";
        JavaScriptSerializer scriptSerializer = new JavaScriptSerializer();
        ArrayList list = LocalConfig.getCurrentConfig().allSSHs();
        int n = 0;
        Array array = (Array) list.ToArray();
        ArrayList arrayList = new ArrayList();
        for (int index = 0; index < array.Length; ++index)
        {
          Dictionary<string, object> dictionary = (Dictionary<string, object>) array.GetValue(index);
          arrayList.Add((object) dictionary);
          n++;
        }
        bool flag2 = arrayList.Count == 0;
        if (flag2)
        {
            this.btnDeleteAll.Enabled = true;
            this.btnDeleteSSH.Enabled = true;
            this.btnCheckLive.Enabled = true;
            this.btnRefreshSSH.Enabled = true;
            this.btnDeleteDead.Enabled = true;
            this.numThreadCount.Enabled = true;
            this.btnImportSSHFromCB.Enabled = true;
            this.btnImportSSHFromFile.Enabled = true;
            this.btnCheckLive.Text = "Check live";
            this.lbCheckLiveStatus.Text = "Done";
        }
        else
        {
            SSHTest.doTestSSHConnections(arrayList.ToArray(), new Action<Dictionary<string, object>, int, bool, string>(delegate (Dictionary<string, object> dict, int index, bool result, string fingerPrint)
            {
                int num = count;
                count = num + 1;
                Console.WriteLine(string.Concat(new object[]
                {
                    dict["host"],
                    "[",
                    index,
                    "] : ",
                    result.ToString()
                }));
                for (int j = 0; j < LocalConfig.getCurrentConfig().allSSHs().Count; j++)
                {
                    bool flag3 = dict.Equals(LocalConfig.getCurrentConfig().allSSHs()[j]);
                    if (flag3)
                    {
                        Dictionary<string, object> ssh = (Dictionary<string, object>)list[j];
                        ssh["status"] = (result ? 1 : 0);
                        bool flag4 = fingerPrint != null;
                        if (flag4)
                        {
                            ssh["fp"] = fingerPrint;
                        }
                        LocalConfig.getCurrentConfig().saveSSHsList();
                        this.btnCheckLive.Invoke(new Action(delegate
                        {
                            this.lvSSH.Items[index].BackColor = result ? Color.Green : Color.Red;

                            if (result)
                            {
                                int num2 = Convert.ToInt32(this.lbLive.Tag) + 1;
                                this.lbLive.Tag = num2;
                                this.lbLive.Text = "Live : " + num2;
                            }
                            else
                            {
                                int num3 = Convert.ToInt32(this.lbDead.Tag) + 1;
                                this.lbDead.Tag = num3;
                                this.lbDead.Text = "Dead : " + num3;
                            }
                            int num4 = Convert.ToInt32(this.lbUnCheck.Tag) - 1;
                            this.lbUnCheck.Tag = num4;
                            this.lbUnCheck.Text = "Unchecked : " + num4;
                            bool flag5 = ssh.ContainsKey("used");
                            if (flag5)
                            {
                                this.lvSSH.Items[index].BackColor = Color.Blue;
                            }
                            bool flag6 = count == n;
                            if (flag6)
                            {
                                this.btnDeleteAll.Enabled = true;
                                this.btnDeleteSSH.Enabled = true;
                                this.btnCheckLive.Enabled = true;
                                this.btnRefreshSSH.Enabled = true;
                                this.btnDeleteDead.Enabled = true;
                                this.numThreadCount.Enabled = true;
                                this.btnImportSSHFromCB.Enabled = true;
                                this.btnImportSSHFromFile.Enabled = true;
                                this.btnCheckLive.Text = "Check live";
                                this.lbCheckLiveStatus.Text = "Done";
                                this.reloadCountriesList();
                            }
                        }));
                    }
                }
            }), int32);
        }



            }
    }

    private void btnImportSSHFromCB_Click(object sender, EventArgs e)
    {
      if ((uint) Regex.Split(Clipboard.GetText(), "\r\n|\r|\n").Length <= 0U)
        return;
      int num = (int) new frmSSHImport().ShowDialog();
      this.reloadSSHsList();
      this.reloadCountriesList();
    }

    private void btnExportSSH_Click(object sender, EventArgs e)
    {
      if (this.lvSSH.Items.Count <= 0)
        return;
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        string fileName = saveFileDialog.FileName;
        string contents = "";
        ArrayList arrayList = LocalConfig.getCurrentConfig().allSSHs();
        if (arrayList != null)
        {
          Array array = (Array) arrayList.ToArray();
          for (int index = 0; index < array.Length; ++index)
          {
            Dictionary<string, object> dictionary = (Dictionary<string, object>) array.GetValue(index);
            contents = contents + dictionary["host"].ToString() + "|" + dictionary["username"].ToString() + "|" + dictionary["password"].ToString() + "|" + dictionary["country"].ToString() + "|" + dictionary["port"].ToString() + "|SPEED: 0\r\n";
          }
        }
        System.IO.File.WriteAllText(fileName, contents);
      }
    }

    public void changeIP()
    {
        this.btnChangeIP.Invoke(new Action(delegate
        {
            this.btnChangeIP.Text = "Stop";
        }));
        this.__changeIpInBackground();
        this.btnChangeIP.Invoke(new Action(delegate
        {
            this.btnChangeIP.Text = "Change IP";
        }));
    }

    public void setupProxy(string tool, string ip, string country, string region, Dictionary<string, object> ssh)
    {
        bool flag = GlobalConfig.currentPublicIPWithLocationInfo != null && GlobalConfig.currentPublicIP != null;
        if (flag)
        {
            bool flag2 = GlobalConfig.currentPublicIPWithLocationInfo.StartsWith(ip);
            if (flag2)
            {
                this.btnChangeIP.Invoke(new Action(delegate
                {
                    this.cbTool.SelectedItem = tool;
                    string text = null;
                    string path = GlobalConfig.executableDirectory() + "\\Countries.list";
                    string[] array = File.ReadAllLines(path);
                    for (int i = 0; i < array.Length; i++)
                    {
                        string text2 = GlobalConfig.stringSplit(array[i])[0];
                        bool flag7 = text2.Equals(country);
                        if (flag7)
                        {
                            text = array[i];
                        }
                    }
                    bool flag8 = !this.cbCountries.Items.Contains(text);
                    if (flag8)
                    {
                        this.cbCountries.Items.Add(text);
                    }
                    this.cbCountries.SelectedItem = text;
                }));
                return;
            }
        }
        bool flag3 = tool.Equals("Direct");
        if (flag3)
        {
            this.btnChangeIP.Invoke(new Action(delegate
            {
                this.cbTool.SelectedItem = "Direct";
                this.btnChangeIP.Text = "Stop";
            }));
            this.__changeIpInBackground();
            this.btnChangeIP.Invoke(new Action(delegate
            {
                this.btnChangeIP.Text = "Change IP";
            }));
        }
        else
        {
            bool flag4 = tool.Equals("SSH");
            if (flag4)
            {
                this.btnChangeIP.Invoke(new Action(delegate
                {
                    this.cbTool.SelectedItem = "SSH";
                    this.btnChangeIP.Text = "Stop";
                    string text = null;
                    string path = GlobalConfig.executableDirectory() + "\\Countries.list";
                    string[] array = File.ReadAllLines(path);
                    for (int i = 0; i < array.Length; i++)
                    {
                        string text2 = GlobalConfig.stringSplit(array[i])[0];
                        bool flag7 = text2.Equals(country);
                        if (flag7)
                        {
                            text = array[i];
                        }
                    }
                    bool flag8 = !this.cbCountries.Items.Contains(text);
                    if (flag8)
                    {
                        this.cbCountries.Items.Add(text);
                    }
                    this.cbCountries.SelectedItem = text;
                }));
                bool flag5 = LocalConfig.getCurrentConfig().allSSHs() == null;
                if (flag5)
                {
                    throw new Exception("No SSH account !");
                }
                this.btnChangeIP.Invoke(new Action(delegate
                {
                    this.lbSelectedIP.Text = "Changing ...";
                }));
                ProxyCore.previousSshInfo = ssh;
                string result;
                ProxyCore.restoreIP(ProxyTool.SSH, ip, country, region, out result);
                this.btnChangeIP.Invoke(new Action(delegate
                {
                    bool dt = result != null;
                    if (dt)
                    {
                        this.lbSelectedIP.Text = result;
                        GlobalConfig.currentPublicIP = GlobalConfig.stringSplit(result, ",")[0].Trim();
                        GlobalConfig.currentPublicIPWithLocationInfo = result;
                        this.BringToFront();
                        Vip72Handle.SetForegroundWindow(this.Handle);
                        this.btnChangeIP.Text = "Change IP";
                        return;
                    }
                    GlobalConfig.currentPublicIP = null;
                    GlobalConfig.currentPublicIPWithLocationInfo = null;
                    throw new Exception("No SSH available in [" + country + "]");
                }));
            }
            else
            {
                this.btnChangeIP.Invoke(new Action(delegate
                {
                    this.cbTool.SelectedItem = "Vip72";
                    this.btnChangeIP.Text = "Stop";
                    string text = null;
                    string path = GlobalConfig.executableDirectory() + "\\Countries.list";
                    string[] array = File.ReadAllLines(path);
                    for (int i = 0; i < array.Length; i++)
                    {
                        string text2 = GlobalConfig.stringSplit(array[i])[0];
                        bool flag7 = text2.Equals(country);
                        if (flag7)
                        {
                            text = array[i];
                        }
                    }
                    bool flag8 = !this.cbCountries.Items.Contains(text);
                    if (flag8)
                    {
                        this.cbCountries.Items.Add(text);
                    }
                    this.cbCountries.SelectedItem = text;
                }));
                bool flag6 = LocalConfig.getCurrentConfig().allSSHs() == null;
                if (flag6)
                {
                    throw new Exception("No Vip72 account !");
                }
                this.btnChangeIP.Invoke(new Action(delegate
                {
                    this.lbSelectedIP.Text = "Changing ...";
                }));
                string result;
                ProxyCore.restoreIP(ProxyTool.Vip72, ip, country, region, out result);
                this.btnChangeIP.Invoke(new Action(delegate
                {
                    bool logs = result != null;
                    if (logs)
                    {
                        this.lbSelectedIP.Text = result;
                        GlobalConfig.currentPublicIP = GlobalConfig.stringSplit(result, ",")[0].Trim();
                        GlobalConfig.currentPublicIPWithLocationInfo = result;
                        this.BringToFront();
                        Vip72Handle.SetForegroundWindow(this.Handle);
                        this.btnChangeIP.Text = "Change IP";
                        return;
                    }
                    GlobalConfig.currentPublicIP = null;
                    GlobalConfig.currentPublicIPWithLocationInfo = null;
                    throw new Exception("No proxy available in [" + country + "]");
                }));
            }
        }
    }

    private void __changeIpInBackgroundbk()
    {
        try
        {
            bool __h__ = false;
            this.btnChangeIP.Invoke(new Action(delegate
            {
                __h__ = (this.cbCountries.SelectedIndex >= 0 && this.cbCountries.SelectedIndex < this.cbCountries.Items.Count);
            }));
            bool index = __h__;
            if (index)
            {
                string tool = null;
                string[] countries = null;
                this.btnChangeIP.Invoke(new Action(delegate
                {
                    GlobalConfig.currentPublicIP = null;
                    string text = this.cbCountries.SelectedItem.ToString();
                    countries = GlobalConfig.stringSplit(text);
                    Console.WriteLine(countries[0]);
                    tool = this.cbTool.SelectedItem.ToString();
                }));
                bool dict = tool.Equals("Vip72");
                if (dict)
                {
                    bool app_id = LocalConfig.getCurrentConfig().allVip72s() == null;
                    if (app_id)
                    {
                        this.btnChangeIP.Invoke(new Action(delegate
                        {
                            MessageBox.Show("No Vip72 account !", "Error", MessageBoxButtons.OK);
                        }));
                    }
                    else
                    {
                        this.btnChangeIP.Invoke(new Action(delegate
                        {
                            this.lbSelectedIP.Text = "Changing ...";
                            this.Refresh();
                        }));
                        string ip;
                        ProxyCore.doChangeIP(ProxyTool.Vip72, countries[0], out ip);
                        this.btnChangeIP.Invoke(new Action(delegate
                        {
                            bool flag3 = ip != null;
                            if (flag3)
                            {
                                this.lbSelectedIP.Text = ip;
                                GlobalConfig.currentPublicIP = GlobalConfig.stringSplit(ip, ",")[0].Trim();
                                GlobalConfig.currentPublicIPWithLocationInfo = ip;
                            }
                            else
                            {
                                this.lbSelectedIP.Text = "N/A";
                                GlobalConfig.currentPublicIP = null;
                            }
                            Vip72Handle.SetForegroundWindow(this.Handle);
                        }));
                    }
                }
                else
                {
                    bool name = tool.Equals("SSH");
                    if (name)
                    {
                        bool result = LocalConfig.getCurrentConfig().allSSHs() == null;
                        if (result)
                        {
                            this.btnChangeIP.Invoke(new Action(delegate
                            {
                                MessageBox.Show("No SSH account !", "Error", MessageBoxButtons.OK);
                            }));
                        }
                        else
                        {
                            this.btnChangeIP.Invoke(new Action(delegate
                            {
                                this.lbSelectedIP.Text = "Changing ...";
                                this.Refresh();
                            }));
                            string ip;
                            ProxyCore.doChangeIP(ProxyTool.SSH, countries[0], out ip);
                            this.btnChangeIP.Invoke(new Action(delegate
                            {
                                bool flag3 = ip != null;
                                if (flag3)
                                {
                                    this.lbSelectedIP.Text = ip;
                                    GlobalConfig.currentPublicIP = GlobalConfig.stringSplit(ip, ",")[0].Trim();
                                    GlobalConfig.currentPublicIPWithLocationInfo = ip;
                                }
                                else
                                {
                                    this.lbSelectedIP.Text = "ERROR. NO MORE SSH IN [" + countries[0] + "]";
                                    GlobalConfig.currentPublicIP = null;
                                }
                                this.BringToFront();
                                Vip72Handle.SetForegroundWindow(this.Handle);
                            }));
                        }
                    }
                    else
                    {
                        bool flag = tool.Equals("Direct");
                        if (flag)
                        {
                            this.btnChangeIP.Invoke(new Action(delegate
                            {
                                this.lbSelectedIP.Text = "Changing ...";
                            }));
                            bool flag2 = AutoLeadClient.send("{\"cmd\":\"get_public_ip\" }");
                            if (flag2)
                            {
                                    //JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                                    //string input = AutoLeadClient.receive();
                                    //Dictionary<string, object> dictionary = javaScriptSerializer.Deserialize<Dictionary<string, object>>(input);
                                    //string ip = dictionary["result"].ToString();
                                string externalip = new WebClient().DownloadString("http://icanhazip.com");

                                string ip = externalip.Replace("\n", "");
                                this.btnChangeIP.Invoke(new Action(delegate
                                {
                                    this.lbSelectedIP.Text = ip;
                                }));
                                GlobalConfig.currentPublicIP = ip;
                                string json = null;
                                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://ipinfo.io/" + ip + "/geo");
                                using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                                {
                                    using (Stream responseStream = httpWebResponse.GetResponseStream())
                                    {
                                        using (StreamReader streamReader = new StreamReader(responseStream))
                                        {
                                            json = streamReader.ReadToEnd();
                                        }
                                    }
                                }
                                this.btnChangeIP.Invoke(new Action(delegate
                                {
                                    bool op = json != null;
                                    if (op)
                                    {
                                        JavaScriptSerializer javaScriptSerializer2 = new JavaScriptSerializer();
                                        Dictionary<string, object> dictionary2 = javaScriptSerializer2.Deserialize<Dictionary<string, object>>(json);
                                        string[] array = Split.tachchuoi(ResourceList.Codes, "\r\n");
                                        foreach (string text in array)
                                        {
                                            string[] array3 = GlobalConfig.stringSplit(text, ";");
                                            bool flag3 = array3.Length == 2;
                                            if (flag3)
                                            {
                                                string text2 = array3[1].Trim();
                                                string text3 = array3[0].Trim();
                                                bool flag4 = text2.Equals(dictionary2["country"].ToString().ToUpper());
                                                if (flag4)
                                                {
                                                    GlobalConfig.currentPublicIPWithLocationInfo = string.Concat(new string[]
                                                    {
                                                        ip,
                                                        ",",
                                                        text3,
                                                        ",",

                                                        dictionary2["region"].ToString().ToUpper()
                                                    });
                                                    this.lbSelectedIP.Text = ip;
                                                    for (int j = 0; j < this.cbCountries.Items.Count; j++)
                                                    {
                                                        bool flag5 = this.cbCountries.Items[j].ToString().StartsWith(text3);
                                                        if (flag5)
                                                        {
                                                            this.cbCountries.SelectedIndex = j;
                                                            break;
                                                        }
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }));
                            }
                            else
                            {
                                this.btnChangeIP.Invoke(new Action(delegate
                                {
                                    this.lbSelectedIP.Text = "ERROR. COULD NOT GET PUBLIC IP";
                                    GlobalConfig.currentPublicIP = null;
                                }));
                            }
                        }
                    }
                }
            }
            else
            {
                this.btnChangeIP.Invoke(new Action(delegate
                {
                    GlobalConfig.currentPublicIP = null;
                    GlobalConfig.currentPublicIPWithLocationInfo = null;
                    GlobalConfig.currentSSH = null;
                    this.lbStatus.Text = "ERROR. Could not change IP";
                    this.lbSelectedIP.Text = "N/A";
                }));
            }
            this.btnChangeIP.Invoke(new Action(delegate
            {
                this.btnChangeIP.Text = "Change IP";
            }));
        }
        catch (Exception value)
        {
            GlobalConfig.currentPublicIP = null;
            GlobalConfig.currentPublicIPWithLocationInfo = null;
            GlobalConfig.currentSSH = null;
            this.btnChangeIP.Invoke(new Action(delegate
            {
                this.btnChangeIP.Text = "Change IP";
                this.lbStatus.Text = "User stopped";
                this.lbSelectedIP.Text = "N/A";
            }));
            Console.WriteLine(value);
        }
    }

    private void __changeIpInBackground()
    {
        frmMain.portFake = LocalConfig.getCurrentConfig().getInt32ForKey("portfakelee").ToString();
        try
        {
            bool __h__ = false;
            this.btnChangeIP.Invoke(new Action(delegate
            {
                __h__ = (this.cbCountries.SelectedIndex >= 0 && this.cbCountries.SelectedIndex < this.cbCountries.Items.Count);
            }));
            bool offers = __h__;
            if (offers)
            {
                string tool = null;
                string[] countries = null;
                this.btnChangeIP.Invoke(new Action(delegate
                {
                    GlobalConfig.currentPublicIP = null;
                    string op = this.cbCountries.SelectedItem.ToString();
                    countries = GlobalConfig.stringSplit(op);
                    Console.WriteLine(countries[0]);
                    tool = this.cbTool.SelectedItem.ToString();
                }));
                bool i = tool.Equals("Vip72");
                if (i)
                {
                    bool flag = LocalConfig.getCurrentConfig().allVip72s() == null;
                    if (flag)
                    {
                        this.btnChangeIP.Invoke(new Action(delegate
                        {
                            MessageBox.Show("No Vip72 account !", "Error", MessageBoxButtons.OK);
                        }));
                    }
                    else
                    {
                        this.btnChangeIP.Invoke(new Action(delegate
                        {
                            this.lbSelectedIP.Text = "Changing ...";
                            this.Refresh();
                        }));
                        bool flag2;
                        string ip;
                        do
                        {
                            this.FakeVip72byLee(countries[0], out ip);
                            bool @checked = this.chkipused.Checked;
                            if (!@checked)
                            {
                                break;
                            }
                            flag2 = !LocalConfig.Checkip(ip, frmMain.linkoff);
                        }
                        while (flag2);
                        this.btnChangeIP.Invoke(new Action(delegate
                        {
                            bool op = ip != null;
                            if (op)
                            {
                                frmMain.ipfake = (this.lbSelectedIP.Text = ip);
                                GlobalConfig.currentPublicIP = GlobalConfig.stringSplit(ip, ",")[0].Trim();
                                GlobalConfig.currentPublicIPWithLocationInfo = ip;
                            }
                            else
                            {
                                this.lbSelectedIP.Text = "N/A";
                                GlobalConfig.currentPublicIP = null;
                            }
                            Vip72Handle.SetForegroundWindow(this.Handle);
                        }));
                    }
                }
                else
                {
                    bool error = tool.Equals("SSH");
                    if (error)
                    {
                        bool sn = LocalConfig.getCurrentConfig().allSSHs() == null;
                        if (sn)
                        {
                            this.btnChangeIP.Invoke(new Action(delegate
                            {
                                MessageBox.Show("No SSH account !", "Error", MessageBoxButtons.OK);
                            }));
                        }
                        else
                        {
                            this.btnChangeIP.Invoke(new Action(delegate
                            {
                                this.lbSelectedIP.Text = "Changing ...";
                                this.Refresh();
                            }));
                            bool flag3;
                            string ip;
                            do
                            {
                                this.FakeSSHByLee(out ip);
                                bool checked2 = this.chkipused.Checked;
                                if (!checked2)
                                {
                                    break;
                                }
                                flag3 = !LocalConfig.Checkip(ip, frmMain.linkoff);
                            }
                            while (flag3);
                            this.btnChangeIP.Invoke(new Action(delegate
                            {
                                bool _scripts = ip != null;
                                if (_scripts)
                                {
                                    frmMain.ipfake = (this.lbSelectedIP.Text = ip);
                                    GlobalConfig.currentPublicIP = GlobalConfig.stringSplit(ip, ",")[0].Trim();
                                    GlobalConfig.currentPublicIPWithLocationInfo = ip;
                                }
                                else
                                {
                                    this.lbSelectedIP.Text = "ERROR. NO MORE SSH IN [" + countries[0] + "]";
                                    GlobalConfig.currentPublicIP = null;
                                }
                                this.BringToFront();
                                Vip72Handle.SetForegroundWindow(this.Handle);
                            }));
                        }
                    }
                    else
                    {
                        bool flag4 = tool.Equals("Direct");
                        if (flag4)
                        {
                            this.btnChangeIP.Invoke(new Action(delegate
                            {
                                this.lbSelectedIP.Text = "Changing ...";
                                this.Refresh();
                            }));
                                //bool flag5 = AutoLeadClient.send("{\"cmd\":\"get_public_ip\" }");
                             bool flag5 = true;
                            if (flag5)
                            {
                                //JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                                //string operation = AutoLeadClient.receive();
                               // Dictionary<string, object> dictionary = javaScriptSerializer.Deserialize<Dictionary<string, object>>(operation);
                                string externalip = new WebClient().DownloadString("http://icanhazip.com");
                                    
                                string ip = externalip.Replace("\n", "");
                                Console.WriteLine(ip);
                                //string ip = dictionary["result"].ToString();
                                this.btnChangeIP.Invoke(new Action(delegate
                                {
                                    lbSelectedIP.Text = ip;
                                }));
                                GlobalConfig.currentPublicIP = ip;
                                string json = null;
                                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://ipinfo.io/" + ip + "/geo");
                                using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                                {
                                    using (Stream responseStream = httpWebResponse.GetResponseStream())
                                    {
                                        using (StreamReader i_appkill = new StreamReader(responseStream))
                                        {
                                            json = i_appkill.ReadToEnd();
                                        }
                                    }
                                }
                                this.btnChangeIP.Invoke(new Action(delegate
                                {
                                    bool flag6 = json != null;
                                    if (flag6)
                                    {
                                        JavaScriptSerializer javaScriptSerializer2 = new JavaScriptSerializer();
                                        Dictionary<string, object> dictionary2 = javaScriptSerializer2.Deserialize<Dictionary<string, object>>(json);
                                        string[] array = Split.tachchuoi(ResourceList.Codes, "\r\n");
                                        foreach (string text in array)
                                        {
                                            string[] array3 = GlobalConfig.stringSplit(text, ";");
                                            bool flag7 = array3.Length == 2;
                                            if (flag7)
                                            {
                                                string text2 = array3[1].Trim();
                                                string text3 = array3[0].Trim();
                                                bool flag8 = text2.Equals(dictionary2["country"].ToString().ToUpper());
                                                if (flag8)
                                                {
                                                    GlobalConfig.currentPublicIP = GlobalConfig.stringSplit(ip, ",")[0].Trim();
                                                    
                                                    GlobalConfig.currentPublicIPWithLocationInfo = string.Concat(new string[]
                                                    {
                                                        ip,
                                                       ",",
                                                        text3,
                                                        ",",
                                                        dictionary2["region"].ToString().ToUpper()
                                                    });
                                                    this.lbSelectedIP.Text = ip;
                                                    for (int k = 0; k < this.cbCountries.Items.Count; k++)
                                                    {
                                                        bool flag9 = this.cbCountries.Items[k].ToString().StartsWith(text3);
                                                        if (flag9)
                                                        {
                                                            this.cbCountries.SelectedIndex = k;

                                                            break;
                                                        }
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }));
                            }
                            else
                            {
                                this.btnChangeIP.Invoke(new Action(delegate
                                {
                                    this.lbSelectedIP.Text = "ERROR. COULD NOT GET PUBLIC IP";
                                    GlobalConfig.currentPublicIP = null;
                                }));
                            }
                                Vip72Handle.SetForegroundWindow(this.Handle);
                                Thread.Sleep(1500);
                            }
                    }
                }
            }
            else
            {
                this.btnChangeIP.Invoke(new Action(delegate
                {
                    GlobalConfig.currentPublicIP = null;
                    GlobalConfig.currentPublicIPWithLocationInfo = null;
                    GlobalConfig.currentSSH = null;
                    this.lbStatus.Text = "ERROR. Could not change IP";
                    this.lbSelectedIP.Text = "N/A";
                }));
            }
            this.btnChangeIP.Invoke(new Action(delegate
            {
                this.btnChangeIP.Text = "Change IP";
            }));
        }
        catch (Exception value)
        {
            GlobalConfig.currentPublicIP = null;
            GlobalConfig.currentPublicIPWithLocationInfo = null;
            GlobalConfig.currentSSH = null;
            this.btnChangeIP.Invoke(new Action(delegate
            {
                this.btnChangeIP.Text = "Change IP";
                this.lbStatus.Text = "User stopped";
                this.lbSelectedIP.Text = "N/A";
            }));
            Console.WriteLine(value);
        }
    }

        private void FakeVip72byLee(string v, out string ip)
    {
      int num1 = Convert.ToInt32(LocalConfig.getCurrentConfig().getInt32ForKey("portfakelee").ToString());
      if (this.chkPortRd.Checked)
      {
        Random random = new Random();
        while (true)
        {
          do
          {
            num1 = random.Next(1000, 65000);
          }
          while (!GlobalConfig.isPortAvailable(num1));
          this.ActiveportPorxy = true;
          this.ipcMyIP.Enabled = false;
          this.nbportfake.Enabled = false;
          this.btApply.Text = "Applying ...";
          this.Refresh();
          Dictionary<string, object> dictionary = new Dictionary<string, object>();
          dictionary["cmd"] = (object) "FakeipbyLee";
          dictionary["ipproxy"] = (object) this.ipcMyIP.Text;
          dictionary["port"] = (object) num1;
          dictionary["setfake"] = (object) "YES";
          string str = "0";
          if (AutoLeadClient.send(Operation.jss.Serialize((object) dictionary)))
            str = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(AutoLeadClient.receive())["result"].ToString();
          if (!(str == "1"))
          {
            this.lbProxyStatus.ForeColor = Color.Red;
            this.lbProxyStatus.Text = "Not configured";
          }
          else
            break;
        }
        this.lbProxyStatus.ForeColor = Color.Green;
        this.lbProxyStatus.Text = "Configured";
      }
      ip = (string) null;
      try
      {
label_47:
        string str1 = (string) null;
        do
        {
          Vip72Rieng vip72Rieng = new Vip72Rieng();
          if (this.ListUseVip == null)
          {
            int num2 = (int) MessageBox.Show((IWin32Window) this, "Please add use and pass Vip72", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
          else
          {
            try
            {
              sshcommand.closebitvise(num1);
              if (!this.bitproc.HasExited)
                this.bitproc.Kill();
            }
            catch (Exception ex)
            {
            }
            int num3 = 0;
            int index1 = 0;
            for (int index2 = 0; index2 < this.ListUseVip.Count; ++index2)
            {
              index1 = index2;
              if (this.ListUseVip[index1].stt == "1")
              {
                frmMain.tokenvip = this.ListUseVip[index1].token;
                string uname = this.ListUseVip[index1].uname;
                string passs = this.ListUseVip[index1].passs;
                ++num3;
                if (this.txtexclusivevip72.Checked)
                {
                  if (!vip72Rieng.vip72login(uname, passs, num1))
                  {
                    this.ListUseVip[index1].stt = "0";
                    if (num3 == this.ListUseVip.Count)
                    {
                      int num4 = (int) MessageBox.Show((IWin32Window) this, "Acc vip72 đã dùng hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                  }
                  else
                    break;
                }
                else if (!Vip72.vip72login(uname, passs))
                {
                  this.ListUseVip[index1].stt = "0";
                  if (num3 == this.ListUseVip.Count)
                  {
                    int num4 = (int) MessageBox.Show((IWin32Window) this, "Acc vip72 đã dùng hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                  }
                }
                else
                  break;
              }
            }
            Vip72.waitiotherVIP72();
            while (true)
            {
              do
              {
                byte countryindex = Convert.ToByte(Split.tachchuoi(this.cbCountries.Text, " | ")[1]);
                string country = Split.tachchuoi(this.cbCountries.Text, " | ")[0];
                string coderegion = "65535";
                string region = "no";
                string codecity = "65535";
                string city = "no";
                try
                {
                  coderegion = Split.tachchuoi(this.cboregion.Text, "|")[1];
                  region = Split.tachchuoi(this.cboregion.Text, "|")[0];
                  codecity = Split.tachchuoi(this.cbocity.Text, "|")[1];
                  city = Split.tachchuoi(this.cbocity.Text, "|")[0];
                }
                catch
                {
                }
                string str2 = Split.tachchuoi(this.cbCountries.Text, " | ")[0];
                if (this.txtexclusivevip72.Checked)
                {
                  if (vip72Rieng.getip(countryindex, country, region, coderegion, city, codecity))
                  {
                    ip = str1 = vip72Rieng.clickip(num1);
                    if (str1 == "not running")
                      goto label_47;
                  }
                  else
                    goto label_47;
                }
                else if (Vip72.getip(countryindex, country, region, coderegion, city, codecity))
                {
                  ip = str1 = Vip72.clickip(num1);
                  if (str1 == "not running")
                    goto label_47;
                }
                else
                  goto label_47;
              }
              while (str1 == "no IP" || str1 == "dead" || str1 == "rror");
              if (!(str1 == "limited"))
              {
                if (str1 == "maximum")
                {
                  if (this.txtexclusivevip72.Checked)
                    vip72Rieng.clearip();
                  else
                    Vip72.clearip();
                }
                else
                  goto label_46;
              }
              else
                break;
            }
            this.ListUseVip[index1].stt = "0";
            goto label_47;
          }
label_46:;
        }
        while (str1 == "timeout");
      }
      catch (Exception ex)
      {
        int num2 = (int) MessageBox.Show((IWin32Window) this, "Fake vip72 false", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void FakeSSHByLee(out string ip)
    {
      int int32 = Convert.ToInt32(LocalConfig.getCurrentConfig().getInt32ForKey("portfakelee").ToString());
      ip = (string) null;
      for (int index = 0; index < this.lvSSH.Items.Count; ++index)
        frmMain.SSHListLive.Add(new ssh()
        {
          IP = this.lvSSH.Items[index].SubItems[0].Text,
          username = this.lvSSH.Items[index].SubItems[2].Text,
          password = this.lvSSH.Items[index].SubItems[3].Text,
          country = this.lvSSH.Items[index].SubItems[4].Text,
          live = "live",
          used = false
        });
      try
      {
        Vip72.clearIpWithPort(int32);
        new Vip72Rieng().clearIpWithPort(int32);
        sshcommand.closebitvise(int32);
        try
        {
          if (!this.bitproc.HasExited)
            this.bitproc.Kill();
        }
        catch (Exception ex)
        {
        }
        string curcountry = Split.tachchuoi(this.cbCountries.Text, " |")[0];
        while (frmMain.SSHListLive.FirstOrDefault<ssh>((Func<ssh, bool>) (x =>
        {
          if (x.live != "dead" && !x.used)
            return x.country == curcountry;
          return false;
        })) != null)
        {
          Random random = new Random();
          int index = random.Next(0, frmMain.SSHListLive.Count);
          while (frmMain.SSHListLive.ElementAt<ssh>(index).live == "dead" || frmMain.SSHListLive.ElementAt<ssh>(index).used || frmMain.SSHListLive.ElementAt<ssh>(index).country != curcountry)
            index = random.Next(0, frmMain.SSHListLive.Count);
          ssh ssh = frmMain.SSHListLive.ElementAt<ssh>(index);
          ssh.used = true;
          ip = ssh.IP;
          frmMain.SSHListLive.Remove(ssh);
          if (!sshcommand.SetSSH(ssh.IP, ssh.username, ssh.password, this.ipcMyIP.Text, int32.ToString(), ref this.bitproc))
            ssh.live = "dead";
          else
            return;
        }
        int num = (int) MessageBox.Show("All SSH are used or dead, please update new SSH list!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      catch
      {
      }
    }

    private void btnChangeIP_Click(object sender, EventArgs e)
    {
      if (this.btnChangeIP.Text.Equals("Stop"))
      {
        if (this.changeIPThread != null && this.changeIPThread.IsAlive)
          this.changeIPThread.Abort();
        if (this._bwLeadThread != null && this._bwLeadThread.IsAlive)
          this._bwLeadThread.Abort();
        if (this._bwRSSThread != null && this._bwRSSThread.IsAlive)
          this._bwRSSThread.Abort();
        this.btnChangeIP.Text = "Change IP";
      }
      else
      {
        this.btnChangeIP.Text = "Stop";
        this.changeIPThread = new Thread(new ThreadStart(this.__changeIpInBackground));
        this.changeIPThread.Start();
      }
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      try
      {
        frmMain.sftpclient.Disconnect();
      }
      catch
      {
      }
      ProxyCore.closeIfNeeds();
    }

    private void btApply_Click(object sender, EventArgs e)
    {
      int int32 = Convert.ToInt32(this.nbportfake.Value);
      if (!this.ActiveportPorxy)
      {
        if (GlobalConfig.isPortAvailable(int32))
        {
          this.ActiveportPorxy = true;
          this.ipcMyIP.Enabled = false;
          this.nbportfake.Enabled = false;
          this.btApply.Text = "Applying ...";
          this.Refresh();
          Dictionary<string, object> dictionary = new Dictionary<string, object>();
          dictionary["cmd"] = (object) "FakeipbyLee";
          dictionary["ipproxy"] = (object) this.ipcMyIP.Text;
          dictionary["port"] = (object) this.nbportfake.Value;
          dictionary["setfake"] = (object) "YES";
          string str = "0";
          if (AutoLeadClient.send(Operation.jss.Serialize((object) dictionary)))
            str = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(AutoLeadClient.receive())["result"].ToString();
          if (str == "1")
          {
            int num = (int) MessageBox.Show("Set proxy done.");
                        this.btApply.Invoke(new MethodInvoker(delegate
                        {
                            this.btApply.Text = "Stop";
                        }));
                    }
          else
          {
            int num = (int) MessageBox.Show("Set proxy fail");
            this.ActiveportPorxy = false;
            this.btApply.Text = "Apply";
            this.ipcMyIP.Enabled = true;
            this.nbportfake.Enabled = true;
            this.lbProxyStatus.ForeColor = Color.Red;
            this.lbProxyStatus.Text = "Not configured";
          }
        }
        else
        {
          int num1 = (int) MessageBox.Show("Port " + (object) this.nbportfake.Value + " is in use", "Error", MessageBoxButtons.OK);
        }
      }
      else if (MessageBox.Show("Do you want to stop proxy server ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        dictionary["cmd"] = (object) "FakeipbyLee";
        dictionary["ipproxy"] = (object) this.ipcMyIP.Text;
        dictionary["port"] = (object) this.nbportfake.Value;
        dictionary["setfake"] = (object) "NO";
        string str = "0";
        if (AutoLeadClient.send(Operation.jss.Serialize((object) dictionary)))
          str = AutoLeadClient.receive();
        this.ActiveportPorxy = false;
        this.btApply.Text = "Apply";
        this.ipcMyIP.Enabled = true;
        this.nbportfake.Enabled = true;
        this.lbProxyStatus.ForeColor = Color.Red;
        this.lbProxyStatus.Text = "Not configured";
      }
    }

    private void ipcMyIP_TextChanged(object sender, EventArgs e)
    {
      this.tbProxyURL.Text = "http://" + this.ipcMyIP.Text + ":" + (object) this.nbportfake.Value + "/ac.pac";
      LocalConfig.getCurrentConfig().myIP = this.ipcMyIP.Text;
    }

    private void numProxyPort_SizeChanged(object sender, EventArgs e)
    {
    }

    private void numProxyPort_ValueChanged(object sender, EventArgs e)
    {
      this.tbProxyURL.Text = "http://" + this.ipcMyIP.Text + ":" + (object) this.nbportfake.Value + "/ac.pac";
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.nbportfake.Value, "portfakelee");
    }

    private void cbTool_SelectedIndexChanged(object sender, EventArgs e)
    {
      ProxyCore.closeCurrent();
      this.lbSelectedIP.Text = "N/A";
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbTool.SelectedItem.ToString(), "ProxyTool");
      if (this.cbTool.SelectedItem.ToString().Equals("Direct"))
        this.cbCountries.Enabled = false;
      else
        this.cbCountries.Enabled = true;
      if (this.cbTool.Text.Equals("Vip72"))
      {
        this.chkPortRd.Enabled = true;
        this.cboregion.Enabled = true;
        this.cbocity.Enabled = true;
      }
      else
      {
        this.chkPortRd.Checked = false;
        this.chkPortRd.Enabled = false;
        this.nbportfake.Enabled = true;
        this.btApply.Enabled = true;
        this.cboregion.Enabled = false;
        this.cbocity.Enabled = false;
      }
      this.reloadCountriesList();
    }

    private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.btnCheckLive.Text.Equals("Stop"))
        this.btnCheckLive.PerformClick();
      LocalConfig.getCurrentConfig().setObjectForKey((object) GlobalConfig.stringSplit(this.cbCountries.SelectedItem.ToString())[0], "Country");
      if (this.cbTool.Text.Equals("Vip72"))
      {
        string str = Split.tachchuoi(this.cbCountries.Text, " | ")[0];
        if (!System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "citycode\\" + str.ToString() + ".dat"))
          return;
        this.cboregion.Items.Clear();
        string[] strArray = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "citycode\\" + str.ToString() + ".dat");
        for (int index = 0; index < ((IEnumerable<string>) strArray).Count<string>(); ++index)
          this.cboregion.Items.Add((object) strArray[index]);
      }
      else
      {
        this.cboregion.Items.Clear();
        this.cbocity.Items.Clear();
      }
    }

    private void btnWipe_Click(object sender, EventArgs e)
    {
      string text = this.cbApps.SelectedItem.ToString();
      string str = GlobalConfig.stringSplit(text)[0];
      string id = GlobalConfig.stringSplit(text)[1];
      if (MessageBox.Show("Do you want to wipe app " + str + " ?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      Operation.Killapp("com.apple.AppStore");
      Operation.Killapp("com.apple.Safari");
      Operation.Killapp(id);
      this.Wipelee();
      bool result = false;
      this.lbStatus.Text = "Executing [Wipe " + str + "]";
      this.Refresh();
      ScriptsCore.executeScript("wipe(" + id + ")", out result);
      this.lbStatus.Text = "Executing [ Fake ip ]";
      this.changeIP();
      this.lbStatus.Text = "Executing [ Fake info ]";
      Dictionary<string, object> dictionary;
      while (true)
      {
        dictionary = new Dictionary<string, object>();
        dictionary["cmd"] = (object) "fake_info";
        id = "com.apple.mobilesafari|" + id;
        dictionary["listapp_id"] = (object) id;
        if (frmMain.dictfakeSP.Count<KeyValuePair<string, object>>() == 0)
          frmMain.dictfakeSP = FakeInfoCore.get();
        if (frmMain.dictfakeSP.Count > 0)
        {
          if (!Operation.CheckinfoFake(frmMain.dictfakeSP))
            frmMain.dictfakeSP.Clear();
          else
            break;
        }
        else
          goto label_8;
      }
      frmMain.dictfakeSP["setfakegeo"] = !frmMain.bool_fakegeo ? (object) "0" : (object) "1";
      frmMain.dictfakeSP["setfakeUa"] = !frmMain.bool_fakeUA ? (object) "0" : (object) "1";
      frmMain.dictfakeSP["setfakescreen"] = !frmMain.bool_fakescreen ? (object) "0" : (object) "1";
      dictionary["info"] = (object) frmMain.dictfakeSP;
label_8:
      if (AutoLeadClient.send(Operation.jss.Serialize((object) dictionary)))
      {
        string input = AutoLeadClient.receive();
        result = Convert.ToInt32(frmMain.jssfakeSP.Deserialize<Dictionary<string, object>>(input)["result"]) == 1;
        if (result)
          ;
      }
      if (!result)
      {
        int num = (int) MessageBox.Show("[Wipe " + str + "] returns [False]", "", MessageBoxButtons.OK);
      }
      else
        this.lbStatus.Text = "[Wipe " + str + "] done";
    }

    private void setStatusTextFromBackground(string text)
    {
            this.btnStart.Invoke(new Action(delegate
            {
                this.lbStatus.Text = text;
            }));
        }

    private List<Operation> GetOpsListForOffer(Dictionary<string, object> dict, bool changeIP)
    {
      List<Operation> operationList = new List<Operation>();
      frmMain.ListAppkill.Clear();
      frmMain.ListAppkill.Add(new Listapp()
      {
        app_id = "com.apple.AppStore",
        app_name = ""
      });
      frmMain.ListAppkill.Add(new Listapp()
      {
        app_id = "com.apple.Safari",
        app_name = ""
      });
      string str1 = (string) dict["name"];
      string str2 = !frmMain.bool_sub ? (string) dict["url"] : (string) dict["url"] + frmMain.fullsub;
      string _defaultAppId = GlobalConfig.stringSplit((string) dict["app"])[1];
      string _defaultAppName = GlobalConfig.stringSplit((string) dict["app"])[0];
      frmMain.Appid = _defaultAppId;
      frmMain.AppnameDefault = _defaultAppName;
      string str3 = dict["wipeList"].ToString();
      int int32 = Convert.ToInt32(dict["appTime"]);
      int _timeout = !Convert.ToBoolean(dict["random"]) ? Convert.ToInt32(dict["asTime"]) : new Random().Next(Convert.ToInt32(dict["asMin"]), Convert.ToInt32(dict["asMax"]));
      bool boolean1 = Convert.ToBoolean(dict["useURLScript"]);
      bool boolean2 = Convert.ToBoolean(dict["useScript"]);
      string str4 = dict["referer"].ToString();
      string[] lines = GlobalConfig.splitToLines(str4);
      string str5 = "";
      if (str4.Trim().Length > 0 && (uint) lines.Length > 0U)
        str5 = GlobalConfig.randItem(lines);
      operationList.Add(Operation.NewScriptOperation("ilead", "killall"));
      if (changeIP)
        operationList.Add(Operation.NewChangeIPOperation(this, "Change IP"));
      operationList.Add(Operation.NewScriptOperation("ilead", "wipeall"));
      operationList.Add(Operation.NewScriptOperation("wipe(com.apple.mobilesafari)", "Wipe Safari"));
      if (!this.chkgameupdate.Checked)
      {
        if (str3.Length == 0)
        {
          frmMain.ListAppkill.Add(new Listapp()
          {
            app_id = _defaultAppId,
            app_name = _defaultAppName
          });
          operationList.Add(Operation.NewScriptOperation("wipe(" + _defaultAppId + ")", "Wipe " + _defaultAppName));
        }
        else
        {
          if (!str3.Contains(_defaultAppId))
          {
            frmMain.ListAppkill.Add(new Listapp()
            {
              app_id = _defaultAppId,
              app_name = _defaultAppName
            });
            operationList.Add(Operation.NewScriptOperation("wipe(" + _defaultAppId + ")", "Wipe " + _defaultAppName));
          }
          foreach (string line in GlobalConfig.splitToLines(str3))
          {
            string[] strArray = GlobalConfig.stringSplit(line);
            if (strArray.Length == 2)
            {
              frmMain.ListAppkill.Add(new Listapp()
              {
                app_id = _defaultAppId,
                app_name = _defaultAppName
              });
              operationList.Add(Operation.NewScriptOperation("wipe(" + strArray[1] + ")", "Wipe " + strArray[0]));
            }
          }
        }
      }
      if (str3.Length == 0)
      {
        string _appId = "com.apple.mobilesafari|" + _defaultAppId;
        operationList.Add(Operation.NewFakeInfoOperation(_appId, true, "Fake Info "));
      }
      else
      {
        string _appId = "com.apple.mobilesafari";
        if (!str3.Contains(_defaultAppId))
          _appId = _appId + "|" + _defaultAppId;
        foreach (string line in GlobalConfig.splitToLines(str3))
        {
          string[] strArray = GlobalConfig.stringSplit(line);
          _appId = _appId + "|" + strArray[1];
        }
        operationList.Add(Operation.NewFakeInfoOperation(_appId, true, "Fake Info "));
      }
      operationList.Add(Operation.NewWaitOperation(Convert.ToInt32(this.num_sleepBfurl.Value), "Will Open Url in <t> sec(s)"));
      string _script1 = "open_url(" + str2 + "," + GlobalConfig.randItem(lines) + ")";
      operationList.Add(Operation.NewScriptOperation(_script1, "Open Offer URL"));
      operationList.Add(Operation.NewWaitOperation(5, "Open Url in <t> sec(s)"));
      float x = 0.0f;
      float y = 0.0f;
      int interval = 0;
      if (this.cbSafari.Checked)
      {
        string[] strArray = GlobalConfig.stringSplit(this.tbSafari.Text, ",");
        if (strArray.Length == 2)
        {
          x = (float) Convert.ToDouble(strArray[0]);
          y = (float) Convert.ToDouble(strArray[1]);
        }
        interval = LocalConfig.getCurrentConfig().getInt32ForKey("nmSafariXy");
      }
      if (this.cbcheckrunappstore.Checked)
        operationList.Add(Operation.NewWaitForAppStoreOperation(Convert.ToInt32(this.numURLLoadTime.Value), this.cbSafari.Checked, x, y, interval, "Will stop loading URL in <t> sec(s)"));
      else
        operationList.Add(Operation.NewWaitForAppStoreOperation(Convert.ToInt32(this.numURLLoadTime.Value), this.cbSafari.Checked, x, y, interval, "Will stop loading URL in <t> sec(s)"));
      if (this.chkuserscript_openurl.Checked)
      {
        string _script2 = System.IO.File.ReadAllText(LocalConfig.getCurrentConfig().configDirectory() + "/Scripts/" + this.cboscript_openurl.Text);
        operationList.Add(Operation.NewScriptOperation(_script2, "Script while open url"));
        operationList.Add(Operation.NewWaitForAppStoreOperation(Convert.ToInt32(this.numURLLoadTime.Value), this.cbSafari.Checked, x, y, interval, "Time load Appstore in <t> sec(s)"));
      }
      if (this.cbAppStore.Checked)
      {
        if (GlobalConfig.stringSplit(this.tbAppStore.Text, ",").Length == 2)
        {
          operationList.Add(Operation.NewWaitOperation(LocalConfig.getCurrentConfig().getInt32ForKey("nmAppStoreXy"), "Will execute [AppStore XY] in <t> sec(s)"));
          string _script2 = "touch(" + this.tbAppStore.Text + ", 0)";
          operationList.Add(Operation.NewAppScriptOperation("com.apple.AppStore", _script2, "Touch AppStoreXY"));
        }
        else if (boolean1)
          operationList.Add(Operation.NewWaitOperation(_timeout, "Will execute [Script 1] in <t> sec(s)"));
        else
          operationList.Add(Operation.NewWaitOperation(_timeout, "Will open app in <t> sec(s)"));
      }
      else if (boolean1)
        operationList.Add(Operation.NewWaitOperation(_timeout, "Will execute [Script 1] in <t> sec(s)"));
      else
        operationList.Add(Operation.NewWaitOperation(_timeout, "Will open app in <t> sec(s)"));
      if (boolean1)
        operationList.Add(Operation.NewScriptOperation(dict["urlScript"].ToString(), "Script 1"));
      operationList.Add(Operation.NewOpenDetectedAppOperation("Open app"));
      operationList.Add(Operation.NewWaitOperation(2, "Will execute [Get Running App Info] in <t> sec(s)"));
      if (this.cbcheckrunappstore.Checked)
        operationList.Add(Operation.NewGetRunningAppOperation(_defaultAppId, _defaultAppName, "Get Running App Info"));
      string currentAppId = Operation.CurrentAppId;
      string currentAppName = Operation.CurrentAppName;
      if (boolean2)
      {
        operationList.Add(Operation.NewWaitOperation(int32, "Will execute [Script 2] in <t> sec(s)"));
        operationList.Add(Operation.NewScript2Operation(currentAppName, "Script 2"));
      }
      else if (this.cbBackup.Checked)
        operationList.Add(Operation.NewWaitOperation(int32, "Will execute [Backup " + currentAppName + "] in <t> sec(s)"));
      else
        operationList.Add(Operation.NewWaitOperation(int32, "Will execute [Exit " + currentAppName + "] in <t> sec(s)"));
      string _name = str1 + "-" + (object) DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
      if (this.cbBackup.Checked)
      {
        Operation operation = Operation.NewBackupOperation(_name, currentAppId, "Backup " + currentAppName, new Dictionary<string, object>()
        {
          ["an"] = (object) currentAppName,
          ["ai"] = (object) currentAppId,
          ["to"] = (object) this.cbTool.SelectedItem.ToString(),
          ["cm"] = (object) this.tbComment.Text,
          ["ct"] = (object) GlobalConfig.stringSplit(this.cbCountries.SelectedItem.ToString())[0],
          ["fn"] = (object) _name
        });
        operationList.Add(operation);
      }
      operationList.Add(Operation.NewWaitOperation(5, "Will exit [" + currentAppName + "] in <t> sec(s)"));
      string _script3 = "exit()";
      operationList.Add(Operation.NewScriptOperation(_script3, "Exit " + currentAppName));
      Console.Write(_script3);
      return operationList;
    }

    public static void FindAli()
    {
      try
      {
        string input = (string) null;
        if (AutoLeadClient.send(Operation.jss.Serialize((object) new Dictionary<string, object>()
        {
          ["cmd"] = (object) nameof (FindAli)
        })))
          input = AutoLeadClient.receive();
        Dictionary<string, object> dictionary = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(input);
        string chuoi = dictionary["result"].ToString();
        string str = dictionary["path"].ToString() + "/Library/Caches/default/com.hackemist.SDWebImageCache.default";
        string[] strArray = Split.tachchuoi(chuoi, "\n");
        for (int index = 0; index < ((IEnumerable<string>) strArray).Count<string>(); ++index)
        {
          if (strArray[index].IndexOf("sessionId") > 0)
          {
            string path = str + "/" + strArray[index];
            using (FileStream fileStream = System.IO.File.OpenWrite(Application.StartupPath.ToString() + "\\capchar.Bmp"))
              frmMain.sftpclient.DownloadFile(path, (Stream) fileStream, (Action<ulong>) null);
          }
        }
      }
      catch
      {
      }
    }

    public static void FindMavrochain()
    {
      try
      {
        frmMain.Cmdrequest("sudo rm -rf /private/var/mobile/Media/DCIM/100APPLE/*");
        frmMain.Cmdrequest("sudo activator send libactivator.system.take-screenshot");
        string path1 = "/private/var/mobile/Media/DCIM/100APPLE/";
        string path2 = "";
        string str = Application.StartupPath.ToString() + "\\capcharsource.Bmp";
        using (FileStream fileStream = System.IO.File.OpenWrite(str))
        {
          frmMain.sftpclient.ChangeDirectory(path1);
          List<SftpFile> list = frmMain.sftpclient.ListDirectory(frmMain.sftpclient.WorkingDirectory, (Action<int>) null).ToList<SftpFile>();
          for (int index = 0; index < list.Count<SftpFile>(); ++index)
          {
            if (list[index].FullName.IndexOf(".PNG") > 0 || list[index].FullName.IndexOf(".png") > 0)
              path2 = list[index].FullName;
          }
          frmMain.sftpclient.DownloadFile(path2, (Stream) fileStream, (Action<ulong>) null);
        }
        Bitmap bitmap1 = new Bitmap(str);
        Rectangle srcRect = new Rectangle(694, 140, 300, 80);
        Bitmap bitmap2 = new Bitmap(srcRect.Width, srcRect.Height);
        Graphics graphics = Graphics.FromImage((Image) bitmap2);
        graphics.DrawImage((Image) bitmap1, 0, 0, srcRect, GraphicsUnit.Pixel);
        graphics.Dispose();
        bitmap2.Save(Application.StartupPath.ToString() + "\\capchar.Bmp");
        bitmap2.Dispose();
        Thread.Sleep(1000);
      }
      catch (Exception ex)
      {
        string message = ex.Message;
      }
    }

    public static string FindUnitinfo()
    {
      string str1 = "";
      try
      {
        string str2;
        do
        {
          string input = (string) null;
          if (AutoLeadClient.send(Operation.jss.Serialize((object) new Dictionary<string, object>()
          {
            ["cmd"] = (object) nameof (FindUnitinfo)
          })))
            input = AutoLeadClient.receive();
          Dictionary<string, object> dictionary = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(input);
          str2 = dictionary["result"].ToString();
          dictionary["path"].ToString();
        }
        while (str2.IndexOf("unitinfo") < 0);
        return frmMain.ReadUnitinfo();
      }
      catch
      {
        return str1;
      }
    }

    private static string ReadUnitinfo()
    {
      string str = "";
      try
      {
        string input = (string) null;
        if (AutoLeadClient.send(Operation.jss.Serialize((object) new Dictionary<string, object>()
        {
          ["cmd"] = (object) nameof (ReadUnitinfo)
        })))
          input = AutoLeadClient.receive();
        return Split.tachchuoi(Split.tachchuoi(new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(input)["result"].ToString(), "<key>")[1], "</key>")[0];
      }
      catch
      {
        return str;
      }
    }

    public static void ThreadCheatAliTest()
    {
      int num = 0;
      iDevice iDevice = new iDevice(Operation.dict["name"].ToString(), Operation.dict["systemVersion"].ToString(), Operation.dict["buildversion"].ToString(), Operation.dict["machine"].ToString(), frmMain.ipfake);
      iDevice.currency = "USD";
      AliParameter aliParameter = iDevice.AliSettingParameter(iDevice.countryCode);
      aliParameter.setURL("https://api.aliexpress.com/openapi/param2/101/aliexpress.mobile/deviceInfo/8495");
      frmMain.cmdResult.signature = "";
      while (true)
      {
        frmMain.cmd.getSignature(aliParameter.getsignparameter(), "8495", "123123");
        DateTime now = DateTime.Now;
        while (frmMain.cmdResult.signature == "" && (DateTime.Now - now).TotalSeconds < 40.0)
          Thread.Sleep(200);
        if (frmMain.cmdResult.signature == "" && num < 50)
        {
          ++num;
          Thread.Sleep(1000);
        }
        else
          break;
      }
      aliParameter.setSignature("C3EC8735A5C88713268DE091D3D20D41AD96AA9B");
      AliParameter aliParameter2 = iDevice.AliActiveParameter(iDevice.countryCode);
      aliParameter2.setURL("https://api.aliexpress.com/openapi/param2/101/aliexpress.mobile/deviceInfo/8495");
      frmMain.cmdResult.signature = "";
      frmMain.cmd.getSignature(aliParameter2.getsignparameter(), "8495", "123123");
      DateTime now1 = DateTime.Now;
      while (frmMain.cmdResult.signature == "" && (DateTime.Now - now1).TotalSeconds < 20.0)
        Thread.Sleep(200);
      aliParameter2.setSignature("85A524B6E8040087CE87C88A022C8CA3C2C8A757");
      AliParameter aliParameter3 = iDevice.AliOpenParameter(iDevice.countryCode);
      aliParameter3.setURL("https://api.aliexpress.com/openapi/param2/101/aliexpress.mobile/deviceInfo/8495");
      frmMain.cmdResult.signature = "";
      frmMain.cmd.getSignature(aliParameter3.getsignparameter(), "8495", "123123");
      DateTime now2 = DateTime.Now;
      while (frmMain.cmdResult.signature == "" && (DateTime.Now - now2).TotalSeconds < 20.0)
        Thread.Sleep(200);
      aliParameter3.setSignature("68A7AAB169E67228E9571C44C27975A02881D5D8");
      AliChilkat.SentCheat(aliParameter3, aliParameter2, aliParameter, iDevice, frmMain.cmdResult, LocalConfig.getCurrentConfig().myIP, frmMain.portFake);
    }

    private void bwLead_DoWork(object sender, DoWorkEventArgs e)
    {
      int int32 = Convert.ToInt32(this.numloopip.Value);
      int phantrambk;
      try
      {
        phantrambk = Convert.ToInt32(this.cboptbackup.Value);
      }
      catch
      {
        phantrambk = 0;
      }
      Public.SetListBK(Convert.ToInt32(this.numRunLimit.Value), phantrambk);
      this._bwLeadThread = Thread.CurrentThread;
      if (this._runState == 0)
      {
        Console.WriteLine("*** Lead [resumed]");
        this.setStatusTextFromBackground("Resumed");
      }
      else
      {
        Console.WriteLine("*** Lead [started]");
        this.setStatusTextFromBackground("Started");
        this.needToChangeIP = true;
      }
      this._runState = 1;
label_7:
      while (true)
      {
        try
        {
          bool flag1 = false;
          bool flag2 = false;
          while (!flag1)
          {
            if (frmMain.bool_sub)
            {
              Random random = new Random();
              if (this.txtnumsub.Text == "" || this.txtnumsub.Text == null)
                this.txtnumsub.Text = random.Next(1, 99999).ToString();
              frmMain.fullsub = this.txtsub.Text + "=" + this.txtnumsub.Text;
            }
            if (!frmMain.sttconnect)
            {
              this.lbStatus.Text = "Auto reconnect to iPhone";
              int error = 0;
              string serial = (string) null;
              int num = 0;
              while (!AutoLeadClient.connect(frmMain.ipreconnect, frmMain.keyreconnect, out error, out serial))
              {
                ++num;
                this.lbStatus.Text = "Auto reconnect to iPhone : " + (object) num;
              }
              frmMain.sttconnect = true;
            }
            Array array = (Array) LocalConfig.getCurrentConfig().allOffers().ToArray();
            if (this._currentOpsList == null || this._currentOpsList.Count == 0)
            {
              for (int index = this._currentIndex + 1; index < array.Length; ++index)
              {
                Dictionary<string, object> dict = (Dictionary<string, object>) LocalConfig.getCurrentConfig().allOffers().ToArray().GetValue(index);
                if (Convert.ToBoolean(dict["enable"]))
                {
                  if (!frmMain.sttconnect)
                  {
                    this.lbStatus.Text = "Auto reconnect to iPhone";
                    int error = 0;
                    string serial = (string) null;
                    int num = 0;
                    while (!AutoLeadClient.connect(frmMain.ipreconnect, frmMain.keyreconnect, out error, out serial))
                    {
                      ++num;
                      this.lbStatus.Text = "Auto reconnect to iPhone : " + (object) num;
                    }
                    frmMain.sttconnect = true;
                    this._currentOpsList = (List<Operation>) null;
                    goto label_7;
                  }
                  else
                  {
                    this._currentIndex = index;
                                        this.btnStart.Invoke(new MethodInvoker(delegate
                                        {
                                            this.lbRun.Tag = Convert.ToInt32(this.lbRun.Tag) + 1;
                                            this.lbRun.Text = "Run: " + this.lbRun.Tag;
                                            bool flag38 = frmMain.bool_sub;
                                            if (flag38)
                                            {
                                                frmMain.linkoff = (string)dict["url"] + frmMain.fullsub;
                                            }
                                            else
                                            {
                                                frmMain.linkoff = (string)dict["url"];
                                            }
                                             this._currentOpsList = this.GetOpsListForOffer(dict, this.needToChangeIP);
                                            frmMain.numberLoadurlAgain = Convert.ToInt32(this.numLoadagainUrl.Value);
                                            this.needToChangeIP = false;
                                        }));
                                        break;
                  }
                }
              }
            }
            if (this._currentOpsList == null)
            {
              if (frmMain._runLimit > 0)
              {
                this._currentIndex = -1;
                this.needToChangeIP = true;
                continue;
              }
              flag1 = true;
            }
            else
            {
              bool end = false;
              while (this._currentOpsList.Count > 0)
              {
                do
                  ;
                while (!frmMain.bool_nextstep);
                string description = this._currentOpsList[0].description();
                while (true)
                {
                  if (this.chkloadurlagain.Checked && description == "Will stop loading URL in <t> sec(s)")
                    this._currentOpsList[0].timeout = Convert.ToInt32(this.numURLLoadTime.Value);
                  frmMain.operation = this._currentOpsList[0];
                  if (description == "Script 2")
                  {
                    frmMain.ScriptListRep.Clear();
                    frmMain.BoolstartTimer1 = true;
                    this.btnStart.Invoke(new Action(delegate
                    {
                        this.timer1.Enabled = true;
                        this.timer1.Start();
                    }));
                                    }
                    bool flag16 = frmMain.operation.type == Operation.OperationType.WaitOperation || frmMain.operation.type == Operation.OperationType.WaitForAppStoreOperation;
                    if (flag16)
                    {
                        this.btnStart.Invoke(new Action(delegate
                        {
                            this._currentWaitOp = this._currentOpsList[0];
                            this.lbStatusCountDown.Start();
                        }));
                    }
                    else
                    {
                        this.btnStart.Invoke(new Action(delegate
                        {
                            this.lbStatusCountDown.Stop();
                            this._currentWaitOp = null;
                            this.lbStatus.Text = "Executing [" + description + "]";
                        }));
                    }
                  if (description == "killall")
                  {
                    Operation.Gohome();
                    this.lbStatus.Text = "Executing [Kill all]";
                    for (int index = 0; index < frmMain.ListAppkill.Count; ++index)
                      Operation.Killapp(frmMain.ListAppkill[index].app_id);
                    end = false;
                  }
                  else if (description == "wipeall")
                  {
                    this.lbStatus.Text = "Executing [Wipe data]";
                    this.Wipelee();
                    end = false;
                  }
                  else if (frmMain.bool_startloop && description == "Change IP")
                    end = false;
                  else
                    frmMain.operation.execute(out end, frmMain._runLimit, false);
                  if (end && frmMain.bool_checkRunAppstore)
                  {
                    if (frmMain.operation.type != Operation.OperationType.GetRunningAppOperation)
                    {
                      if (frmMain.operation.type == Operation.OperationType.WaitForAppStoreOperation)
                      {
                        if (this.chkloadurlagain.Checked && frmMain.numberLoadurlAgain > 0)
                        {
                          Operation.Killapp("com.apple.Safari");
                          Thread.Sleep(1000);
                          bool result;
                          ScriptsCore.executeScript("open_url(" + frmMain.linkoff + ",)", out result);
                          --frmMain.numberLoadurlAgain;
                          Thread.Sleep(3000);
                        }
                        else
                          goto label_62;
                      }
                      else
                        goto label_70;
                    }
                    else
                      break;
                  }
                  else
                    goto label_71;
                }
                this.btnStart.Invoke(new Action(delegate
                {
                    this.lbStatus.Text = "Can't run app. End current operation ...";
                }));
                Thread.Sleep(2000);
                goto label_70;
label_62:
                if (!flag2)
                {
                    this.btnStart.Invoke(new Action(delegate
                    {
                        this.lbStatus.Text = "Can't open App Store. Retry ...";
                    }));
                    Thread.Sleep(2000);
                  flag2 = true;
                  --this._currentIndex;
                  this._currentOpsList.Clear();
                  break;
                }
                if (!frmMain.sttconnect)
                {
                  this.lbStatus.Text = "Auto reconnect to iPhone";
                  int error = 0;
                  string serial = (string) null;
                  int num = 0;
                  while (!AutoLeadClient.connect(frmMain.ipreconnect, frmMain.keyreconnect, out error, out serial))
                  {
                    ++num;
                    this.lbStatus.Text = "Auto reconnect to iPhone : " + (object) num;
                  }
                  frmMain.sttconnect = true;
                  this._currentOpsList = (List<Operation>) null;
                  goto label_7;
                }
                else
                {
                    this.btnStart.Invoke(new Action(delegate
                    {
                        this.lbStatus.Text = "Can't open App Store. End current operation ...";
                    }));
                    Thread.Sleep(2000);
                  flag2 = false;
                }
label_70:
                this._currentOpsList.Clear();
                goto label_77;
label_71:
                if (frmMain.operation.type == Operation.OperationType.WaitForAppStoreOperation)
                {
                  if (!frmMain.bool_checkRunAppstore)
                    end = false;
                  else
                    flag2 = false;
                }
label_77:
                if (frmMain.operation.type == Operation.OperationType.BackupOperation)
                {
                    this.btnStart.Invoke(new MethodInvoker(delegate
                    {
                        this.lbBackup.Tag = Convert.ToInt32(this.lbBackup.Tag) + 1;
                        this.lbBackup.Text = "Backup: " + this.lbBackup.Tag;
                    }));
                    if (frmMain.bool_loopip && int32 > 0)
                  {
                    frmMain.bool_startloop = true;
                    --int32;
                  }
                  else
                  {
                    frmMain.bool_startloop = false;
                    int32 = Convert.ToInt32(this.numloopip.Value);
                  }
                }
                if (!end)
                {
                    this._currentOpsList.RemoveAt(0);
                    this.lvRSS.Invoke(new Action(delegate
                    {
                        this.reloadRSSList();
                    }));
                }
                else
                  break;
              }
            }
            if (!flag2)
            {
                this.lvAutoLead.Invoke(new Action(delegate
                {
                }));
                this._currentOpsList = (List<Operation>) null;
              --frmMain._runLimit;
              if (frmMain._runLimit <= 0)
                flag1 = true;
            }
          }
          break;
        }
        catch (ThreadAbortException ex)
        {
          if (this._runState == -2)
          {
            e.Cancel = true;
            Thread.ResetAbort();
            this._runState = 0;
            this._bwLeadThread = (Thread) null;
            Console.WriteLine("*** Lead [reset]");
            this.btnStart.Invoke(new Action(delegate
            {
                this.lbStatusCountDown.Stop();
                this._currentWaitOp = null;
                this._currentOpsList = null;
                this._currentIndex = -1;
                this._runState = -1;
                this.btnStart.Text = "START";
                this.btnReset.Enabled = false;
                this.lbStatus.Text = "Reset done";
            }));
                        return;
          }
          e.Cancel = true;
          Thread.ResetAbort();
          this._runState = 0;
          this._bwLeadThread = (Thread) null;
          Console.WriteLine("*** Lead [paused]");
            this.btnStart.Invoke(new Action(delegate
            {
                this.lbStatusCountDown.Stop();
                this.btnStart.Text = "RESUME";
            }));
            return;
        }
        catch (Exception ex)
        {
          if (!frmMain.sttconnect)
          {
            this.lbStatus.Text = "Auto reconnect to iPhone";
            int error = 0;
            string serial = (string) null;
            int num = 0;
            while (!AutoLeadClient.connect(frmMain.ipreconnect, frmMain.keyreconnect, out error, out serial))
            {
              ++num;
              this.lbStatus.Text = "Auto reconnect to iPhone : " + (object) num;
            }
            frmMain.sttconnect = true;
            this._currentOpsList = (List<Operation>) null;
          }
          else
            this.lbStatus.Text = "Error - Auto resume";
        }
      }
      this._runState = -1;
      this._currentIndex = -1;
      this._bwLeadThread = (Thread) null;
      Console.WriteLine("*** Lead [stoped]");
      this.setStatusTextFromBackground("Done");
        this.btnReset.Invoke(new Action(delegate
        {
            this.lbStatusCountDown.Stop();
            this.btnStart.Text = "START";
            this.btnReset.Enabled = false;
            this._currentWaitOp = null;
        }));
        }

    private void WipeleeRRS()
    {
      if (!AutoLeadClient.send(Operation.jss.Serialize((object) new Dictionary<string, object>()
      {
        ["cmd"] = (object) "Wipelee",
        ["boolrrs"] = (object) "1"
      })))
        return;
      AutoLeadClient.receive();
    }

    private void Wipelee()
    {
      if (!AutoLeadClient.send(Operation.jss.Serialize((object) new Dictionary<string, object>()
      {
        ["cmd"] = (object) nameof (Wipelee)
      })))
        return;
      AutoLeadClient.receive();
    }

    private void lbStatusCountDown_Tick(object sender, EventArgs e)
    {
      ++frmMain.getUptimewait;
      string str1 = this._currentWaitOp.description().ToString();
      if (str1.IndexOf("Will execute [Script 2] in") >= 0 || str1.IndexOf("RRS-Script") >= 0)
      {
        string str2 = Operation.idapp_open;
        if (str1.IndexOf("RRS-Script") >= 0)
          str2 = frmMain.idappRRS;
        if (AutoLeadClient.send(Operation.jss.Serialize((object) new Dictionary<string, object>()
        {
          ["cmd"] = (object) "topmostappsystem"
        })) && AutoLeadClient.receive().IndexOf(str2) < 0)
        {
          string script1Line = "open_app(" + str2 + ")";
          try
          {
            bool result;
            ScriptsCore.executeScript(script1Line, out result);
            this._currentWaitOp.timeout += frmMain.getUptimewait;
            frmMain.getUptimewait = 0;
            frmMain.bool_nextstep = false;
          }
          catch
          {
          }
        }
      }
      if (this._currentWaitOp != null)
      {
        --this._currentWaitOp.timeout;
        if (this._currentWaitOp.timeout == 0)
        {
          frmMain.getUptimewait = 0;
          this.lbStatusCountDown.Stop();
          frmMain.bool_nextstep = true;
        }
        else
          this.lbStatus.Text = this._currentWaitOp.getTimeoutStatusText();
      }
      else
      {
        frmMain.bool_nextstep = true;
        frmMain.getUptimewait = 0;
        this.lbStatusCountDown.Stop();
      }
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Do you want to reset ?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      this.lbBackup.Text = "Backup : 0";
      this.lbRun.Text = "Run : 0";
      this.lbBackup.Tag = (object) 0;
      this.lbRun.Tag = (object) 0;
      this.timer1.Enabled = false;
      this.timer1.Stop();
      if (this._runState == 1)
      {
        try
        {
          this.lvAutoLead.Items[this._currentIndex].BackColor = Color.White;
        }
        catch
        {
        }
        this._runState = -2;
        frmMain._runLimit = 0;
        this._bwLeadThread.Abort();
      }
      else if (this._runState == 0)
      {
        try
        {
          this.lvAutoLead.Items[this._currentIndex].BackColor = Color.White;
        }
        catch
        {
        }
        this._runState = -1;
        frmMain._runLimit = 0;
        this._currentWaitOp = (Operation) null;
        this._currentOpsList = (List<Operation>) null;
        this._currentIndex = -1;
        this.btnStart.Text = "START";
        this.btnReset.Enabled = false;
      }
    }

    public static void removeRSSBK(int index)
    {
      ArrayList arrayList1 = LocalConfig.getCurrentConfig().allRSSs();
      ArrayList arrayList2 = new ArrayList();
      Dictionary<string, object> dictionary = (Dictionary<string, object>) arrayList1[index];
      arrayList2.Add(dictionary["fn"]);
      if (!AutoLeadClient.send(new JavaScriptSerializer().Serialize((object) new Dictionary<string, object>()
      {
        ["type"] = (object) 13,
        ["cmd"] = (object) "sendUE",
        ["names"] = (object) arrayList2
      })))
        return;
      AutoLeadClient.receive();
    }

    public void removeRSS(string name, string ip)
    {
      ArrayList arrayList1 = LocalConfig.getCurrentConfig().allRSSs();
      ArrayList arrayList2 = new ArrayList();
      int index1 = -1;
      for (int index2 = 0; index2 < arrayList1.Count; ++index2)
      {
        Dictionary<string, object> dictionary = (Dictionary<string, object>) arrayList1[index2];
        if (dictionary[nameof (ip)].ToString() == ip && dictionary["fn"].ToString() == name)
          index1 = index2;
      }
      Dictionary<string, object> dictionary1 = (Dictionary<string, object>) arrayList1[index1];
      arrayList2.Add(dictionary1["fn"]);
      if (!AutoLeadClient.send(new JavaScriptSerializer().Serialize((object) new Dictionary<string, object>()
      {
        ["type"] = (object) 13,
        ["cmd"] = (object) "sendUE",
        ["names"] = (object) arrayList2
      })))
        return;
      Console.WriteLine(AutoLeadClient.receive());
      arrayList1.RemoveAt(index1);
      LocalConfig.getCurrentConfig().saveRSSsList();
    }

    public void removeRSSNolead(string name, string ip)
    {
      ArrayList arrayList1 = LocalConfig.getCurrentConfig().allRSSs();
      ArrayList arrayList2 = new ArrayList();
      int index1 = -1;
      for (int index2 = 0; index2 < arrayList1.Count; ++index2)
      {
        Dictionary<string, object> dictionary = (Dictionary<string, object>) arrayList1[index2];
        if (dictionary[nameof (ip)].ToString() == ip && dictionary["fn"].ToString() == name)
          index1 = index2;
      }
      Dictionary<string, object> dictionary1 = (Dictionary<string, object>) arrayList1[index1];
      arrayList2.Add(dictionary1["fn"]);
      if (!AutoLeadClient.send(new JavaScriptSerializer().Serialize((object) new Dictionary<string, object>()
      {
        ["type"] = (object) 13,
        ["cmd"] = (object) "sendUE",
        ["names"] = (object) arrayList2
      })))
        return;
      Console.WriteLine(AutoLeadClient.receive());
      arrayList1.RemoveAt(index1);
      LocalConfig.getCurrentConfig().saveRSSsList();
    }

    private void removeAllRSS()
    {
      ArrayList arrayList1 = LocalConfig.getCurrentConfig().allRSSs();
      ArrayList arrayList2 = new ArrayList();
      foreach (Dictionary<string, object> dictionary in arrayList1)
      {
        string str = dictionary["fn"].ToString();
        arrayList2.Add((object) str);
      }
      if (!AutoLeadClient.send(new JavaScriptSerializer().Serialize((object) new Dictionary<string, object>()
      {
        ["type"] = (object) 13,
        ["cmd"] = (object) "sendUE",
        ["names"] = (object) arrayList2
      })))
        return;
      Console.WriteLine(AutoLeadClient.receive());
      arrayList1.Clear();
      LocalConfig.getCurrentConfig().saveRSSsList();
      this.reloadRSSList();
      frmMain.UpRRSFtp();
    }

    private void btnRemoveAllRSS_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("This operation will remove all RSS. Continue ?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      this.removeAllRSS();
    }

    private void btnRemoveRSS_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("This operation will remove selected RSS. Continue ?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      this.lbStatus.Text = "Remove RRS";
      new Thread(new ThreadStart(this.RemoveRRSLee)).Start();
    }

    private void RemoveRRSLee()
    {
      for (int index = 0; index < this.lvRSS.Items.Count; ++index)
      {
        if (this.lvRSS.Items[index].Checked)
          this.removeRSS(Split.tachchuoi(this.lvRSS.Items[index].SubItems[0].Text, "|")[1], this.lvRSS.Items[index].SubItems[6].Text);
      }
      this.reloadRSSList();
      frmMain.UpRRSFtp();
      this.lbStatus.Text = "Remove RRS done";
    }

    private void lvRSS_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (e.NewValue == CheckState.Checked && e.CurrentValue == CheckState.Unchecked)
      {
        this.lbSelectedRSS.Tag = (object) (Convert.ToInt32(this.lbSelectedRSS.Tag) + 1);
        this.lbSelectedRSS.Text = "Enabled: " + this.lbSelectedRSS.Tag;
      }
      else
      {
        if (e.NewValue != CheckState.Unchecked || e.CurrentValue != CheckState.Checked)
          return;
        this.lbSelectedRSS.Tag = (object) (Convert.ToInt32(this.lbSelectedRSS.Tag) - 1);
        this.lbSelectedRSS.Text = "Enabled: " + this.lbSelectedRSS.Tag;
      }
    }

    private void RRS_Itemcheck(ItemCheckEventArgs e)
    {
      if (e.NewValue == CheckState.Checked && e.CurrentValue == CheckState.Unchecked)
      {
        this.lbSelectedRSS.Tag = (object) (Convert.ToInt32(this.lbSelectedRSS.Tag) + 1);
        this.lbSelectedRSS.Text = "Enabled: " + this.lbSelectedRSS.Tag;
      }
      else
      {
        if (e.NewValue != CheckState.Unchecked || e.CurrentValue != CheckState.Checked)
          return;
        this.lbSelectedRSS.Tag = (object) (Convert.ToInt32(this.lbSelectedRSS.Tag) - 1);
        this.lbSelectedRSS.Text = "Enabled: " + this.lbSelectedRSS.Tag;
      }
    }

    private void lvRSS_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.lvRSS.SelectedIndices.Count > 0)
      {
        this.btnRestoreRSS.Enabled = true;
        this.btnRemoveRSS.Enabled = true;
        this.btnSaveRSS.Enabled = true;
        this.tbRSSComment.Enabled = true;
        this.btnSaveRSSComment.Enabled = true;
        this.tbRSSComment.Text = ((Dictionary<string, object>) LocalConfig.getCurrentConfig().allRSSs()[this.lvRSS.SelectedIndices[0]])["cm"].ToString();
      }
      else
      {
        this.btnRestoreRSS.Enabled = false;
        this.btnRemoveRSS.Enabled = false;
        this.btnSaveRSS.Enabled = false;
        this.tbRSSComment.Enabled = false;
        this.btnSaveRSSComment.Enabled = false;
      }
    }

    private void btnSaveRSSComment_Click(object sender, EventArgs e)
    {
      if (this.lvRSS.SelectedIndices.Count <= 0)
        return;
      int selectedIndex = this.lvRSS.SelectedIndices[0];
      ((Dictionary<string, object>) LocalConfig.getCurrentConfig().allRSSs()[selectedIndex])["cm"] = (object) this.tbRSSComment.Text;
      LocalConfig.getCurrentConfig().saveOffersList();
      this.lvRSS.Items[selectedIndex].SubItems[7].Text = this.tbRSSComment.Text;
    }

    private void tbRSSComment_TextChanged(object sender, EventArgs e)
    {
    }

    private void numURLLoadTime_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.numURLLoadTime.Value, "URLLoadTime");
    }

    private void numRunLimit_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.numRunLimit.Value, "LeadRunTime");
    }

    private void cbBackup_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbBackup.Checked, "DoBackup");
    }

    private void cbFullWipe_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbFullWipe.Checked, "FullWipe");
    }

    private void cbAppStore_CheckStateChanged(object sender, EventArgs e)
    {
    }

    private void cbAppStore_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbAppStore.Checked, "cbAppStore");
    }

    private void cbSafari_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbSafari.Checked, "cbSafari");
    }

    private void tbComment_TextChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.tbComment.Text, "Comment");
    }

    private List<Operation> GetOpsListForRestoreRSS(Dictionary<string, object> dict, int wait, string scriptname, bool save)
    {
      List<Operation> operationList = new List<Operation>();
      Operation.dict.Clear();
      Operation.dict.Add("tz", (object) dict["tz"].ToString());
      Operation.dict.Add("locale", (object) dict["locale"].ToString());
      Operation.dict.Add("lang", (object) dict["lang"].ToString());
      Operation.dict.Add("carrier", (object) dict["carrier"].ToString());
      Operation.dict.Add("mcc", (object) dict["mcc"].ToString());
      try
      {
        Operation.dict.Add("mnc", (object) dict["mnc"].ToString());
      }
      catch
      {
        Operation.dict.Add("mnc", (object) "800");
      }
      try
      {
        Operation.dict.Add("BSSID", (object) dict["BSSID"].ToString());
      }
      catch
      {
        string str = (string) null + GlobalConfig.RandomString("0123456789abcde", 2) + ":" + GlobalConfig.RandomString("0123456789abcde", 2) + ":" + GlobalConfig.RandomString("0123456789abcde", 2) + ":" + GlobalConfig.RandomString("0123456789abcde", 2) + ":" + GlobalConfig.RandomString("0123456789abcde", 2) + ":" + GlobalConfig.RandomString("0123456789abcde", 2);
        Operation.dict.Add("BSSID", (object) str);
      }
      Operation.dict.Add("iso", (object) dict["iso"].ToString());
      Operation.dict.Add("location_x", (object) dict["location_x"].ToString());
      Operation.dict.Add("location_y", (object) dict["location_y"].ToString());
      Operation.dict.Add("name", (object) dict["name"].ToString());
      Operation.dict.Add("systemVersion", (object) dict["systemVersion"].ToString());
      Operation.dict.Add("buildversion", (object) dict["buildversion"].ToString());
      Operation.dict.Add("model", (object) dict["model"].ToString());
      Operation.dict.Add("machine", (object) dict["machine"].ToString());
      Operation.dict.Add("ua", (object) dict["ua"].ToString());
      Operation.dict.Add("serial", (object) dict["serial"].ToString());
      Operation.dict.Add("imei", (object) dict["imei"].ToString());
      Operation.dict.Add("modelVersion", (object) dict["modelVersion"].ToString());
      Operation.dict.Add("ModemVersion", (object) dict["ModemVersion"].ToString());
      try
      {
        Operation.dict.Add("AppleLocale", (object) dict["AppleLocale"].ToString());
        Operation.dict.Add("AppleLanguages", (object) dict["AppleLanguages"].ToString());
      }
      catch
      {
        Operation.dict.Add("AppleLocale", (object) dict["lang"].ToString());
        Operation.dict.Add("AppleLanguages", (object) dict["lang"].ToString().Replace("_", "-"));
      }
      try
      {
        Operation.dict.Add("sub", (object) dict["sub"].ToString());
      }
      catch
      {
        Operation.dict.Add("sub", (object) "");
      }
      try
      {
        Operation.dict.Add("yearcpr", (object) dict["yearcpr"].ToString());
        Operation.dict.Add("setfakegeo", (object) dict["setfakegeo"].ToString());
        Operation.dict.Add("setfakeUa", (object) dict["setfakeUa"].ToString());
        Operation.dict.Add("setfakescreen", (object) dict["setfakescreen"].ToString());
      }
      catch
      {
      }
      string _appId1 = dict["app"].ToString();
      frmMain.idappRRS = _appId1;
      string str1 = dict["an"].ToString();
      string _name = dict["fn"].ToString();
      dict["to"].ToString();
      dict["lo"].ToString();
      if (_appId1.Equals(Operation.CurrentAppId))
        _appId1 = dict["ai"].ToString();
      Dictionary<string, object> dictionary = (Dictionary<string, object>) null;
      if (dict.ContainsKey("ssh"))
        dictionary = (Dictionary<string, object>) dict["ssh"];
      operationList.Add(Operation.NewScriptOperation("ilead", "killall"));
      frmMain.ListAppkill.Clear();
      frmMain.ListAppkill.Add(new Listapp()
      {
        app_id = "com.apple.AppStore",
        app_name = ""
      });
      frmMain.ListAppkill.Add(new Listapp()
      {
        app_id = "com.apple.Safari",
        app_name = ""
      });
      frmMain.ListAppkill.Add(new Listapp()
      {
        app_id = _appId1,
        app_name = str1
      });
      operationList.Add(Operation.NewScriptOperation("ilead", "wipeall"));
      operationList.Add(Operation.NewScriptOperation("wipe(com.apple.mobilesafari)", "Wipe Safari"));
      operationList.Add(Operation.NewScriptOperation("wipe(" + _appId1 + ")", "Wipe " + str1));
      operationList.Add(Operation.NewChangeIPOperation(this, "Change IP"));
      string _appId2 = "com.apple.mobilesafari|" + _appId1;
      operationList.Add(Operation.NewFakeInfoOperation(_appId2, true, "Fake Info "));
      operationList.Add(Operation.NewScriptOperation("restore(" + _name + "," + _appId1 + ")", "Restore " + str1 ?? ""));
      operationList.Add(Operation.NewScriptOperation("open_app(" + _appId1 + ")", "Open app"));
      if (wait > 0)
      {
        if (scriptname != null)
          operationList.Add(Operation.NewWaitOperation(wait, "Will execute [RRS-Script " + scriptname + "] in <t> sec(s)"));
        else
          operationList.Add(Operation.NewWaitOperation(wait, "Will close [" + str1 + "] in <t> sec(s)"));
      }
      if (scriptname != null && System.IO.File.Exists(LocalConfig.getCurrentConfig().configDirectory() + "/Scripts/" + scriptname))
      {
        string _script = System.IO.File.ReadAllText(LocalConfig.getCurrentConfig().configDirectory() + "/Scripts/" + scriptname);
        if (_script != null)
          operationList.Add(Operation.NewScriptOperation(_script, "Script RRS" + scriptname));
      }
      if (save)
      {
        operationList.Add(Operation.NewSaveOperation(_name, _appId1, "Save " + str1));
        operationList.Add(Operation.NewWaitOperation(3, "Will exit [" + str1 + "] in <t> sec(s)"));
        operationList.Add(Operation.NewScriptOperation("exit()", "Exit " + str1));
      }
      return operationList;
    }

    private void btnRestoreRSS_Click(object sender, EventArgs e)
    {
      if (this.btnRestoreRSS.Text.Equals("Stop"))
      {
        this._bwRSSThread.Abort();
        this.btnRestoreRSS.Text = "Restore";
        this.btnStartRSS.Enabled = true;
        if (this.lvRSS.SelectedIndices.Count > 0)
        {
          this.btnRemoveRSS.Enabled = true;
          this.btnSaveRSS.Enabled = true;
        }
        this.btnRemoveAllRSS.Enabled = true;
      }
        else
        {
            int index = 0;
            this.lvRSS.Invoke(new Action(delegate
            {
                index = this.lvRSS.SelectedIndices[0];
            }));
            this._RestoreIndex = index;
            bool flag3 = this.lvRSS.SelectedIndices.Count > 0;
            if (flag3)
            {
                this.btnRestoreRSS.Text = "Stop";
                this.bwRestoreRSS.RunWorkerAsync();
                this.btnStartRSS.Enabled = false;
                this.btnRemoveRSS.Enabled = false;
                this.btnSaveRSS.Enabled = false;
                this.btnRemoveAllRSS.Enabled = false;
            }
        }
        }

    private void cbScriptList_SelectedIndexChanged(object sender, EventArgs e)
    {
      string str = this.cbScriptList.SelectedItem.ToString();
      if (str == null)
        return;
      LocalConfig.getCurrentConfig().setObjectForKey((object) str, "SelectedScriptForRSS");
    }

    private void rbButtonNoScript_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) 0, "RSSScriptType");
    }

    private void rbButtonRandomScript_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) 1, "RSSScriptType");
    }

    private void rbThisScript_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) 2, "RSSScriptType");
    }

    private void numWaitTime_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.numWaitTime.Value, "WaitTime");
    }

    private void btnStartRSS_Click(object sender, EventArgs e)
    {
      frmMain.patchfileMail = this.txtfileMail.Text;
      frmMain.bool_nextstep = true;
      this.UpdateRunVip();
      if (this._runState == -1 || this._runState == 0)
      {
        frmMain._runLimit = Convert.ToInt32(this.lbSelectedRSS.Tag);
        this.btnStartRSS.Text = "PAUSE";
        this.bwRSS.RunWorkerAsync();
        this.btnResetRSS.Enabled = true;
      }
      else
      {
        if (this._runState != 1 || this._bwRSSThread == null)
          return;
        this.btnStartRSS.Text = "RESUME";
        this._bwRSSThread.Abort();
      }
    }

    private void btnSaveRSS_Click(object sender, EventArgs e)
    {
      if (this.lvRSS.SelectedIndices.Count <= 0)
        return;
      int selectedIndex = this.lvRSS.SelectedIndices[0];
      Dictionary<string, object> allRsS = (Dictionary<string, object>) LocalConfig.getCurrentConfig().allRSSs()[selectedIndex];
      string str1 = allRsS["app"].ToString();
      string str2 = allRsS["an"].ToString();
      string str3 = allRsS["fn"].ToString();
      bool result = false;
      this.lbStatus.Text = "Saving [" + str2 + "] ...";
      if (!ScriptsCore.executeScript("backup(" + str3 + ", " + str1 + ")", out result) || !result)
      {
        this.lbStatus.Text = "";
        int num = (int) MessageBox.Show("Error. Could not backup [" + str2 + "]", "", MessageBoxButtons.OK);
      }
      else
      {
        allRsS["md"] = (object) DateTime.Now;
        if (GlobalConfig.currentPublicIP != null)
        {
          allRsS["ip"] = (object) GlobalConfig.currentPublicIP;
          allRsS["lo"] = (object) GlobalConfig.currentPublicIPWithLocationInfo;
        }
        allRsS.Remove("ssh");
        if (GlobalConfig.currentSSH != null)
          allRsS["ssh"] = (object) GlobalConfig.currentSSH;
        LocalConfig.getCurrentConfig().saveRSSsList();
        ListViewItem.ListViewSubItem subItem = this.lvRSS.Items[selectedIndex].SubItems[2];
        DateTime dateTime = DateTime.Now;
        dateTime = dateTime.ToLocalTime();
        string str4 = dateTime.ToString();
        subItem.Text = str4;
        this.lvRSS.Items[selectedIndex].SubItems[6].Text = allRsS["ip"].ToString();
        this.lbStatus.Text = "Saved [" + str2 + "]";
      }
    }

    private void bwRSS_DoWork(object sender, DoWorkEventArgs e)
    {
      this._bwRSSThread = Thread.CurrentThread;
      if (this._runState == 0)
      {
        Console.WriteLine("*** RSS [resumed]");
        this.setStatusTextFromBackground("Resumed");
      }
      else
      {
        Console.WriteLine("*** RSS [started]");
        this.setStatusTextFromBackground("Started");
      }
      this._runState = 1;
label_4:
      while (true)
      {
        try
        {
          bool flag1 = false;
          while (!flag1)
          {
            Array array = (Array) LocalConfig.getCurrentConfig().allRSSs().ToArray();
            if (this._currentOpsList == null || this._currentOpsList.Count == 0)
            {
              for (int index = this._currentIndex + 1; index < array.Length; ++index)
              {
                Dictionary<string, object> dict = (Dictionary<string, object>) LocalConfig.getCurrentConfig().allRSSs().ToArray().GetValue(index);
                bool flag2 = dict.ContainsKey("selected") && Convert.ToBoolean(dict["selected"]);
                if (this.lvRSS.Items[index].Checked)
                {
                  if (!frmMain.sttconnect)
                  {
                    this.lbStatus.Text = "Auto reconnect to iPhone";
                    int error = 0;
                    string serial = (string) null;
                    int num = 0;
                    while (!AutoLeadClient.connect(frmMain.ipreconnect, frmMain.keyreconnect, out error, out serial))
                    {
                      ++num;
                      this.lbStatus.Text = "Auto reconnect to iPhone : " + (object) num;
                    }
                    frmMain.sttconnect = true;
                    this._currentOpsList = (List<Operation>) null;
                    goto label_4;
                  }
                  else
                  {
                    this.sttEunRRS.Text = (index + 1).ToString() + "-" + dict["fn"].ToString();
                    this._currentIndex = index;
                    frmMain.idRRS = index;
                    this.btnStart.Invoke(new MethodInvoker(delegate
                    {
                        int wait = Convert.ToInt32(this.numWaitTime.Value);
                        string text4 = null;
                        bool checked2 = this.rbButtonNoScript.Checked;
                        if (checked2)
                        {
                            text4 = null;
                        }
                        else
                        {
                            bool checked3 = this.rbThisScript.Checked;
                            if (checked3)
                            {
                                text4 = this.cbScriptList.SelectedItem.ToString();
                                bool flag24 = text4.Length == 0;
                                if (flag24)
                                {
                                    text4 = null;
                                }
                            }
                            else
                            {
                                List<string> list = LocalConfig.getCurrentConfig().allScripts();
                                bool flag25 = list.Count > 0;
                                if (flag25)
                                {
                                    string text5 = GlobalConfig.randItem(list.ToArray());
                                    text4 = text5;
                                }
                            }
                        }
                        this._currentOpsList = this.GetOpsListForRestoreRSS(dict, wait, text4, true);
                    }));
                                        break;
                  }
                }
              }
            }
            if (this._currentOpsList == null)
            {
              if (frmMain._runLimit > 0)
              {
                this._currentIndex = -1;
                continue;
              }
              flag1 = true;
            }
            else
            {
              bool end = false;
                this.lvRSS.Invoke(new Action(delegate
                {
                    this.lvRSS.Items[this._currentIndex].BackColor = Color.Yellow;
                }));
                while (this._currentOpsList.Count > 0)
              {
                do
                  ;
                while (!frmMain.bool_nextstep);
                string description = this._currentOpsList[0].description();
                Operation currentOps = this._currentOpsList[0];
                if (description.IndexOf("Script RRS") >= 0)
                {
                  frmMain.ScriptListRep.Clear();
                  frmMain.BoolstartTimer1 = true;
                  this.btnStart.Invoke(new Action(delegate
                  {
                    this.timer1.Enabled = true;
                    this.timer1.Start();
                  }));
                }
                if (currentOps.type == Operation.OperationType.WaitOperation)
                  this.btnStart.Invoke(new Action(delegate
                  {
                    this._currentWaitOp = this._currentOpsList[0];
                    this.lbStatusCountDown.Start();
                  }));
                else
                  this.btnStart.Invoke(new Action(delegate
                  {
                    this.lbStatusCountDown.Stop();
                    this._currentWaitOp = (Operation) null;
                    this.lbStatus.Text = "Executing [" + description + "]";
                  }));
                if (description == "killall")
                {
                  Operation.Gohome();
                  this.lbStatus.Text = "Executing [Kill all]";
                  for (int index = 0; index < frmMain.ListAppkill.Count; ++index)
                    Operation.Killapp(frmMain.ListAppkill[index].app_id);
                  end = false;
                }
                else if (description == "wipeall")
                {
                  this.lbStatus.Text = "Executing [Wipe data]";
                  this.WipeleeRRS();
                }
                else if (!frmMain.sttconnect)
                {
                  this.lbStatus.Text = "Auto reconnect to iPhone";
                  int error = 0;
                  string serial = (string) null;
                  int num = 0;
                  while (!AutoLeadClient.connect(frmMain.ipreconnect, frmMain.keyreconnect, out error, out serial))
                  {
                    ++num;
                    this.lbStatus.Text = "Auto reconnect to iPhone : " + (object) num;
                  }
                  frmMain.sttconnect = true;
                  this._currentOpsList = (List<Operation>) null;
                  goto label_4;
                }
                else
                  currentOps.execute(out end, frmMain._runLimit, true);
                if (end)
                  this._currentOpsList.Clear();
                if (currentOps.type == Operation.OperationType.SaveOperation)
                {
                  Dictionary<string, object> allRsS = (Dictionary<string, object>) LocalConfig.getCurrentConfig().allRSSs()[this._currentIndex];
                  allRsS.Remove("ssh");
                  if (GlobalConfig.currentSSH != null)
                    allRsS["ssh"] = (object) GlobalConfig.currentSSH;
                  allRsS["md"] = (object) DateTime.Now;
                  allRsS["rt"] = (object) (Convert.ToInt32(allRsS["rt"]) + 1);
                  LocalConfig.getCurrentConfig().saveRSSsList();
                  this.lvRSS.Invoke(new Action(delegate
                  {
                    this.lvRSS.Items[this._currentIndex].Checked = false;
                    this.lvRSS.Items[this._currentIndex].BackColor = Color.White;
                    ListViewItem.ListViewSubItem subItem = this.lvRSS.Items[this._currentIndex].SubItems[2];
                    DateTime dateTime = DateTime.Now;
                    dateTime = dateTime.ToLocalTime();
                    string str = dateTime.ToString();
                    subItem.Text = str;
                    this.lvRSS.Items[this._currentIndex].SubItems[3].Text = Convert.ToString(Convert.ToInt32(this.lvRSS.Items[this._currentIndex].SubItems[3].Text) + 1);
                  }));
                  frmMain.UpRRSFtp();
                }
                if (!end)
                  this._currentOpsList.RemoveAt(0);
                else
                  break;
              }
            }
            this._currentOpsList = (List<Operation>) null;
            --frmMain._runLimit;
            if (frmMain._runLimit <= 0)
              flag1 = true;
          }
          this.sttEunRRS.Text = "";
          frmMain.idRRS = -1;
          break;
        }
        catch (ThreadAbortException ex)
        {
          if (this._runState == -2)
          {
            e.Cancel = true;
            Thread.ResetAbort();
            this._runState = 0;
            this._bwRSSThread = (Thread) null;
            Console.WriteLine("*** RSS [reset]");
            this.btnStartRSS.Invoke(new Action(delegate
            {
              this.lbStatusCountDown.Stop();
              this._currentWaitOp = (Operation) null;
              this._currentOpsList = (List<Operation>) null;
              this._currentIndex = -1;
              this._runState = -1;
              this.btnStartRSS.Text = "START";
              this.btnResetRSS.Enabled = false;
              this.lbStatus.Text = "Reset done";
            }));
            return;
          }
          e.Cancel = true;
          Thread.ResetAbort();
          this._runState = 0;
          this._bwRSSThread = (Thread) null;
          Console.WriteLine("*** RSS [paused]");
          this.btnStartRSS.Invoke(new Action(delegate
          {
            this.lbStatusCountDown.Stop();
            this.btnStartRSS.Text = "RESUME";
          }));
          return;
        }
        catch (Exception ex)
        {
          if (!frmMain.sttconnect)
          {
            this.lbStatus.Text = "Auto reconnect to iPhone";
            int error = 0;
            string serial = (string) null;
            int num = 0;
            while (!AutoLeadClient.connect(frmMain.ipreconnect, frmMain.keyreconnect, out error, out serial))
            {
              ++num;
              this.lbStatus.Text = "Auto reconnect to iPhone : " + (object) num;
            }
            frmMain.sttconnect = true;
            this._currentOpsList = (List<Operation>) null;
          }
          else
            this.lbStatus.Text = "Error - Auto resume";
                    Thread.Sleep(1000);
        }
      }
      this._runState = -1;
      this._currentIndex = -1;
      this._bwRSSThread = (Thread) null;
      Console.WriteLine("*** RSS [stoped]");
      this.setStatusTextFromBackground("Done");
      this.sttEunRRS.Text = "";
      this.btnResetRSS.Invoke(new Action(delegate
      {
        this.lbStatusCountDown.Stop();
        this.btnStartRSS.Text = "START";
        this.btnResetRSS.Enabled = false;
        this._currentWaitOp = (Operation) null;
      }));
    }

    private void btnResetRSS_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Do you want to reset ?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      frmMain.i_ptRRS = 0;
      frmMain.i_limitptRRS = 0;
      frmMain.dayrrs = 0;
      frmMain.ptRRS = 0;
      frmMain.totalRRSSelectRemove = 0;
      this.timer1.Enabled = false;
      this.timer1.Stop();
      if (this._runState == 1)
      {
        try
        {
          this.lvRSS.Items[this._currentIndex].BackColor = Color.White;
        }
        catch
        {
        }
        this._runState = -2;
        frmMain._runLimit = 0;
        this._bwRSSThread.Abort();
      }
      else if (this._runState == 0)
      {
        try
        {
          this.lvRSS.Items[this._currentIndex].BackColor = Color.White;
        }
        catch
        {
        }
        this._runState = -1;
        frmMain._runLimit = 0;
        this._currentWaitOp = (Operation) null;
        this._currentOpsList = (List<Operation>) null;
        this._currentIndex = -1;
        this.btnStartRSS.Text = "START";
        this.btnResetRSS.Enabled = false;
      }
    }

    private void cbAutoFakeLocation_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cbAutoFakeLocation.Checked)
      {
        this.cbFakeCarrier.Enabled = false;
        this.cbFakeRegion.Enabled = false;
        this.cbFakeTimeZone.Enabled = false;
        this.cbFakeGPS.Enabled = false;
        this.numLat.Enabled = false;
        this.numLong.Enabled = false;
        this.combFakeCarrier.Enabled = false;
        this.combFakeRegion.Enabled = false;
        this.combFakeTimezone.Enabled = false;
        LocalConfig.getCurrentConfig().setObjectForKey((object) true, "FakeLocationFromIP");
      }
      else
      {
        this.cbFakeCarrier.Enabled = true;
        this.cbFakeLang.Enabled = true;
        this.cbFakeRegion.Enabled = true;
        this.cbFakeTimeZone.Enabled = true;
        this.cbFakeGPS.Enabled = true;
        this.numLat.Enabled = true;
        this.numLong.Enabled = true;
        this.combFakeCarrier.Enabled = true;
        this.combFakeLang.Enabled = true;
        this.combFakeRegion.Enabled = true;
        this.combFakeTimezone.Enabled = true;
        LocalConfig.getCurrentConfig().setObjectForKey((object) false, "FakeLocationFromIP");
      }
    }

    private void cbFakeDeviceFromFile_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cbFakeDeviceFromFile.Checked)
      {
        this.tbFakeDeviceName.Enabled = false;
        this.combFakeIOSVersion.Enabled = false;
        this.combFakeDeviceModel.Enabled = false;
        LocalConfig.getCurrentConfig().setObjectForKey((object) true, "FakeDeviceFromFile");
      }
      else
      {
        this.tbFakeDeviceName.Enabled = true;
        this.combFakeIOSVersion.Enabled = true;
        this.combFakeDeviceModel.Enabled = true;
        LocalConfig.getCurrentConfig().setObjectForKey((object) false, "FakeDeviceFromFile");
      }
    }

    private void cbFakeTimeZone_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbFakeTimeZone.Checked, "fakeTzEnable");
    }

    private void cbFakeCarrier_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbFakeCarrier.Checked, "fakeCaEnable");
    }

    private void cbFakeRegion_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbFakeRegion.Checked, "fakeRegionEnable");
    }

    private void cbFakeLang_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbFakeLang.Checked, "fakelangEnable");
    }

    private void cbFakeGPS_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbFakeGPS.Checked, "fakeLocationEnable");
    }

    private void combFakeTimezone_SelectedIndexChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.combFakeTimezone.SelectedIndex, "fakeTz");
    }

    private void combFakeCarrier_SelectedIndexChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.combFakeCarrier.SelectedIndex, "fakeCa");
    }

    private void combFakeRegion_SelectedIndexChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.combFakeRegion.SelectedIndex, "fakeRegion");
    }

    private void combFakeLang_SelectedIndexChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.combFakeLang.SelectedIndex, "fakeLang");
    }

    private void combFakeIOSVersion_SelectedIndexChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.combFakeIOSVersion.SelectedIndex, "fakeVersion");
    }

    private void combFakeDeviceModel_SelectedIndexChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.combFakeDeviceModel.SelectedIndex, "fakeModel");
    }

    private void numLat_TextChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.numLat.Text, "fakeLocationLat");
    }

    private void numLong_TextChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.numLong.Text, "fakeLocationLong");
    }

    private void tbFakeDeviceName_TextChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.tbFakeDeviceName.Text, "fakeName");
    }

    private void tcMain_Selecting(object sender, TabControlCancelEventArgs e)
    {
      if (e.TabPage != this.tpProxy)
      {
        if (e.TabPage == this.tpRSS)
            rrsselect = true;
        else
            rrsselect = false;
        return;
      }
      this.reloadSSHsList();
    }

    private void btnDeleteDead_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Do you want to delete all dead ssh ?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      List<object> objectList = new List<object>();
      ArrayList arrayList = LocalConfig.getCurrentConfig().allSSHs();
      for (int index = 0; index < arrayList.Count; ++index)
      {
        Dictionary<string, object> dictionary = (Dictionary<string, object>) arrayList[index];
        if (dictionary.ContainsKey("status") && !Convert.ToBoolean(dictionary["status"]))
          objectList.Add((object) dictionary);
      }
      foreach (object obj in objectList)
        LocalConfig.getCurrentConfig().allSSHs().Remove(obj);
      LocalConfig.getCurrentConfig().saveSSHsList();
      this.reloadSSHsList();
      this.reloadCountriesList();
    }

    private void reloadLicenseKeys()
    {
      try
      {
        Dictionary<string, object> dictionary1 = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(System.IO.File.ReadAllText(GlobalConfig.executableDirectory() + "\\License.list"));
        this.tbKeyActivation.Text = dictionary1["key"].ToString();
        ArrayList arrayList = (ArrayList) dictionary1["list"];
        if (Convert.ToInt32(dictionary1["result"]) == 1)
        {
          this.lvRegisteredList.Items.Clear();
          foreach (Dictionary<string, object> dictionary2 in arrayList)
          {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = dictionary2["serial"].ToString();
            DateTime dateTime = (DateTime) dictionary2["exp"];
            listViewItem.SubItems.Add(dateTime.ToLocalTime().ToString());
            this.lvRegisteredList.Items.Add(listViewItem);
          }
          this.btnActivate.Text = "Refresh";
        }
        else
        {
          this.btnActivate.Text = "Activate";
          this.lvRegisteredList.Items.Clear();
        }
      }
      catch
      {
        this.btnActivate.Text = "Activate";
        this.lvRegisteredList.Items.Clear();
      }
    }

    private void btnActivate_Click(object sender, EventArgs e)
    {
      string text = this.tbKeyActivation.Text;
      string input = (string) null;
      using (HttpWebResponse response = (HttpWebResponse) WebRequest.Create("http://" + this.IP + "/autolead/list.php?key=" + text).GetResponse())
      {
        using (Stream responseStream = response.GetResponseStream())
        {
          using (StreamReader streamReader = new StreamReader(responseStream))
            input = streamReader.ReadToEnd();
        }
      }
      if (input != null)
      {
        JavaScriptSerializer scriptSerializer = new JavaScriptSerializer();
        Dictionary<string, object> dictionary = scriptSerializer.Deserialize<Dictionary<string, object>>(input);
        if (Convert.ToInt32(dictionary["result"]) == 1)
        {
          ArrayList arrayList1 = (ArrayList) dictionary["list"];
          ArrayList arrayList2 = new ArrayList();
          for (int index = 0; index < arrayList1.Count; ++index)
          {
            string[] strArray = GlobalConfig.stringSplit(arrayList1[index].ToString(), " ");
            if (strArray.Length == 4)
            {
              string str = strArray[0];
              DateTime exact = DateTime.ParseExact(strArray[2] + " " + strArray[3] + " +07:00", "yyyy-MM-dd HH:mm:ss zzz", (IFormatProvider) CultureInfo.InvariantCulture);
              arrayList2.Add((object) new Dictionary<string, object>()
              {
                ["serial"] = (object) str,
                ["exp"] = (object) exact
              });
            }
          }
          dictionary["key"] = (object) text;
          dictionary["list"] = (object) arrayList2;
          System.IO.File.WriteAllText(GlobalConfig.executableDirectory() + "\\License.list", scriptSerializer.Serialize((object) dictionary));
          this.reloadLicenseKeys();
        }
        else
        {
          int num = (int) MessageBox.Show("Invalid key", "", MessageBoxButtons.OK);
          this.reloadLicenseKeys();
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Connection problem. Please connect to internet to activate", "", MessageBoxButtons.OK);
      }
    }

    private void frmMain_Resize(object sender, EventArgs e)
    {
    }

    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);
    }

    private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      try
      {
        frmMain.sftpclient.Disconnect();
      }
      catch
      {
      }
      Process.GetCurrentProcess().Kill();
    }

    private void cbChangeIPWhenCheckIPReturnsFalse_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbChangeIPWhenCheckIPReturnsFalse.Checked, "AutoChangeIP");
    }

    private void cbAutoChangeIPRRS_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbAutoChangeIPRRS.Checked, "AutoChangeIPRRS");
    }

    private void changeIPTimer_Tick(object sender, EventArgs e)
    {
      this.changeIPTimer.Stop();
      this.btnStart.PerformClick();
    }

    private void changeIPTimer2_Tick(object sender, EventArgs e)
    {
      this.changeIPTimer2.Stop();
      this.btnStartRSS.PerformClick();
    }

    private void bwRestoreRSS_DoWork(object sender, DoWorkEventArgs e)
    {
        this._bwRSSThread = Thread.CurrentThread;
        this._runState = 1;
        int index = this._RestoreIndex;
        ArrayList arrayList = LocalConfig.getCurrentConfig().allRSSs();
        string app_name = (string)null;
        bool reset = false;
        try
        {
            Dictionary<string, object> dict = (Dictionary<string, object>)arrayList[index];
            app_name = dict["an"].ToString();
            List<Operation> ops = this.GetOpsListForRestoreRSS(dict, 0, (string)null, false);
            if (sender == null)
            {
                ops.RemoveAt(0);
                ops.RemoveAt(1);
                ops.Insert(0, Operation.NewWaitOperation(10, "Will change IP in <t> sec(s)"));
                ops.Insert(1, Operation.NewChangeIPOperation(this, "Change IP"));
                ops.Insert(2, Operation.NewWaitOperation(LocalConfig.getCurrentConfig().getInt32ForKey("ConnectionTime"), "Will check IP in <t> sec(s)"));
            }
            this.lvRSS.Invoke(new Action(delegate
            {
                this.lvRSS.Items[index].BackColor = Color.Yellow;
            }));
            while (ops.Count > 0)
            {
                string description = ops[0].description();
                Operation operation = ops[0];
                if (operation.type == Operation.OperationType.WaitOperation)
                    this.btnStart.Invoke(new Action(delegate
                    {
                        this._currentWaitOp = ops[0];
                        this.lbStatusCountDown.Start();
                    }));
                else
                    this.btnStart.Invoke(new Action(delegate
                    {
                        this.lbStatusCountDown.Stop();
                        this._currentWaitOp = (Operation)null;
                        this.lbStatus.Text = "Executing [" + description + "]";
                    }));
                bool end;
                operation.execute(out end, frmMain._runLimit, true);
                ops.RemoveAt(0);
                if (ops.Count == 0)
                    this.btnStart.Invoke(new Action(delegate
                    {
                        this.lvRSS.Items[index].BackColor = Color.White;
                        this.setStatusTextFromBackground("Restored [" + app_name + "]");
                    }));
            }
        }
        catch (ThreadAbortException ex)
        {
            e.Cancel = true;
            Thread.ResetAbort();
            this._bwRSSThread = (Thread)null;
            this.btnStartRSS.Invoke(new Action(delegate
            {
                this.lbStatusCountDown.Stop();
                this.lbStatus.Text = "";
            }));
        }
        catch (Exception ex)
        {
            this.btnStartRSS.Invoke(new Action(delegate
            {
                this.lbStatusCountDown.Stop();
                this.lbStatus.Text = ex.Message;
                if (!ex.Message.Contains("[Check IP] return [False]") && !ex.Message.Contains("[Check IP] returns [False]"))
                    return;
                reset = true;
            }));
            if (!reset)
            {
                e.Cancel = true;
                this._bwRSSThread = (Thread)null;
            }
        }
        if (reset)
        {
            this.bwRestoreRSS_DoWork((object)null, e);
        }
        else
        {
            this._runState = -1;
            this._bwRSSThread = (Thread)null;
            this.btnResetRSS.Invoke(new Action(delegate
            {
                this.lbStatusCountDown.Stop();
                this.btnRestoreRSS.Text = "Restore";
                if (this.lvRSS.SelectedIndices.Count > 0)
                {
                    this.btnRemoveRSS.Enabled = true;
                    this.btnSaveRSS.Enabled = true;
                }
                this.btnRemoveAllRSS.Enabled = true;
                this.btnStartRSS.Enabled = true;
            }));
        }
    }

        private void ipcDeviceIP_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.btConnect.PerformClick();
    }

    private void numThreadCount_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.numThreadCount.Value, "sshThreadCount");
      GlobalConfig.SSHThreadCount = Convert.ToInt32(this.numThreadCount.Value);
    }

    private void numSSHtimeout_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.numSSHtimeout.Value, "sshTimeout");
      GlobalConfig.SSHTimeout = Convert.ToInt32(this.numSSHtimeout.Value);
    }

    private void cbRefreshSSH_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbRefreshSSH.Checked, "sshRefresh");
      GlobalConfig.SSHRefresh = this.cbRefreshSSH.Checked;
    }

    private void tbScript_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData != (Keys.A | Keys.Control))
        return;
      ((TextBoxBase) sender).SelectAll();
      e.Handled = e.SuppressKeyPress = true;
    }

    private void numSSHWaitTimeRRS_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.numSSHWaitTimeRRS.Value, "ConnectionTime");
      this.numSSHWait.Value = this.numSSHWaitTimeRRS.Value;
    }

    private void numSSHWait_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.numSSHWait.Value, "ConnectionTime");
      this.numSSHWaitTimeRRS.Value = this.numSSHWait.Value;
    }

    private void cbiOS8_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cbiOS9.Checked)
        this.cbiOS9.Checked = false;
      if (this.cbiOS8.Checked)
      {
        this.checkiPhone7.Checked = false;
        LocalConfig.getCurrentConfig().setObjectForKey((object) 8, "FiOS");
      }
      else if (this.cbiOS11.Checked)
        LocalConfig.getCurrentConfig().setObjectForKey((object) 11, "FiOS");
      else if (this.cbiOS10.Checked)
        LocalConfig.getCurrentConfig().setObjectForKey((object) 10, "FiOS");
      else
        LocalConfig.getCurrentConfig().setObjectForKey((object) 0, "FiOS");
      this.reloadVersionList();
      this.reloadVersionCheckbox();
    }

    private void reloadVersionList()
    {
      List<string> stringList1 = new List<string>();
      string str1 = LocalConfig.getCurrentConfig().getInt32ForKey("FiOS").ToString();
      FakeInfoCore.iosVersion = str1;
      if (Convert.ToInt32(str1) > 0)
      {
        string[] strArray = Split.tachchuoi(ResourceList.Versions, "\r\n");
        List<string> stringList2 = new List<string>();
        this.combFakeIOSVersion.Items.Clear();
        foreach (string text in strArray)
        {
          if (Convert.ToInt32(GlobalConfig.stringSplit(text, ".")[0]) == Convert.ToInt32(str1))
          {
            stringList2.Add(text);
            stringList1.Add(text);
          }
        }
        this.combFakeIOSVersion.Items.AddRange((object[]) stringList2.ToArray());
      }
      else
      {
        string[] strArray = Split.tachchuoi(ResourceList.Versions, "\r\n");
        List<string> stringList2 = new List<string>();
        this.combFakeIOSVersion.Items.Clear();
        foreach (string str2 in strArray)
        {
          stringList2.Add(str2);
          stringList1.Add(str2);
        }
        this.combFakeIOSVersion.Items.AddRange((object[]) stringList2.ToArray());
      }
      FakeInfoCore._versions_ = stringList1.ToArray();
    }

    private void reloadVersionCheckbox()
    {
      switch (LocalConfig.getCurrentConfig().getInt32ForKey("FiOS"))
      {
        case 8:
          this.cbiOS8.Checked = true;
          this.cbiOS9.Checked = false;
          this.cbiOS10.Checked = false;
          this.cbiOS11.Checked = false;
          break;
        case 9:
          this.cbiOS8.Checked = false;
          this.cbiOS9.Checked = true;
          this.cbiOS10.Checked = false;
          this.cbiOS11.Checked = false;
          break;
        case 10:
          this.cbiOS8.Checked = false;
          this.cbiOS9.Checked = false;
          this.cbiOS10.Checked = true;
          this.cbiOS11.Checked = false;
          break;
        case 11:
          this.cbiOS8.Checked = false;
          this.cbiOS9.Checked = false;
          this.cbiOS10.Checked = false;
          this.cbiOS11.Checked = true;
          break;
        default:
          this.cbiOS10.Checked = false;
          this.cbiOS8.Checked = false;
          this.cbiOS9.Checked = false;
          this.cbiOS11.Checked = false;
          break;
      }
    }

    private void cbiOS9_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cbiOS9.Checked)
      {
        this.checkiPhone7.Checked = false;
        LocalConfig.getCurrentConfig().setObjectForKey((object) 9, "FiOS");
      }
      else if (this.cbiOS8.Checked)
        LocalConfig.getCurrentConfig().setObjectForKey((object) 8, "FiOS");
      else if (this.cbiOS11.Checked)
        LocalConfig.getCurrentConfig().setObjectForKey((object) 11, "FiOS");
      else if (this.cbiOS10.Checked)
        LocalConfig.getCurrentConfig().setObjectForKey((object) 10, "FiOS");
      else
        LocalConfig.getCurrentConfig().setObjectForKey((object) 0, "FiOS");
      this.reloadVersionList();
      this.reloadVersionCheckbox();
    }

    private void reloadModelList()
    {
      List<string> stringList1 = new List<string>();
      this.combFakeDeviceModel.Items.Clear();
      bool flag = false;
      string[] strArray = System.IO.File.ReadAllLines(GlobalConfig.executableDirectory() + "\\Models.list");
      if (LocalConfig.getCurrentConfig().getBooleanForKey("FiPhone"))
      {
        List<string> stringList2 = new List<string>();
        foreach (string str in strArray)
        {
          if (str.StartsWith("iPhone"))
          {
            stringList2.Add(str);
            stringList1.Add(str);
            flag = true;
          }
        }
        this.combFakeDeviceModel.Items.AddRange((object[]) stringList2.ToArray());
      }
      if (LocalConfig.getCurrentConfig().getBooleanForKey("FiPad"))
      {
        List<string> stringList2 = new List<string>();
        foreach (string str in strArray)
        {
          if (str.StartsWith("iPad"))
          {
            stringList2.Add(str);
            stringList1.Add(str);
            flag = true;
          }
        }
        this.combFakeDeviceModel.Items.AddRange((object[]) stringList2.ToArray());
      }
      if (LocalConfig.getCurrentConfig().getBooleanForKey("FiPod"))
      {
        List<string> stringList2 = new List<string>();
        foreach (string str in strArray)
        {
          if (str.StartsWith("iPod"))
          {
            stringList2.Add(str);
            stringList1.Add(str);
            flag = true;
          }
        }
        this.combFakeDeviceModel.Items.AddRange((object[]) stringList2.ToArray());
      }
      if (!flag)
      {
        List<string> stringList2 = new List<string>();
        foreach (string str in strArray)
        {
          stringList2.Add(str);
          stringList1.Add(str);
        }
        this.combFakeDeviceModel.Items.AddRange((object[]) stringList2.ToArray());
      }
      FakeInfoCore._models_ = stringList1.ToArray();
    }

    private void reloadModelListCheckbox()
    {
      this.cbiPhone.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("FiPhone");
      this.cbiPad.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("FiPad");
      if (LocalConfig.getCurrentConfig().getBooleanForKey("FiPod"))
        this.cbiPodTouch.Checked = true;
      else
        this.cbiPodTouch.Checked = false;
    }

    private void cbiPhone_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbiPhone.Checked, "FiPhone");
      this.reloadModelList();
    }

    private void cbiPad_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbiPad.Checked, "FiPad");
      this.reloadModelList();
    }

    private void cbiPodTouch_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbiPodTouch.Checked, "FiPod");
      this.reloadModelList();
    }

    private void reloadRandName()
    {
      this.cbRandomName.Checked = LocalConfig.getCurrentConfig().getBooleanForKey("FRandName");
      if (this.cbRandomName.Checked)
        this.tbFakeDeviceName.Enabled = false;
      else
        this.tbFakeDeviceName.Enabled = true;
    }

    private void cbRandomName_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbRandomName.Checked, "FRandName");
      if (this.cbRandomName.Checked)
        this.tbFakeDeviceName.Enabled = false;
      else
        this.tbFakeDeviceName.Enabled = true;
    }

    private void nmSafariXy_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.nmSafariXy.Value, "nmSafariXy");
    }

    private void nmAppStoreXy_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.nmAppStoreXy.Value, "nmAppStoreXy");
    }

    private void cbiOS10_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cbiOS10.Checked)
        LocalConfig.getCurrentConfig().setObjectForKey((object) 10, "FiOS");
      else if (this.cbiOS9.Checked)
        LocalConfig.getCurrentConfig().setObjectForKey((object) 9, "FiOS");
      else if (this.cbiOS11.Checked)
        LocalConfig.getCurrentConfig().setObjectForKey((object) 11, "FiOS");
      else if (this.cbiOS8.Checked)
        LocalConfig.getCurrentConfig().setObjectForKey((object) 8, "FiOS");
      else
        LocalConfig.getCurrentConfig().setObjectForKey((object) 0, "FiOS");
      this.reloadVersionList();
      this.reloadVersionCheckbox();
    }

    private void checkrunappstore_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cbcheckrunappstore.Checked, "chkrunAppstore");
    }

    private void cboptbackup_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cboptbackup.Value, "cbobkpt");
    }

    private void ssMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.lbStatus.Text = "Sript Run : " + frmMain.sttScript2;
      if (frmMain.BoolstartTimer1)
        return;
      this.timer1.Enabled = false;
      this.timer1.Stop();
    }

    private void btnfilterip_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.lbStatus.Text = "Filter ip Lead";
      frmSSHImport frmSshImport = new frmSSHImport();
      string fileName = openFileDialog.FileName;
      if (fileName != null)
      {
        Console.WriteLine(fileName);
        string[] strArray = System.IO.File.ReadAllLines(fileName);
        for (int index1 = 0; index1 < this.lvRSS.Items.Count; ++index1)
        {
          if (this.lvRSS.Items[index1].Checked)
          {
            string text = this.lvRSS.Items[index1].SubItems[6].Text;
            for (int index2 = 0; index2 < strArray.Length; ++index2)
            {
              Dictionary<string, object> dictionary = new Dictionary<string, object>();
              if (GlobalConfig.stringSplit(strArray[index2].Trim(), "|")[0] == text)
                this.lvRSS.Items[index1].BackColor = Color.Green;
            }
          }
        }
      }
      this.lbStatus.Text = "Filter ip Lead Done";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      for (int index = 0; index < this.lvRSS.Items.Count; ++index)
      {
        if (this.lvRSS.Items[index].Checked && this.lvRSS.Items[index].BackColor != Color.Green)
          this.removeRSSNolead(Split.tachchuoi(this.lvRSS.Items[index].SubItems[0].Text, "|")[1], this.lvRSS.Items[index].SubItems[6].Text);
      }
      this.reloadRSSList();
    }

    private void btnBKSP_Click(object sender, EventArgs e)
    {
      bool result = false;
      string text = this.cbApps.SelectedItem.ToString();
      string __g_var_appName = GlobalConfig.stringSplit(text)[0];
      string __g_var_appId = GlobalConfig.stringSplit(text)[1];
      Random random = new Random();
      string str1 = "SupportBK-" + __g_var_appName + "-" + (object) random.Next(9999, 999999999);
      this.lbStatus.Text = "Executing [Backup " + __g_var_appName + " ]";
      string str2 = "backup(" + str1 + "," + __g_var_appId + ")";
      ScriptsCore.executeScript(str2, out result);
      frmMain.BKSP(Split.tachchuoi(str2, ",")[0].Replace("backup(", ""), __g_var_appName, __g_var_appId);
      this.reloadRSSList();
      this.lbStatus.Text = "Executing [Backup Done]";
    }

    private void timerConnectRealtime_Tick(object sender, EventArgs e)
    {
    }

    private void nbportfake_ValueChanged(object sender, EventArgs e)
    {
      this.tbProxyURL.Text = "http://" + this.ipcMyIP.Text + ":" + (object) this.nbportfake.Value + "/ac.pac";
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.nbportfake.Value, "portfakelee");
    }

    private void tpRSS_Click(object sender, EventArgs e)
    {
    }

    private void lvRSS_ColumnClick(object sender, ColumnClickEventArgs e)
    {
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void day1_TextChanged(object sender, EventArgs e)
    {
    }

    private void day2_TextChanged(object sender, EventArgs e)
    {
    }

    private void day3_TextChanged(object sender, EventArgs e)
    {
    }

    private void day4_TextChanged(object sender, EventArgs e)
    {
    }

    private void day5_TextChanged(object sender, EventArgs e)
    {
    }

    private void day6_TextChanged(object sender, EventArgs e)
    {
    }

    private void day7_TextChanged(object sender, EventArgs e)
    {
    }

    private void day8_TextChanged(object sender, EventArgs e)
    {
    }

    private void day9_TextChanged(object sender, EventArgs e)
    {
    }

    private void day10_TextChanged(object sender, EventArgs e)
    {
    }

    private void day11_TextChanged(object sender, EventArgs e)
    {
    }

    private void day12_TextChanged(object sender, EventArgs e)
    {
    }

    private void day13_TextChanged(object sender, EventArgs e)
    {
    }

    private void day14_TextChanged(object sender, EventArgs e)
    {
    }

    private void day15_TextChanged(object sender, EventArgs e)
    {
    }

    private void day16_TextChanged(object sender, EventArgs e)
    {
    }

    private void day17_TextChanged(object sender, EventArgs e)
    {
    }

    private void day18_TextChanged(object sender, EventArgs e)
    {
    }

    private void day19_TextChanged(object sender, EventArgs e)
    {
    }

    private void day20_TextChanged(object sender, EventArgs e)
    {
    }

    private void day21_TextChanged(object sender, EventArgs e)
    {
    }

    private void day22_TextChanged(object sender, EventArgs e)
    {
    }

    private void day23_TextChanged(object sender, EventArgs e)
    {
    }

    private void day24_TextChanged(object sender, EventArgs e)
    {
    }

    private void day25_TextChanged(object sender, EventArgs e)
    {
    }

    private void day26_TextChanged(object sender, EventArgs e)
    {
    }

    private void day27_TextChanged(object sender, EventArgs e)
    {
    }

    private void day28_TextChanged(object sender, EventArgs e)
    {
    }

    private void day29_TextChanged(object sender, EventArgs e)
    {
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.richTextBox1.Text, "NoteRRS");
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
      this.lbStatus.Text = "Remove RRS ...";
      this.button2.Enabled = false;
      for (int index = 0; index < this.lvRSS.Items.Count; ++index)
      {
        if (this.lvRSS.Items[index].Checked && this.lvRSS.Items[index].SubItems[1].Text.IndexOf(this.comboBox1.Text) >= 0)
          ++frmMain.totalRRSSelectRemove;
      }
      frmMain.ptRRS = Convert.ToInt32(this.numericUpDown1.Value);
      frmMain.i_limitptRRS = Convert.ToInt32(frmMain.totalRRSSelectRemove * frmMain.ptRRS / 100);
      for (int index = 0; index < this.lvRSS.Items.Count; ++index)
      {
        if (this.lvRSS.Items[index].Checked && this.lvRSS.Items[index].SubItems[1].Text.IndexOf(this.comboBox1.Text) >= 0 && frmMain.i_limitptRRS > 0)
        {
          --frmMain.i_limitptRRS;
          this.removeRSS(Split.tachchuoi(this.lvRSS.Items[index].SubItems[0].Text, "|")[1], this.lvRSS.Items[index].SubItems[6].Text);
        }
      }
      this.reloadRSSList();
      frmMain.UpRRSFtp();
      this.lbStatus.Text = "Remove RRS done";
      frmMain.totalRRSSelectRemove = 0;
      frmMain.ptRRS = 0;
      frmMain.i_limitptRRS = 0;
      frmMain.i_ptRRS = 0;
      this.button2.Enabled = true;
      this.richTextBox1.Text = DateTime.Now.ToString() + " - RRS day " + this.comboBox1.Text + " remove " + (object) this.numericUpDown1.Value + "%\r\n" + this.richTextBox1.Text;
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.numericUpDown1.Value, "ptRRSRemove");
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.lbStatus.Text = "Select all";
      for (int index = 0; index < this.lvRSS.Items.Count; ++index)
      {
        this.lvRSS.Items[index].Checked = true;
        this.lvRSS.Items[index].BackColor = Color.Violet;
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.lbStatus.Text = "UnSelect all";
      for (int index = 0; index < this.lvRSS.Items.Count; ++index)
      {
        this.lvRSS.Items[index].Checked = false;
        this.lvRSS.Items[index].BackColor = Color.White;
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      for (int index = 0; index < this.lvRSS.Items.Count; ++index)
      {
        if (this.lvRSS.Items[index].SubItems[1].Text.IndexOf(this.comboBox1.Text) >= 0 && this.lvRSS.Items[index].Checked)
        {
          this.lbStatus.Text = "Un---Select RRS - " + this.comboBox1.Text;
          this.lvRSS.Items[index].Checked = false;
          this.lvRSS.Items[index].BackColor = Color.White;
        }
        else if (this.lvRSS.Items[index].SubItems[1].Text.IndexOf(this.comboBox1.Text) >= 0)
        {
          this.lbStatus.Text = "Select RRS - " + this.comboBox1.Text;
          this.lvRSS.Items[index].Checked = true;
          this.lvRSS.Items[index].BackColor = Color.Violet;
        }
        else
        {
          this.lvRSS.Items[index].BackColor = Color.White;
          this.lvRSS.Items[index].Checked = false;
        }
      }
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      for (int index = 0; index < this.lvRSS.Items.Count; ++index)
      {
        if (this.lvRSS.Items[index].SubItems[1].Text.IndexOf(this.comboBox2.Text) >= 0 && this.lvRSS.Items[index].Checked)
        {
          this.lbStatus.Text = "Un---Select RRS - " + this.comboBox2.Text;
          this.lvRSS.Items[index].Checked = false;
          this.lvRSS.Items[index].BackColor = Color.White;
        }
        else if (this.lvRSS.Items[index].SubItems[1].Text.IndexOf(this.comboBox2.Text) >= 0)
        {
          this.lbStatus.Text = "Select RRS - " + this.comboBox2.Text;
          this.lvRSS.Items[index].Checked = true;
          this.lvRSS.Items[index].BackColor = Color.Violet;
        }
        else if (!this.lvRSS.Items[index].Checked)
        {
          this.lvRSS.Items[index].Checked = false;
          this.lvRSS.Items[index].BackColor = Color.White;
        }
      }
    }

    private void chkgameupdate_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chkgameupdate.Checked, "chkgameupdate");
    }

    private void frmMain_MinimumSizeChanged(object sender, EventArgs e)
    {
    }

    private void button6_Click(object sender, EventArgs e)
    {
      this.Text = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      this.Height = 200;
      this.Width = 300;
      this.lvAutoLead.Hide();
      this.gbProxy.Hide();
    }

    private void button7_Click(object sender, EventArgs e)
    {
      this.Height = 670;
      this.Width = 862;
      this.lvAutoLead.Show();
      string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      this.Text = "AutoLead Helper v1.1 | " + frmMain.ipdv + " | " + directoryName;
      this.gbProxy.Show();
    }

    private void ipcDeviceIP_TextChanged(object sender, EventArgs e)
    {
    }

    private void tbKeyActivation_TextChanged(object sender, EventArgs e)
    {
    }

    private void gbFD_Enter(object sender, EventArgs e)
    {
    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void label23_Click(object sender, EventArgs e)
    {
    }

    private void tpAutoLead_Click(object sender, EventArgs e)
    {
    }

    private void chkrunsml_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chkrunsml.Checked, "chkrunsml");
    }

    private void button5_Click_1(object sender, EventArgs e)
    {
    }

    private void chkuserscript_openurl_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chkuserscript_openurl.Checked, "chkuserscript_openurl");
      if (this.chkuserscript_openurl.Checked)
      {
        this.timeloadAppstrore.Enabled = true;
        this.cboscript_openurl.Enabled = true;
        this.cbcheckrunappstore.Checked = false;
      }
      else
      {
        this.timeloadAppstrore.Enabled = false;
        this.cboscript_openurl.Enabled = false;
        this.cbcheckrunappstore.Checked = true;
      }
    }

    private void cboscript_openurl_SelectedIndexChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.cboscript_openurl.Text, "cboscript_openurl");
    }

    private void button5_Click_2(object sender, EventArgs e)
    {
      this.reloadAllScripts();
    }

    private void timeloadAppstrore_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.timeloadAppstrore.Value, "timeloadAppstrore");
    }

    private void chkipused_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chkipused.Checked, "chkipused");
      if (!this.chkipused.Checked)
        return;
      this.chkloopip.Checked = false;
    }

    private void button8_Click(object sender, EventArgs e)
    {
      if (this.BACKUP_DataiPhone() == "1")
        this.lbStatus.Text = "Backup data iPhone success !";
      else
        this.lbStatus.Text = "Backup data iPhone fail";
    }

    private string BACKUP_DataiPhone()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      dictionary["cmd"] = (object) "bkSystemVersion";
      string str = "0";
      if (AutoLeadClient.send(Operation.jss.Serialize((object) dictionary)))
        str = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(AutoLeadClient.receive())["result"].ToString();
      return str;
    }

    private void button9_Click(object sender, EventArgs e)
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      dictionary["cmd"] = (object) "rsSystemVersion";
      string str = "0";
      if (AutoLeadClient.send(Operation.jss.Serialize((object) dictionary)))
        str = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(AutoLeadClient.receive())["result"].ToString();
      if (str == "1")
        this.lbStatus.Text = "Restore data iPhone success !";
      else
        this.lbStatus.Text = "Restore data iPhone fail";
    }

    private void chkfakeGeo_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chkfakeGeo.Checked, "chkfakeGeo");
    }

    private void chkfakecoresystem_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void token_TextChanged(object sender, EventArgs e)
    {
    }

    private void gbProxy_Enter(object sender, EventArgs e)
    {
    }

    private void tpTestoff_Click(object sender, EventArgs e)
    {
    }

    private void goButton_Click(object sender, EventArgs e)
    {
    }

    private void button10_Click_1(object sender, EventArgs e)
    {
    }

    private void groupBox6_Enter(object sender, EventArgs e)
    {
    }

    private void button11_Click(object sender, EventArgs e)
    {
      frmMain.Cmdrequest("reboot");
    }

    private void chkPortRd_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chkPortRd.Checked, "chkPortRd");
      if (this.chkPortRd.Checked)
      {
        this.nbportfake.Enabled = false;
        this.btApply.Enabled = false;
      }
      else
      {
        this.nbportfake.Enabled = true;
        this.btApply.Enabled = true;
      }
    }

    private void LoadUrl(string url)
    {
    }

    private void numLoadagainUrl_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.numLoadagainUrl.Value, "numLoadagainUrl");
    }

    private void checkiPhone7_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.checkiPhone7.Checked, "checkiPhone7");
    }

    private void button12_Click(object sender, EventArgs e)
    {
      this.tbScript.Clear();
    }

    private void btnupdateVip_Click(object sender, EventArgs e)
    {
      if (this.tbVip72ID.Text == null || this.tbVip72Password.Text == null || this.token.Text == null)
        return;
      string str = this.cbostt.Text == "Yes" ? "1" : "0";
      Dictionary<string, object> dictionary = (Dictionary<string, object>) LocalConfig.getCurrentConfig().allVip72s().ToArray().GetValue(this.lvVip72.SelectedIndices[0]);
      dictionary["username"] = (object) this.tbVip72ID.Text;
      dictionary["password"] = (object) this.tbVip72Password.Text;
      dictionary["status"] = (object) str;
      dictionary["token"] = (object) this.token.Text;
      LocalConfig.getCurrentConfig().saveVip72sList();
      this.updateVip72List();
    }

    private void tabPage2_Click(object sender, EventArgs e)
    {
    }

    private void chksub_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chksub.Checked, "chksub");
      if (this.chksub.Checked)
      {
        this.txtsub.Enabled = true;
        frmMain.bool_sub = true;
      }
      else
      {
        frmMain.bool_sub = false;
        this.txtsub.Enabled = false;
      }
    }

    private void tbProxyURL_TextChanged(object sender, EventArgs e)
    {
    }

    private void button13_Click(object sender, EventArgs e)
    {
      frmMain.Cmdrequest("killall -9 SpringBoard");
    }

    private void button14_Click(object sender, EventArgs e)
    {
      int num = 0;
      for (int index = 0; index < this.lvsrrsmanager.Items.Count; ++index)
      {
        if (this.lvsrrsmanager.Items[index].SubItems[1].Text.IndexOf(this.cborrsmnDay.Text) >= 0 && this.lvsrrsmanager.Items[index].SubItems[4].Text.IndexOf(this.cborrsmnName.Text) >= 0 && this.lvsrrsmanager.Items[index].SubItems[5].Text.IndexOf(this.cborrsmnCountry.Text) >= 0)
        {
          this.lbStatus.Text = "Select RRS - " + this.cborrsmnDay.Text;
          this.lvsrrsmanager.Items[index].Checked = true;
          this.lvsrrsmanager.Items[index].BackColor = Color.Violet;
          ++num;
        }
        else
        {
          this.lvsrrsmanager.Items[index].BackColor = Color.White;
          this.lvsrrsmanager.Items[index].Checked = false;
        }
      }
      this.label35.Text = "Enabled: " + (object) num;
    }

    private void button15_Click(object sender, EventArgs e)
    {
      try
      {
        if (Convert.ToDateTime(this.cborrsmnDay.Text) > Convert.ToDateTime("06/20/2017"))
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          if (openFileDialog.ShowDialog() != DialogResult.OK)
            return;
          this.lbStatus.Text = "Filter ip Lead";
          frmSSHImport frmSshImport = new frmSSHImport();
          string fileName = openFileDialog.FileName;
          if (fileName != null)
          {
            Console.WriteLine(fileName);
            string[] strArray = System.IO.File.ReadAllLines(fileName);
            for (int index1 = 0; index1 < this.lvsrrsmanager.Items.Count; ++index1)
            {
              if (this.lvsrrsmanager.Items[index1].Checked)
              {
                string text = this.lvsrrsmanager.Items[index1].SubItems[6].Text;
                for (int index2 = 0; index2 < strArray.Length; ++index2)
                {
                  Dictionary<string, object> dictionary = new Dictionary<string, object>();
                  if (GlobalConfig.stringSplit(strArray[index2].Trim(), "|")[0] == text)
                    this.lvsrrsmanager.Items[index1].BackColor = Color.Green;
                }
              }
            }
          }
          this.lbStatus.Text = "Filter ip Lead Done";
        }
        else
        {
          int num = (int) MessageBox.Show("Chức năng này chỉ áp dụng với RRS từ ngày 20/06/2017 trở đi");
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("Chọn ngày");
      }
    }

    private void button16_Click(object sender, EventArgs e)
    {
      for (int index = 0; index < this.lvsrrsmanager.Items.Count; ++index)
      {
        if (this.lvsrrsmanager.Items[index].Checked && this.lvsrrsmanager.Items[index].BackColor != Color.Green)
          this.removeRSSNolead(Split.tachchuoi(this.lvsrrsmanager.Items[index].SubItems[0].Text, "|")[1], this.lvsrrsmanager.Items[index].SubItems[6].Text);
      }
      this.reloadRSSList();
      frmMain.UpRRSFtp();
    }

    private void button17_Click(object sender, EventArgs e)
    {
      try
      {
        if (Convert.ToDateTime(this.cborrsmnDay.Text) > Convert.ToDateTime("06/20/2017"))
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          if (openFileDialog.ShowDialog() != DialogResult.OK)
            return;
          this.lbStatus.Text = "Filter ip Lead";
          frmSSHImport frmSshImport = new frmSSHImport();
          string fileName = openFileDialog.FileName;
          if (fileName != null)
          {
            Console.WriteLine(fileName);
            string[] strArray1 = System.IO.File.ReadAllLines(fileName);
            for (int index1 = 0; index1 < this.lvsrrsmanager.Items.Count; ++index1)
            {
              if (this.lvsrrsmanager.Items[index1].Checked)
              {
                string text = this.lvsrrsmanager.Items[index1].SubItems[8].Text;
                for (int index2 = 0; index2 < strArray1.Length; ++index2)
                {
                  Dictionary<string, object> dictionary = new Dictionary<string, object>();
                  string[] strArray2 = GlobalConfig.stringSplit(strArray1[index2].Trim(), "|");
                  if (text.IndexOf(strArray2[0]) >= 0)
                    this.lvsrrsmanager.Items[index1].BackColor = Color.Green;
                }
              }
            }
          }
          this.lbStatus.Text = "Filter ip Lead Done";
        }
        else
        {
          int num = (int) MessageBox.Show("Chức năng này chỉ áp dụng với RRS từ ngày 20/06/2017 trở đi");
        }
      }
      catch
      {
        int num = (int) MessageBox.Show("Chọn ngày");
      }
    }

    private void button18_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.txtfileMail.Text = openFileDialog.FileName;
    }

    private void txtfileMail_TextChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.txtfileMail.Text, "txtfileMail");
    }

    private void cbocity_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void cboregion_SelectedIndexChanged(object sender, EventArgs e)
    {
      string str = Split.tachchuoi(this.cboregion.Text, "|")[0];
      if (!System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "citycode\\Cities\\" + str.ToString() + ".dat"))
        return;
      this.cbocity.Items.Clear();
      string[] strArray = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "citycode\\Cities\\" + str.ToString() + ".dat");
      for (int index = 0; index < ((IEnumerable<string>) strArray).Count<string>(); ++index)
        this.cbocity.Items.Add((object) strArray[index]);
    }

    private void button19_Click(object sender, EventArgs e)
    {
      int num = 0;
      for (int index = 0; index < this.lvsrrsmanager.Items.Count; ++index)
      {
        this.lvsrrsmanager.Items[index].BackColor = Color.White;
        this.lvsrrsmanager.Items[index].Checked = false;
      }
      this.label35.Text = "Enabled: " + (object) num;
    }

    private void button20_Click(object sender, EventArgs e)
    {
      if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        if (!Directory.Exists(this.folderBrowserDialog1.SelectedPath))
          Directory.CreateDirectory(this.folderBrowserDialog1.SelectedPath);
        frmMain.CloneDirectory(frmMain.exeDir + "\\" + frmMain.serial, this.folderBrowserDialog1.SelectedPath);
      }
      this.lbStatus.Text = "Export success !";
    }

    private void CloneFile(string rootv, string dest)
    {
      System.IO.File.Delete(Path.Combine(dest, Path.GetFileName(rootv)));
      System.IO.File.Copy(rootv, Path.Combine(dest, Path.GetFileName(rootv)));
    }

    private static void CloneDirectory(string root, string dest)
    {
      foreach (string directory in Directory.GetDirectories(root))
      {
        string fileName = Path.GetFileName(directory);
        if (fileName == "Scripts")
        {
          if (!Directory.Exists(Path.Combine(dest, fileName)))
            Directory.CreateDirectory(Path.Combine(dest, fileName));
          frmMain.CloneDirectory(directory, Path.Combine(dest, fileName));
        }
      }
      foreach (string file in Directory.GetFiles(root))
      {
        string fileName = Path.GetFileName(file);
        if (fileName != "rss.list" && fileName != "rss.listbk")
        {
          System.IO.File.Delete(Path.Combine(dest, Path.GetFileName(file)));
          System.IO.File.Copy(file, Path.Combine(dest, Path.GetFileName(file)));
        }
      }
    }

    private void groupBox10_Enter(object sender, EventArgs e)
    {
    }

    private void button24_Click(object sender, EventArgs e)
    {
      if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        if (!Directory.Exists(this.folderBrowserDialog1.SelectedPath))
          Directory.CreateDirectory(this.folderBrowserDialog1.SelectedPath);
        this.CloneFile(frmMain.exeDir + "\\" + frmMain.serial + "\\offers.list", this.folderBrowserDialog1.SelectedPath);
      }
      this.lbStatus.Text = "Export success !";
    }

    private void button22_Click(object sender, EventArgs e)
    {
      if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        if (!Directory.Exists(this.folderBrowserDialog1.SelectedPath))
          Directory.CreateDirectory(this.folderBrowserDialog1.SelectedPath);
        this.CloneFile(frmMain.exeDir + "\\" + frmMain.serial + "\\vip72accounts.list", this.folderBrowserDialog1.SelectedPath);
      }
      this.lbStatus.Text = "Export success !";
    }

    private void button26_Click(object sender, EventArgs e)
    {
      if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        if (!Directory.Exists(this.folderBrowserDialog1.SelectedPath))
          Directory.CreateDirectory(this.folderBrowserDialog1.SelectedPath);
        this.CloneFile(frmMain.exeDir + "\\" + frmMain.serial + "\\settings.list", this.folderBrowserDialog1.SelectedPath);
      }
      this.lbStatus.Text = "Export success !";
    }

    private void button21_Click(object sender, EventArgs e)
    {
      if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        if (!Directory.Exists(this.folderBrowserDialog1.SelectedPath))
          Directory.CreateDirectory(this.folderBrowserDialog1.SelectedPath);
        frmMain.CloneDirectory(this.folderBrowserDialog1.SelectedPath, frmMain.exeDir + "\\" + frmMain.serial);
      }
      this.lbStatus.Text = "Import success !";
      int num = (int) MessageBox.Show((IWin32Window) this, "Import success please disconnect and try connect tool again");
      this.btnDisconnect_Click(sender, e);
    }

    private void button25_Click(object sender, EventArgs e)
    {
      if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        if (!Directory.Exists(this.folderBrowserDialog1.SelectedPath))
          Directory.CreateDirectory(this.folderBrowserDialog1.SelectedPath);
        this.CloneFile(this.folderBrowserDialog1.SelectedPath + "\\offers.list", frmMain.exeDir + "\\" + frmMain.serial);
      }
      this.lbStatus.Text = "Import success !";
      int num = (int) MessageBox.Show((IWin32Window) this, "Import success please disconnect and try connect tool again");
      this.btnDisconnect_Click(sender, e);
    }

    private void button23_Click(object sender, EventArgs e)
    {
      if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        if (!Directory.Exists(this.folderBrowserDialog1.SelectedPath))
          Directory.CreateDirectory(this.folderBrowserDialog1.SelectedPath);
        this.CloneFile(this.folderBrowserDialog1.SelectedPath + "\\vip72accounts.list", frmMain.exeDir + "\\" + frmMain.serial);
      }
      this.lbStatus.Text = "Import success !";
      int num = (int) MessageBox.Show((IWin32Window) this, "Import success please disconnect and try connect tool again");
      this.btnDisconnect_Click(sender, e);
    }

    private void button27_Click(object sender, EventArgs e)
    {
      if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
      {
        if (!Directory.Exists(this.folderBrowserDialog1.SelectedPath))
          Directory.CreateDirectory(this.folderBrowserDialog1.SelectedPath);
        this.CloneFile(this.folderBrowserDialog1.SelectedPath + "\\settings.list", frmMain.exeDir + "\\" + frmMain.serial);
      }
      this.lbStatus.Text = "Import success !";
      int num = (int) MessageBox.Show((IWin32Window) this, "Import success please disconnect and try connect tool again");
      this.btnDisconnect_Click(sender, e);
    }

    private void button29_Click(object sender, EventArgs e)
    {
    }

    private void num_sleepBfurl_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.num_sleepBfurl.Value, "num_sleepBfurl");
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
      this.lvAutoLead.Items.Clear();
      ArrayList arrayList = LocalConfig.getCurrentConfig().allOffers();
      if (arrayList == null)
        return;
      Array array = (Array) arrayList.ToArray();
      for (int index = 0; index < array.Length; ++index)
      {
        Dictionary<string, object> dictionary = (Dictionary<string, object>) array.GetValue(index);
        if (dictionary["app"].ToString().ToLower().IndexOf(this.textBox3.Text.ToLower()) >= 0)
        {
          ListViewItem listViewItem = new ListViewItem();
          listViewItem.Checked = Convert.ToBoolean(dictionary["enable"]);
          listViewItem.SubItems.Add((index + 1).ToString() + "-" + dictionary["name"].ToString());
          listViewItem.SubItems.Add(dictionary["url"].ToString());
          if (dictionary.ContainsKey("app") && dictionary["app"] != null)
          {
            string text = GlobalConfig.stringSplit(dictionary["app"].ToString())[0];
            listViewItem.SubItems.Add(text);
          }
          else
          {
            dictionary["app"] = (object) "Unknown App | unknown.app.id";
            string text = GlobalConfig.stringSplit(dictionary["app"].ToString())[0];
            listViewItem.SubItems.Add(text);
          }
          listViewItem.SubItems.Add(Convert.ToInt32(dictionary["appTime"]).ToString() + " s");
          if (Convert.ToBoolean(dictionary["random"]))
            listViewItem.SubItems.Add(dictionary["asMin"].ToString() + " - " + dictionary["asMax"] + " s");
          else
            listViewItem.SubItems.Add(dictionary["asTime"].ToString() + " s");
          bool boolean1 = Convert.ToBoolean(dictionary["useURLScript"]);
          bool boolean2 = Convert.ToBoolean(dictionary["useScript"]);
          listViewItem.SubItems.Add(boolean1 ? "Yes" : "No");
          listViewItem.SubItems.Add(boolean2 ? "Yes" : "No");
          this.lvAutoLead.Items.Add(listViewItem);
        }
      }
    }

    private void lvVip72_DoubleClick(object sender, EventArgs e)
    {
      if (this.tbVip72ID.Text == null || this.tbVip72Password.Text == null || this.token.Text == null)
        return;
      if ((this.cbostt.Text == "Yes" ? "1" : "0") == "1")
      {
        string str = "0";
        Dictionary<string, object> dictionary = (Dictionary<string, object>) LocalConfig.getCurrentConfig().allVip72s().ToArray().GetValue(this.lvVip72.SelectedIndices[0]);
        dictionary["username"] = (object) this.tbVip72ID.Text;
        dictionary["password"] = (object) this.tbVip72Password.Text;
        dictionary["status"] = (object) str;
        dictionary["token"] = (object) this.token.Text;
        LocalConfig.getCurrentConfig().saveVip72sList();
        this.updateVip72List();
      }
      else
      {
        string str = "1";
        Dictionary<string, object> dictionary = (Dictionary<string, object>) LocalConfig.getCurrentConfig().allVip72s().ToArray().GetValue(this.lvVip72.SelectedIndices[0]);
        dictionary["username"] = (object) this.tbVip72ID.Text;
        dictionary["password"] = (object) this.tbVip72Password.Text;
        dictionary["status"] = (object) str;
        dictionary["token"] = (object) this.token.Text;
        LocalConfig.getCurrentConfig().saveVip72sList();
        this.updateVip72List();
      }
    }

    private void txtnumsub_TextChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.txtnumsub.Text, "txtnumsub");
    }

    private void cbiOS11_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cbiOS11.Checked)
        LocalConfig.getCurrentConfig().setObjectForKey((object) 11, "FiOS");
      else if (this.cbiOS9.Checked)
        LocalConfig.getCurrentConfig().setObjectForKey((object) 9, "FiOS");
      else if (this.cbiOS10.Checked)
        LocalConfig.getCurrentConfig().setObjectForKey((object) 10, "FiOS");
      else if (this.cbiOS8.Checked)
        LocalConfig.getCurrentConfig().setObjectForKey((object) 8, "FiOS");
      else
        LocalConfig.getCurrentConfig().setObjectForKey((object) 0, "FiOS");
      this.reloadVersionList();
      this.reloadVersionCheckbox();
    }

    private void chkonly10_3_1_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chkonly10_3_1.Checked, "chkonly10_3_1");
      if (this.chkonly10_3_1.Checked)
        frmMain.bool_chkonly10_3_1 = true;
      else
        frmMain.bool_chkonly10_3_1 = false;
    }

    private void chkloopip_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chkloopip.Checked, "chkloopip");
      if (this.chkloopip.Checked)
      {
        frmMain.bool_loopip = true;
        this.numloopip.Enabled = true;
        this.chkipused.Checked = false;
      }
      else
      {
        this.numloopip.Enabled = false;
        frmMain.bool_loopip = false;
      }
    }

    private void numloopip_ValueChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.numloopip.Value, "numloopip");
    }

    private void usingchrome_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.usingchrome.Checked, "usingchrome");
      if (this.usingchrome.Checked)
        frmMain.bool_usingchrome = true;
      else
        frmMain.bool_usingchrome = false;
    }

    private void txtsub_TextChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.txtsub.Text, "txtsub");
    }

    private void chkmailfile_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chkmailfile.Checked, "chkmailfile");
      if (this.chkmailfile.Checked)
        frmMain.bool_chkmailfile = true;
      else
        frmMain.bool_chkmailfile = false;
    }

    private void chkonlymail_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chkonlymail.Checked, "chkonlymail");
    }

    private void chkloadurlagain_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chkloadurlagain.Checked, "chkloadurlagain");
      if (this.chkloadurlagain.Checked)
        this.numLoadagainUrl.Enabled = true;
      else
        this.numLoadagainUrl.Enabled = false;
    }

    private void chktryopenapp_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void nbtryopenapp_ValueChanged(object sender, EventArgs e)
    {
    }

    private void nmtimesleeptryopenapp_ValueChanged(object sender, EventArgs e)
    {
    }

    private void chkdetectapp_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chkdetectapp.Checked, "chkdetectapp");
    }

    private void txtexclusivevip72_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.txtexclusivevip72.Checked, "chkvipnrieng");
    }

    private void chkautodetectapp_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void button10_Click(object sender, EventArgs e)
    {
      AliChilkat.test();
    }

    private void chkfakescreen_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chkfakescreen.Checked, "chkfakescreen");
    }

    private void chkfakeUA_CheckedChanged(object sender, EventArgs e)
    {
      LocalConfig.getCurrentConfig().setObjectForKey((object) this.chkfakeUA.Checked, "chkfakeUA");
    }

    private void button5_Click(object sender, EventArgs e)
    {
    }

    private void day30_TextChanged(object sender, EventArgs e)
    {
    }

    private void label21_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMain));
      this.tcMain = new TabControl();
      this.tpAutoLead = new TabPage();
      this.splitContainer1 = new SplitContainer();
      this.lvAutoLead = new ListView();
      this.columnHeader0 = new ColumnHeader();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.columnHeader3 = new ColumnHeader();
      this.columnHeader4 = new ColumnHeader();
      this.columnHeader5 = new ColumnHeader();
      this.columnHeader22 = new ColumnHeader();
      this.columnHeader23 = new ColumnHeader();
      this.splitContainer2 = new SplitContainer();
      this.sellectoff = new Label();
      this.gbStart = new GroupBox();
      this.label36 = new Label();
      this.num_sleepBfurl = new NumericUpDown();
      this.lbBackup = new Label();
      this.lbRun = new Label();
      this.label31 = new Label();
      this.txtnumsub = new TextBox();
      this.txtsub = new TextBox();
      this.chksub = new CheckBox();
      this.chkdetectapp = new CheckBox();
      this.label24 = new Label();
      this.timeloadAppstrore = new NumericUpDown();
      this.button5 = new Button();
      this.cboscript_openurl = new ComboBox();
      this.chkuserscript_openurl = new CheckBox();
      this.chkrunsml = new CheckBox();
      this.label16 = new Label();
      this.cboptbackup = new NumericUpDown();
      this.nmAppStoreXy = new NumericUpDown();
      this.chkgameupdate = new CheckBox();
      this.nmSafariXy = new NumericUpDown();
      this.cbcheckrunappstore = new CheckBox();
      this.label9 = new Label();
      this.numSSHWait = new NumericUpDown();
      this.cbChangeIPWhenCheckIPReturnsFalse = new CheckBox();
      this.label10 = new Label();
      this.numURLLoadTime = new NumericUpDown();
      this.btnRecord2 = new Button();
      this.btnRecord1 = new Button();
      this.tbAppStore = new TextBox();
      this.cbAppStore = new CheckBox();
      this.tbSafari = new TextBox();
      this.cbSafari = new CheckBox();
      this.tbComment = new TextBox();
      this.label7 = new Label();
      this.label6 = new Label();
      this.numRunLimit = new NumericUpDown();
      this.cbBackup = new CheckBox();
      this.cbFullWipe = new CheckBox();
      this.textBox3 = new TextBox();
      this.btnEdit = new Button();
      this.btAddOffer = new Button();
      this.btnReset = new Button();
      this.btRemoveAll = new Button();
      this.btnStart = new Button();
      this.btnRemove = new Button();
      this.progressBar1 = new ProgressBar();
      this.tpProxy = new TabPage();
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.cbRefreshSSH = new CheckBox();
      this.label8 = new Label();
      this.numSSHtimeout = new NumericUpDown();
      this.lbUsed = new Label();
      this.lbCheckLiveStatus = new Label();
      this.btnDeleteDead = new Button();
      this.label15 = new Label();
      this.numThreadCount = new NumericUpDown();
      this.lbDead = new Label();
      this.lbLive = new Label();
      this.lbUnCheck = new Label();
      this.lbTotalSSH = new Label();
      this.btnCheckLive = new Button();
      this.btnExportSSH = new Button();
      this.btnImportSSHFromCB = new Button();
      this.btnImportSSHFromFile = new Button();
      this.btnRefreshSSH = new Button();
      this.btnDeleteAll = new Button();
      this.btnDeleteSSH = new Button();
      this.lvSSH = new ListView();
      this.columnHeader6 = new ColumnHeader();
      this.columnHeader7 = new ColumnHeader();
      this.columnHeader8 = new ColumnHeader();
      this.columnHeader9 = new ColumnHeader();
      this.columnHeader26 = new ColumnHeader();
      this.columnHeader27 = new ColumnHeader();
      this.tabPage2 = new TabPage();
      this.cbostt = new ComboBox();
      this.label30 = new Label();
      this.token = new TextBox();
      this.label23 = new Label();
      this.tbVip72Password = new TextBox();
      this.label28 = new Label();
      this.tbVip72ID = new TextBox();
      this.label29 = new Label();
      this.btnupdateVip = new Button();
      this.btnAddVip72 = new Button();
      this.btnDeleteVip72 = new Button();
      this.btnCheckVip72 = new Button();
      this.lvVip72 = new ListView();
      this.columnHeader10 = new ColumnHeader();
      this.columnHeader11 = new ColumnHeader();
      this.columnHeader25 = new ColumnHeader();
      this.tpRSS = new TabPage();
      this.label20 = new Label();
      this.comboBox2 = new ComboBox();
      this.button4 = new Button();
      this.button3 = new Button();
      this.groupBox3 = new GroupBox();
      this.label19 = new Label();
      this.numericUpDown1 = new NumericUpDown();
      this.button2 = new Button();
      this.label17 = new Label();
      this.comboBox1 = new ComboBox();
      this.richTextBox1 = new RichTextBox();
      this.sttEunRRS = new Label();
      this.button1 = new Button();
      this.groupBox1 = new GroupBox();
      this.label11 = new Label();
      this.numSSHWaitTimeRRS = new NumericUpDown();
      this.cbAutoChangeIPRRS = new CheckBox();
      this.rbThisScript = new RadioButton();
      this.rbButtonRandomScript = new RadioButton();
      this.rbButtonNoScript = new RadioButton();
      this.cbScriptList = new ComboBox();
      this.label21 = new Label();
      this.numWaitTime = new NumericUpDown();
      this.btnResetRSS = new Button();
      this.btnStartRSS = new Button();
      this.lbSelectedRSS = new Label();
      this.lbTotalRSS = new Label();
      this.label18 = new Label();
      this.tbRSSComment = new TextBox();
      this.btnSaveRSSComment = new Button();
      this.btnRestoreRSS = new Button();
      this.btnSaveRSS = new Button();
      this.btnRemoveRSS = new Button();
      this.btnRemoveAllRSS = new Button();
      this.lvRSS = new ListView();
      this.columnHeader19 = new ColumnHeader();
      this.columnHeader12 = new ColumnHeader();
      this.columnHeader13 = new ColumnHeader();
      this.columnHeader14 = new ColumnHeader();
      this.columnHeader15 = new ColumnHeader();
      this.columnHeader16 = new ColumnHeader();
      this.columnHeader28 = new ColumnHeader();
      this.columnHeader17 = new ColumnHeader();
      this.columnHeader18 = new ColumnHeader();
      this.tpSupport = new TabPage();
      this.lvAllScripts = new ListView();
      this.columnHeader24 = new ColumnHeader();
      this.panel1 = new Panel();
      this.btnDeleteScript = new Button();
      this.btnAddScript = new Button();
      this.gbScript = new GroupBox();
      this.button12 = new Button();
      this.btnBKSP = new Button();
      this.btnTestScript = new Button();
      this.groupBox9 = new GroupBox();
      this.rbCustomScript = new RadioButton();
      this.rbScriptForApp = new RadioButton();
      this.tbScriptName = new TextBox();
      this.cbApps = new ComboBox();
      this.btRefresh = new Button();
      this.btnHelp = new Button();
      this.btnRecordEvent = new Button();
      this.btnSaveScript = new Button();
      this.btnWipe = new Button();
      this.tbnOpenApp = new Button();
      this.tbScript = new TextBox();
      this.groupBox2 = new GroupBox();
      this.label22 = new Label();
      this.btnOpenURL = new Button();
      this.tbURL = new TextBox();
      this.tpSettings = new TabPage();
      this.groupBox6 = new GroupBox();
      this.chkloopip = new CheckBox();
      this.numloopip = new NumericUpDown();
      this.usingchrome = new CheckBox();
      this.button18 = new Button();
      this.txtfileMail = new TextBox();
      this.chkmailfile = new CheckBox();
      this.chkonlymail = new CheckBox();
      this.chkloadurlagain = new CheckBox();
      this.numLoadagainUrl = new NumericUpDown();
      this.chkfakescreen = new CheckBox();
      this.chkfakeUA = new CheckBox();
      this.chkfakecoresystem = new CheckBox();
      this.chkfakeGeo = new CheckBox();
      this.chkipused = new CheckBox();
      this.groupBox5 = new GroupBox();
      this.chkonly10_3_1 = new CheckBox();
      this.checkiPhone7 = new CheckBox();
      this.gbFD = new GroupBox();
      this.cbiOS10 = new CheckBox();
      this.label12 = new Label();
      this.cbRandomName = new CheckBox();
      this.tbFakeDeviceName = new TextBox();
      this.label14 = new Label();
      this.cbiPhone = new CheckBox();
      this.label13 = new Label();
      this.cbiPad = new CheckBox();
      this.cbiPodTouch = new CheckBox();
      this.cbiOS9 = new CheckBox();
      this.cbiOS8 = new CheckBox();
      this.combFakeDeviceModel = new ComboBox();
      this.combFakeIOSVersion = new ComboBox();
      this.cbFakeDeviceFromFile = new CheckBox();
      this.groupBox4 = new GroupBox();
      this.numLong = new TextBox();
      this.numLat = new TextBox();
      this.combFakeCarrier = new ComboBox();
      this.combFakeTimezone = new ComboBox();
      this.label27 = new Label();
      this.label26 = new Label();
      this.cbFakeGPS = new CheckBox();
      this.combFakeLang = new ComboBox();
      this.combFakeRegion = new ComboBox();
      this.cbFakeLang = new CheckBox();
      this.cbFakeRegion = new CheckBox();
      this.cbFakeCarrier = new CheckBox();
      this.cbFakeTimeZone = new CheckBox();
      this.cbAutoFakeLocation = new CheckBox();
      this.tpContact = new TabPage();
      this.groupBox8 = new GroupBox();
      this.tbKeyActivation = new TextBox();
      this.btnActivate = new Button();
      this.lvRegisteredList = new ListView();
      this.columnHeader20 = new ColumnHeader();
      this.columnHeader21 = new ColumnHeader();
      this.label25 = new Label();
      this.groupBox7 = new GroupBox();
      this.button10 = new Button();
      this.tprrsmanager = new TabPage();
      this.button19 = new Button();
      this.label35 = new Label();
      this.button17 = new Button();
      this.button16 = new Button();
      this.button15 = new Button();
      this.button14 = new Button();
      this.label34 = new Label();
      this.cborrsmnCountry = new ComboBox();
      this.label33 = new Label();
      this.cborrsmnName = new ComboBox();
      this.label32 = new Label();
      this.cborrsmnDay = new ComboBox();
      this.lvsrrsmanager = new ListView();
      this.columnHeader29 = new ColumnHeader();
      this.columnHeader30 = new ColumnHeader();
      this.columnHeader31 = new ColumnHeader();
      this.columnHeader32 = new ColumnHeader();
      this.columnHeader33 = new ColumnHeader();
      this.columnHeader34 = new ColumnHeader();
      this.columnHeader35 = new ColumnHeader();
      this.columnHeader36 = new ColumnHeader();
      this.columnHeader37 = new ColumnHeader();
      this.tpExIm = new TabPage();
      this.button30 = new Button();
      this.textBox2 = new TextBox();
      this.button29 = new Button();
      this.button28 = new Button();
      this.textBox1 = new TextBox();
      this.button13 = new Button();
      this.richTextBox2 = new RichTextBox();
      this.groupBox10 = new GroupBox();
      this.button26 = new Button();
      this.button27 = new Button();
      this.button24 = new Button();
      this.button22 = new Button();
      this.button23 = new Button();
      this.button25 = new Button();
      this.button20 = new Button();
      this.button21 = new Button();
      this.button11 = new Button();
      this.button8 = new Button();
      this.button9 = new Button();
      this.gbDevice = new GroupBox();
      this.button7 = new Button();
      this.pnDeviceInfo = new Panel();
      this.btnDisconnect = new Button();
      this.lbLicensed = new Label();
      this.lbDeviceVersion = new Label();
      this.lbDeviceSN = new Label();
      this.lbModelName = new Label();
      this.button6 = new Button();
      this.ipcDeviceIP = new TextBox();
      this.btConnect = new Button();
      this.cbAutoReconnect = new CheckBox();
      this.lbDeviceIP = new Label();
      this.connectToDeviceWorker = new BackgroundWorker();
      this.sshImport = new BackgroundWorker();
      this.bwLead = new BackgroundWorker();
      this.ssMain = new StatusStrip();
      this.lbStatus = new ToolStripStatusLabel();
      this.lbStatusCountDown = new System.Windows.Forms.Timer(this.components);
      this.bwRSS = new BackgroundWorker();
      this.changeIPTimer = new System.Windows.Forms.Timer(this.components);
      this.changeIPTimer2 = new System.Windows.Forms.Timer(this.components);
      this.bwRestoreRSS = new BackgroundWorker();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.timerConnectRealtime = new System.Windows.Forms.Timer(this.components);
      this.btApply = new Button();
      this.cbTool = new ComboBox();
      this.lbTool = new Label();
      this.cbCountries = new ComboBox();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.btnChangeIP = new Button();
      this.label1 = new Label();
      this.lbSelectedIP = new Label();
      this.tbProxyURL = new TextBox();
      this.label5 = new Label();
      this.ipcMyIP = new TextBox();
      this.lbProxyStatus = new Label();
      this.txtexclusivevip72 = new CheckBox();
      this.gbProxy = new GroupBox();
      this.panel4 = new Panel();
      this.nbportfake = new NumericUpDown();
      this.panel3 = new Panel();
      this.cboregion = new ComboBox();
      this.chkPortRd = new CheckBox();
      this.cbocity = new ComboBox();
      this.saveFileDialog1 = new SaveFileDialog();
      this.cbiOS11 = new CheckBox();
      this.tcMain.SuspendLayout();
      this.tpAutoLead.SuspendLayout();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.splitContainer2.BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.gbStart.SuspendLayout();
      this.num_sleepBfurl.BeginInit();
      this.timeloadAppstrore.BeginInit();
      this.cboptbackup.BeginInit();
      this.nmAppStoreXy.BeginInit();
      this.nmSafariXy.BeginInit();
      this.numSSHWait.BeginInit();
      this.numURLLoadTime.BeginInit();
      this.numRunLimit.BeginInit();
      this.tpProxy.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.numSSHtimeout.BeginInit();
      this.numThreadCount.BeginInit();
      this.tabPage2.SuspendLayout();
      this.tpRSS.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.numericUpDown1.BeginInit();
      this.groupBox1.SuspendLayout();
      this.numSSHWaitTimeRRS.BeginInit();
      this.numWaitTime.BeginInit();
      this.tpSupport.SuspendLayout();
      this.panel1.SuspendLayout();
      this.gbScript.SuspendLayout();
      this.groupBox9.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.tpSettings.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.numloopip.BeginInit();
      this.numLoadagainUrl.BeginInit();
      this.groupBox5.SuspendLayout();
      this.gbFD.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.tpContact.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.tprrsmanager.SuspendLayout();
      this.tpExIm.SuspendLayout();
      this.groupBox10.SuspendLayout();
      this.gbDevice.SuspendLayout();
      this.pnDeviceInfo.SuspendLayout();
      this.ssMain.SuspendLayout();
      this.gbProxy.SuspendLayout();
      this.panel4.SuspendLayout();
      this.nbportfake.BeginInit();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      this.tcMain.Controls.Add((Control) this.tpAutoLead);
      this.tcMain.Controls.Add((Control) this.tpProxy);
      this.tcMain.Controls.Add((Control) this.tpRSS);
      this.tcMain.Controls.Add((Control) this.tpSupport);
      this.tcMain.Controls.Add((Control) this.tpSettings);
      this.tcMain.Controls.Add((Control) this.tpContact);
      this.tcMain.Controls.Add((Control) this.tprrsmanager);
      this.tcMain.Controls.Add((Control) this.tpExIm);
      this.tcMain.Dock = DockStyle.Fill;
      this.tcMain.ItemSize = new Size(100, 30);
      this.tcMain.Location = new Point(0, 0);
      this.tcMain.Margin = new Padding(1);
      this.tcMain.Name = "tcMain";
      this.tcMain.SelectedIndex = 0;
      this.tcMain.Size = new Size(842, 439);
      this.tcMain.SizeMode = TabSizeMode.Fixed;
      this.tcMain.TabIndex = 0;
      this.tcMain.Selecting += new TabControlCancelEventHandler(this.tcMain_Selecting);
      this.tpAutoLead.Controls.Add((Control) this.splitContainer1);
      this.tpAutoLead.Controls.Add((Control) this.progressBar1);
      this.tpAutoLead.Location = new Point(4, 34);
      this.tpAutoLead.Margin = new Padding(1);
      this.tpAutoLead.Name = "tpAutoLead";
      this.tpAutoLead.Padding = new Padding(1);
      this.tpAutoLead.Size = new Size(834, 401);
      this.tpAutoLead.TabIndex = 0;
      this.tpAutoLead.Text = "AutoLead";
      this.tpAutoLead.UseVisualStyleBackColor = true;
      this.tpAutoLead.Click += new EventHandler(this.tpAutoLead_Click);
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.Location = new Point(1, 1);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = Orientation.Horizontal;
      this.splitContainer1.Panel1.Controls.Add((Control) this.lvAutoLead);
      this.splitContainer1.Panel2.Controls.Add((Control) this.splitContainer2);
      this.splitContainer1.Size = new Size(832, 399);
      this.splitContainer1.SplitterDistance = 145;
      this.splitContainer1.TabIndex = 54;
      this.lvAutoLead.AllowColumnReorder = true;
      this.lvAutoLead.BorderStyle = BorderStyle.FixedSingle;
      this.lvAutoLead.CheckBoxes = true;
      this.lvAutoLead.Columns.AddRange(new ColumnHeader[8]
      {
        this.columnHeader0,
        this.columnHeader1,
        this.columnHeader2,
        this.columnHeader3,
        this.columnHeader4,
        this.columnHeader5,
        this.columnHeader22,
        this.columnHeader23
      });
      this.lvAutoLead.Dock = DockStyle.Fill;
      this.lvAutoLead.FullRowSelect = true;
      this.lvAutoLead.GridLines = true;
      this.lvAutoLead.HideSelection = false;
      this.lvAutoLead.Location = new Point(0, 0);
      this.lvAutoLead.Margin = new Padding(1);
      this.lvAutoLead.MultiSelect = false;
      this.lvAutoLead.Name = "lvAutoLead";
      this.lvAutoLead.ShowGroups = false;
      this.lvAutoLead.Size = new Size(832, 145);
      this.lvAutoLead.TabIndex = 0;
      this.lvAutoLead.UseCompatibleStateImageBehavior = false;
      this.lvAutoLead.View = View.Details;
      this.lvAutoLead.ItemCheck += new ItemCheckEventHandler(this.lvAutoLead_ItemCheck);
      this.lvAutoLead.SelectedIndexChanged += new EventHandler(this.lvAutoLead_SelectedIndexChanged);
      this.columnHeader0.Text = "";
      this.columnHeader0.Width = 30;
      this.columnHeader1.Text = "Offer name";
      this.columnHeader1.Width = 174;
      this.columnHeader2.Text = "URL";
      this.columnHeader2.Width = 428;
      this.columnHeader3.Text = "App name";
      this.columnHeader3.Width = 134;
      this.columnHeader4.Text = "App opening time";
      this.columnHeader4.TextAlign = HorizontalAlignment.Center;
      this.columnHeader4.Width = 147;
      this.columnHeader5.Text = "AppStore time";
      this.columnHeader5.TextAlign = HorizontalAlignment.Center;
      this.columnHeader5.Width = 147;
      this.columnHeader22.Text = "Script 1";
      this.columnHeader22.TextAlign = HorizontalAlignment.Center;
      this.columnHeader22.Width = 77;
      this.columnHeader23.Text = "Script 2";
      this.columnHeader23.TextAlign = HorizontalAlignment.Center;
      this.columnHeader23.Width = 68;
      this.splitContainer2.Dock = DockStyle.Fill;
      this.splitContainer2.Location = new Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Panel1.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.splitContainer2.Panel1.Controls.Add((Control) this.sellectoff);
      this.splitContainer2.Panel1.Controls.Add((Control) this.gbStart);
      this.splitContainer2.Panel2.BackColor = Color.FromArgb(192, (int) byte.MaxValue, 192);
      this.splitContainer2.Panel2.Controls.Add((Control) this.textBox3);
      this.splitContainer2.Panel2.Controls.Add((Control) this.btnEdit);
      this.splitContainer2.Panel2.Controls.Add((Control) this.btAddOffer);
      this.splitContainer2.Panel2.Controls.Add((Control) this.btnReset);
      this.splitContainer2.Panel2.Controls.Add((Control) this.btRemoveAll);
      this.splitContainer2.Panel2.Controls.Add((Control) this.btnStart);
      this.splitContainer2.Panel2.Controls.Add((Control) this.btnRemove);
      this.splitContainer2.Size = new Size(832, 250);
      this.splitContainer2.SplitterDistance = 618;
      this.splitContainer2.TabIndex = 0;
      this.sellectoff.AutoSize = true;
      this.sellectoff.ForeColor = Color.Red;
      this.sellectoff.Location = new Point(11, 204);
      this.sellectoff.Name = "sellectoff";
      this.sellectoff.Size = new Size(63, 13);
      this.sellectoff.TabIndex = 30;
      this.sellectoff.Text = "Sellect off : ";
      this.gbStart.Controls.Add((Control) this.label36);
      this.gbStart.Controls.Add((Control) this.num_sleepBfurl);
      this.gbStart.Controls.Add((Control) this.lbBackup);
      this.gbStart.Controls.Add((Control) this.lbRun);
      this.gbStart.Controls.Add((Control) this.label31);
      this.gbStart.Controls.Add((Control) this.txtnumsub);
      this.gbStart.Controls.Add((Control) this.txtsub);
      this.gbStart.Controls.Add((Control) this.chksub);
      this.gbStart.Controls.Add((Control) this.chkdetectapp);
      this.gbStart.Controls.Add((Control) this.label24);
      this.gbStart.Controls.Add((Control) this.timeloadAppstrore);
      this.gbStart.Controls.Add((Control) this.button5);
      this.gbStart.Controls.Add((Control) this.cboscript_openurl);
      this.gbStart.Controls.Add((Control) this.chkuserscript_openurl);
      this.gbStart.Controls.Add((Control) this.chkrunsml);
      this.gbStart.Controls.Add((Control) this.label16);
      this.gbStart.Controls.Add((Control) this.cboptbackup);
      this.gbStart.Controls.Add((Control) this.nmAppStoreXy);
      this.gbStart.Controls.Add((Control) this.chkgameupdate);
      this.gbStart.Controls.Add((Control) this.nmSafariXy);
      this.gbStart.Controls.Add((Control) this.cbcheckrunappstore);
      this.gbStart.Controls.Add((Control) this.label9);
      this.gbStart.Controls.Add((Control) this.numSSHWait);
      this.gbStart.Controls.Add((Control) this.cbChangeIPWhenCheckIPReturnsFalse);
      this.gbStart.Controls.Add((Control) this.label10);
      this.gbStart.Controls.Add((Control) this.numURLLoadTime);
      this.gbStart.Controls.Add((Control) this.btnRecord2);
      this.gbStart.Controls.Add((Control) this.btnRecord1);
      this.gbStart.Controls.Add((Control) this.tbAppStore);
      this.gbStart.Controls.Add((Control) this.cbAppStore);
      this.gbStart.Controls.Add((Control) this.tbSafari);
      this.gbStart.Controls.Add((Control) this.cbSafari);
      this.gbStart.Controls.Add((Control) this.tbComment);
      this.gbStart.Controls.Add((Control) this.label7);
      this.gbStart.Controls.Add((Control) this.label6);
      this.gbStart.Controls.Add((Control) this.numRunLimit);
      this.gbStart.Controls.Add((Control) this.cbBackup);
      this.gbStart.Controls.Add((Control) this.cbFullWipe);
      this.gbStart.Dock = DockStyle.Top;
      this.gbStart.Location = new Point(0, 0);
      this.gbStart.Margin = new Padding(2);
      this.gbStart.Name = "gbStart";
      this.gbStart.Padding = new Padding(2);
      this.gbStart.Size = new Size(618, 199);
      this.gbStart.TabIndex = 29;
      this.gbStart.TabStop = false;
      this.label36.AutoSize = true;
      this.label36.Location = new Point(3, 172);
      this.label36.Margin = new Padding(1, 0, 1, 0);
      this.label36.Name = "label36";
      this.label36.Size = new Size(108, 13);
      this.label36.TabIndex = 64;
      this.label36.Text = "Sleep before open url";
      this.num_sleepBfurl.Location = new Point(113, 170);
      this.num_sleepBfurl.Margin = new Padding(1);
      this.num_sleepBfurl.Maximum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      this.num_sleepBfurl.Minimum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.num_sleepBfurl.Name = "num_sleepBfurl";
      this.num_sleepBfurl.Size = new Size(45, 20);
      this.num_sleepBfurl.TabIndex = 63;
      this.num_sleepBfurl.Value = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.num_sleepBfurl.ValueChanged += new EventHandler(this.num_sleepBfurl_ValueChanged);
      this.lbBackup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lbBackup.AutoSize = true;
      this.lbBackup.ForeColor = Color.FromArgb(192, 64, 0);
      this.lbBackup.Location = new Point(334, 179);
      this.lbBackup.Margin = new Padding(1, 0, 1, 0);
      this.lbBackup.Name = "lbBackup";
      this.lbBackup.Size = new Size(56, 13);
      this.lbBackup.TabIndex = 28;
      this.lbBackup.Text = "Backup: 0";
      this.lbRun.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lbRun.AutoSize = true;
      this.lbRun.ForeColor = SystemColors.MenuHighlight;
      this.lbRun.Location = new Point(242, 179);
      this.lbRun.Margin = new Padding(1, 0, 1, 0);
      this.lbRun.Name = "lbRun";
      this.lbRun.Size = new Size(39, 13);
      this.lbRun.TabIndex = 27;
      this.lbRun.Text = "Run: 0";
      this.label31.AutoSize = true;
      this.label31.Location = new Point(495, 144);
      this.label31.Margin = new Padding(1, 0, 1, 0);
      this.label31.Name = "label31";
      this.label31.Size = new Size(13, 13);
      this.label31.TabIndex = 62;
      this.label31.Text = "=";
      this.txtnumsub.Font = new Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtnumsub.Location = new Point(513, 140);
      this.txtnumsub.Margin = new Padding(2);
      this.txtnumsub.Name = "txtnumsub";
      this.txtnumsub.Size = new Size(87, 22);
      this.txtnumsub.TabIndex = 61;
      this.txtnumsub.TextChanged += new EventHandler(this.txtnumsub_TextChanged);
      this.txtsub.Font = new Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtsub.Location = new Point(411, 140);
      this.txtsub.Margin = new Padding(2);
      this.txtsub.Name = "txtsub";
      this.txtsub.Size = new Size(80, 22);
      this.txtsub.TabIndex = 60;
      this.txtsub.TextChanged += new EventHandler(this.txtsub_TextChanged);
      this.chksub.AutoSize = true;
      this.chksub.Location = new Point(320, 143);
      this.chksub.Margin = new Padding(1);
      this.chksub.Name = "chksub";
      this.chksub.Size = new Size(89, 17);
      this.chksub.TabIndex = 59;
      this.chksub.Text = "Auto add sub";
      this.chksub.UseVisualStyleBackColor = true;
      this.chksub.CheckedChanged += new EventHandler(this.chksub_CheckedChanged);
      this.chkdetectapp.AutoSize = true;
      this.chkdetectapp.Checked = true;
      this.chkdetectapp.CheckState = CheckState.Checked;
      this.chkdetectapp.Location = new Point(113, 36);
      this.chkdetectapp.Margin = new Padding(1);
      this.chkdetectapp.Name = "chkdetectapp";
      this.chkdetectapp.Size = new Size(100, 17);
      this.chkdetectapp.TabIndex = 58;
      this.chkdetectapp.Text = "Nhận dạng app";
      this.chkdetectapp.UseVisualStyleBackColor = true;
      this.chkdetectapp.CheckedChanged += new EventHandler(this.chkdetectapp_CheckedChanged);
      this.label24.AutoSize = true;
      this.label24.Location = new Point(260, 37);
      this.label24.Margin = new Padding(1, 0, 1, 0);
      this.label24.Name = "label24";
      this.label24.Size = new Size(98, 13);
      this.label24.TabIndex = 57;
      this.label24.Text = "Time load Appstore";
      this.timeloadAppstrore.Enabled = false;
      this.timeloadAppstrore.Location = new Point(405, 35);
      this.timeloadAppstrore.Margin = new Padding(1);
      this.timeloadAppstrore.Maximum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      this.timeloadAppstrore.Minimum = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.timeloadAppstrore.Name = "timeloadAppstrore";
      this.timeloadAppstrore.Size = new Size(45, 20);
      this.timeloadAppstrore.TabIndex = 56;
      this.timeloadAppstrore.Value = new Decimal(new int[4]
      {
        20,
        0,
        0,
        0
      });
      this.timeloadAppstrore.ValueChanged += new EventHandler(this.timeloadAppstrore_ValueChanged);
      this.button5.Image = (Image) Resources.refresh;
      this.button5.Location = new Point(534, 12);
      this.button5.Margin = new Padding(2);
      this.button5.Name = "button5";
      this.button5.Size = new Size(28, 21);
      this.button5.TabIndex = 55;
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new EventHandler(this.button5_Click_2);
      this.cboscript_openurl.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboscript_openurl.Enabled = false;
      this.cboscript_openurl.FormattingEnabled = true;
      this.cboscript_openurl.Items.AddRange(new object[2]
      {
        (object) "api.aliexpress.com",
        (object) "198.11.136.1"
      });
      this.cboscript_openurl.Location = new Point(405, 12);
      this.cboscript_openurl.Margin = new Padding(1);
      this.cboscript_openurl.Name = "cboscript_openurl";
      this.cboscript_openurl.Size = new Size(126, 21);
      this.cboscript_openurl.TabIndex = 54;
      this.cboscript_openurl.SelectedIndexChanged += new EventHandler(this.cboscript_openurl_SelectedIndexChanged);
      this.chkuserscript_openurl.AutoSize = true;
      this.chkuserscript_openurl.Location = new Point(263, 14);
      this.chkuserscript_openurl.Margin = new Padding(1);
      this.chkuserscript_openurl.Name = "chkuserscript_openurl";
      this.chkuserscript_openurl.Size = new Size(141, 17);
      this.chkuserscript_openurl.TabIndex = 53;
      this.chkuserscript_openurl.Text = "Use script while open url";
      this.chkuserscript_openurl.UseVisualStyleBackColor = true;
      this.chkuserscript_openurl.CheckedChanged += new EventHandler(this.chkuserscript_openurl_CheckedChanged);
      this.chkrunsml.AutoSize = true;
      this.chkrunsml.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.chkrunsml.ForeColor = Color.FromArgb(0, 0, 192);
      this.chkrunsml.Location = new Point(8, 14);
      this.chkrunsml.Margin = new Padding(1);
      this.chkrunsml.Name = "chkrunsml";
      this.chkrunsml.Size = new Size(101, 17);
      this.chkrunsml.TabIndex = 52;
      this.chkrunsml.Text = "Run Smarlink";
      this.chkrunsml.UseVisualStyleBackColor = true;
      this.chkrunsml.CheckedChanged += new EventHandler(this.chkrunsml_CheckedChanged);
      this.label16.AutoSize = true;
      this.label16.Location = new Point(221, 62);
      this.label16.Margin = new Padding(1, 0, 1, 0);
      this.label16.Name = "label16";
      this.label16.Size = new Size(15, 13);
      this.label16.TabIndex = 48;
      this.label16.Text = "%";
      this.cboptbackup.Location = new Point(174, 58);
      this.cboptbackup.Margin = new Padding(1);
      this.cboptbackup.Maximum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      this.cboptbackup.Minimum = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.cboptbackup.Name = "cboptbackup";
      this.cboptbackup.Size = new Size(45, 20);
      this.cboptbackup.TabIndex = 47;
      this.cboptbackup.Value = new Decimal(new int[4]
      {
        20,
        0,
        0,
        0
      });
      this.cboptbackup.ValueChanged += new EventHandler(this.cboptbackup_ValueChanged);
      this.nmAppStoreXy.Location = new Point(208, 113);
      this.nmAppStoreXy.Margin = new Padding(1);
      this.nmAppStoreXy.Maximum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      this.nmAppStoreXy.Minimum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.nmAppStoreXy.Name = "nmAppStoreXy";
      this.nmAppStoreXy.Size = new Size(45, 20);
      this.nmAppStoreXy.TabIndex = 46;
      this.nmAppStoreXy.Value = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.nmAppStoreXy.ValueChanged += new EventHandler(this.nmAppStoreXy_ValueChanged);
      this.chkgameupdate.AutoSize = true;
      this.chkgameupdate.Location = new Point(8, 36);
      this.chkgameupdate.Margin = new Padding(1);
      this.chkgameupdate.Name = "chkgameupdate";
      this.chkgameupdate.Size = new Size(107, 17);
      this.chkgameupdate.TabIndex = 50;
      this.chkgameupdate.Text = "Off game Update";
      this.chkgameupdate.UseVisualStyleBackColor = true;
      this.chkgameupdate.CheckedChanged += new EventHandler(this.chkgameupdate_CheckedChanged);
      this.nmSafariXy.Location = new Point(208, 86);
      this.nmSafariXy.Margin = new Padding(1);
      this.nmSafariXy.Maximum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      this.nmSafariXy.Minimum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.nmSafariXy.Name = "nmSafariXy";
      this.nmSafariXy.Size = new Size(45, 20);
      this.nmSafariXy.TabIndex = 45;
      this.nmSafariXy.Value = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.nmSafariXy.ValueChanged += new EventHandler(this.nmSafariXy_ValueChanged);
      this.cbcheckrunappstore.AutoSize = true;
      this.cbcheckrunappstore.Location = new Point(113, 14);
      this.cbcheckrunappstore.Margin = new Padding(1);
      this.cbcheckrunappstore.Name = "cbcheckrunappstore";
      this.cbcheckrunappstore.Size = new Size(120, 17);
      this.cbcheckrunappstore.TabIndex = 49;
      this.cbcheckrunappstore.Text = "Check run Appstore";
      this.cbcheckrunappstore.UseVisualStyleBackColor = true;
      this.cbcheckrunappstore.CheckedChanged += new EventHandler(this.checkrunappstore_CheckedChanged);
      this.label9.AutoSize = true;
      this.label9.Location = new Point(469, 61);
      this.label9.Margin = new Padding(1, 0, 1, 0);
      this.label9.Name = "label9";
      this.label9.Size = new Size(69, 13);
      this.label9.TabIndex = 44;
      this.label9.Text = "Connect time";
      this.numSSHWait.Location = new Point(555, 59);
      this.numSSHWait.Margin = new Padding(1);
      this.numSSHWait.Maximum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      this.numSSHWait.Minimum = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.numSSHWait.Name = "numSSHWait";
      this.numSSHWait.Size = new Size(45, 20);
      this.numSSHWait.TabIndex = 43;
      this.numSSHWait.Value = new Decimal(new int[4]
      {
        20,
        0,
        0,
        0
      });
      this.numSSHWait.ValueChanged += new EventHandler(this.numSSHWait_ValueChanged);
      this.cbChangeIPWhenCheckIPReturnsFalse.AutoSize = true;
      this.cbChangeIPWhenCheckIPReturnsFalse.Checked = true;
      this.cbChangeIPWhenCheckIPReturnsFalse.CheckState = CheckState.Checked;
      this.cbChangeIPWhenCheckIPReturnsFalse.Location = new Point(263, 60);
      this.cbChangeIPWhenCheckIPReturnsFalse.Margin = new Padding(1);
      this.cbChangeIPWhenCheckIPReturnsFalse.Name = "cbChangeIPWhenCheckIPReturnsFalse";
      this.cbChangeIPWhenCheckIPReturnsFalse.Size = new Size(174, 17);
      this.cbChangeIPWhenCheckIPReturnsFalse.TabIndex = 42;
      this.cbChangeIPWhenCheckIPReturnsFalse.Text = "Change IP when [Check IP fail]";
      this.cbChangeIPWhenCheckIPReturnsFalse.UseVisualStyleBackColor = true;
      this.cbChangeIPWhenCheckIPReturnsFalse.CheckedChanged += new EventHandler(this.cbChangeIPWhenCheckIPReturnsFalse_CheckedChanged);
      this.label10.AutoSize = true;
      this.label10.Location = new Point(469, 115);
      this.label10.Margin = new Padding(1, 0, 1, 0);
      this.label10.Name = "label10";
      this.label10.Size = new Size(74, 13);
      this.label10.TabIndex = 41;
      this.label10.Text = "URL load time";
      this.numURLLoadTime.Location = new Point(555, 114);
      this.numURLLoadTime.Margin = new Padding(1);
      this.numURLLoadTime.Maximum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      this.numURLLoadTime.Minimum = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.numURLLoadTime.Name = "numURLLoadTime";
      this.numURLLoadTime.Size = new Size(45, 20);
      this.numURLLoadTime.TabIndex = 40;
      this.numURLLoadTime.Value = new Decimal(new int[4]
      {
        30,
        0,
        0,
        0
      });
      this.numURLLoadTime.ValueChanged += new EventHandler(this.numURLLoadTime_ValueChanged);
      this.btnRecord2.Location = new Point(262, 111);
      this.btnRecord2.Margin = new Padding(2);
      this.btnRecord2.Name = "btnRecord2";
      this.btnRecord2.Size = new Size(50, 20);
      this.btnRecord2.TabIndex = 39;
      this.btnRecord2.Text = "Record";
      this.btnRecord2.UseVisualStyleBackColor = true;
      this.btnRecord2.Click += new EventHandler(this.btnRecord2_Click);
      this.btnRecord1.Location = new Point(262, 84);
      this.btnRecord1.Margin = new Padding(2);
      this.btnRecord1.Name = "btnRecord1";
      this.btnRecord1.Size = new Size(50, 20);
      this.btnRecord1.TabIndex = 38;
      this.btnRecord1.Text = "Record";
      this.btnRecord1.UseVisualStyleBackColor = true;
      this.btnRecord1.Click += new EventHandler(this.btnRecord1_Click);
      this.tbAppStore.Location = new Point(113, 113);
      this.tbAppStore.Margin = new Padding(2);
      this.tbAppStore.Name = "tbAppStore";
      this.tbAppStore.Size = new Size(93, 20);
      this.tbAppStore.TabIndex = 37;
      this.tbAppStore.TextChanged += new EventHandler(this.tbAppStore_TextChanged);
      this.cbAppStore.AutoSize = true;
      this.cbAppStore.Checked = true;
      this.cbAppStore.CheckState = CheckState.Checked;
      this.cbAppStore.Location = new Point(9, 114);
      this.cbAppStore.Margin = new Padding(2);
      this.cbAppStore.Name = "cbAppStore";
      this.cbAppStore.Size = new Size(102, 17);
      this.cbAppStore.TabIndex = 36;
      this.cbAppStore.Text = "App Store (X, Y)";
      this.cbAppStore.UseVisualStyleBackColor = true;
      this.cbAppStore.CheckedChanged += new EventHandler(this.cbAppStore_CheckedChanged);
      this.cbAppStore.CheckStateChanged += new EventHandler(this.cbAppStore_CheckStateChanged);
      this.tbSafari.Location = new Point(113, 86);
      this.tbSafari.Margin = new Padding(2);
      this.tbSafari.Name = "tbSafari";
      this.tbSafari.Size = new Size(93, 20);
      this.tbSafari.TabIndex = 35;
      this.tbSafari.TextChanged += new EventHandler(this.tbSafari_TextChanged);
      this.cbSafari.AutoSize = true;
      this.cbSafari.Checked = true;
      this.cbSafari.CheckState = CheckState.Checked;
      this.cbSafari.Location = new Point(8, 87);
      this.cbSafari.Margin = new Padding(2);
      this.cbSafari.Name = "cbSafari";
      this.cbSafari.Size = new Size(82, 17);
      this.cbSafari.TabIndex = 34;
      this.cbSafari.Text = "Safari (X, Y)";
      this.cbSafari.UseVisualStyleBackColor = true;
      this.cbSafari.CheckedChanged += new EventHandler(this.cbSafari_CheckedChanged);
      this.tbComment.Location = new Point(69, 142);
      this.tbComment.Margin = new Padding(1);
      this.tbComment.Name = "tbComment";
      this.tbComment.Size = new Size(243, 20);
      this.tbComment.TabIndex = 32;
      this.tbComment.TextChanged += new EventHandler(this.tbComment_TextChanged);
      this.label7.AutoSize = true;
      this.label7.Location = new Point(5, 143);
      this.label7.Margin = new Padding(1, 0, 1, 0);
      this.label7.Name = "label7";
      this.label7.Size = new Size(54, 13);
      this.label7.TabIndex = 31;
      this.label7.Text = "Comment:";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(469, 87);
      this.label6.Margin = new Padding(1, 0, 1, 0);
      this.label6.Name = "label6";
      this.label6.Size = new Size(54, 13);
      this.label6.TabIndex = 30;
      this.label6.Text = "Run times";
      this.numRunLimit.Location = new Point(555, 86);
      this.numRunLimit.Margin = new Padding(1);
      this.numRunLimit.Maximum = new Decimal(new int[4]
      {
        65000,
        0,
        0,
        0
      });
      this.numRunLimit.Name = "numRunLimit";
      this.numRunLimit.Size = new Size(45, 20);
      this.numRunLimit.TabIndex = 29;
      this.numRunLimit.Value = new Decimal(new int[4]
      {
        200,
        0,
        0,
        0
      });
      this.numRunLimit.ValueChanged += new EventHandler(this.numRunLimit_ValueChanged);
      this.cbBackup.AutoSize = true;
      this.cbBackup.Checked = true;
      this.cbBackup.CheckState = CheckState.Checked;
      this.cbBackup.Location = new Point(114, 60);
      this.cbBackup.Margin = new Padding(1);
      this.cbBackup.Name = "cbBackup";
      this.cbBackup.Size = new Size(63, 17);
      this.cbBackup.TabIndex = 28;
      this.cbBackup.Text = "Backup";
      this.cbBackup.UseVisualStyleBackColor = true;
      this.cbBackup.CheckedChanged += new EventHandler(this.cbBackup_CheckedChanged);
      this.cbFullWipe.AutoSize = true;
      this.cbFullWipe.Location = new Point(8, 60);
      this.cbFullWipe.Margin = new Padding(1);
      this.cbFullWipe.Name = "cbFullWipe";
      this.cbFullWipe.Size = new Size(70, 17);
      this.cbFullWipe.TabIndex = 27;
      this.cbFullWipe.Text = "Full Wipe";
      this.cbFullWipe.UseVisualStyleBackColor = true;
      this.cbFullWipe.CheckedChanged += new EventHandler(this.cbFullWipe_CheckedChanged);
      this.textBox3.Location = new Point(12, 12);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(184, 20);
      this.textBox3.TabIndex = 38;
      this.textBox3.TextChanged += new EventHandler(this.textBox3_TextChanged);
      this.btnEdit.Enabled = false;
      this.btnEdit.Location = new Point(102, 51);
      this.btnEdit.Margin = new Padding(1);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new Size(94, 27);
      this.btnEdit.TabIndex = 19;
      this.btnEdit.Text = "Edit";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
      this.btAddOffer.Location = new Point(12, 51);
      this.btAddOffer.Margin = new Padding(1);
      this.btAddOffer.Name = "btAddOffer";
      this.btAddOffer.Size = new Size(87, 27);
      this.btAddOffer.TabIndex = 14;
      this.btAddOffer.Text = "Add";
      this.btAddOffer.UseVisualStyleBackColor = true;
      this.btAddOffer.Click += new EventHandler(this.button2_Click);
      this.btnReset.Enabled = false;
      this.btnReset.Location = new Point(97, 172);
      this.btnReset.Margin = new Padding(1);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(86, 27);
      this.btnReset.TabIndex = 37;
      this.btnReset.Text = "Reset";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new EventHandler(this.btnReset_Click);
      this.btRemoveAll.Location = new Point(102, 80);
      this.btRemoveAll.Margin = new Padding(1);
      this.btRemoveAll.Name = "btRemoveAll";
      this.btRemoveAll.Size = new Size(94, 27);
      this.btRemoveAll.TabIndex = 15;
      this.btRemoveAll.Text = "Remove all";
      this.btRemoveAll.UseVisualStyleBackColor = true;
      this.btRemoveAll.Click += new EventHandler(this.btRemoveAll_Click);
      this.btnStart.BackColor = Color.Green;
      this.btnStart.Font = new Font("Microsoft Sans Serif", 15.83246f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnStart.ForeColor = Color.White;
      this.btnStart.Location = new Point(12, 117);
      this.btnStart.Margin = new Padding(1);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new Size(184, 49);
      this.btnStart.TabIndex = 36;
      this.btnStart.Text = "START";
      this.btnStart.UseVisualStyleBackColor = false;
      this.btnStart.Click += new EventHandler(this.btnStart_Click);
      this.btnRemove.Enabled = false;
      this.btnRemove.Location = new Point(12, 80);
      this.btnRemove.Margin = new Padding(1);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new Size(87, 27);
      this.btnRemove.TabIndex = 18;
      this.btnRemove.Text = "Remove";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new EventHandler(this.btnRemove_Click);
      this.progressBar1.Location = new Point(739, -32);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new Size(70, 19);
      this.progressBar1.TabIndex = 52;
      this.tpProxy.Controls.Add((Control) this.tabControl1);
      this.tpProxy.Location = new Point(4, 34);
      this.tpProxy.Margin = new Padding(1);
      this.tpProxy.Name = "tpProxy";
      this.tpProxy.Padding = new Padding(1);
      this.tpProxy.Size = new Size(834, 401);
      this.tpProxy.TabIndex = 1;
      this.tpProxy.Text = "Proxy";
      this.tpProxy.UseVisualStyleBackColor = true;
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Dock = DockStyle.Fill;
      this.tabControl1.ItemSize = new Size(100, 20);
      this.tabControl1.Location = new Point(1, 1);
      this.tabControl1.Margin = new Padding(1);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(832, 399);
      this.tabControl1.SizeMode = TabSizeMode.Fixed;
      this.tabControl1.TabIndex = 0;
      this.tabPage1.Controls.Add((Control) this.cbRefreshSSH);
      this.tabPage1.Controls.Add((Control) this.label8);
      this.tabPage1.Controls.Add((Control) this.numSSHtimeout);
      this.tabPage1.Controls.Add((Control) this.lbUsed);
      this.tabPage1.Controls.Add((Control) this.lbCheckLiveStatus);
      this.tabPage1.Controls.Add((Control) this.btnDeleteDead);
      this.tabPage1.Controls.Add((Control) this.label15);
      this.tabPage1.Controls.Add((Control) this.numThreadCount);
      this.tabPage1.Controls.Add((Control) this.lbDead);
      this.tabPage1.Controls.Add((Control) this.lbLive);
      this.tabPage1.Controls.Add((Control) this.lbUnCheck);
      this.tabPage1.Controls.Add((Control) this.lbTotalSSH);
      this.tabPage1.Controls.Add((Control) this.btnCheckLive);
      this.tabPage1.Controls.Add((Control) this.btnExportSSH);
      this.tabPage1.Controls.Add((Control) this.btnImportSSHFromCB);
      this.tabPage1.Controls.Add((Control) this.btnImportSSHFromFile);
      this.tabPage1.Controls.Add((Control) this.btnRefreshSSH);
      this.tabPage1.Controls.Add((Control) this.btnDeleteAll);
      this.tabPage1.Controls.Add((Control) this.btnDeleteSSH);
      this.tabPage1.Controls.Add((Control) this.lvSSH);
      this.tabPage1.Location = new Point(4, 24);
      this.tabPage1.Margin = new Padding(1);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(1);
      this.tabPage1.Size = new Size(824, 371);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "SSH";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.cbRefreshSSH.Anchor = AnchorStyles.Bottom;
      this.cbRefreshSSH.AutoSize = true;
      this.cbRefreshSSH.Checked = true;
      this.cbRefreshSSH.CheckState = CheckState.Checked;
      this.cbRefreshSSH.Location = new Point(200, 317);
      this.cbRefreshSSH.Margin = new Padding(2);
      this.cbRefreshSSH.Name = "cbRefreshSSH";
      this.cbRefreshSSH.Size = new Size(156, 17);
      this.cbRefreshSSH.TabIndex = 42;
      this.cbRefreshSSH.Text = "Refresh if no SSH available";
      this.cbRefreshSSH.UseVisualStyleBackColor = true;
      this.cbRefreshSSH.CheckedChanged += new EventHandler(this.cbRefreshSSH_CheckedChanged);
      this.label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.label8.AutoSize = true;
      this.label8.Location = new Point(380, 319);
      this.label8.Margin = new Padding(1, 0, 1, 0);
      this.label8.Name = "label8";
      this.label8.Size = new Size(48, 13);
      this.label8.TabIndex = 41;
      this.label8.Text = "Timeout:";
      this.numSSHtimeout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.numSSHtimeout.Location = new Point(430, 318);
      this.numSSHtimeout.Margin = new Padding(1);
      this.numSSHtimeout.Maximum = new Decimal(new int[4]
      {
        3600,
        0,
        0,
        0
      });
      this.numSSHtimeout.Minimum = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.numSSHtimeout.Name = "numSSHtimeout";
      this.numSSHtimeout.Size = new Size(62, 20);
      this.numSSHtimeout.TabIndex = 40;
      this.numSSHtimeout.Value = new Decimal(new int[4]
      {
        30,
        0,
        0,
        0
      });
      this.numSSHtimeout.ValueChanged += new EventHandler(this.numSSHtimeout_ValueChanged);
      this.lbUsed.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lbUsed.AutoSize = true;
      this.lbUsed.ForeColor = Color.Blue;
      this.lbUsed.Location = new Point(721, 355);
      this.lbUsed.Margin = new Padding(1, 0, 1, 0);
      this.lbUsed.Name = "lbUsed";
      this.lbUsed.Size = new Size(44, 13);
      this.lbUsed.TabIndex = 39;
      this.lbUsed.Text = "Used: 0";
      this.lbCheckLiveStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.lbCheckLiveStatus.AutoSize = true;
      this.lbCheckLiveStatus.Location = new Point(4, 321);
      this.lbCheckLiveStatus.Margin = new Padding(2, 0, 2, 0);
      this.lbCheckLiveStatus.Name = "lbCheckLiveStatus";
      this.lbCheckLiveStatus.Size = new Size(0, 13);
      this.lbCheckLiveStatus.TabIndex = 38;
      this.btnDeleteDead.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnDeleteDead.Location = new Point(737, 162);
      this.btnDeleteDead.Margin = new Padding(1);
      this.btnDeleteDead.Name = "btnDeleteDead";
      this.btnDeleteDead.Size = new Size(79, 27);
      this.btnDeleteDead.TabIndex = 36;
      this.btnDeleteDead.Text = "Delete dead";
      this.btnDeleteDead.UseVisualStyleBackColor = true;
      this.btnDeleteDead.Click += new EventHandler(this.btnDeleteDead_Click);
      this.label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.label15.AutoSize = true;
      this.label15.Location = new Point(498, 319);
      this.label15.Margin = new Padding(1, 0, 1, 0);
      this.label15.Name = "label15";
      this.label15.Size = new Size(49, 13);
      this.label15.TabIndex = 35;
      this.label15.Text = "Threads:";
      this.numThreadCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.numThreadCount.Location = new Point(548, 318);
      this.numThreadCount.Margin = new Padding(1);
      this.numThreadCount.Minimum = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.numThreadCount.Name = "numThreadCount";
      this.numThreadCount.Size = new Size(62, 20);
      this.numThreadCount.TabIndex = 34;
      this.numThreadCount.Value = new Decimal(new int[4]
      {
        20,
        0,
        0,
        0
      });
      this.numThreadCount.ValueChanged += new EventHandler(this.numThreadCount_ValueChanged);
      this.lbDead.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lbDead.AutoSize = true;
      this.lbDead.ForeColor = Color.Red;
      this.lbDead.Location = new Point(558, 355);
      this.lbDead.Margin = new Padding(1, 0, 1, 0);
      this.lbDead.Name = "lbDead";
      this.lbDead.Size = new Size(45, 13);
      this.lbDead.TabIndex = 33;
      this.lbDead.Text = "Dead: 0";
      this.lbLive.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lbLive.AutoSize = true;
      this.lbLive.ForeColor = Color.FromArgb(0, 192, 0);
      this.lbLive.Location = new Point(380, 355);
      this.lbLive.Margin = new Padding(1, 0, 1, 0);
      this.lbLive.Name = "lbLive";
      this.lbLive.Size = new Size(39, 13);
      this.lbLive.TabIndex = 31;
      this.lbLive.Text = "Live: 0";
      this.lbUnCheck.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lbUnCheck.AutoSize = true;
      this.lbUnCheck.ForeColor = Color.Gray;
      this.lbUnCheck.Location = new Point(199, 355);
      this.lbUnCheck.Margin = new Padding(1, 0, 1, 0);
      this.lbUnCheck.Name = "lbUnCheck";
      this.lbUnCheck.Size = new Size(63, 13);
      this.lbUnCheck.TabIndex = 30;
      this.lbUnCheck.Text = "Uncheck: 0";
      this.lbTotalSSH.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lbTotalSSH.AutoSize = true;
      this.lbTotalSSH.ForeColor = SystemColors.InfoText;
      this.lbTotalSSH.Location = new Point(25, 355);
      this.lbTotalSSH.Margin = new Padding(1, 0, 1, 0);
      this.lbTotalSSH.Name = "lbTotalSSH";
      this.lbTotalSSH.Size = new Size(68, 13);
      this.lbTotalSSH.TabIndex = 29;
      this.lbTotalSSH.Text = "Total SSH: 0";
      this.btnCheckLive.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.btnCheckLive.Location = new Point(627, 312);
      this.btnCheckLive.Margin = new Padding(1);
      this.btnCheckLive.Name = "btnCheckLive";
      this.btnCheckLive.Size = new Size(97, 27);
      this.btnCheckLive.TabIndex = 11;
      this.btnCheckLive.Text = "Check live";
      this.btnCheckLive.UseVisualStyleBackColor = true;
      this.btnCheckLive.Click += new EventHandler(this.btnCheckLive_Click);
      this.btnExportSSH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnExportSSH.Location = new Point(337, 8);
      this.btnExportSSH.Margin = new Padding(1);
      this.btnExportSSH.Name = "btnExportSSH";
      this.btnExportSSH.Size = new Size(121, 27);
      this.btnExportSSH.TabIndex = 10;
      this.btnExportSSH.Text = "Export to file";
      this.btnExportSSH.UseVisualStyleBackColor = true;
      this.btnExportSSH.Click += new EventHandler(this.btnExportSSH_Click);
      this.btnImportSSHFromCB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnImportSSHFromCB.Location = new Point(470, 8);
      this.btnImportSSHFromCB.Margin = new Padding(1);
      this.btnImportSSHFromCB.Name = "btnImportSSHFromCB";
      this.btnImportSSHFromCB.Size = new Size(121, 27);
      this.btnImportSSHFromCB.TabIndex = 9;
      this.btnImportSSHFromCB.Text = "Import from clipboard";
      this.btnImportSSHFromCB.UseVisualStyleBackColor = true;
      this.btnImportSSHFromCB.Click += new EventHandler(this.btnImportSSHFromCB_Click);
      this.btnImportSSHFromFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnImportSSHFromFile.Location = new Point(602, 8);
      this.btnImportSSHFromFile.Margin = new Padding(1);
      this.btnImportSSHFromFile.Name = "btnImportSSHFromFile";
      this.btnImportSSHFromFile.Size = new Size(121, 27);
      this.btnImportSSHFromFile.TabIndex = 8;
      this.btnImportSSHFromFile.Text = "Import from file";
      this.btnImportSSHFromFile.UseVisualStyleBackColor = true;
      this.btnImportSSHFromFile.Click += new EventHandler(this.btnImportSSHFromFile_Click);
      this.btnRefreshSSH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnRefreshSSH.Location = new Point(737, 126);
      this.btnRefreshSSH.Margin = new Padding(1);
      this.btnRefreshSSH.Name = "btnRefreshSSH";
      this.btnRefreshSSH.Size = new Size(79, 27);
      this.btnRefreshSSH.TabIndex = 7;
      this.btnRefreshSSH.Text = "Refresh";
      this.btnRefreshSSH.UseVisualStyleBackColor = true;
      this.btnRefreshSSH.Click += new EventHandler(this.btnRefreshSSH_Click);
      this.btnDeleteAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnDeleteAll.Location = new Point(737, 89);
      this.btnDeleteAll.Margin = new Padding(1);
      this.btnDeleteAll.Name = "btnDeleteAll";
      this.btnDeleteAll.Size = new Size(79, 27);
      this.btnDeleteAll.TabIndex = 6;
      this.btnDeleteAll.Text = "Delete all";
      this.btnDeleteAll.UseVisualStyleBackColor = true;
      this.btnDeleteAll.Click += new EventHandler(this.btnDeleteAll_Click);
      this.btnDeleteSSH.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnDeleteSSH.Location = new Point(737, 53);
      this.btnDeleteSSH.Margin = new Padding(1);
      this.btnDeleteSSH.Name = "btnDeleteSSH";
      this.btnDeleteSSH.Size = new Size(79, 27);
      this.btnDeleteSSH.TabIndex = 5;
      this.btnDeleteSSH.Text = "Delete";
      this.btnDeleteSSH.UseVisualStyleBackColor = true;
      this.btnDeleteSSH.Click += new EventHandler(this.btnDeleteSSH_Click);
      this.lvSSH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lvSSH.Columns.AddRange(new ColumnHeader[6]
      {
        this.columnHeader6,
        this.columnHeader7,
        this.columnHeader8,
        this.columnHeader9,
        this.columnHeader26,
        this.columnHeader27
      });
      this.lvSSH.FullRowSelect = true;
      this.lvSSH.GridLines = true;
      this.lvSSH.HideSelection = false;
      this.lvSSH.Location = new Point(3, 45);
      this.lvSSH.Margin = new Padding(1);
      this.lvSSH.MultiSelect = false;
      this.lvSSH.Name = "lvSSH";
      this.lvSSH.Size = new Size(722, 266);
      this.lvSSH.TabIndex = 0;
      this.lvSSH.UseCompatibleStateImageBehavior = false;
      this.lvSSH.View = View.Details;
      this.columnHeader6.Text = "Host";
      this.columnHeader6.Width = 170;
      this.columnHeader7.Text = "Port";
      this.columnHeader7.Width = 75;
      this.columnHeader8.Text = "Username";
      this.columnHeader8.Width = 173;
      this.columnHeader9.Text = "Password";
      this.columnHeader9.Width = 194;
      this.columnHeader26.Text = "Country";
      this.columnHeader26.Width = 416;
      this.columnHeader27.Text = "Region";
      this.tabPage2.Controls.Add((Control) this.cbostt);
      this.tabPage2.Controls.Add((Control) this.label30);
      this.tabPage2.Controls.Add((Control) this.token);
      this.tabPage2.Controls.Add((Control) this.label23);
      this.tabPage2.Controls.Add((Control) this.tbVip72Password);
      this.tabPage2.Controls.Add((Control) this.label28);
      this.tabPage2.Controls.Add((Control) this.tbVip72ID);
      this.tabPage2.Controls.Add((Control) this.label29);
      this.tabPage2.Controls.Add((Control) this.btnupdateVip);
      this.tabPage2.Controls.Add((Control) this.btnAddVip72);
      this.tabPage2.Controls.Add((Control) this.btnDeleteVip72);
      this.tabPage2.Controls.Add((Control) this.btnCheckVip72);
      this.tabPage2.Controls.Add((Control) this.lvVip72);
      this.tabPage2.Location = new Point(4, 24);
      this.tabPage2.Margin = new Padding(1);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(1);
      this.tabPage2.Size = new Size(824, 371);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Vip72";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.tabPage2.Click += new EventHandler(this.tabPage2_Click);
      this.cbostt.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbostt.FormattingEnabled = true;
      this.cbostt.Items.AddRange(new object[2]
      {
        (object) "Yes",
        (object) "No"
      });
      this.cbostt.Location = new Point(517, 202);
      this.cbostt.Name = "cbostt";
      this.cbostt.Size = new Size(141, 21);
      this.cbostt.TabIndex = 21;
      this.label30.AutoSize = true;
      this.label30.Location = new Point(452, 205);
      this.label30.Margin = new Padding(1, 0, 1, 0);
      this.label30.Name = "label30";
      this.label30.Size = new Size(37, 13);
      this.label30.TabIndex = 20;
      this.label30.Text = "Active";
      this.token.Location = new Point(517, 167);
      this.token.Margin = new Padding(1);
      this.token.Name = "token";
      this.token.Size = new Size(237, 20);
      this.token.TabIndex = 19;
      this.label23.AutoSize = true;
      this.label23.Location = new Point(452, 169);
      this.label23.Margin = new Padding(1, 0, 1, 0);
      this.label23.Name = "label23";
      this.label23.Size = new Size(41, 13);
      this.label23.TabIndex = 18;
      this.label23.Text = "Token:";
      this.tbVip72Password.Location = new Point(517, 129);
      this.tbVip72Password.Margin = new Padding(1);
      this.tbVip72Password.Name = "tbVip72Password";
      this.tbVip72Password.Size = new Size(237, 20);
      this.tbVip72Password.TabIndex = 17;
      this.label28.AutoSize = true;
      this.label28.Location = new Point(452, 131);
      this.label28.Margin = new Padding(1, 0, 1, 0);
      this.label28.Name = "label28";
      this.label28.Size = new Size(56, 13);
      this.label28.TabIndex = 16;
      this.label28.Text = "Password:";
      this.tbVip72ID.Location = new Point(517, 95);
      this.tbVip72ID.Margin = new Padding(1);
      this.tbVip72ID.Name = "tbVip72ID";
      this.tbVip72ID.Size = new Size(237, 20);
      this.tbVip72ID.TabIndex = 15;
      this.label29.AutoSize = true;
      this.label29.Location = new Point(452, 97);
      this.label29.Margin = new Padding(1, 0, 1, 0);
      this.label29.Name = "label29";
      this.label29.Size = new Size(21, 13);
      this.label29.TabIndex = 14;
      this.label29.Text = "ID:";
      this.btnupdateVip.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnupdateVip.Location = new Point(583, 331);
      this.btnupdateVip.Margin = new Padding(1);
      this.btnupdateVip.Name = "btnupdateVip";
      this.btnupdateVip.Size = new Size(89, 27);
      this.btnupdateVip.TabIndex = 7;
      this.btnupdateVip.Text = "Update";
      this.btnupdateVip.UseVisualStyleBackColor = true;
      this.btnupdateVip.Click += new EventHandler(this.btnupdateVip_Click);
      this.btnAddVip72.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnAddVip72.Location = new Point(460, 331);
      this.btnAddVip72.Margin = new Padding(1);
      this.btnAddVip72.Name = "btnAddVip72";
      this.btnAddVip72.Size = new Size(86, 27);
      this.btnAddVip72.TabIndex = 6;
      this.btnAddVip72.Text = "Add account";
      this.btnAddVip72.UseVisualStyleBackColor = true;
      this.btnAddVip72.Click += new EventHandler(this.btnAddVip72_Click);
      this.btnDeleteVip72.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnDeleteVip72.Enabled = false;
      this.btnDeleteVip72.Location = new Point(704, 331);
      this.btnDeleteVip72.Margin = new Padding(1);
      this.btnDeleteVip72.Name = "btnDeleteVip72";
      this.btnDeleteVip72.Size = new Size(89, 27);
      this.btnDeleteVip72.TabIndex = 6;
      this.btnDeleteVip72.Text = "Delete account";
      this.btnDeleteVip72.UseVisualStyleBackColor = true;
      this.btnDeleteVip72.Click += new EventHandler(this.btnDeleteVip72_Click);
      this.btnCheckVip72.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCheckVip72.Enabled = false;
      this.btnCheckVip72.Location = new Point(812, 331);
      this.btnCheckVip72.Margin = new Padding(1);
      this.btnCheckVip72.Name = "btnCheckVip72";
      this.btnCheckVip72.Size = new Size(10, 27);
      this.btnCheckVip72.TabIndex = 5;
      this.btnCheckVip72.Text = "Check account";
      this.btnCheckVip72.UseVisualStyleBackColor = true;
      this.btnCheckVip72.Click += new EventHandler(this.btnCheckVip72_Click);
      this.lvVip72.Columns.AddRange(new ColumnHeader[3]
      {
        this.columnHeader10,
        this.columnHeader11,
        this.columnHeader25
      });
      this.lvVip72.Dock = DockStyle.Left;
      this.lvVip72.FullRowSelect = true;
      this.lvVip72.GridLines = true;
      this.lvVip72.HideSelection = false;
      this.lvVip72.Location = new Point(1, 1);
      this.lvVip72.Margin = new Padding(1);
      this.lvVip72.MultiSelect = false;
      this.lvVip72.Name = "lvVip72";
      this.lvVip72.Size = new Size(422, 369);
      this.lvVip72.TabIndex = 0;
      this.lvVip72.UseCompatibleStateImageBehavior = false;
      this.lvVip72.View = View.Details;
      this.lvVip72.SelectedIndexChanged += new EventHandler(this.lvVip72_SelectedIndexChanged);
      this.lvVip72.DoubleClick += new EventHandler(this.lvVip72_DoubleClick);
      this.columnHeader10.Text = "Username";
      this.columnHeader10.Width = 131;
      this.columnHeader11.Text = "Password";
      this.columnHeader11.Width = 168;
      this.columnHeader25.Text = "Last status";
      this.columnHeader25.Width = 806;
      this.tpRSS.Controls.Add((Control) this.label20);
      this.tpRSS.Controls.Add((Control) this.comboBox2);
      this.tpRSS.Controls.Add((Control) this.button4);
      this.tpRSS.Controls.Add((Control) this.button3);
      this.tpRSS.Controls.Add((Control) this.groupBox3);
      this.tpRSS.Controls.Add((Control) this.sttEunRRS);
      this.tpRSS.Controls.Add((Control) this.button1);
      this.tpRSS.Controls.Add((Control) this.groupBox1);
      this.tpRSS.Controls.Add((Control) this.btnResetRSS);
      this.tpRSS.Controls.Add((Control) this.btnStartRSS);
      this.tpRSS.Controls.Add((Control) this.lbSelectedRSS);
      this.tpRSS.Controls.Add((Control) this.lbTotalRSS);
      this.tpRSS.Controls.Add((Control) this.label18);
      this.tpRSS.Controls.Add((Control) this.tbRSSComment);
      this.tpRSS.Controls.Add((Control) this.btnSaveRSSComment);
      this.tpRSS.Controls.Add((Control) this.btnRestoreRSS);
      this.tpRSS.Controls.Add((Control) this.btnSaveRSS);
      this.tpRSS.Controls.Add((Control) this.btnRemoveRSS);
      this.tpRSS.Controls.Add((Control) this.btnRemoveAllRSS);
      this.tpRSS.Controls.Add((Control) this.lvRSS);
      this.tpRSS.Location = new Point(4, 34);
      this.tpRSS.Margin = new Padding(1);
      this.tpRSS.Name = "tpRSS";
      this.tpRSS.Size = new Size(834, 401);
      this.tpRSS.TabIndex = 2;
      this.tpRSS.Text = "RRS";
      this.tpRSS.UseVisualStyleBackColor = true;
      this.tpRSS.Click += new EventHandler(this.tpRSS_Click);
      this.label20.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.label20.AutoSize = true;
      this.label20.Location = new Point(211, 221);
      this.label20.Margin = new Padding(1, 0, 1, 0);
      this.label20.Name = "label20";
      this.label20.Size = new Size(59, 13);
      this.label20.TabIndex = 44;
      this.label20.Text = "Select with";
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new Point(272, 217);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(75, 21);
      this.comboBox2.TabIndex = 43;
      this.comboBox2.SelectedIndexChanged += new EventHandler(this.comboBox2_SelectedIndexChanged);
      this.button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.button4.Location = new Point(99, 214);
      this.button4.Margin = new Padding(1);
      this.button4.Name = "button4";
      this.button4.Size = new Size(106, 27);
      this.button4.TabIndex = 42;
      this.button4.Text = "UnSelect all";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.button3.Location = new Point(5, 213);
      this.button3.Margin = new Padding(1);
      this.button3.Name = "button3";
      this.button3.Size = new Size(92, 27);
      this.button3.TabIndex = 41;
      this.button3.Text = "Select  all";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.groupBox3.Controls.Add((Control) this.label19);
      this.groupBox3.Controls.Add((Control) this.numericUpDown1);
      this.groupBox3.Controls.Add((Control) this.button2);
      this.groupBox3.Controls.Add((Control) this.label17);
      this.groupBox3.Controls.Add((Control) this.comboBox1);
      this.groupBox3.Controls.Add((Control) this.richTextBox1);
      this.groupBox3.Location = new Point(358, 235);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(326, 158);
      this.groupBox3.TabIndex = 40;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "RRS Editer with day";
      this.label19.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.label19.AutoSize = true;
      this.label19.Location = new Point(190, 31);
      this.label19.Margin = new Padding(1, 0, 1, 0);
      this.label19.Name = "label19";
      this.label19.Size = new Size(15, 13);
      this.label19.TabIndex = 36;
      this.label19.Text = "%";
      this.numericUpDown1.Location = new Point(150, 20);
      this.numericUpDown1.Margin = new Padding(1);
      this.numericUpDown1.Maximum = new Decimal(new int[4]
      {
        3600,
        0,
        0,
        0
      });
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new Size(38, 20);
      this.numericUpDown1.TabIndex = 35;
      this.numericUpDown1.Value = new Decimal(new int[4]
      {
        20,
        0,
        0,
        0
      });
      this.numericUpDown1.ValueChanged += new EventHandler(this.numericUpDown1_ValueChanged);
      this.button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.button2.Location = new Point(221, 15);
      this.button2.Margin = new Padding(1);
      this.button2.Name = "button2";
      this.button2.Size = new Size(101, 27);
      this.button2.TabIndex = 13;
      this.button2.Text = "Remove";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click_1);
      this.label17.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.label17.AutoSize = true;
      this.label17.Location = new Point(5, 49);
      this.label17.Margin = new Padding(1, 0, 1, 0);
      this.label17.Name = "label17";
      this.label17.Size = new Size(88, 13);
      this.label17.TabIndex = 12;
      this.label17.Text = "Logs delete RRS";
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(8, 18);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(136, 21);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
      this.richTextBox1.BackColor = Color.Black;
      this.richTextBox1.Dock = DockStyle.Bottom;
      this.richTextBox1.ForeColor = Color.Lime;
      this.richTextBox1.Location = new Point(3, 68);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new Size(320, 87);
      this.richTextBox1.TabIndex = 0;
      this.richTextBox1.Text = "";
      this.richTextBox1.TextChanged += new EventHandler(this.richTextBox1_TextChanged);
      this.sttEunRRS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.sttEunRRS.AutoSize = true;
      this.sttEunRRS.ForeColor = Color.Red;
      this.sttEunRRS.Location = new Point(217, 381);
      this.sttEunRRS.Margin = new Padding(1, 0, 1, 0);
      this.sttEunRRS.Name = "sttEunRRS";
      this.sttEunRRS.Size = new Size(13, 13);
      this.sttEunRRS.TabIndex = 39;
      this.sttEunRRS.Text = "0";
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.button1.Location = new Point(688, 269);
      this.button1.Margin = new Padding(1);
      this.button1.Name = "button1";
      this.button1.Size = new Size(140, 27);
      this.button1.TabIndex = 38;
      this.button1.Text = "Remove ip no Lead";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.groupBox1.Controls.Add((Control) this.label11);
      this.groupBox1.Controls.Add((Control) this.numSSHWaitTimeRRS);
      this.groupBox1.Controls.Add((Control) this.cbAutoChangeIPRRS);
      this.groupBox1.Controls.Add((Control) this.rbThisScript);
      this.groupBox1.Controls.Add((Control) this.rbButtonRandomScript);
      this.groupBox1.Controls.Add((Control) this.rbButtonNoScript);
      this.groupBox1.Controls.Add((Control) this.cbScriptList);
      this.groupBox1.Controls.Add((Control) this.label21);
      this.groupBox1.Controls.Add((Control) this.numWaitTime);
      this.groupBox1.Location = new Point(8, 272);
      this.groupBox1.Margin = new Padding(2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new Padding(2);
      this.groupBox1.Size = new Size(370, 101);
      this.groupBox1.TabIndex = 36;
      this.groupBox1.TabStop = false;
      this.groupBox1.Enter += new EventHandler(this.groupBox1_Enter);
      this.label11.AutoSize = true;
      this.label11.Location = new Point(222, 47);
      this.label11.Margin = new Padding(1, 0, 1, 0);
      this.label11.Name = "label11";
      this.label11.Size = new Size(69, 13);
      this.label11.TabIndex = 46;
      this.label11.Text = "Connect time";
      this.numSSHWaitTimeRRS.Location = new Point(293, 42);
      this.numSSHWaitTimeRRS.Margin = new Padding(1);
      this.numSSHWaitTimeRRS.Maximum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      this.numSSHWaitTimeRRS.Minimum = new Decimal(new int[4]
      {
        10,
        0,
        0,
        0
      });
      this.numSSHWaitTimeRRS.Name = "numSSHWaitTimeRRS";
      this.numSSHWaitTimeRRS.Size = new Size(45, 20);
      this.numSSHWaitTimeRRS.TabIndex = 45;
      this.numSSHWaitTimeRRS.Value = new Decimal(new int[4]
      {
        20,
        0,
        0,
        0
      });
      this.numSSHWaitTimeRRS.ValueChanged += new EventHandler(this.numSSHWaitTimeRRS_ValueChanged);
      this.cbAutoChangeIPRRS.AutoSize = true;
      this.cbAutoChangeIPRRS.Checked = true;
      this.cbAutoChangeIPRRS.CheckState = CheckState.Checked;
      this.cbAutoChangeIPRRS.Location = new Point(113, 22);
      this.cbAutoChangeIPRRS.Margin = new Padding(1);
      this.cbAutoChangeIPRRS.Name = "cbAutoChangeIPRRS";
      this.cbAutoChangeIPRRS.Size = new Size(227, 17);
      this.cbAutoChangeIPRRS.TabIndex = 43;
      this.cbAutoChangeIPRRS.Text = "Change IP when [Check IP] returns [False]";
      this.cbAutoChangeIPRRS.UseVisualStyleBackColor = true;
      this.cbAutoChangeIPRRS.CheckedChanged += new EventHandler(this.cbAutoChangeIPRRS_CheckedChanged);
      this.rbThisScript.AutoSize = true;
      this.rbThisScript.Location = new Point(9, 70);
      this.rbThisScript.Margin = new Padding(2);
      this.rbThisScript.Name = "rbThisScript";
      this.rbThisScript.Size = new Size(91, 17);
      this.rbThisScript.TabIndex = 39;
      this.rbThisScript.TabStop = true;
      this.rbThisScript.Text = "Use this script";
      this.rbThisScript.UseVisualStyleBackColor = true;
      this.rbThisScript.CheckedChanged += new EventHandler(this.rbThisScript_CheckedChanged);
      this.rbButtonRandomScript.AutoSize = true;
      this.rbButtonRandomScript.Location = new Point(111, 45);
      this.rbButtonRandomScript.Margin = new Padding(2);
      this.rbButtonRandomScript.Name = "rbButtonRandomScript";
      this.rbButtonRandomScript.Size = new Size(93, 17);
      this.rbButtonRandomScript.TabIndex = 38;
      this.rbButtonRandomScript.TabStop = true;
      this.rbButtonRandomScript.Text = "Random script";
      this.rbButtonRandomScript.UseVisualStyleBackColor = true;
      this.rbButtonRandomScript.CheckedChanged += new EventHandler(this.rbButtonRandomScript_CheckedChanged);
      this.rbButtonNoScript.AutoSize = true;
      this.rbButtonNoScript.Location = new Point(9, 45);
      this.rbButtonNoScript.Margin = new Padding(2);
      this.rbButtonNoScript.Name = "rbButtonNoScript";
      this.rbButtonNoScript.Size = new Size(98, 17);
      this.rbButtonNoScript.TabIndex = 37;
      this.rbButtonNoScript.TabStop = true;
      this.rbButtonNoScript.Text = "Don't use script";
      this.rbButtonNoScript.UseVisualStyleBackColor = true;
      this.rbButtonNoScript.CheckedChanged += new EventHandler(this.rbButtonNoScript_CheckedChanged);
      this.cbScriptList.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbScriptList.FormattingEnabled = true;
      this.cbScriptList.Location = new Point(107, 68);
      this.cbScriptList.Margin = new Padding(2);
      this.cbScriptList.Name = "cbScriptList";
      this.cbScriptList.Size = new Size(231, 21);
      this.cbScriptList.TabIndex = 36;
      this.cbScriptList.SelectedIndexChanged += new EventHandler(this.cbScriptList_SelectedIndexChanged);
      this.label21.AutoSize = true;
      this.label21.Location = new Point(7, 22);
      this.label21.Margin = new Padding(1, 0, 1, 0);
      this.label21.Name = "label21";
      this.label21.Size = new Size(51, 13);
      this.label21.TabIndex = 35;
      this.label21.Text = "Wait time";
      this.label21.Click += new EventHandler(this.label21_Click);
      this.numWaitTime.Location = new Point(60, 21);
      this.numWaitTime.Margin = new Padding(1);
      this.numWaitTime.Maximum = new Decimal(new int[4]
      {
        3600,
        0,
        0,
        0
      });
      this.numWaitTime.Name = "numWaitTime";
      this.numWaitTime.Size = new Size(44, 20);
      this.numWaitTime.TabIndex = 34;
      this.numWaitTime.Value = new Decimal(new int[4]
      {
        20,
        0,
        0,
        0
      });
      this.numWaitTime.ValueChanged += new EventHandler(this.numWaitTime_ValueChanged);
      this.btnResetRSS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.btnResetRSS.Enabled = false;
      this.btnResetRSS.Location = new Point(688, 366);
      this.btnResetRSS.Margin = new Padding(1);
      this.btnResetRSS.Name = "btnResetRSS";
      this.btnResetRSS.Size = new Size(140, 27);
      this.btnResetRSS.TabIndex = 32;
      this.btnResetRSS.Text = "Reset";
      this.btnResetRSS.UseVisualStyleBackColor = true;
      this.btnResetRSS.Click += new EventHandler(this.btnResetRSS_Click);
      this.btnStartRSS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.btnStartRSS.BackColor = Color.Green;
      this.btnStartRSS.Font = new Font("Microsoft Sans Serif", 18.09424f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnStartRSS.ForeColor = Color.White;
      this.btnStartRSS.Location = new Point(688, 301);
      this.btnStartRSS.Margin = new Padding(1);
      this.btnStartRSS.Name = "btnStartRSS";
      this.btnStartRSS.Size = new Size(140, 63);
      this.btnStartRSS.TabIndex = 31;
      this.btnStartRSS.Text = "START";
      this.btnStartRSS.UseVisualStyleBackColor = false;
      this.btnStartRSS.Click += new EventHandler(this.btnStartRSS_Click);
      this.lbSelectedRSS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lbSelectedRSS.AutoSize = true;
      this.lbSelectedRSS.ForeColor = Color.FromArgb(0, 192, 0);
      this.lbSelectedRSS.Location = new Point(103, 381);
      this.lbSelectedRSS.Margin = new Padding(1, 0, 1, 0);
      this.lbSelectedRSS.Name = "lbSelectedRSS";
      this.lbSelectedRSS.Size = new Size(58, 13);
      this.lbSelectedRSS.TabIndex = 30;
      this.lbSelectedRSS.Text = "Enabled: 0";
      this.lbTotalRSS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lbTotalRSS.AutoSize = true;
      this.lbTotalRSS.ForeColor = SystemColors.MenuHighlight;
      this.lbTotalRSS.Location = new Point(11, 381);
      this.lbTotalRSS.Margin = new Padding(1, 0, 1, 0);
      this.lbTotalRSS.Name = "lbTotalRSS";
      this.lbTotalRSS.Size = new Size(69, 13);
      this.lbTotalRSS.TabIndex = 29;
      this.lbTotalRSS.Text = "Total RRS: 0";
      this.label18.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.label18.AutoSize = true;
      this.label18.Location = new Point(358, 218);
      this.label18.Margin = new Padding(1, 0, 1, 0);
      this.label18.Name = "label18";
      this.label18.Size = new Size(54, 13);
      this.label18.TabIndex = 11;
      this.label18.Text = "Comment:";
      this.tbRSSComment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.tbRSSComment.Location = new Point(419, 214);
      this.tbRSSComment.Margin = new Padding(1);
      this.tbRSSComment.Name = "tbRSSComment";
      this.tbRSSComment.Size = new Size(409, 20);
      this.tbRSSComment.TabIndex = 10;
      this.tbRSSComment.TextChanged += new EventHandler(this.tbRSSComment_TextChanged);
      this.btnSaveRSSComment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.btnSaveRSSComment.Enabled = false;
      this.btnSaveRSSComment.Location = new Point(5, 242);
      this.btnSaveRSSComment.Margin = new Padding(1);
      this.btnSaveRSSComment.Name = "btnSaveRSSComment";
      this.btnSaveRSSComment.Size = new Size(92, 27);
      this.btnSaveRSSComment.TabIndex = 9;
      this.btnSaveRSSComment.Text = "Save comment";
      this.btnSaveRSSComment.UseVisualStyleBackColor = true;
      this.btnSaveRSSComment.Click += new EventHandler(this.btnSaveRSSComment_Click);
      this.btnRestoreRSS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.btnRestoreRSS.Enabled = false;
      this.btnRestoreRSS.Location = new Point(99, 242);
      this.btnRestoreRSS.Margin = new Padding(1);
      this.btnRestoreRSS.Name = "btnRestoreRSS";
      this.btnRestoreRSS.Size = new Size(58, 27);
      this.btnRestoreRSS.TabIndex = 8;
      this.btnRestoreRSS.Text = "Restore";
      this.btnRestoreRSS.UseVisualStyleBackColor = true;
      this.btnRestoreRSS.Click += new EventHandler(this.btnRestoreRSS_Click);
      this.btnSaveRSS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.btnSaveRSS.Enabled = false;
      this.btnSaveRSS.Location = new Point(159, 242);
      this.btnSaveRSS.Margin = new Padding(1);
      this.btnSaveRSS.Name = "btnSaveRSS";
      this.btnSaveRSS.Size = new Size(52, 27);
      this.btnSaveRSS.TabIndex = 7;
      this.btnSaveRSS.Text = "Save";
      this.btnSaveRSS.UseVisualStyleBackColor = true;
      this.btnSaveRSS.Click += new EventHandler(this.btnSaveRSS_Click);
      this.btnRemoveRSS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.btnRemoveRSS.Enabled = false;
      this.btnRemoveRSS.Location = new Point(213, 242);
      this.btnRemoveRSS.Margin = new Padding(1);
      this.btnRemoveRSS.Name = "btnRemoveRSS";
      this.btnRemoveRSS.Size = new Size(57, 27);
      this.btnRemoveRSS.TabIndex = 6;
      this.btnRemoveRSS.Text = "Remove";
      this.btnRemoveRSS.UseVisualStyleBackColor = true;
      this.btnRemoveRSS.Click += new EventHandler(this.btnRemoveRSS_Click);
      this.btnRemoveAllRSS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.btnRemoveAllRSS.Location = new Point(272, 242);
      this.btnRemoveAllRSS.Margin = new Padding(1);
      this.btnRemoveAllRSS.Name = "btnRemoveAllRSS";
      this.btnRemoveAllRSS.Size = new Size(76, 27);
      this.btnRemoveAllRSS.TabIndex = 5;
      this.btnRemoveAllRSS.Text = "Remove all";
      this.btnRemoveAllRSS.UseVisualStyleBackColor = true;
      this.btnRemoveAllRSS.Click += new EventHandler(this.btnRemoveAllRSS_Click);
      this.lvRSS.Columns.AddRange(new ColumnHeader[9]
      {
        this.columnHeader19,
        this.columnHeader12,
        this.columnHeader13,
        this.columnHeader14,
        this.columnHeader15,
        this.columnHeader16,
        this.columnHeader28,
        this.columnHeader17,
        this.columnHeader18
      });
      this.lvRSS.Dock = DockStyle.Top;
      this.lvRSS.GridLines = true;
      this.lvRSS.Location = new Point(0, 0);
      this.lvRSS.Margin = new Padding(1);
      this.lvRSS.Name = "lvRSS";
      this.lvRSS.Size = new Size(834, 205);
      this.lvRSS.TabIndex = 1;
      this.lvRSS.UseCompatibleStateImageBehavior = false;
      this.lvRSS.View = View.Details;
      this.lvRSS.ColumnClick += new ColumnClickEventHandler(this.lvRSS_ColumnClick);
      this.lvRSS.ItemCheck += new ItemCheckEventHandler(this.lvRSS_ItemCheck);
      this.lvRSS.SelectedIndexChanged += new EventHandler(this.lvRSS_SelectedIndexChanged);
      this.columnHeader19.Text = "";
      this.columnHeader19.Width = 215;
      this.columnHeader12.Text = "Created date";
      this.columnHeader12.Width = 121;
      this.columnHeader13.Text = "Modified date";
      this.columnHeader13.Width = 120;
      this.columnHeader14.Text = "Run #";
      this.columnHeader14.TextAlign = HorizontalAlignment.Center;
      this.columnHeader14.Width = 81;
      this.columnHeader15.Text = "App name";
      this.columnHeader15.Width = 149;
      this.columnHeader16.Text = "Country";
      this.columnHeader16.Width = 158;
      this.columnHeader28.Text = "Last IP";
      this.columnHeader28.Width = 163;
      this.columnHeader17.Text = "Comment";
      this.columnHeader17.Width = 186;
      this.columnHeader18.Text = "Sub";
      this.tpSupport.Controls.Add((Control) this.lvAllScripts);
      this.tpSupport.Controls.Add((Control) this.panel1);
      this.tpSupport.Controls.Add((Control) this.gbScript);
      this.tpSupport.Controls.Add((Control) this.groupBox2);
      this.tpSupport.Location = new Point(4, 34);
      this.tpSupport.Margin = new Padding(1);
      this.tpSupport.Name = "tpSupport";
      this.tpSupport.Size = new Size(834, 401);
      this.tpSupport.TabIndex = 3;
      this.tpSupport.Text = "Support";
      this.tpSupport.UseVisualStyleBackColor = true;
      this.lvAllScripts.Columns.AddRange(new ColumnHeader[1]
      {
        this.columnHeader24
      });
      this.lvAllScripts.Dock = DockStyle.Fill;
      this.lvAllScripts.FullRowSelect = true;
      this.lvAllScripts.GridLines = true;
      this.lvAllScripts.HideSelection = false;
      this.lvAllScripts.Location = new Point(0, 56);
      this.lvAllScripts.Margin = new Padding(2);
      this.lvAllScripts.MultiSelect = false;
      this.lvAllScripts.Name = "lvAllScripts";
      this.lvAllScripts.Size = new Size(190, 276);
      this.lvAllScripts.TabIndex = 28;
      this.lvAllScripts.UseCompatibleStateImageBehavior = false;
      this.lvAllScripts.View = View.Details;
      this.lvAllScripts.SelectedIndexChanged += new EventHandler(this.lvAllScripts_SelectedIndexChanged);
      this.columnHeader24.Text = "All scripts";
      this.columnHeader24.Width = 203;
      this.panel1.Controls.Add((Control) this.btnDeleteScript);
      this.panel1.Controls.Add((Control) this.btnAddScript);
      this.panel1.Dock = DockStyle.Bottom;
      this.panel1.Location = new Point(0, 332);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(190, 69);
      this.panel1.TabIndex = 31;
      this.btnDeleteScript.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.btnDeleteScript.Enabled = false;
      this.btnDeleteScript.Location = new Point(8, 33);
      this.btnDeleteScript.Margin = new Padding(1);
      this.btnDeleteScript.Name = "btnDeleteScript";
      this.btnDeleteScript.Size = new Size(72, 27);
      this.btnDeleteScript.TabIndex = 30;
      this.btnDeleteScript.Text = "Delete";
      this.btnDeleteScript.UseVisualStyleBackColor = true;
      this.btnDeleteScript.Click += new EventHandler(this.btnDeleteScript_Click);
      this.btnAddScript.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.btnAddScript.Location = new Point(105, 33);
      this.btnAddScript.Margin = new Padding(1);
      this.btnAddScript.Name = "btnAddScript";
      this.btnAddScript.Size = new Size(81, 27);
      this.btnAddScript.TabIndex = 29;
      this.btnAddScript.Text = "New";
      this.btnAddScript.UseVisualStyleBackColor = true;
      this.btnAddScript.Click += new EventHandler(this.btnAddScript_Click);
      this.gbScript.Controls.Add((Control) this.button12);
      this.gbScript.Controls.Add((Control) this.btnBKSP);
      this.gbScript.Controls.Add((Control) this.btnTestScript);
      this.gbScript.Controls.Add((Control) this.groupBox9);
      this.gbScript.Controls.Add((Control) this.btnHelp);
      this.gbScript.Controls.Add((Control) this.btnRecordEvent);
      this.gbScript.Controls.Add((Control) this.btnSaveScript);
      this.gbScript.Controls.Add((Control) this.btnWipe);
      this.gbScript.Controls.Add((Control) this.tbnOpenApp);
      this.gbScript.Controls.Add((Control) this.tbScript);
      this.gbScript.Dock = DockStyle.Right;
      this.gbScript.Enabled = false;
      this.gbScript.Location = new Point(190, 56);
      this.gbScript.Margin = new Padding(1);
      this.gbScript.Name = "gbScript";
      this.gbScript.Padding = new Padding(1);
      this.gbScript.Size = new Size(644, 345);
      this.gbScript.TabIndex = 2;
      this.gbScript.TabStop = false;
      this.button12.Location = new Point(7, 94);
      this.button12.Margin = new Padding(1);
      this.button12.Name = "button12";
      this.button12.Size = new Size(68, 27);
      this.button12.TabIndex = 28;
      this.button12.Text = "Clear";
      this.button12.UseVisualStyleBackColor = true;
      this.button12.Click += new EventHandler(this.button12_Click);
      this.btnBKSP.Enabled = false;
      this.btnBKSP.Location = new Point(324, 57);
      this.btnBKSP.Margin = new Padding(1);
      this.btnBKSP.Name = "btnBKSP";
      this.btnBKSP.Size = new Size(68, 27);
      this.btnBKSP.TabIndex = 26;
      this.btnBKSP.Text = "Backup";
      this.btnBKSP.UseVisualStyleBackColor = true;
      this.btnBKSP.Click += new EventHandler(this.btnBKSP_Click);
      this.btnTestScript.Location = new Point(84, 57);
      this.btnTestScript.Margin = new Padding(1);
      this.btnTestScript.Name = "btnTestScript";
      this.btnTestScript.Size = new Size(68, 27);
      this.btnTestScript.TabIndex = 25;
      this.btnTestScript.Text = "Test script";
      this.btnTestScript.UseVisualStyleBackColor = true;
      this.btnTestScript.Click += new EventHandler(this.btnTestScript_Click);
      this.groupBox9.Controls.Add((Control) this.rbCustomScript);
      this.groupBox9.Controls.Add((Control) this.rbScriptForApp);
      this.groupBox9.Controls.Add((Control) this.tbScriptName);
      this.groupBox9.Controls.Add((Control) this.cbApps);
      this.groupBox9.Controls.Add((Control) this.btRefresh);
      this.groupBox9.Location = new Point(7, 10);
      this.groupBox9.Margin = new Padding(2);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Padding = new Padding(2);
      this.groupBox9.Size = new Size(631, 44);
      this.groupBox9.TabIndex = 24;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "Script type";
      this.rbCustomScript.AutoSize = true;
      this.rbCustomScript.Location = new Point(298, 17);
      this.rbCustomScript.Margin = new Padding(2);
      this.rbCustomScript.Name = "rbCustomScript";
      this.rbCustomScript.Size = new Size(88, 17);
      this.rbCustomScript.TabIndex = 22;
      this.rbCustomScript.Text = "Custom script";
      this.rbCustomScript.UseVisualStyleBackColor = true;
      this.rbCustomScript.CheckedChanged += new EventHandler(this.rbCustomScript_CheckedChanged);
      this.rbScriptForApp.AutoSize = true;
      this.rbScriptForApp.Checked = true;
      this.rbScriptForApp.Location = new Point(8, 17);
      this.rbScriptForApp.Margin = new Padding(2);
      this.rbScriptForApp.Name = "rbScriptForApp";
      this.rbScriptForApp.Size = new Size(91, 17);
      this.rbScriptForApp.TabIndex = 0;
      this.rbScriptForApp.TabStop = true;
      this.rbScriptForApp.Text = "Script for app:";
      this.rbScriptForApp.UseVisualStyleBackColor = true;
      this.rbScriptForApp.CheckedChanged += new EventHandler(this.rbScriptForApp_CheckedChanged);
      this.tbScriptName.Location = new Point(389, 17);
      this.tbScriptName.Margin = new Padding(2);
      this.tbScriptName.Name = "tbScriptName";
      this.tbScriptName.Size = new Size(239, 20);
      this.tbScriptName.TabIndex = 22;
      this.tbScriptName.TextChanged += new EventHandler(this.tbScriptName_TextChanged);
      this.cbApps.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbApps.FormattingEnabled = true;
      this.cbApps.Items.AddRange(new object[4]
      {
        (object) "App1",
        (object) "App2",
        (object) "Game1",
        (object) "Game2"
      });
      this.cbApps.Location = new Point(101, 16);
      this.cbApps.Margin = new Padding(1);
      this.cbApps.Name = "cbApps";
      this.cbApps.Size = new Size(140, 21);
      this.cbApps.TabIndex = 7;
      this.cbApps.SelectedIndexChanged += new EventHandler(this.cbApps_SelectedIndexChanged);
      this.btRefresh.Image = (Image) Resources.refresh;
      this.btRefresh.Location = new Point(246, 16);
      this.btRefresh.Margin = new Padding(2);
      this.btRefresh.Name = "btRefresh";
      this.btRefresh.Size = new Size(28, 19);
      this.btRefresh.TabIndex = 21;
      this.btRefresh.UseVisualStyleBackColor = true;
      this.btRefresh.Click += new EventHandler(this.btRefresh_Click);
      this.btnHelp.Location = new Point(247, 57);
      this.btnHelp.Margin = new Padding(1);
      this.btnHelp.Name = "btnHelp";
      this.btnHelp.Size = new Size(68, 27);
      this.btnHelp.TabIndex = 23;
      this.btnHelp.Text = "Help";
      this.btnHelp.UseVisualStyleBackColor = true;
      this.btnHelp.Click += new EventHandler(this.btnHelp_Click);
      this.btnRecordEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnRecordEvent.Location = new Point(573, 57);
      this.btnRecordEvent.Margin = new Padding(1);
      this.btnRecordEvent.Name = "btnRecordEvent";
      this.btnRecordEvent.Size = new Size(68, 27);
      this.btnRecordEvent.TabIndex = 13;
      this.btnRecordEvent.Text = "Record";
      this.btnRecordEvent.UseVisualStyleBackColor = true;
      this.btnRecordEvent.Click += new EventHandler(this.btnRecordEvent_Click);
      this.btnSaveScript.Enabled = false;
      this.btnSaveScript.Location = new Point(168, 57);
      this.btnSaveScript.Margin = new Padding(1);
      this.btnSaveScript.Name = "btnSaveScript";
      this.btnSaveScript.Size = new Size(68, 27);
      this.btnSaveScript.TabIndex = 12;
      this.btnSaveScript.Text = "Save";
      this.btnSaveScript.UseVisualStyleBackColor = true;
      this.btnSaveScript.Click += new EventHandler(this.btnSaveScript_Click);
      this.btnWipe.Location = new Point(503, 57);
      this.btnWipe.Margin = new Padding(1);
      this.btnWipe.Name = "btnWipe";
      this.btnWipe.Size = new Size(68, 27);
      this.btnWipe.TabIndex = 11;
      this.btnWipe.Text = "Wipe";
      this.btnWipe.UseVisualStyleBackColor = true;
      this.btnWipe.Click += new EventHandler(this.btnWipe_Click);
      this.tbnOpenApp.Location = new Point(7, 57);
      this.tbnOpenApp.Margin = new Padding(1);
      this.tbnOpenApp.Name = "tbnOpenApp";
      this.tbnOpenApp.Size = new Size(68, 27);
      this.tbnOpenApp.TabIndex = 5;
      this.tbnOpenApp.Text = "Open app";
      this.tbnOpenApp.UseVisualStyleBackColor = true;
      this.tbnOpenApp.Click += new EventHandler(this.tbnOpenApp_Click);
      this.tbScript.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.tbScript.Font = new Font("Segoe UI", 7.916231f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tbScript.Location = new Point(6, 124);
      this.tbScript.Margin = new Padding(1);
      this.tbScript.Multiline = true;
      this.tbScript.Name = "tbScript";
      this.tbScript.ScrollBars = ScrollBars.Vertical;
      this.tbScript.Size = new Size(636, 212);
      this.tbScript.TabIndex = 1;
      this.tbScript.TextChanged += new EventHandler(this.tbScript_TextChanged);
      this.tbScript.KeyDown += new KeyEventHandler(this.tbScript_KeyDown);
      this.groupBox2.Controls.Add((Control) this.label22);
      this.groupBox2.Controls.Add((Control) this.btnOpenURL);
      this.groupBox2.Controls.Add((Control) this.tbURL);
      this.groupBox2.Dock = DockStyle.Top;
      this.groupBox2.Location = new Point(0, 0);
      this.groupBox2.Margin = new Padding(1);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new Padding(1);
      this.groupBox2.Size = new Size(834, 56);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Open URL";
      this.label22.AutoSize = true;
      this.label22.Location = new Point(7, 23);
      this.label22.Margin = new Padding(1, 0, 1, 0);
      this.label22.Name = "label22";
      this.label22.Size = new Size(32, 13);
      this.label22.TabIndex = 10;
      this.label22.Text = "URL:";
      this.btnOpenURL.Location = new Point(720, 16);
      this.btnOpenURL.Margin = new Padding(1);
      this.btnOpenURL.Name = "btnOpenURL";
      this.btnOpenURL.Size = new Size(68, 27);
      this.btnOpenURL.TabIndex = 5;
      this.btnOpenURL.Text = "Open";
      this.btnOpenURL.UseVisualStyleBackColor = true;
      this.btnOpenURL.Click += new EventHandler(this.btnOpenURL_Click);
      this.tbURL.Location = new Point(45, 22);
      this.tbURL.Margin = new Padding(1);
      this.tbURL.Name = "tbURL";
      this.tbURL.Size = new Size(667, 20);
      this.tbURL.TabIndex = 2;
      this.tbURL.Text = "https://www.apple.com/";
      this.tpSettings.Controls.Add((Control) this.groupBox6);
      this.tpSettings.Controls.Add((Control) this.groupBox5);
      this.tpSettings.Controls.Add((Control) this.groupBox4);
      this.tpSettings.Location = new Point(4, 34);
      this.tpSettings.Margin = new Padding(1);
      this.tpSettings.Name = "tpSettings";
      this.tpSettings.Size = new Size(834, 401);
      this.tpSettings.TabIndex = 4;
      this.tpSettings.Text = "Settings";
      this.tpSettings.UseVisualStyleBackColor = true;
      this.groupBox6.Controls.Add((Control) this.chkloopip);
      this.groupBox6.Controls.Add((Control) this.numloopip);
      this.groupBox6.Controls.Add((Control) this.usingchrome);
      this.groupBox6.Controls.Add((Control) this.button18);
      this.groupBox6.Controls.Add((Control) this.txtfileMail);
      this.groupBox6.Controls.Add((Control) this.chkmailfile);
      this.groupBox6.Controls.Add((Control) this.chkonlymail);
      this.groupBox6.Controls.Add((Control) this.chkloadurlagain);
      this.groupBox6.Controls.Add((Control) this.numLoadagainUrl);
      this.groupBox6.Controls.Add((Control) this.chkfakescreen);
      this.groupBox6.Controls.Add((Control) this.chkfakeUA);
      this.groupBox6.Controls.Add((Control) this.chkfakecoresystem);
      this.groupBox6.Controls.Add((Control) this.chkfakeGeo);
      this.groupBox6.Controls.Add((Control) this.chkipused);
      this.groupBox6.Location = new Point(10, 253);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new Size(796, 145);
      this.groupBox6.TabIndex = 2;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Setting Run";
      this.groupBox6.Enter += new EventHandler(this.groupBox6_Enter);
      this.chkloopip.AutoSize = true;
      this.chkloopip.Location = new Point(532, 22);
      this.chkloopip.Name = "chkloopip";
      this.chkloopip.Size = new Size(76, 17);
      this.chkloopip.TabIndex = 34;
      this.chkloopip.Text = "Set loop ip";
      this.chkloopip.UseVisualStyleBackColor = true;
      this.chkloopip.CheckedChanged += new EventHandler(this.chkloopip_CheckedChanged);
      this.numloopip.Location = new Point(614, 19);
      this.numloopip.Name = "numloopip";
      this.numloopip.Size = new Size(43, 20);
      this.numloopip.TabIndex = 33;
      this.numloopip.ValueChanged += new EventHandler(this.numloopip_ValueChanged);
      this.usingchrome.AutoSize = true;
      this.usingchrome.Location = new Point(532, 115);
      this.usingchrome.Margin = new Padding(1);
      this.usingchrome.Name = "usingchrome";
      this.usingchrome.Size = new Size(92, 17);
      this.usingchrome.TabIndex = 32;
      this.usingchrome.Text = "Using Chrome";
      this.usingchrome.UseVisualStyleBackColor = true;
      this.usingchrome.CheckedChanged += new EventHandler(this.usingchrome_CheckedChanged);
      this.button18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.button18.Location = new Point(454, 108);
      this.button18.Margin = new Padding(1);
      this.button18.Name = "button18";
      this.button18.Size = new Size(55, 27);
      this.button18.TabIndex = 31;
      this.button18.Text = "...";
      this.button18.UseVisualStyleBackColor = true;
      this.button18.Click += new EventHandler(this.button18_Click);
      this.txtfileMail.Location = new Point(282, 112);
      this.txtfileMail.Margin = new Padding(2);
      this.txtfileMail.Name = "txtfileMail";
      this.txtfileMail.Size = new Size(169, 20);
      this.txtfileMail.TabIndex = 30;
      this.txtfileMail.TextChanged += new EventHandler(this.txtfileMail_TextChanged);
      this.chkmailfile.AutoSize = true;
      this.chkmailfile.Location = new Point(189, 114);
      this.chkmailfile.Margin = new Padding(1);
      this.chkmailfile.Name = "chkmailfile";
      this.chkmailfile.Size = new Size(90, 17);
      this.chkmailfile.TabIndex = 28;
      this.chkmailfile.Text = "Mail : from file";
      this.chkmailfile.UseVisualStyleBackColor = true;
      this.chkmailfile.CheckedChanged += new EventHandler(this.chkmailfile_CheckedChanged);
      this.chkonlymail.AutoSize = true;
      this.chkonlymail.Location = new Point(189, 86);
      this.chkonlymail.Margin = new Padding(1);
      this.chkonlymail.Name = "chkonlymail";
      this.chkonlymail.Size = new Size(246, 17);
      this.chkonlymail.TabIndex = 21;
      this.chkonlymail.Text = "Mail only : gmail,hotmail,yahoo.com,verizon.net";
      this.chkonlymail.UseVisualStyleBackColor = true;
      this.chkonlymail.CheckedChanged += new EventHandler(this.chkonlymail_CheckedChanged);
      this.chkloadurlagain.AutoSize = true;
      this.chkloadurlagain.Location = new Point(189, 55);
      this.chkloadurlagain.Name = "chkloadurlagain";
      this.chkloadurlagain.Size = new Size(271, 17);
      this.chkloadurlagain.TabIndex = 20;
      this.chkloadurlagain.Text = "Số lần load lại link offer nếu không vào đc Appstore";
      this.chkloadurlagain.UseVisualStyleBackColor = true;
      this.chkloadurlagain.CheckedChanged += new EventHandler(this.chkloadurlagain_CheckedChanged);
      this.numLoadagainUrl.Location = new Point(466, 54);
      this.numLoadagainUrl.Name = "numLoadagainUrl";
      this.numLoadagainUrl.Size = new Size(43, 20);
      this.numLoadagainUrl.TabIndex = 19;
      this.numLoadagainUrl.ValueChanged += new EventHandler(this.numLoadagainUrl_ValueChanged);
      this.chkfakescreen.AutoSize = true;
      this.chkfakescreen.Checked = true;
      this.chkfakescreen.CheckState = CheckState.Checked;
      this.chkfakescreen.Location = new Point(9, 114);
      this.chkfakescreen.Margin = new Padding(1);
      this.chkfakescreen.Name = "chkfakescreen";
      this.chkfakescreen.Size = new Size(85, 17);
      this.chkfakescreen.TabIndex = 17;
      this.chkfakescreen.Text = "Fake screen";
      this.chkfakescreen.UseVisualStyleBackColor = true;
      this.chkfakescreen.CheckedChanged += new EventHandler(this.chkfakescreen_CheckedChanged);
      this.chkfakeUA.AutoSize = true;
      this.chkfakeUA.Checked = true;
      this.chkfakeUA.CheckState = CheckState.Checked;
      this.chkfakeUA.Location = new Point(9, 22);
      this.chkfakeUA.Margin = new Padding(1);
      this.chkfakeUA.Name = "chkfakeUA";
      this.chkfakeUA.Size = new Size(106, 17);
      this.chkfakeUA.TabIndex = 16;
      this.chkfakeUA.Text = "Fake User Agent";
      this.chkfakeUA.UseVisualStyleBackColor = true;
      this.chkfakeUA.CheckedChanged += new EventHandler(this.chkfakeUA_CheckedChanged);
      this.chkfakecoresystem.AutoSize = true;
      this.chkfakecoresystem.Location = new Point(9, 86);
      this.chkfakecoresystem.Margin = new Padding(1);
      this.chkfakecoresystem.Name = "chkfakecoresystem";
      this.chkfakecoresystem.Size = new Size(144, 17);
      this.chkfakecoresystem.TabIndex = 15;
      this.chkfakecoresystem.Text = "Fake core system device";
      this.chkfakecoresystem.UseVisualStyleBackColor = true;
      this.chkfakecoresystem.CheckedChanged += new EventHandler(this.chkfakecoresystem_CheckedChanged);
      this.chkfakeGeo.AutoSize = true;
      this.chkfakeGeo.Checked = true;
      this.chkfakeGeo.CheckState = CheckState.Checked;
      this.chkfakeGeo.Location = new Point(9, 55);
      this.chkfakeGeo.Margin = new Padding(1);
      this.chkfakeGeo.Name = "chkfakeGeo";
      this.chkfakeGeo.Size = new Size(95, 17);
      this.chkfakeGeo.TabIndex = 14;
      this.chkfakeGeo.Text = "Auto fake Geo";
      this.chkfakeGeo.UseVisualStyleBackColor = true;
      this.chkfakeGeo.CheckedChanged += new EventHandler(this.chkfakeGeo_CheckedChanged);
      this.chkipused.AutoSize = true;
      this.chkipused.Location = new Point(190, 22);
      this.chkipused.Margin = new Padding(1);
      this.chkipused.Name = "chkipused";
      this.chkipused.Size = new Size(94, 17);
      this.chkipused.TabIndex = 11;
      this.chkipused.Text = "Check ip used";
      this.chkipused.UseVisualStyleBackColor = true;
      this.chkipused.CheckedChanged += new EventHandler(this.chkipused_CheckedChanged);
      this.groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.groupBox5.Controls.Add((Control) this.chkonly10_3_1);
      this.groupBox5.Controls.Add((Control) this.checkiPhone7);
      this.groupBox5.Controls.Add((Control) this.gbFD);
      this.groupBox5.Controls.Add((Control) this.combFakeDeviceModel);
      this.groupBox5.Controls.Add((Control) this.combFakeIOSVersion);
      this.groupBox5.Controls.Add((Control) this.cbFakeDeviceFromFile);
      this.groupBox5.Location = new Point(387, 8);
      this.groupBox5.Margin = new Padding(1);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Padding = new Padding(1);
      this.groupBox5.Size = new Size(442, 240);
      this.groupBox5.TabIndex = 1;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Fake device";
      this.chkonly10_3_1.AutoSize = true;
      this.chkonly10_3_1.Location = new Point(11, 189);
      this.chkonly10_3_1.Margin = new Padding(2);
      this.chkonly10_3_1.Name = "chkonly10_3_1";
      this.chkonly10_3_1.Size = new Size(77, 17);
      this.chkonly10_3_1.TabIndex = 36;
      this.chkonly10_3_1.Text = "Only10.3.1";
      this.chkonly10_3_1.UseVisualStyleBackColor = true;
      this.chkonly10_3_1.CheckedChanged += new EventHandler(this.chkonly10_3_1_CheckedChanged);
      this.checkiPhone7.AutoSize = true;
      this.checkiPhone7.Location = new Point(11, 159);
      this.checkiPhone7.Margin = new Padding(2);
      this.checkiPhone7.Name = "checkiPhone7";
      this.checkiPhone7.Size = new Size(77, 17);
      this.checkiPhone7.TabIndex = 35;
      this.checkiPhone7.Text = "iPhone7>>";
      this.checkiPhone7.UseVisualStyleBackColor = true;
      this.checkiPhone7.CheckedChanged += new EventHandler(this.checkiPhone7_CheckedChanged);
      this.gbFD.Controls.Add((Control) this.cbiOS11);
      this.gbFD.Controls.Add((Control) this.cbiOS10);
      this.gbFD.Controls.Add((Control) this.label12);
      this.gbFD.Controls.Add((Control) this.cbRandomName);
      this.gbFD.Controls.Add((Control) this.tbFakeDeviceName);
      this.gbFD.Controls.Add((Control) this.label14);
      this.gbFD.Controls.Add((Control) this.cbiPhone);
      this.gbFD.Controls.Add((Control) this.label13);
      this.gbFD.Controls.Add((Control) this.cbiPad);
      this.gbFD.Controls.Add((Control) this.cbiPodTouch);
      this.gbFD.Controls.Add((Control) this.cbiOS9);
      this.gbFD.Controls.Add((Control) this.cbiOS8);
      this.gbFD.Location = new Point(11, 43);
      this.gbFD.Margin = new Padding(2);
      this.gbFD.Name = "gbFD";
      this.gbFD.Padding = new Padding(2);
      this.gbFD.Size = new Size(418, 109);
      this.gbFD.TabIndex = 34;
      this.gbFD.TabStop = false;
      this.gbFD.Enter += new EventHandler(this.gbFD_Enter);
      this.cbiOS10.AutoSize = true;
      this.cbiOS10.Location = new Point(270, 18);
      this.cbiOS10.Margin = new Padding(2);
      this.cbiOS10.Name = "cbiOS10";
      this.cbiOS10.Size = new Size(58, 17);
      this.cbiOS10.TabIndex = 34;
      this.cbiOS10.Text = "iOS 10";
      this.cbiOS10.UseVisualStyleBackColor = true;
      this.cbiOS10.CheckedChanged += new EventHandler(this.cbiOS10_CheckedChanged);
      this.label12.AutoSize = true;
      this.label12.Location = new Point(12, 19);
      this.label12.Margin = new Padding(2, 0, 2, 0);
      this.label12.Name = "label12";
      this.label12.Size = new Size(88, 13);
      this.label12.TabIndex = 30;
      this.label12.Text = "Fake iOS version";
      this.cbRandomName.AutoSize = true;
      this.cbRandomName.Location = new Point(125, 72);
      this.cbRandomName.Margin = new Padding(2);
      this.cbRandomName.Name = "cbRandomName";
      this.cbRandomName.Size = new Size(66, 17);
      this.cbRandomName.TabIndex = 33;
      this.cbRandomName.Text = "Random";
      this.cbRandomName.UseVisualStyleBackColor = true;
      this.cbRandomName.CheckedChanged += new EventHandler(this.cbRandomName_CheckedChanged);
      this.tbFakeDeviceName.Location = new Point(202, 71);
      this.tbFakeDeviceName.Margin = new Padding(1);
      this.tbFakeDeviceName.Name = "tbFakeDeviceName";
      this.tbFakeDeviceName.Size = new Size(145, 20);
      this.tbFakeDeviceName.TabIndex = 24;
      this.tbFakeDeviceName.TextChanged += new EventHandler(this.tbFakeDeviceName_TextChanged);
      this.label14.AutoSize = true;
      this.label14.Location = new Point(12, 73);
      this.label14.Margin = new Padding(2, 0, 2, 0);
      this.label14.Name = "label14";
      this.label14.Size = new Size(60, 13);
      this.label14.TabIndex = 32;
      this.label14.Text = "Fake name";
      this.cbiPhone.AutoSize = true;
      this.cbiPhone.Location = new Point(125, 45);
      this.cbiPhone.Margin = new Padding(2);
      this.cbiPhone.Name = "cbiPhone";
      this.cbiPhone.Size = new Size(59, 17);
      this.cbiPhone.TabIndex = 25;
      this.cbiPhone.Text = "iPhone";
      this.cbiPhone.UseVisualStyleBackColor = true;
      this.cbiPhone.CheckedChanged += new EventHandler(this.cbiPhone_CheckedChanged);
      this.label13.AutoSize = true;
      this.label13.Location = new Point(12, 45);
      this.label13.Margin = new Padding(2, 0, 2, 0);
      this.label13.Name = "label13";
      this.label13.Size = new Size(62, 13);
      this.label13.TabIndex = 31;
      this.label13.Text = "Fake model";
      this.cbiPad.AutoSize = true;
      this.cbiPad.Enabled = false;
      this.cbiPad.Location = new Point(207, 45);
      this.cbiPad.Margin = new Padding(2);
      this.cbiPad.Name = "cbiPad";
      this.cbiPad.Size = new Size(47, 17);
      this.cbiPad.TabIndex = 26;
      this.cbiPad.Text = "iPad";
      this.cbiPad.UseVisualStyleBackColor = true;
      this.cbiPad.CheckedChanged += new EventHandler(this.cbiPad_CheckedChanged);
      this.cbiPodTouch.AutoSize = true;
      this.cbiPodTouch.Enabled = false;
      this.cbiPodTouch.Location = new Point(269, 45);
      this.cbiPodTouch.Margin = new Padding(2);
      this.cbiPodTouch.Name = "cbiPodTouch";
      this.cbiPodTouch.Size = new Size(81, 17);
      this.cbiPodTouch.TabIndex = 27;
      this.cbiPodTouch.Text = "iPod Touch";
      this.cbiPodTouch.UseVisualStyleBackColor = true;
      this.cbiPodTouch.CheckedChanged += new EventHandler(this.cbiPodTouch_CheckedChanged);
      this.cbiOS9.AutoSize = true;
      this.cbiOS9.Location = new Point(207, 18);
      this.cbiOS9.Margin = new Padding(2);
      this.cbiOS9.Name = "cbiOS9";
      this.cbiOS9.Size = new Size(52, 17);
      this.cbiOS9.TabIndex = 29;
      this.cbiOS9.Text = "iOS 9";
      this.cbiOS9.UseVisualStyleBackColor = true;
      this.cbiOS9.CheckedChanged += new EventHandler(this.cbiOS9_CheckedChanged);
      this.cbiOS8.AutoSize = true;
      this.cbiOS8.Location = new Point(124, 18);
      this.cbiOS8.Margin = new Padding(2);
      this.cbiOS8.Name = "cbiOS8";
      this.cbiOS8.Size = new Size(52, 17);
      this.cbiOS8.TabIndex = 28;
      this.cbiOS8.Text = "iOS 8";
      this.cbiOS8.UseVisualStyleBackColor = true;
      this.cbiOS8.CheckedChanged += new EventHandler(this.cbiOS8_CheckedChanged);
      this.combFakeDeviceModel.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combFakeDeviceModel.FormattingEnabled = true;
      this.combFakeDeviceModel.Location = new Point(173, 155);
      this.combFakeDeviceModel.Margin = new Padding(1);
      this.combFakeDeviceModel.Name = "combFakeDeviceModel";
      this.combFakeDeviceModel.Size = new Size(220, 21);
      this.combFakeDeviceModel.TabIndex = 19;
      this.combFakeDeviceModel.Visible = false;
      this.combFakeDeviceModel.SelectedIndexChanged += new EventHandler(this.combFakeDeviceModel_SelectedIndexChanged);
      this.combFakeIOSVersion.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combFakeIOSVersion.FormattingEnabled = true;
      this.combFakeIOSVersion.Location = new Point(173, 185);
      this.combFakeIOSVersion.Margin = new Padding(1);
      this.combFakeIOSVersion.Name = "combFakeIOSVersion";
      this.combFakeIOSVersion.Size = new Size(220, 21);
      this.combFakeIOSVersion.TabIndex = 18;
      this.combFakeIOSVersion.Visible = false;
      this.combFakeIOSVersion.SelectedIndexChanged += new EventHandler(this.combFakeIOSVersion_SelectedIndexChanged);
      this.cbFakeDeviceFromFile.AutoSize = true;
      this.cbFakeDeviceFromFile.Font = new Font("Microsoft Sans Serif", 7.916231f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cbFakeDeviceFromFile.Location = new Point(11, 24);
      this.cbFakeDeviceFromFile.Margin = new Padding(1);
      this.cbFakeDeviceFromFile.Name = "cbFakeDeviceFromFile";
      this.cbFakeDeviceFromFile.Size = new Size(97, 17);
      this.cbFakeDeviceFromFile.TabIndex = 5;
      this.cbFakeDeviceFromFile.Text = "Random info";
      this.cbFakeDeviceFromFile.UseVisualStyleBackColor = true;
      this.cbFakeDeviceFromFile.CheckedChanged += new EventHandler(this.cbFakeDeviceFromFile_CheckedChanged);
      this.groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.groupBox4.Controls.Add((Control) this.numLong);
      this.groupBox4.Controls.Add((Control) this.numLat);
      this.groupBox4.Controls.Add((Control) this.combFakeCarrier);
      this.groupBox4.Controls.Add((Control) this.combFakeTimezone);
      this.groupBox4.Controls.Add((Control) this.label27);
      this.groupBox4.Controls.Add((Control) this.label26);
      this.groupBox4.Controls.Add((Control) this.cbFakeGPS);
      this.groupBox4.Controls.Add((Control) this.combFakeLang);
      this.groupBox4.Controls.Add((Control) this.combFakeRegion);
      this.groupBox4.Controls.Add((Control) this.cbFakeLang);
      this.groupBox4.Controls.Add((Control) this.cbFakeRegion);
      this.groupBox4.Controls.Add((Control) this.cbFakeCarrier);
      this.groupBox4.Controls.Add((Control) this.cbFakeTimeZone);
      this.groupBox4.Controls.Add((Control) this.cbAutoFakeLocation);
      this.groupBox4.Location = new Point(8, 8);
      this.groupBox4.Margin = new Padding(1);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Padding = new Padding(1);
      this.groupBox4.Size = new Size(368, 240);
      this.groupBox4.TabIndex = 0;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Fake location";
      this.numLong.Location = new Point(192, 207);
      this.numLong.Margin = new Padding(2);
      this.numLong.Name = "numLong";
      this.numLong.Size = new Size(169, 20);
      this.numLong.TabIndex = 19;
      this.numLong.TextChanged += new EventHandler(this.numLong_TextChanged);
      this.numLat.Location = new Point(192, 177);
      this.numLat.Margin = new Padding(2);
      this.numLat.Name = "numLat";
      this.numLat.Size = new Size(169, 20);
      this.numLat.TabIndex = 18;
      this.numLat.TextChanged += new EventHandler(this.numLat_TextChanged);
      this.combFakeCarrier.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combFakeCarrier.FormattingEnabled = true;
      this.combFakeCarrier.Location = new Point(141, 83);
      this.combFakeCarrier.Margin = new Padding(1);
      this.combFakeCarrier.Name = "combFakeCarrier";
      this.combFakeCarrier.Size = new Size(221, 21);
      this.combFakeCarrier.TabIndex = 17;
      this.combFakeCarrier.SelectedIndexChanged += new EventHandler(this.combFakeCarrier_SelectedIndexChanged);
      this.combFakeTimezone.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combFakeTimezone.FormattingEnabled = true;
      this.combFakeTimezone.Location = new Point(141, 52);
      this.combFakeTimezone.Margin = new Padding(1);
      this.combFakeTimezone.Name = "combFakeTimezone";
      this.combFakeTimezone.Size = new Size(221, 21);
      this.combFakeTimezone.TabIndex = 16;
      this.combFakeTimezone.SelectedIndexChanged += new EventHandler(this.combFakeTimezone_SelectedIndexChanged);
      this.label27.AutoSize = true;
      this.label27.Location = new Point(138, 209);
      this.label27.Margin = new Padding(1, 0, 1, 0);
      this.label27.Name = "label27";
      this.label27.Size = new Size(34, 13);
      this.label27.TabIndex = 15;
      this.label27.Text = "Long:";
      this.label26.AutoSize = true;
      this.label26.Location = new Point(138, 179);
      this.label26.Margin = new Padding(1, 0, 1, 0);
      this.label26.Name = "label26";
      this.label26.Size = new Size(25, 13);
      this.label26.TabIndex = 13;
      this.label26.Text = "Lat:";
      this.cbFakeGPS.AutoSize = true;
      this.cbFakeGPS.Location = new Point(11, 178);
      this.cbFakeGPS.Margin = new Padding(1);
      this.cbFakeGPS.Name = "cbFakeGPS";
      this.cbFakeGPS.Size = new Size(75, 17);
      this.cbFakeGPS.TabIndex = 10;
      this.cbFakeGPS.Text = "Fake GPS";
      this.cbFakeGPS.UseVisualStyleBackColor = true;
      this.cbFakeGPS.CheckedChanged += new EventHandler(this.cbFakeGPS_CheckedChanged);
      this.combFakeLang.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combFakeLang.FormattingEnabled = true;
      this.combFakeLang.Location = new Point(141, 144);
      this.combFakeLang.Margin = new Padding(1);
      this.combFakeLang.Name = "combFakeLang";
      this.combFakeLang.Size = new Size(221, 21);
      this.combFakeLang.TabIndex = 9;
      this.combFakeLang.SelectedIndexChanged += new EventHandler(this.combFakeLang_SelectedIndexChanged);
      this.combFakeRegion.DropDownStyle = ComboBoxStyle.DropDownList;
      this.combFakeRegion.FormattingEnabled = true;
      this.combFakeRegion.Location = new Point(141, 113);
      this.combFakeRegion.Margin = new Padding(1);
      this.combFakeRegion.Name = "combFakeRegion";
      this.combFakeRegion.Size = new Size(221, 21);
      this.combFakeRegion.TabIndex = 8;
      this.combFakeRegion.SelectedIndexChanged += new EventHandler(this.combFakeRegion_SelectedIndexChanged);
      this.cbFakeLang.AutoSize = true;
      this.cbFakeLang.Location = new Point(11, 146);
      this.cbFakeLang.Margin = new Padding(1);
      this.cbFakeLang.Name = "cbFakeLang";
      this.cbFakeLang.Size = new Size(97, 17);
      this.cbFakeLang.TabIndex = 7;
      this.cbFakeLang.Text = "Fake language";
      this.cbFakeLang.UseVisualStyleBackColor = true;
      this.cbFakeLang.CheckedChanged += new EventHandler(this.cbFakeLang_CheckedChanged);
      this.cbFakeRegion.AutoSize = true;
      this.cbFakeRegion.Location = new Point(11, 115);
      this.cbFakeRegion.Margin = new Padding(1);
      this.cbFakeRegion.Name = "cbFakeRegion";
      this.cbFakeRegion.Size = new Size(82, 17);
      this.cbFakeRegion.TabIndex = 6;
      this.cbFakeRegion.Text = "Fake region";
      this.cbFakeRegion.UseVisualStyleBackColor = true;
      this.cbFakeRegion.CheckedChanged += new EventHandler(this.cbFakeRegion_CheckedChanged);
      this.cbFakeCarrier.AutoSize = true;
      this.cbFakeCarrier.Location = new Point(11, 84);
      this.cbFakeCarrier.Margin = new Padding(1);
      this.cbFakeCarrier.Name = "cbFakeCarrier";
      this.cbFakeCarrier.Size = new Size(82, 17);
      this.cbFakeCarrier.TabIndex = 5;
      this.cbFakeCarrier.Text = "Fake carrier";
      this.cbFakeCarrier.UseVisualStyleBackColor = true;
      this.cbFakeCarrier.CheckedChanged += new EventHandler(this.cbFakeCarrier_CheckedChanged);
      this.cbFakeTimeZone.AutoSize = true;
      this.cbFakeTimeZone.Location = new Point(11, 53);
      this.cbFakeTimeZone.Margin = new Padding(1);
      this.cbFakeTimeZone.Name = "cbFakeTimeZone";
      this.cbFakeTimeZone.Size = new Size(95, 17);
      this.cbFakeTimeZone.TabIndex = 4;
      this.cbFakeTimeZone.Text = "Fake timezone";
      this.cbFakeTimeZone.UseVisualStyleBackColor = true;
      this.cbFakeTimeZone.CheckedChanged += new EventHandler(this.cbFakeTimeZone_CheckedChanged);
      this.cbAutoFakeLocation.AutoSize = true;
      this.cbAutoFakeLocation.Font = new Font("Microsoft Sans Serif", 7.916231f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.cbAutoFakeLocation.Location = new Point(11, 23);
      this.cbAutoFakeLocation.Margin = new Padding(1);
      this.cbAutoFakeLocation.Name = "cbAutoFakeLocation";
      this.cbAutoFakeLocation.Size = new Size(228, 17);
      this.cbAutoFakeLocation.TabIndex = 3;
      this.cbAutoFakeLocation.Text = "Auto fake location correspond to IP";
      this.cbAutoFakeLocation.UseVisualStyleBackColor = true;
      this.cbAutoFakeLocation.CheckedChanged += new EventHandler(this.cbAutoFakeLocation_CheckedChanged);
      this.tpContact.Controls.Add((Control) this.groupBox8);
      this.tpContact.Controls.Add((Control) this.groupBox7);
      this.tpContact.Location = new Point(4, 34);
      this.tpContact.Margin = new Padding(1);
      this.tpContact.Name = "tpContact";
      this.tpContact.Size = new Size(834, 401);
      this.tpContact.TabIndex = 5;
      this.tpContact.Text = "Contact";
      this.tpContact.UseVisualStyleBackColor = true;
      this.groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.groupBox8.Controls.Add((Control) this.tbKeyActivation);
      this.groupBox8.Controls.Add((Control) this.btnActivate);
      this.groupBox8.Controls.Add((Control) this.lvRegisteredList);
      this.groupBox8.Controls.Add((Control) this.label25);
      this.groupBox8.Location = new Point(9, 88);
      this.groupBox8.Margin = new Padding(1);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Padding = new Padding(1);
      this.groupBox8.Size = new Size(820, 160);
      this.groupBox8.TabIndex = 2;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "License";
      this.tbKeyActivation.Font = new Font("Segoe UI", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tbKeyActivation.Location = new Point(11, 27);
      this.tbKeyActivation.Margin = new Padding(2);
      this.tbKeyActivation.Name = "tbKeyActivation";
      this.tbKeyActivation.Size = new Size(659, 25);
      this.tbKeyActivation.TabIndex = 8;
      this.tbKeyActivation.TextAlign = HorizontalAlignment.Center;
      this.tbKeyActivation.TextChanged += new EventHandler(this.tbKeyActivation_TextChanged);
      this.btnActivate.Location = new Point(681, 27);
      this.btnActivate.Margin = new Padding(1);
      this.btnActivate.Name = "btnActivate";
      this.btnActivate.Size = new Size(89, 22);
      this.btnActivate.TabIndex = 7;
      this.btnActivate.Text = "Activate";
      this.btnActivate.UseVisualStyleBackColor = true;
      this.btnActivate.Click += new EventHandler(this.btnActivate_Click);
      this.lvRegisteredList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.lvRegisteredList.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader20,
        this.columnHeader21
      });
      this.lvRegisteredList.FullRowSelect = true;
      this.lvRegisteredList.GridLines = true;
      this.lvRegisteredList.Location = new Point(11, 79);
      this.lvRegisteredList.Margin = new Padding(1);
      this.lvRegisteredList.Name = "lvRegisteredList";
      this.lvRegisteredList.Size = new Size(796, 72);
      this.lvRegisteredList.TabIndex = 6;
      this.lvRegisteredList.UseCompatibleStateImageBehavior = false;
      this.lvRegisteredList.View = View.Details;
      this.columnHeader20.Text = "Serial number";
      this.columnHeader20.Width = 562;
      this.columnHeader21.Text = "Expiration date";
      this.columnHeader21.Width = 514;
      this.label25.AutoSize = true;
      this.label25.Location = new Point(9, 57);
      this.label25.Margin = new Padding(1, 0, 1, 0);
      this.label25.Name = "label25";
      this.label25.Size = new Size(98, 13);
      this.label25.TabIndex = 5;
      this.label25.Text = "Registered devices";
      this.groupBox7.Controls.Add((Control) this.button10);
      this.groupBox7.Location = new Point(9, 9);
      this.groupBox7.Margin = new Padding(1);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Padding = new Padding(1);
      this.groupBox7.Size = new Size(783, 77);
      this.groupBox7.TabIndex = 1;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Contact";
      this.button10.Location = new Point(32, 17);
      this.button10.Name = "button10";
      this.button10.Size = new Size(75, 23);
      this.button10.TabIndex = 0;
      this.button10.Text = "testcode";
      this.button10.UseVisualStyleBackColor = true;
      this.button10.Click += new EventHandler(this.button10_Click_1);
      this.tprrsmanager.BackColor = Color.Transparent;
      this.tprrsmanager.Controls.Add((Control) this.button19);
      this.tprrsmanager.Controls.Add((Control) this.label35);
      this.tprrsmanager.Controls.Add((Control) this.button17);
      this.tprrsmanager.Controls.Add((Control) this.button16);
      this.tprrsmanager.Controls.Add((Control) this.button15);
      this.tprrsmanager.Controls.Add((Control) this.button14);
      this.tprrsmanager.Controls.Add((Control) this.label34);
      this.tprrsmanager.Controls.Add((Control) this.cborrsmnCountry);
      this.tprrsmanager.Controls.Add((Control) this.label33);
      this.tprrsmanager.Controls.Add((Control) this.cborrsmnName);
      this.tprrsmanager.Controls.Add((Control) this.label32);
      this.tprrsmanager.Controls.Add((Control) this.cborrsmnDay);
      this.tprrsmanager.Controls.Add((Control) this.lvsrrsmanager);
      this.tprrsmanager.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tprrsmanager.Location = new Point(4, 34);
      this.tprrsmanager.Name = "tprrsmanager";
      this.tprrsmanager.Padding = new Padding(3);
      this.tprrsmanager.Size = new Size(834, 401);
      this.tprrsmanager.TabIndex = 6;
      this.tprrsmanager.Text = "RRS Manager";
      this.tprrsmanager.Click += new EventHandler(this.tpTestoff_Click);
      this.button19.Image = (Image) Resources.refresh;
      this.button19.Location = new Point(329, 358);
      this.button19.Margin = new Padding(2);
      this.button19.Name = "button19";
      this.button19.Size = new Size(28, 21);
      this.button19.TabIndex = 56;
      this.button19.UseVisualStyleBackColor = true;
      this.button19.Click += new EventHandler(this.button19_Click);
      this.label35.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.label35.AutoSize = true;
      this.label35.ForeColor = Color.FromArgb(0, 192, 0);
      this.label35.Location = new Point(233, 362);
      this.label35.Margin = new Padding(1, 0, 1, 0);
      this.label35.Name = "label35";
      this.label35.Size = new Size(58, 13);
      this.label35.TabIndex = 54;
      this.label35.Text = "Enabled: 0";
      this.button17.BackColor = Color.FromArgb(0, 192, 0);
      this.button17.Font = new Font("Times New Roman", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button17.ForeColor = Color.White;
      this.button17.Location = new Point(493, 363);
      this.button17.Margin = new Padding(1);
      this.button17.Name = "button17";
      this.button17.Size = new Size(138, 35);
      this.button17.TabIndex = 53;
      this.button17.Text = "Filter with Sub";
      this.button17.UseVisualStyleBackColor = false;
      this.button17.Click += new EventHandler(this.button17_Click);
      this.button16.BackColor = Color.Red;
      this.button16.Font = new Font("Times New Roman", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button16.ForeColor = Color.Yellow;
      this.button16.Location = new Point(699, 328);
      this.button16.Margin = new Padding(1);
      this.button16.Name = "button16";
      this.button16.Size = new Size(106, 68);
      this.button16.TabIndex = 52;
      this.button16.Text = "Remove no Lead";
      this.button16.UseVisualStyleBackColor = false;
      this.button16.Click += new EventHandler(this.button16_Click);
      this.button15.BackColor = Color.FromArgb(0, 192, 0);
      this.button15.Font = new Font("Times New Roman", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button15.ForeColor = Color.White;
      this.button15.Location = new Point(493, 328);
      this.button15.Margin = new Padding(1);
      this.button15.Name = "button15";
      this.button15.Size = new Size(138, 35);
      this.button15.TabIndex = 51;
      this.button15.Text = "Filter with IP";
      this.button15.UseVisualStyleBackColor = false;
      this.button15.Click += new EventHandler(this.button15_Click);
      this.button14.BackColor = Color.FromArgb(0, 192, 0);
      this.button14.Font = new Font("Times New Roman", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button14.ForeColor = Color.Yellow;
      this.button14.Location = new Point(377, 328);
      this.button14.Margin = new Padding(1);
      this.button14.Name = "button14";
      this.button14.Size = new Size(106, 68);
      this.button14.TabIndex = 50;
      this.button14.Text = "Search";
      this.button14.UseVisualStyleBackColor = false;
      this.button14.Click += new EventHandler(this.button14_Click);
      this.label34.AutoSize = true;
      this.label34.Location = new Point(185, 335);
      this.label34.Margin = new Padding(1, 0, 1, 0);
      this.label34.Name = "label34";
      this.label34.Size = new Size(43, 13);
      this.label34.TabIndex = 49;
      this.label34.Text = "Country";
      this.cborrsmnCountry.FormattingEnabled = true;
      this.cborrsmnCountry.Location = new Point(236, 331);
      this.cborrsmnCountry.Name = "cborrsmnCountry";
      this.cborrsmnCountry.Size = new Size(122, 21);
      this.cborrsmnCountry.TabIndex = 48;
      this.label33.AutoSize = true;
      this.label33.Location = new Point(7, 362);
      this.label33.Margin = new Padding(1, 0, 1, 0);
      this.label33.Name = "label33";
      this.label33.Size = new Size(35, 13);
      this.label33.TabIndex = 47;
      this.label33.Text = "Name";
      this.cborrsmnName.FormattingEnabled = true;
      this.cborrsmnName.Location = new Point(48, 358);
      this.cborrsmnName.Name = "cborrsmnName";
      this.cborrsmnName.Size = new Size(133, 21);
      this.cborrsmnName.TabIndex = 46;
      this.label32.AutoSize = true;
      this.label32.Location = new Point(7, 335);
      this.label32.Margin = new Padding(1, 0, 1, 0);
      this.label32.Name = "label32";
      this.label32.Size = new Size(31, 13);
      this.label32.TabIndex = 45;
      this.label32.Text = "Days";
      this.cborrsmnDay.FormattingEnabled = true;
      this.cborrsmnDay.Location = new Point(48, 331);
      this.cborrsmnDay.Name = "cborrsmnDay";
      this.cborrsmnDay.Size = new Size(133, 21);
      this.cborrsmnDay.TabIndex = 44;
      this.lvsrrsmanager.Columns.AddRange(new ColumnHeader[9]
      {
        this.columnHeader29,
        this.columnHeader30,
        this.columnHeader31,
        this.columnHeader32,
        this.columnHeader33,
        this.columnHeader34,
        this.columnHeader35,
        this.columnHeader36,
        this.columnHeader37
      });
      this.lvsrrsmanager.Dock = DockStyle.Top;
      this.lvsrrsmanager.GridLines = true;
      this.lvsrrsmanager.Location = new Point(3, 3);
      this.lvsrrsmanager.Margin = new Padding(1);
      this.lvsrrsmanager.Name = "lvsrrsmanager";
      this.lvsrrsmanager.Size = new Size(828, 315);
      this.lvsrrsmanager.TabIndex = 2;
      this.lvsrrsmanager.UseCompatibleStateImageBehavior = false;
      this.lvsrrsmanager.View = View.Details;
      this.columnHeader29.Text = "";
      this.columnHeader29.Width = 215;
      this.columnHeader30.Text = "Created date";
      this.columnHeader30.Width = 121;
      this.columnHeader31.Text = "Modified date";
      this.columnHeader31.Width = 120;
      this.columnHeader32.Text = "Run #";
      this.columnHeader32.TextAlign = HorizontalAlignment.Center;
      this.columnHeader32.Width = 81;
      this.columnHeader33.Text = "App name";
      this.columnHeader33.Width = 149;
      this.columnHeader34.Text = "Country";
      this.columnHeader34.Width = 158;
      this.columnHeader35.Text = "Last IP";
      this.columnHeader35.Width = 163;
      this.columnHeader36.Text = "Comment";
      this.columnHeader36.Width = 86;
      this.columnHeader37.Text = "Sub";
      this.columnHeader37.Width = 160;
      this.tpExIm.Controls.Add((Control) this.button30);
      this.tpExIm.Controls.Add((Control) this.textBox2);
      this.tpExIm.Controls.Add((Control) this.button29);
      this.tpExIm.Controls.Add((Control) this.button28);
      this.tpExIm.Controls.Add((Control) this.textBox1);
      this.tpExIm.Controls.Add((Control) this.button13);
      this.tpExIm.Controls.Add((Control) this.richTextBox2);
      this.tpExIm.Controls.Add((Control) this.groupBox10);
      this.tpExIm.Controls.Add((Control) this.button11);
      this.tpExIm.Controls.Add((Control) this.button8);
      this.tpExIm.Controls.Add((Control) this.button9);
      this.tpExIm.Location = new Point(4, 34);
      this.tpExIm.Margin = new Padding(1);
      this.tpExIm.Name = "tpExIm";
      this.tpExIm.Size = new Size(834, 401);
      this.tpExIm.TabIndex = 7;
      this.tpExIm.Text = "Manager";
      this.tpExIm.UseVisualStyleBackColor = true;
      this.button30.Location = new Point(419, 90);
      this.button30.Margin = new Padding(1);
      this.button30.Name = "button30";
      this.button30.Size = new Size(137, 27);
      this.button30.TabIndex = 32;
      this.button30.Text = "Connect ssh";
      this.button30.UseVisualStyleBackColor = true;
      this.textBox2.Location = new Point(266, 94);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(137, 20);
      this.textBox2.TabIndex = 31;
      this.button29.Enabled = false;
      this.button29.Location = new Point(266, 126);
      this.button29.Margin = new Padding(1);
      this.button29.Name = "button29";
      this.button29.Size = new Size(137, 27);
      this.button29.TabIndex = 30;
      this.button29.Text = "Check sudo";
      this.button29.UseVisualStyleBackColor = true;
      this.button29.Click += new EventHandler(this.button29_Click);
      this.button28.Enabled = false;
      this.button28.Location = new Point(741, 156);
      this.button28.Name = "button28";
      this.button28.Size = new Size(85, 30);
      this.button28.TabIndex = 5;
      this.button28.Text = "Sent";
      this.button28.UseVisualStyleBackColor = true;
      this.textBox1.Enabled = false;
      this.textBox1.Location = new Point(266, 162);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(467, 20);
      this.textBox1.TabIndex = 4;
      this.button13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.button13.BackColor = Color.Green;
      this.button13.ForeColor = Color.White;
      this.button13.Location = new Point(580, 47);
      this.button13.Margin = new Padding(1);
      this.button13.Name = "button13";
      this.button13.Size = new Size(123, 27);
      this.button13.TabIndex = 29;
      this.button13.Text = "SpringBoard iPhone";
      this.button13.UseVisualStyleBackColor = false;
      this.button13.Click += new EventHandler(this.button13_Click);
      this.richTextBox2.BackColor = Color.Black;
      this.richTextBox2.ForeColor = Color.Lime;
      this.richTextBox2.Location = new Point(266, 190);
      this.richTextBox2.Name = "richTextBox2";
      this.richTextBox2.Size = new Size(560, 188);
      this.richTextBox2.TabIndex = 3;
      this.richTextBox2.Text = "";
      this.groupBox10.Controls.Add((Control) this.button26);
      this.groupBox10.Controls.Add((Control) this.button27);
      this.groupBox10.Controls.Add((Control) this.button24);
      this.groupBox10.Controls.Add((Control) this.button22);
      this.groupBox10.Controls.Add((Control) this.button23);
      this.groupBox10.Controls.Add((Control) this.button25);
      this.groupBox10.Controls.Add((Control) this.button20);
      this.groupBox10.Controls.Add((Control) this.button21);
      this.groupBox10.Location = new Point(11, 17);
      this.groupBox10.Name = "groupBox10";
      this.groupBox10.Size = new Size(241, 361);
      this.groupBox10.TabIndex = 2;
      this.groupBox10.TabStop = false;
      this.groupBox10.Text = "Import-Export setting";
      this.groupBox10.Enter += new EventHandler(this.groupBox10_Enter);
      this.button26.Location = new Point(15, 146);
      this.button26.Name = "button26";
      this.button26.Size = new Size(92, 27);
      this.button26.TabIndex = 6;
      this.button26.Text = "Export Setting";
      this.button26.UseVisualStyleBackColor = true;
      this.button26.Click += new EventHandler(this.button26_Click);
      this.button27.Location = new Point(130, 146);
      this.button27.Name = "button27";
      this.button27.Size = new Size(92, 27);
      this.button27.TabIndex = 7;
      this.button27.Text = "Import Setting";
      this.button27.UseVisualStyleBackColor = true;
      this.button27.Click += new EventHandler(this.button27_Click);
      this.button24.Location = new Point(15, 70);
      this.button24.Name = "button24";
      this.button24.Size = new Size(92, 27);
      this.button24.TabIndex = 4;
      this.button24.Text = "Export Offer";
      this.button24.UseVisualStyleBackColor = true;
      this.button24.Click += new EventHandler(this.button24_Click);
      this.button22.Location = new Point(15, 109);
      this.button22.Name = "button22";
      this.button22.Size = new Size(92, 27);
      this.button22.TabIndex = 2;
      this.button22.Text = "Export Vip";
      this.button22.UseVisualStyleBackColor = true;
      this.button22.Click += new EventHandler(this.button22_Click);
      this.button23.Location = new Point(130, 109);
      this.button23.Name = "button23";
      this.button23.Size = new Size(92, 27);
      this.button23.TabIndex = 3;
      this.button23.Text = "Import Vip";
      this.button23.UseVisualStyleBackColor = true;
      this.button23.Click += new EventHandler(this.button23_Click);
      this.button25.Location = new Point(130, 70);
      this.button25.Name = "button25";
      this.button25.Size = new Size(92, 27);
      this.button25.TabIndex = 5;
      this.button25.Text = "Import Offer";
      this.button25.UseVisualStyleBackColor = true;
      this.button25.Click += new EventHandler(this.button25_Click);
      this.button20.Location = new Point(15, 33);
      this.button20.Name = "button20";
      this.button20.Size = new Size(92, 27);
      this.button20.TabIndex = 0;
      this.button20.Text = "Export All Setting";
      this.button20.UseVisualStyleBackColor = true;
      this.button20.Click += new EventHandler(this.button20_Click);
      this.button21.Location = new Point(130, 33);
      this.button21.Name = "button21";
      this.button21.Size = new Size(92, 27);
      this.button21.TabIndex = 1;
      this.button21.Text = "Import All Setting";
      this.button21.UseVisualStyleBackColor = true;
      this.button21.Click += new EventHandler(this.button21_Click);
      this.button11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.button11.BackColor = Color.Red;
      this.button11.ForeColor = Color.Yellow;
      this.button11.Location = new Point(718, 47);
      this.button11.Margin = new Padding(1);
      this.button11.Name = "button11";
      this.button11.Size = new Size(114, 27);
      this.button11.TabIndex = 27;
      this.button11.Text = "Reboot iPhone";
      this.button11.UseVisualStyleBackColor = false;
      this.button11.Click += new EventHandler(this.button11_Click);
      this.button8.Location = new Point(266, 50);
      this.button8.Margin = new Padding(1);
      this.button8.Name = "button8";
      this.button8.Size = new Size(137, 27);
      this.button8.TabIndex = 12;
      this.button8.Text = "Backup data iPhone";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.button9.Location = new Point(419, 50);
      this.button9.Margin = new Padding(1);
      this.button9.Name = "button9";
      this.button9.Size = new Size(138, 27);
      this.button9.TabIndex = 13;
      this.button9.Text = "Restore data iPhone";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new EventHandler(this.button9_Click);
      this.gbDevice.Controls.Add((Control) this.button7);
      this.gbDevice.Controls.Add((Control) this.pnDeviceInfo);
      this.gbDevice.Controls.Add((Control) this.button6);
      this.gbDevice.Controls.Add((Control) this.ipcDeviceIP);
      this.gbDevice.Controls.Add((Control) this.btConnect);
      this.gbDevice.Controls.Add((Control) this.cbAutoReconnect);
      this.gbDevice.Controls.Add((Control) this.lbDeviceIP);
      this.gbDevice.Dock = DockStyle.Bottom;
      this.gbDevice.Location = new Point(0, 560);
      this.gbDevice.Margin = new Padding(1);
      this.gbDevice.Name = "gbDevice";
      this.gbDevice.Padding = new Padding(1);
      this.gbDevice.Size = new Size(842, 45);
      this.gbDevice.TabIndex = 2;
      this.gbDevice.TabStop = false;
      this.button7.Dock = DockStyle.Left;
      this.button7.Location = new Point(66, 14);
      this.button7.Margin = new Padding(1);
      this.button7.Name = "button7";
      this.button7.Size = new Size(67, 30);
      this.button7.TabIndex = 53;
      this.button7.Text = "Zoom in";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.pnDeviceInfo.Controls.Add((Control) this.btnDisconnect);
      this.pnDeviceInfo.Controls.Add((Control) this.lbLicensed);
      this.pnDeviceInfo.Controls.Add((Control) this.lbDeviceVersion);
      this.pnDeviceInfo.Controls.Add((Control) this.lbDeviceSN);
      this.pnDeviceInfo.Controls.Add((Control) this.lbModelName);
      this.pnDeviceInfo.Location = new Point(147, 11);
      this.pnDeviceInfo.Margin = new Padding(2);
      this.pnDeviceInfo.Name = "pnDeviceInfo";
      this.pnDeviceInfo.Size = new Size(477, 31);
      this.pnDeviceInfo.TabIndex = 7;
      this.pnDeviceInfo.Visible = false;
      this.btnDisconnect.Location = new Point(369, 1);
      this.btnDisconnect.Margin = new Padding(1);
      this.btnDisconnect.Name = "btnDisconnect";
      this.btnDisconnect.Size = new Size(68, 27);
      this.btnDisconnect.TabIndex = 11;
      this.btnDisconnect.Text = "Disconnect";
      this.btnDisconnect.UseVisualStyleBackColor = true;
      this.btnDisconnect.Click += new EventHandler(this.btnDisconnect_Click);
      this.lbLicensed.AutoSize = true;
      this.lbLicensed.Font = new Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbLicensed.ForeColor = Color.FromArgb(0, 192, 0);
      this.lbLicensed.Location = new Point(288, 8);
      this.lbLicensed.Margin = new Padding(2, 0, 2, 0);
      this.lbLicensed.Name = "lbLicensed";
      this.lbLicensed.Size = new Size(51, 13);
      this.lbLicensed.TabIndex = 10;
      this.lbLicensed.Text = "Licensed";
      this.lbDeviceVersion.AutoSize = true;
      this.lbDeviceVersion.Font = new Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbDeviceVersion.Location = new Point(232, 7);
      this.lbDeviceVersion.Margin = new Padding(2, 0, 2, 0);
      this.lbDeviceVersion.Name = "lbDeviceVersion";
      this.lbDeviceVersion.Size = new Size(52, 13);
      this.lbDeviceVersion.TabIndex = 9;
      this.lbDeviceVersion.Text = "iOS 9.3.3";
      this.lbDeviceSN.AutoSize = true;
      this.lbDeviceSN.Font = new Font("Segoe UI", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lbDeviceSN.ForeColor = Color.Maroon;
      this.lbDeviceSN.Location = new Point(143, 7);
      this.lbDeviceSN.Margin = new Padding(2, 0, 2, 0);
      this.lbDeviceSN.Name = "lbDeviceSN";
      this.lbDeviceSN.Size = new Size(79, 13);
      this.lbDeviceSN.TabIndex = 1;
      this.lbDeviceSN.Text = "123456789012";
      this.lbModelName.Font = new Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lbModelName.ForeColor = Color.Navy;
      this.lbModelName.Location = new Point(3, 7);
      this.lbModelName.Margin = new Padding(2, 0, 2, 0);
      this.lbModelName.Name = "lbModelName";
      this.lbModelName.Size = new Size(137, 13);
      this.lbModelName.TabIndex = 0;
      this.lbModelName.Text = "iPhone 6+(iPhone)";
      this.lbModelName.TextAlign = ContentAlignment.MiddleRight;
      this.button6.Dock = DockStyle.Left;
      this.button6.Location = new Point(1, 14);
      this.button6.Margin = new Padding(1);
      this.button6.Name = "button6";
      this.button6.Size = new Size(65, 30);
      this.button6.TabIndex = 51;
      this.button6.Text = "Zoom out";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.ipcDeviceIP.Font = new Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ipcDeviceIP.Location = new Point(459, 16);
      this.ipcDeviceIP.Margin = new Padding(2);
      this.ipcDeviceIP.Name = "ipcDeviceIP";
      this.ipcDeviceIP.Size = new Size(117, 22);
      this.ipcDeviceIP.TabIndex = 20;
      this.ipcDeviceIP.Text = "192.168.0.103";
      this.ipcDeviceIP.TextAlign = HorizontalAlignment.Center;
      this.ipcDeviceIP.TextChanged += new EventHandler(this.ipcDeviceIP_TextChanged);
      this.ipcDeviceIP.KeyDown += new KeyEventHandler(this.ipcDeviceIP_KeyDown);
      this.btConnect.Location = new Point(724, 11);
      this.btConnect.Margin = new Padding(1);
      this.btConnect.Name = "btConnect";
      this.btConnect.Size = new Size(68, 27);
      this.btConnect.TabIndex = 3;
      this.btConnect.Text = "Connect";
      this.btConnect.UseVisualStyleBackColor = true;
      this.btConnect.Click += new EventHandler(this.btConnect_Click);
      this.cbAutoReconnect.AutoSize = true;
      this.cbAutoReconnect.Location = new Point(627, 17);
      this.cbAutoReconnect.Margin = new Padding(1);
      this.cbAutoReconnect.Name = "cbAutoReconnect";
      this.cbAutoReconnect.Size = new Size(99, 17);
      this.cbAutoReconnect.TabIndex = 2;
      this.cbAutoReconnect.Text = "Auto reconnect";
      this.cbAutoReconnect.UseVisualStyleBackColor = true;
      this.lbDeviceIP.AutoSize = true;
      this.lbDeviceIP.Location = new Point(400, 18);
      this.lbDeviceIP.Margin = new Padding(1, 0, 1, 0);
      this.lbDeviceIP.Name = "lbDeviceIP";
      this.lbDeviceIP.Size = new Size(57, 13);
      this.lbDeviceIP.TabIndex = 0;
      this.lbDeviceIP.Text = "Device IP:";
      this.connectToDeviceWorker.DoWork += new DoWorkEventHandler(this.connectToDeviceWorker_DoWork);
      this.sshImport.DoWork += new DoWorkEventHandler(this.sshImport_DoWork);
      this.bwLead.DoWork += new DoWorkEventHandler(this.bwLead_DoWork);
      this.ssMain.ImageScalingSize = new Size(24, 24);
      this.ssMain.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.lbStatus
      });
      this.ssMain.Location = new Point(0, 605);
      this.ssMain.Name = "ssMain";
      this.ssMain.Padding = new Padding(1, 0, 9, 0);
      this.ssMain.Size = new Size(842, 22);
      this.ssMain.TabIndex = 3;
      this.ssMain.Text = "statusStrip1";
      this.ssMain.ItemClicked += new ToolStripItemClickedEventHandler(this.ssMain_ItemClicked);
      this.lbStatus.Name = "lbStatus";
      this.lbStatus.Size = new Size(0, 17);
      this.lbStatusCountDown.Interval = 1000;
      this.lbStatusCountDown.Tick += new EventHandler(this.lbStatusCountDown_Tick);
      this.bwRSS.DoWork += new DoWorkEventHandler(this.bwRSS_DoWork);
      this.changeIPTimer.Interval = 1000;
      this.changeIPTimer.Tick += new EventHandler(this.changeIPTimer_Tick);
      this.changeIPTimer2.Tick += new EventHandler(this.changeIPTimer2_Tick);
      this.bwRestoreRSS.DoWork += new DoWorkEventHandler(this.bwRestoreRSS_DoWork);
      this.timer1.Interval = 1000;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.timerConnectRealtime.Interval = 10000;
      this.timerConnectRealtime.Tick += new EventHandler(this.timerConnectRealtime_Tick);
      this.btApply.BackColor = Color.Green;
      this.btApply.ForeColor = Color.White;
      this.btApply.Location = new Point((int) byte.MaxValue, 13);
      this.btApply.Margin = new Padding(1);
      this.btApply.Name = "btApply";
      this.btApply.Size = new Size(68, 27);
      this.btApply.TabIndex = 4;
      this.btApply.Text = "Apply";
      this.btApply.UseVisualStyleBackColor = false;
      this.btApply.Click += new EventHandler(this.btApply_Click);
      this.cbTool.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbTool.FormattingEnabled = true;
      this.cbTool.Items.AddRange(new object[3]
      {
        (object) "SSH",
        (object) "Vip72",
        (object) "Direct"
      });
      this.cbTool.Location = new Point(58, 10);
      this.cbTool.Margin = new Padding(1);
      this.cbTool.Name = "cbTool";
      this.cbTool.Size = new Size(147, 21);
      this.cbTool.TabIndex = 5;
      this.cbTool.SelectedIndexChanged += new EventHandler(this.cbTool_SelectedIndexChanged);
      this.lbTool.AutoSize = true;
      this.lbTool.Location = new Point(10, 18);
      this.lbTool.Margin = new Padding(1, 0, 1, 0);
      this.lbTool.Name = "lbTool";
      this.lbTool.Size = new Size(31, 13);
      this.lbTool.TabIndex = 6;
      this.lbTool.Text = "Tool:";
      this.cbCountries.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbCountries.FormattingEnabled = true;
      this.cbCountries.Location = new Point(58, 40);
      this.cbCountries.Margin = new Padding(1);
      this.cbCountries.Name = "cbCountries";
      this.cbCountries.Size = new Size(147, 21);
      this.cbCountries.TabIndex = 7;
      this.cbCountries.SelectedIndexChanged += new EventHandler(this.cbCountries_SelectedIndexChanged);
      this.label2.AutoSize = true;
      this.label2.Location = new Point(10, 46);
      this.label2.Margin = new Padding(1, 0, 1, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(46, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Country:";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(10, 21);
      this.label3.Margin = new Padding(1, 0, 1, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(20, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "IP:";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(154, 21);
      this.label4.Margin = new Padding(1, 0, 1, 0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(29, 13);
      this.label4.TabIndex = 12;
      this.label4.Text = "Port:";
      this.btnChangeIP.BackColor = Color.Green;
      this.btnChangeIP.ForeColor = Color.White;
      this.btnChangeIP.Location = new Point(56, 69);
      this.btnChangeIP.Margin = new Padding(1);
      this.btnChangeIP.Name = "btnChangeIP";
      this.btnChangeIP.Size = new Size(149, 27);
      this.btnChangeIP.TabIndex = 13;
      this.btnChangeIP.Text = "Change IP";
      this.btnChangeIP.UseVisualStyleBackColor = false;
      this.btnChangeIP.Click += new EventHandler(this.btnChangeIP_Click);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(230, 76);
      this.label1.Margin = new Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(65, 13);
      this.label1.TabIndex = 15;
      this.label1.Text = "Selected IP:";
      this.lbSelectedIP.AutoSize = true;
      this.lbSelectedIP.ForeColor = Color.White;
      this.lbSelectedIP.Location = new Point(302, 76);
      this.lbSelectedIP.Margin = new Padding(2, 0, 2, 0);
      this.lbSelectedIP.Name = "lbSelectedIP";
      this.lbSelectedIP.Size = new Size(27, 13);
      this.lbSelectedIP.TabIndex = 16;
      this.lbSelectedIP.Text = "N/A";
      this.tbProxyURL.Enabled = false;
      this.tbProxyURL.Location = new Point(77, 49);
      this.tbProxyURL.Margin = new Padding(2);
      this.tbProxyURL.Name = "tbProxyURL";
      this.tbProxyURL.Size = new Size(246, 20);
      this.tbProxyURL.TabIndex = 17;
      this.tbProxyURL.Text = "http://192.168.0.110:12579/auto.pac";
      this.tbProxyURL.TextChanged += new EventHandler(this.tbProxyURL_TextChanged);
      this.label5.AutoSize = true;
      this.label5.Location = new Point(12, 52);
      this.label5.Margin = new Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new Size(61, 13);
      this.label5.TabIndex = 18;
      this.label5.Text = "Proxy URL:";
      this.ipcMyIP.Font = new Font("Segoe UI", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ipcMyIP.Location = new Point(35, 17);
      this.ipcMyIP.Margin = new Padding(2);
      this.ipcMyIP.Name = "ipcMyIP";
      this.ipcMyIP.Size = new Size(117, 22);
      this.ipcMyIP.TabIndex = 19;
      this.ipcMyIP.TextAlign = HorizontalAlignment.Center;
      this.ipcMyIP.TextChanged += new EventHandler(this.ipcMyIP_TextChanged);
      this.lbProxyStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.lbProxyStatus.AutoSize = true;
      this.lbProxyStatus.ForeColor = Color.Red;
      this.lbProxyStatus.Location = new Point(12, 83);
      this.lbProxyStatus.Margin = new Padding(2, 0, 2, 0);
      this.lbProxyStatus.Name = "lbProxyStatus";
      this.lbProxyStatus.Size = new Size(77, 13);
      this.lbProxyStatus.TabIndex = 20;
      this.lbProxyStatus.Text = "Not configured";
      this.txtexclusivevip72.AutoSize = true;
      this.txtexclusivevip72.Location = new Point(228, 14);
      this.txtexclusivevip72.Name = "txtexclusivevip72";
      this.txtexclusivevip72.Size = new Size(84, 17);
      this.txtexclusivevip72.TabIndex = 25;
      this.txtexclusivevip72.Text = "Vip72 Riêng";
      this.txtexclusivevip72.UseVisualStyleBackColor = true;
      this.txtexclusivevip72.CheckedChanged += new EventHandler(this.txtexclusivevip72_CheckedChanged);
      this.gbProxy.BackColor = SystemColors.Control;
      this.gbProxy.Controls.Add((Control) this.panel4);
      this.gbProxy.Controls.Add((Control) this.panel3);
      this.gbProxy.Dock = DockStyle.Bottom;
      this.gbProxy.Enabled = false;
      this.gbProxy.Location = new Point(0, 439);
      this.gbProxy.Margin = new Padding(1);
      this.gbProxy.Name = "gbProxy";
      this.gbProxy.Padding = new Padding(1);
      this.gbProxy.Size = new Size(842, 121);
      this.gbProxy.TabIndex = 1;
      this.gbProxy.TabStop = false;
      this.gbProxy.Text = "Proxy settings";
      this.gbProxy.Enter += new EventHandler(this.gbProxy_Enter);
      this.panel4.BackColor = Color.FromArgb(128, 64, 64);
      this.panel4.Controls.Add((Control) this.lbProxyStatus);
      this.panel4.Controls.Add((Control) this.nbportfake);
      this.panel4.Controls.Add((Control) this.label3);
      this.panel4.Controls.Add((Control) this.btApply);
      this.panel4.Controls.Add((Control) this.ipcMyIP);
      this.panel4.Controls.Add((Control) this.label4);
      this.panel4.Controls.Add((Control) this.label5);
      this.panel4.Controls.Add((Control) this.tbProxyURL);
      this.panel4.Dock = DockStyle.Right;
      this.panel4.Location = new Point(511, 14);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(330, 106);
      this.panel4.TabIndex = 52;
      this.nbportfake.Location = new Point(186, 18);
      this.nbportfake.Margin = new Padding(1);
      this.nbportfake.Maximum = new Decimal(new int[4]
      {
        65000,
        0,
        0,
        0
      });
      this.nbportfake.Minimum = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.nbportfake.Name = "nbportfake";
      this.nbportfake.Size = new Size(53, 20);
      this.nbportfake.TabIndex = 47;
      this.nbportfake.Value = new Decimal(new int[4]
      {
        10101,
        0,
        0,
        0
      });
      this.nbportfake.ValueChanged += new EventHandler(this.nbportfake_ValueChanged);
      this.panel3.BackColor = Color.FromArgb(128, 64, 64);
      this.panel3.Controls.Add((Control) this.cboregion);
      this.panel3.Controls.Add((Control) this.chkPortRd);
      this.panel3.Controls.Add((Control) this.cbocity);
      this.panel3.Controls.Add((Control) this.txtexclusivevip72);
      this.panel3.Controls.Add((Control) this.lbSelectedIP);
      this.panel3.Controls.Add((Control) this.label1);
      this.panel3.Controls.Add((Control) this.btnChangeIP);
      this.panel3.Controls.Add((Control) this.cbTool);
      this.panel3.Controls.Add((Control) this.label2);
      this.panel3.Controls.Add((Control) this.cbCountries);
      this.panel3.Controls.Add((Control) this.lbTool);
      this.panel3.Dock = DockStyle.Left;
      this.panel3.Location = new Point(1, 14);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(505, 106);
      this.panel3.TabIndex = 51;
      this.cboregion.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboregion.FormattingEnabled = true;
      this.cboregion.Location = new Point(228, 43);
      this.cboregion.Margin = new Padding(1);
      this.cboregion.Name = "cboregion";
      this.cboregion.Size = new Size(132, 21);
      this.cboregion.TabIndex = 50;
      this.cboregion.SelectedIndexChanged += new EventHandler(this.cboregion_SelectedIndexChanged);
      this.chkPortRd.AutoSize = true;
      this.chkPortRd.Location = new Point(320, 12);
      this.chkPortRd.Name = "chkPortRd";
      this.chkPortRd.Size = new Size(88, 17);
      this.chkPortRd.TabIndex = 48;
      this.chkPortRd.Text = "Port Random";
      this.chkPortRd.UseVisualStyleBackColor = true;
      this.chkPortRd.CheckedChanged += new EventHandler(this.chkPortRd_CheckedChanged);
      this.cbocity.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cbocity.FormattingEnabled = true;
      this.cbocity.Location = new Point(372, 43);
      this.cbocity.Margin = new Padding(1);
      this.cbocity.Name = "cbocity";
      this.cbocity.Size = new Size(125, 21);
      this.cbocity.TabIndex = 49;
      this.cbocity.SelectedIndexChanged += new EventHandler(this.cbocity_SelectedIndexChanged);
      this.cbiOS11.AutoSize = true;
      this.cbiOS11.Location = new Point(343, 18);
      this.cbiOS11.Margin = new Padding(2);
      this.cbiOS11.Name = "cbiOS11";
      this.cbiOS11.Size = new Size(58, 17);
      this.cbiOS11.TabIndex = 35;
      this.cbiOS11.Text = "iOS 11";
      this.cbiOS11.UseVisualStyleBackColor = true;
      this.cbiOS11.CheckedChanged += new EventHandler(this.cbiOS11_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(842, 627);
      this.Controls.Add((Control) this.tcMain);
      this.Controls.Add((Control) this.gbProxy);
      this.Controls.Add((Control) this.gbDevice);
      this.Controls.Add((Control) this.ssMain);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Margin = new Padding(1);
      this.MaximizeBox = false;
      this.Name = nameof (frmMain);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "AutoLead Helper v2.8";
      this.MinimumSizeChanged += new EventHandler(this.frmMain_MinimumSizeChanged);
      this.FormClosing += new FormClosingEventHandler(this.frmMain_FormClosing);
      this.FormClosed += new FormClosedEventHandler(this.frmMain_FormClosed);
      this.Load += new EventHandler(this.frmMain_Load);
      this.Resize += new EventHandler(this.frmMain_Resize);
      this.tcMain.ResumeLayout(false);
      this.tpAutoLead.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel1.PerformLayout();
      this.splitContainer2.Panel2.ResumeLayout(false);
      this.splitContainer2.Panel2.PerformLayout();
      this.splitContainer2.EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.gbStart.ResumeLayout(false);
      this.gbStart.PerformLayout();
      this.num_sleepBfurl.EndInit();
      this.timeloadAppstrore.EndInit();
      this.cboptbackup.EndInit();
      this.nmAppStoreXy.EndInit();
      this.nmSafariXy.EndInit();
      this.numSSHWait.EndInit();
      this.numURLLoadTime.EndInit();
      this.numRunLimit.EndInit();
      this.tpProxy.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.numSSHtimeout.EndInit();
      this.numThreadCount.EndInit();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.tpRSS.ResumeLayout(false);
      this.tpRSS.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.numericUpDown1.EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.numSSHWaitTimeRRS.EndInit();
      this.numWaitTime.EndInit();
      this.tpSupport.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.gbScript.ResumeLayout(false);
      this.gbScript.PerformLayout();
      this.groupBox9.ResumeLayout(false);
      this.groupBox9.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.tpSettings.ResumeLayout(false);
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.numloopip.EndInit();
      this.numLoadagainUrl.EndInit();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.gbFD.ResumeLayout(false);
      this.gbFD.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.tpContact.ResumeLayout(false);
      this.groupBox8.ResumeLayout(false);
      this.groupBox8.PerformLayout();
      this.groupBox7.ResumeLayout(false);
      this.tprrsmanager.ResumeLayout(false);
      this.tprrsmanager.PerformLayout();
      this.tpExIm.ResumeLayout(false);
      this.tpExIm.PerformLayout();
      this.groupBox10.ResumeLayout(false);
      this.gbDevice.ResumeLayout(false);
      this.gbDevice.PerformLayout();
      this.pnDeviceInfo.ResumeLayout(false);
      this.pnDeviceInfo.PerformLayout();
      this.ssMain.ResumeLayout(false);
      this.ssMain.PerformLayout();
      this.gbProxy.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.nbportfake.EndInit();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
