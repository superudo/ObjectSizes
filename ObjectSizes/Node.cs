using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Text.RegularExpressions;

namespace ObjectSizes
{
    public class Node
    {
        private string _name;
        private long _size;
        private int _objID = -1;
        private List<Node> _nodes = new List<Node>();

        public Node(XmlElement el)
        {
            _name = el.Name;
            _size = Regex.Replace(el.InnerXml, " xmlns=\"[^\"]*\"", "", RegexOptions.None).Length;
        }

        public Node(string name, long size)
        {
            _name = name;
            _size = size;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            private set { }
        }

        public long Size { get { return _size; } private set { } }
        public int ObjID { get { return _objID; } set { _objID = value; } }
        public List<Node> Nodes { get { return _nodes; } private set { } }
    }
}
