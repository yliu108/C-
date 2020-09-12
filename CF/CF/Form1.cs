using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime;
namespace CF
{
    public partial class Form1 : Form
    {
        string temp;
        List<KeyValuePair<String, bool>> Search=new List<KeyValuePair<string, bool>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var slist = new List<string>();
            var ofd = new OpenFileDialog();
            var file = "";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(ofd.FileName);
                    file = sr.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                //var
                temp = file;
               
               
               
                char[] a = file.ToCharArray();
                var b = a.ToList();
                b = b.Where(x => (x >= 64&&x<=90) ||(x>=97&&x<=122)).ToList();
                var c = a.Where(x => char.IsPunctuation(x));
                b.Sort();
                Dictionary<char, int> Dic = new Dictionary<char, int>();
                Dictionary<char, int> Dic2 = new Dictionary<char, int>();
                Dictionary<string, int> Dic3 = new Dictionary<string, int>();
                var a3 = temp.Split(' ', '\r', '\n').ToList();
                var a3T = new List<string>(a3);
                foreach (string x in a3)
                {
                    if (x.Any(y => !((y >= 64 && y <= 90) || (y >= 97 && y <= 122))) || x.Count() == 0)
                        a3T.Remove(x);

                }
                foreach (string x in a3T)
                {
                    if (!Dic3.Keys.Contains(x))
                        Dic3.Add(x, 1);
                    else
                        Dic3[x] += 1;

                }
                List<KeyValuePair<string, int>> List3 = Dic3.ToList();
                List3.Sort((x, y) => x.Key.CompareTo(y.Key));
                for (int i = 0; i < List3.Count; ++i)
                {
                        Console.WriteLine(List3[i]);
                }
                


                foreach (char x in b)
                {
                    if (!Dic.Keys.Contains(x))
                        Dic.Add(x, 1);
                    else
                        Dic[x] += 1;
                }
                foreach(char x in c)
                {
                    if (!Dic2.Keys.Contains(x))
                        Dic2.Add(x, 1);
                    else
                        Dic2[x] += 1;
                }
               
               
                
                List<KeyValuePair<char, int>> List1 = Dic.ToList();
                List<KeyValuePair<char, int>> List2 = Dic2.ToList();
                List2.Sort((x, y) => x.Value.CompareTo(y.Value));
                for(int i=0;i<List1.Count;++i)
                {
                    Console.Write(List1[i]+" ");
                }
                Console.WriteLine();
                for (int i = 0; i < List2.Count; ++i)
                {
                    Console.Write(List2[i] + " ");
                }
                Console.WriteLine();


            }
          

        }
        public List<KeyValuePair<String, int>> SearchByWord(List<KeyValuePair<String, bool>> Search, List<string> List)
        {
            List<KeyValuePair<string, int>> ReturnL = new List<KeyValuePair<string, int>>();
            foreach (KeyValuePair<string, bool> a in Search)
            {
                if (a.Value == false)
                {
                    List<string> l = a.Key.Split(' ').ToList();
                    for (int i = 0; i < List.Count; ++i)
                    {
                        if (l.All(x => List[i].Contains(x)))
                            ReturnL.Add(new KeyValuePair<string, int>(List[i], i + 1));
                    }
                }
                else
                {
                    for (int i = 0; i < List.Count; ++i)
                    {
                        if (List[i].Contains(a.Key))
                            ReturnL.Add(new KeyValuePair<string, int>(List[i], i + 1));
                    }
                }
            }
            return ReturnL;
        }

       

        private void UI_btnSearch_Click(object sender, EventArgs e)
        {
            if(temp==null)
            {
                Text = "Please choose a file.";
                return;
            }
            if(Search.Count==0)
            {
                Text = "Please add words you want to search for.";
                return;
            }
            var a4 = temp.Split('\r', '\n').ToList();
            a4 = a4.Where(x => x.Count() != 0).ToList();
            List<KeyValuePair<String, int>> Matches = SearchByWord(Search, a4);
            foreach(KeyValuePair<string,int> i in Matches)
            {
                Console.WriteLine(i);
            }

        }

        private void UI_btnClear_Click(object sender, EventArgs e)
        {
            if(Search.Count!=0)
            {
                Search.Clear();
            }
        }

        private void UI_btnFindTop_Click(object sender, EventArgs e)
        {
            if(temp==null)
            {
                return;
            }
            Dictionary<string, int> Dic3 = new Dictionary<string, int>();
            var a3 = temp.Split(' ', '\r', '\n').ToList();
            var a3T = new List<string>(a3);
            foreach (string x in a3)
            {
                if (x.Any(y => !((y >= 64 && y <= 90) || (y >= 97 && y <= 122))) || x.Count() == 0)
                    a3T.Remove(x);

            }
            foreach (string x in a3T)
            {
                if (!Dic3.Keys.Contains(x))
                    Dic3.Add(x, 1);
                else
                    Dic3[x] += 1;

            }
            List<KeyValuePair<string, int>> List3 = Dic3.ToList();
            List3.Sort((x, y) => y.Value.CompareTo(x.Value));
            if (!UI_cbxConjunction.Checked)
            {
                for(int i=0;i<UI_nudTop.Value;++i)
                {
                    Console.WriteLine(List3[i]);
                }
            }
            else
            {
                Dictionary<int, string> Dic4 = new Dictionary<int, string>();
                foreach (KeyValuePair<string, int> x in Dic3)
                {
                    if (!Dic4.Keys.Contains(x.Value))
                        Dic4.Add(x.Value, x.Key);
                    else
                        Dic4[x.Value] += ' ' + x.Key;

                }
                List<KeyValuePair<int, string>> List4 = Dic4.ToList();
                List4.Sort((x, y) => y.Key.CompareTo(x.Key));
                int top = List4.Count;
                if (UI_nudTop.Value < top)
                    top = (int)UI_nudTop.Value;
                for (int i = 0; i < top; ++i)
                {
                    Console.WriteLine(List4[i]);
                }
            }
        }

        private void UI_btnAddWord_Click(object sender, EventArgs e)
        {
            if (UI_cbxIsPhrase.Checked)
            {
                Search.Add(new KeyValuePair<string, bool>(UI_tbxSearch.Text, true));
            }
            else
            {
                Search.Add(new KeyValuePair<string, bool>(UI_tbxSearch.Text, false));
            }
        }
    }
}
