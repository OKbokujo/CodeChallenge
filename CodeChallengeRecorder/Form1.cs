using CodeChallengeRecorder.Models;
using CodeChallengeRecorder.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChallengeRecorder
{
   
    public partial class Form1 : Form
    {
        FileManager Files = new FileManager();
        ListConverter ListConverter = new ListConverter();
        Timer timer = new Timer();
        List<Problems> SearchListProblems = new List<Problems>();
        List<Solutions> SearchListSolutions = new List<Solutions>();
        List<Languages> Languages;
        List<Problems> Problems;
        List<Problems> CurrentProblems;
        List<Solutions> Solutions;
        List<Solutions> CurrentSolutions;
        List<Method> CurrentMethods;
        List<Method> Methods;
        string SelectedLanguage = "";
        int? SelectedLanguageID = null;
        Problems SelectedProblem = new Problems();
        int? SelectedProblemID = null;
        Solutions SelectedSolution = new Solutions();
        int? SelectedSolutionID = null;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        async Task LoadData()
        {
            try
            {
                List<object> LanguagesList = await Files.GetEntries("languages");
                List<object> ProblemsList = await Files.GetEntries("problems");
                List<object> SolutionsList = await Files.GetEntries("solutions");
                List<object> MethodsList = await Files.GetEntries("methods");
                Languages = await ListConverter.ObjectToLanguagesList(LanguagesList);
                Problems = await ListConverter.ObjectToProblemsList(ProblemsList);
                Solutions = await ListConverter.ObjectToSolutionsList(SolutionsList);
                Methods = await ListConverter.ObjectToMethodsList(MethodsList);
                foreach(var x in Languages)
                {
                    listBox1.Items.Add(x.Title);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
           
        }
       

        
        async Task Delete(int? key, string type)
        {
            try
            {
                List<int?> LangChildrenkeys = new List<int?>();
                List<int?> ProbChildrenKeys = new List<int?>();
                if (type == "languages")
                {
                    
                    for(int i = 0; i < Problems.Count; i ++)
                    {
                        if(Problems[i].ParentID == key)
                        {
                            LangChildrenkeys.Add(Problems[i].Id);
                        }
                    }
                    for(int i = 0; i < Solutions.Count; i ++)
                    {
                        for(int x = 0; x < LangChildrenkeys.Count; x++)
                        {
                            if(Solutions[i].ParentID == LangChildrenkeys[x])
                            {
                                ProbChildrenKeys.Add(Solutions[i].Id);
                                break;
                            }
                        }
                    }

                    foreach(var x in LangChildrenkeys)
                    {
                        await Files.DeleteObjects(x, "problems");

                    }
                    foreach(var x in ProbChildrenKeys)
                    {
                        await Files.DeleteObjects(x, "solutions");

                    }
                    await DeleteMethodSolutions(ProbChildrenKeys);
                    await Files.DeleteObjects(key,"languages");
                }
                else if (type == "problems")
                {
                    
                    for (int i = 0; i < Solutions.Count; i++)
                    {
                        
                            if (Solutions[i].ParentID == key)
                            {
                                ProbChildrenKeys.Add(Solutions[i].Id);
                                
                            }
                        
                    }
                    
                    await Files.DeleteObjects(key, "problems");
                    foreach (var x in ProbChildrenKeys)
                    {
                        await Files.DeleteObjects(x, "solutions");
                    }
                    await DeleteMethodSolutions(ProbChildrenKeys);
                }
                else
                {
                    await Files.DeleteObjects(key, type);
                    await DeleteMethodSolutions(new List<int?> { key });
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        void ResetItems()
        {
            WebURLinput.Text = "";
            WebURLinput.Visible = false;
            Title.Text = "";
            URL.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            Title.Visible = false;


        }
        private void AddLanguage_clicked(object sender, EventArgs e)
        {
            string txtbox = textBox1.Text;
            bool Exists = listBox1.Items.Contains(txtbox);
            if (txtbox != "" && !txtbox.Contains(" ") && !Exists)
            {
                listBox1.Items.Add(txtbox);
                Languages l = new Languages() { Title = txtbox };
                Languages.Add(l);
                Files.AddUpdate(l, "languages");
               
            }
            textBox1.Text = "";
        }
        private void AddMethods_Click(object sender, EventArgs e)
        {

            foreach (Languages x in Languages)
            {
                List<Solutions> LanguageSolutions = new List<Solutions>();
                Dictionary<string, List<int?>> titles = new Dictionary<string, List<int?>>();
                foreach (Problems z in Problems)
                {
                    if (z.ParentID == x.Id)
                    {
                        foreach (Solutions l in Solutions)
                        {
                            if (z.Id == l.ParentID)
                            {
                                LanguageSolutions.Add(l);
                            }
                        }
                    }
                }


                foreach (var z in LanguageSolutions)
                {
                    foreach (Match match in Regex.Matches(z.Solution, @"(?<=[a-zA-Z\s)])\.[a-zA-Z_?]+"))
                    {
                        if (match.Length > 2)
                        {
                            string title = match.Value.Substring(match.Value.IndexOf('.'));
                            try
                            {
                                if (!titles[title].Contains(z.Id))
                                {
                                    titles[title].Add(z.Id);
                                }
                            }
                            catch
                            {

                                titles.Add(title, new List<int?> { z.Id });

                            }
                        }

                    }

                }
                foreach (var methods in titles)
                {
                    Method method = new Method
                    {
                        ParentID = x.Id,
                        Title = methods.Key,
                        SolutionsID = JsonConvert.SerializeObject(methods.Value)
                    };
                  
                    Files.AddUpdate(method, "methods");
                }

            }
        }
        private void AddProblem_clicked(object sender, EventArgs e)
        {
            
            if (AddProblems.Text == "Add")
            {
                richTextBox1.Text = "";
                richTextBox1.ReadOnly = false;
                AddProblems.Text = "save";
                label6.Visible = true;
                Title.Visible = true;
                WebURLinput.Visible = true;
                URL.Visible = false;
            }
            else
            {
                if (Title.Text != "" && richTextBox1.Text != "" && WebURLinput.Text != "")
                {
                    Problems problems = new Problems()
                    {
                        ParentID = (Int32)SelectedLanguageID,
                        Problem = richTextBox1.Text,
                        Title = Title.Text,
                        WebAddress = WebURLinput.Text,
                        DateTime =  DateTime.Now

                    };
                    Problems.Add(problems);
                    listBox2.Items.Insert(0,problems.DateTime.Date.ToShortDateString());
                    CurrentProblems.Insert(0,problems);
                    Files.AddUpdate(problems, "problems");
                }
                
                AddProblems.Text = "Add";
                ResetItems();
                richTextBox1.ReadOnly = true;

            }
            
            
        }

        private void AddSolution_Clicked(object sender, EventArgs e)
        {
            if (AddSolutions.Text == "Add")
            {
                richTextBox2.ReadOnly = false;
                AddSolutions.Text = "Save";
            }
            else
            {
                if(richTextBox2.Text != "" && SolutionTitle.Text != "")
                {
                    Solutions solution = new Solutions()
                    {
                        ParentID = SelectedProblemID,
                        Title = SolutionTitle.Text,
                        Solution = richTextBox2.Text, 
                    };
                    Solutions.Add(solution);
                    listBox3.Items.Add(solution.Title);
                    CurrentSolutions.Add(solution);
                    Files.AddUpdate(solution, "solutions");
                 //Below code can be greatly improved for speed.
                    foreach (Match m in Regex.Matches(richTextBox2.Text, @"(?<=[a-zA-Z0-9\s)])\.[a-zA-Z_?]+"))
                    {
                        
                        string meow = m.Value.Substring(m.Value.IndexOf('.'));
                        if (meow.Length > 2)
                        {
                            int? solutionID = Solutions.Last().Id;

                            while(solutionID == null)
                            {
                                solutionID = Solutions.Last().Id;
                            }

                            for (int x = 0; x < Methods.Count-1; x++)
                            {
                                if(Methods[x].Title == meow && Methods[x].ParentID == SelectedLanguageID)
                                {
                                    List<int?> numbers = JsonConvert.DeserializeObject<List<int?>>(Methods[x].SolutionsID);
                                    if(numbers.Contains(solutionID))
                                    {
                                        break;
                                    }
                                    numbers.Add(solutionID);
                                    Methods[x].SolutionsID = JsonConvert.SerializeObject(numbers);
                                    Files.AddUpdate(Methods[x], "methods");
                                    break;
                                    
                                }
                                else if(x == Methods.Count -2 && Methods.Last().Title !=  meow)
                                {
                                    Method method = new Method
                                    {
                                        Id = Methods.Count,
                                        ParentID = SelectedLanguageID,
                                        Title = meow,
                                        SolutionsID = "[" + solutionID.ToString() + "]"
                                    };
                                   
                                    Files.AddUpdate(method, "methods");
                                    Methods.Add(method);
                                    CurrentMethods.Add(method);
                                    
                                    break;
                                }
                            }
                        }
                    }
                    
                }
                SolutionTitle.Text = "";
                richTextBox2.Text = "";
                AddSolutions.Text = "Add";
                richTextBox2.ReadOnly = true;
            }

            
               

            

        }
        private void Problemsbox_Clicked(object sender, EventArgs e)
        {
            if (SolutionsBox.Checked)
            {
                SolutionsBox.Checked = false;
            }
        }
        private void SolutionsBox_Clicked(object sender, EventArgs e)
        {
            if (Problemsbox.Checked)
            {
                Problemsbox.Checked = false;
            }
        }

        private void LanguageChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                
                SelectedLanguage= Regex.Match(listBox1.SelectedItem.ToString(), @"\w+").Value;
                SelectedLanguageID = Languages[listBox1.SelectedIndex].Id;
                CurrentProblems = new List<Problems>();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                ResetItems();
                for(int i = Problems.Count-1; i > -1; i --)
                {
                    if(Problems[i].ParentID == SelectedLanguageID)
                    {
                        listBox2.Items.Add(Problems[i].DateTime.ToShortDateString());
                        CurrentProblems.Add(Problems[i]);
                    }
                }
                CurrentMethods = new List<Method>();
                LanguageMethods.Items.Clear();
                List<string> titles = new List<string>();
                foreach(var x in Methods)
                {
                    if(x.ParentID == SelectedLanguageID)
                    {
                        CurrentMethods.Add(x);
                        titles.Add(x.Title);
                    }
                }
                titles.Sort();
                foreach(var x in titles)
                {
                    LanguageMethods.Items.Add(x);
                }
               
            }
            else
            {
                listBox2.Items.Clear();
                SelectedLanguage = "";
            }

        }
        private void LanguageMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentSolutions = new List<Solutions>();
            string convert = "";
            foreach (var x in CurrentMethods)
            {
                if ( x.Title == LanguageMethods.SelectedItem.ToString())
                {
                    convert = x.SolutionsID;
                    break;
                }
            }

            string fuck = CurrentMethods[0].SolutionsID;
            List<int?> solutions = JsonConvert.DeserializeObject<List<int?>>(convert);
            foreach (var x in solutions)
            {
                foreach (var l in Solutions)
                {
                    if (l.Id == x)
                    {
                        CurrentSolutions.Add(l);
                    }
                }
            }
            listBox3.Items.Clear();
            foreach (var x in CurrentSolutions)
            {
                listBox3.Items.Add(x.Title);
            }
            listBox3.SelectedItem = listBox3.Items[0];
        }
        private void ProblemChanged(object sender, EventArgs e)
        {
            if(listBox2.SelectedItem != null)
            {
              
                SelectedProblem = CurrentProblems[listBox2.SelectedIndex];
                SelectedProblemID = SelectedProblem.Id;

                LoadSolutions(SelectedProblemID);
           
                Title.Visible = true;
                URL.Visible = true;
                richTextBox1.Text = SelectedProblem.Problem;
                URL.Text = SelectedProblem.WebAddress;
                Title.Text = SelectedProblem.Title;
                richTextBox2.Text = "";

            }
            if (listBox3.Items.Count > 0)
            {
                listBox3.SelectedItem = listBox3.Items[0];
            }
        }
        void SearchItemChanged(object sender, EventArgs e)
        {
            if(SearchResults.SelectedItem != null)
            {
                
                if (Problemsbox.Checked)
                {
                    var item = SearchListProblems[SearchResults.SelectedIndex];
                    Title.Visible = true;
                    Title.Text = item.Title;
                    richTextBox1.Text = item.Problem;
                    URL.Text = item.WebAddress;
                    LoadSolutions(item.Id);


                }
                else
                {
                   var item = SearchListSolutions[ SearchResults.SelectedIndex];
                    richTextBox2.Text = item.Solution;
                    Problems p = new Problems();
                    for(int x = 0; x < Problems.Count-1; x ++)
                    {
                        if(Problems[x].Id == item.ParentID)
                        {
                            p = Problems[x];
                            break;
                        }
                    }
                    Title.Visible = true;
                    Title.Text = p.Title;
                    richTextBox1.Text = p.Problem;
                    URL.Text = p.WebAddress;
                }
            }
        }
        private void SolutionChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem != null)
            {
                SelectedSolution = CurrentSolutions[listBox3.SelectedIndex];
                SelectedSolutionID = SelectedSolution.Id;
                richTextBox2.Text = SelectedSolution.Solution;
                
                Problems TheProblem = new Problems();
                for(int i = 0; i < CurrentProblems.Count; i ++)
                {
                    if(CurrentProblems[i].Id == (int)SelectedSolution.ParentID)
                    {
                        TheProblem = CurrentProblems[i];
                        break;
                    }
                }

                richTextBox1.Text = TheProblem.Problem;
                URL.Text = TheProblem.WebAddress;
                Title.Text = TheProblem.Title;
            }
            else
            {
                richTextBox2.Text = "";
            }

           
        }

        private void DeleteLanguage_clicked(object sender, EventArgs e)
        {

            if (SelectedLanguage != "")
            {
                Delete(SelectedLanguageID, "languages");
                Languages.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                ResetItems();
            }
        }
        private void DeleteProblem_Clicked(object sender, EventArgs e)
        {
            if (SelectedLanguage != "")
            {
                Delete(SelectedProblemID, "problems");
                CurrentProblems.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.Remove(listBox2.SelectedItem);
                Problems.Remove(SelectedProblem);
                listBox3.Items.Clear();
                ResetItems();
            }
        }
        private void DeleteSolution_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (SelectedSolution != null && SelectedProblem != null)
                {
                    Delete(SelectedSolutionID, "solutions");
                    CurrentSolutions.RemoveAt(listBox3.SelectedIndex);
                    Solutions.Remove(SelectedSolution);
                    listBox3.Items.Remove(listBox3.SelectedItem);
                }
            }
            catch(Exception m)
            {
                MessageBox.Show(m.ToString());
            }
        }
      
        private void URL_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", URL.Text);
            }
            catch(Exception m)
            {
                MessageBox.Show(m.ToString());
            }
        }

        private void SearchBoxFocus(object sender, EventArgs e)
        {
            SearchResults.Items.Clear();
            SearchListProblems.Clear();
            SearchListSolutions.Clear();
            string search = SearchBox.Text;
            if (Problemsbox.Checked && search != "")
            {
                
                foreach(var x in Problems)
                {
                    if(x.Problem.Contains(search) || x.Title.Contains(search))
                    {
                        SearchListProblems.Add(x);
                        SearchResults.Items.Add(x.Title);
                    }
                }
            }
            else if(SolutionsBox.Checked && search != "")
            {

                foreach (var x in Solutions)
                {
                    if (x.Solution.Contains(search))
                    {
                        SearchListSolutions.Add(x);
                        SearchResults.Items.Add(x.Title);
                    }
                }
            }
            else
            {

            }

        }

        void LoadSolutions(int? parentID)
        {
            CurrentSolutions = new List<Solutions>();
            listBox3.Items.Clear();
            if (Solutions.Count > 0)
            {
                for (int i = 0; i < Solutions.Count; i++)
                {
                    if (Solutions[i].ParentID == parentID)
                    {
                        listBox3.Items.Add(Solutions[i].Title);
                        CurrentSolutions.Add(Solutions[i]);
                    }
                }
            }
        }
       

        async Task DeleteMethodSolutions(List<int?> Id)
        {   //an error is thrown when a solution generated from the method list is deleted.
     
            try
            {
                foreach (var y in Methods)
                {
                    bool added = false;
                    List<int?> Ids = JsonConvert.DeserializeObject<List<int?>>(y.SolutionsID);
                    foreach (var x in Id)
                    {

                        if (Ids.Count > 1)
                        {
                            if (Ids.Contains(x))
                            {
                                Ids.Remove(x);
                                added = true;
                            }
                        }
                        else
                        {
                            if (Ids.Contains(x))
                            {
                                Files.DeleteObjects(y.Id, "methods");
                                Methods.Remove(y);
                            }
                        }
                    }
                    if (added)
                    {
                        y.SolutionsID = JsonConvert.SerializeObject(Ids);
                        Files.AddUpdate(y, "methods");
                    }
                }
            }
            catch
            {

            }

        }

      
    }
}

