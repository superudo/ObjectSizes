using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using BrightIdeasSoftware;
using System.Globalization;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;

namespace ObjectSizes
{
    public partial class MainForm : Form
    {
        private long fileSize = 0;
        private bool alreadyFocused = false;

        public event EventHandler UseMinSizeChanged;
        public virtual void OnUseMinSizeChanged(EventArgs a)
        {
            EventHandler handler = UseMinSizeChanged;
            if (handler != null)
            {
                handler(this, a);
            }
        }

        private bool useMinSize;
        public bool UseMinSize
        {
            get
            {
                return useMinSize;
            }
            set
            {
                if (value != useMinSize)
                {
                    useMinSize = value;
                    OnUseMinSizeChanged(new EventArgs());
                }
            }
        }

        public event EventHandler MinSizeChanged;
        public virtual void OnMinSizeChanged(EventArgs a)
        {
            EventHandler handler = MinSizeChanged;
            if (handler != null)
            {
                handler(this, a);
            }
        }

        private long minSize;
        public long MinSize
        {
            get
            {
                return minSize;
            }
            set
            {
                if (value != minSize)
                {
                    minSize = value;
                    OnMinSizeChanged(new EventArgs());
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            tbFile.AutoEllipsis = AutoEllipsis.EllipsisFormat.Middle | AutoEllipsis.EllipsisFormat.Path;
            tlvNodes.CanExpandGetter = delegate(object x)
            {
                Node node = x as Node;
                return (node.Nodes.Count > 0);
            };

            tlvNodes.ChildrenGetter = delegate(object x)
            {
                Node node = x as Node;
                return node.Nodes;
            };

            olvObjId.AspectToStringConverter = delegate(object x)
            {
                int objID = (int)x;
                return (objID < 0) ? "" : objID.ToString();
            };

            olvSize.AspectToStringConverter = delegate(object x)
            {
                long size = (long)x;
                string fmt = "N0";

                if (UseMinSize && (size < MinSize))
                {
                    return "";
                }

                if (rbKBytes.Checked)
                {
                    size /= 1024;
                    fmt = "N1";
                }

                if (rbMBytes.Checked)
                {
                    size /= 1024 * 1024;
                    fmt = "N1";
                }
                return size.ToString(fmt, CultureInfo.CreateSpecificCulture("de-DE"));
            };

            MinSize = 1000;
            UseMinSize = true;

            form1BindingSource.Add(this);

            UseMinSizeChanged += new EventHandler(Form1_UseMinSizeChanged);
            MinSizeChanged  += new EventHandler(Form1_UseMinSizeChanged);

            numMinSizeToShow.GotFocus += new EventHandler(numMinSizeToShow_GotFocus);
            numMinSizeToShow.MouseUp += new MouseEventHandler(numMinSizeToShow_MouseUp);
            numMinSizeToShow.Leave += new EventHandler(numMinSizeToShow_Leave);

            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Visible = false;

            object[] result = e.Result as object[];
            string filePath = result[0] as string;

            if (result[1] is string) // Error!
            {
                return;
            }

            tbFile.Text = filePath;

            Node rootNode = (result[1] as Node);
            fileSize = (int)new FileInfo(filePath).Length;
            long wastedSpace = fileSize - rootNode.Size;

            barRenderer1.MinimumValue = 0;
            barRenderer1.MaximumValue = fileSize; // Math.Max((result[1] as Node).Size, wastedSpace);

            List<Node> roots = new List<Node>();
            roots.Add(rootNode);
            roots.Add(new Node("Whitespace", wastedSpace));

            tlvNodes.Roots = roots;
        }

        void Form1_UseMinSizeChanged(object sender, EventArgs e)
        {
            tlvNodes.Invalidate();
        }

        private void bnSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;
            dlg.Filter = "arcplan Documents (*.apd;*.apl)|*.apd;*.apd|XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadAndAnalyzeFile(dlg.FileName);
            }
        }

        private void LoadAndAnalyzeFile(string filePath)
        {
            progressBar1.Visible = true;
            tlvNodes.Roots = null;

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync(filePath);
            }
        }

        private void rbBytes_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            olvSize.Text = "Size (" + rb.Text + ")";
            tlvNodes.Invalidate();
        }

        private void numMinSizeToShow_Leave(object sender, EventArgs e)
        {
            alreadyFocused = false;
            MinSize = Convert.ToInt32(numMinSizeToShow.Text.Replace(".", ""));
        }

        void numMinSizeToShow_MouseUp(object sender, MouseEventArgs e)
        {
            if (!alreadyFocused && (numMinSizeToShow.SelectionLength == 0))
            {
                alreadyFocused = true;
                numMinSizeToShow.SelectAll();
            }
        }

        void numMinSizeToShow_GotFocus(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.None)
            {
                numMinSizeToShow.SelectAll();
                alreadyFocused = true;
            }
        }

        private void numMinSizeToShow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tlvNodes.Focus();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(filePath);
            }
            catch (XmlException ex)
            {
                e.Result = new object[] { filePath, ex.Message };
                return;
            }

            Node rootNode = BuildNodeList(doc.DocumentElement);
            e.Result = new object[] { filePath, rootNode };
        }

        private Node BuildNodeList(XmlElement xmlElement)
        {
            Node subRoot = new Node(xmlElement);
            if (xmlElement.Attributes["ObjID"] != null)
            {
                string val = xmlElement.Attributes["ObjID"].Value;
                subRoot.ObjID = Convert.ToInt32(val);
            }

            foreach (XmlNode n in xmlElement.ChildNodes)
            {
                if (n.NodeType == XmlNodeType.Element)
                {
                    Node subTree = BuildNodeList(n as XmlElement);
                    subRoot.Nodes.Add(subTree);
                }
            }
            return subRoot;
        }

    }
}
