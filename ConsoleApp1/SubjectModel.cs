using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SubjectModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<SubjectModel> Children { get; set; }

        /*public SubjectModel[] ConvertToSubjectArray(string id, string title)
        {
            var subjects = new List<SubjectModel>();

            SubjectModel subject1 = new SubjectModel
            {
                Children = new List<SubjectModel>
                {
                    new SubjectModel { Id = id, Title = title }
                }
            };

            subjects.Add(subject1);

            return subjects.ToArray();
        }*/
    }
}
