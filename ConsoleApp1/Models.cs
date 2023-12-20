using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public class Value
    {
        public string odataetag { get; set; }
        public string _modifiedby_value { get; set; }
        public string description { get; set; }
        public int featuremask { get; set; }
        public DateTime createdon { get; set; }
        public string _createdby_value { get; set; }
        public string subjectid { get; set; }
        public int versionnumber { get; set; }
        public DateTime modifiedon { get; set; }
        public string _organizationid_value { get; set; }
        public string title { get; set; }
        public object importsequencenumber { get; set; }
        public object _createdbyexternalparty_value { get; set; }
        public object _modifiedbyexternalparty_value { get; set; }
        public string _parentsubject_value { get; set; }
        public object _createdonbehalfby_value { get; set; }
        public object _modifiedonbehalfby_value { get; set; }
        public object overriddencreatedon { get; set; }
    }

    internal class Algorithm
    {
        public Value[] value { get; set; }
        public void PrintTree()
        {
            if (value != null)
            {
                PrintTreeRecursive(null, 0);
            }
        }

        private void PrintTreeRecursive(string parentId, int level)
        {
            foreach (var item in value)
            {
                if (item._parentsubject_value == parentId)
                {
                    Console.WriteLine(new string('-', level * 4) + "subjectId: " + item.subjectid);
                    Console.WriteLine(new string('-', level * 4) + "title: " + item.title);

                    PrintTreeRecursive(item.subjectid, level + 1);
                }
            }
        }
    }
}
