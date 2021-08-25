using CodeChallengeRecorder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChallengeRecorder.Services
{
    public class ListConverter
    {
        public async Task<List<Languages>> ObjectToLanguagesList(List<object> item)
        {
            List<Languages> NewItem = new List<Languages>();
            foreach(var x in item)
            {
                NewItem.Add((Languages)x);
            }
            return NewItem;
        }
        public async Task<List<Problems>> ObjectToProblemsList(List<object> item)
        {
            List<Problems> NewItem = new List<Problems>();
            foreach (var x in item)
            {
                NewItem.Add((Problems)x);
            }
            return NewItem;
        }
        public async Task<List<Solutions>> ObjectToSolutionsList(List<object> item)
        {
            List<Solutions> NewItem = new List<Solutions>();
            foreach (var x in item)
            {
                NewItem.Add((Solutions)x);
            }
            return NewItem;
        }
        public async Task<List<Method>> ObjectToMethodsList(List<object> item)
        {
            List<Method> NewItem = new List<Method>();
            foreach (var x in item)
            {
                NewItem.Add((Method)x);
            }
            return NewItem;
        }

    }
}
