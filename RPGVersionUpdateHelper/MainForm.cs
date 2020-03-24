using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGVersionUpdateHelper
{
    public partial class MainForm : Form
    {
        #region 전역 컨트롤 | 변수
        FolderBrowserDialog FolderBrowser = new FolderBrowserDialog();

        #endregion


        public MainForm()
        {
            InitializeComponent();

        }

        public void AddLog(string log)
        {
            LogTB.Text += log + Environment.NewLine;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        #region 버튼클릭 부분
        private void Btn_SelectOldText_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                TB_OldText.Text = FolderBrowser.SelectedPath;
            }

        }
        private void Btn_SelectOldTranslated_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                TB_OldTranslated.Text = FolderBrowser.SelectedPath;
            }
        }
        private void Btn_SelectNewText_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                TB_NewText.Text = FolderBrowser.SelectedPath;
            }
        }
        #endregion

        #region 드래그 드랍 설정부

        private void TB_OldText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void TB_OldText_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] FileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
                ((TextBox)sender).Text = FileNames[0];
            }

        }
        #endregion




        private void Btn_Excute_Click(object sender, EventArgs e) //익스큐유ㅜ우==유융뮨ㄴ유뮨융뮹ㅇ션!
        {
            if (TB_NewText.Text != String.Empty & TB_OldText.Text != String.Empty & TB_OldTranslated.Text != String.Empty)
            {
                VersionManegement RPGTexts = new VersionManegement(TB_OldText.Text, TB_OldTranslated.Text, TB_NewText.Text,this);
                if (RPGTexts.isRightFolder()) //파일이 문제가 없을경우
                {
                    RPGTexts.CreatePool();
                }

                //MessageBox.Show(RPGTexts.CompareFiles().ToString()); //테스트 코드
            }
            else
            {
                MessageBox.Show("윽엑 악");
            }

        }
    }

    #region 텍스트 풀 및 파일 로드부
    public class TextPool{
        public List<string> Orig_Text = new List<string>();
        public List<string> Trans_Text= new List<string>();
        public void Add(string a, string b)
        {
            if (!Orig_Text.Contains(a))
            {
                Orig_Text.Add(a);
                Trans_Text.Add(b);
            }
        }
        public int Find(string a)
        {
            int output = 0;
            bool isExist = false;
            foreach (string inst in Orig_Text)
            {
                if (inst == a)
                {
                    isExist = true;
                    break;
                }
                output++;
            }

            if (!isExist)
            {
                output = -1;
            }
            return output;
        }
    }

    public class VersionManegement
    {
        public DirectoryInfo OldTextInfo, OldTranslatedInfo, NewTextInfo;   //경로 설정해줄것
        public EntityRef<MainForm> Parent;
        public List<FileInfo> OldTextFiles, OldTranslatedFiles, NewTextFiles;
        public List<string> NewVersioinText;
        public TextPool TPool = new TextPool();
        public VersionManegement(string OTP, string OTransP, string NTP,MainForm sender)
        {
            Parent.Entity = sender;
            OldTextInfo = new DirectoryInfo(OTP);
            OldTranslatedInfo = new DirectoryInfo(OTransP);
            NewTextInfo = new DirectoryInfo(NTP);
            GetFiles();
        }
        public void AddLog(string log)        
        {
            Parent.Entity.AddLog(log);
        }

        public void GetFiles()
        {
            AddLog("파일 불러오는중");
            OldTextFiles = OldTextInfo.GetFiles("*.txt", SearchOption.AllDirectories).ToList();
            OldTranslatedFiles = OldTranslatedInfo.GetFiles("*.txt", SearchOption.AllDirectories).ToList();
            NewTextFiles = NewTextInfo.GetFiles("*.txt", SearchOption.AllDirectories).ToList();
            AddLog("파일 불러오기 성공");
        }

        public bool isRightFolder()
        {
            AddLog("파일 검사하는중");
            bool output = true;
            if (OldTextFiles.Count != OldTranslatedFiles.Count)
            {
                output = false;
            }
            else
            {
                int Proc = 0;
                foreach (FileInfo InstFile in OldTextFiles)
                {
                    if (InstFile.Name != OldTranslatedFiles[Proc].Name)
                    {
                        output = false;
                    }
                    Proc++;
                }
            }
            AddLog("파일 검사 완료");
            return output;
        }

        public void CreatePool() //텍스트 풀 만드는부분
        {
            AddLog("텍스트 풀 생성중");
            for (int Proc = 0; Proc < OldTextFiles.Count; Proc++)
            {
                StreamReader sr = OldTextFiles[Proc].OpenText();
                string[] Orig = sr.ReadToEnd().Split(new[] { Environment.NewLine },StringSplitOptions.None);
                sr.Close();
                sr = OldTranslatedFiles[Proc].OpenText();
                string[] Trans = sr.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                sr.Close();
                for (int instProc = 0;instProc < Orig.Length; instProc++)
                {
                    TPool.Add(Orig[instProc],Trans[instProc]);
                }
            }
            AddLog("텍스트 풀 생성 완료");
            ReplaceOldVersion();
        }
        public void ReplaceOldVersion()
        {
            AddLog("새로운 버전 작업시작");
            foreach (FileInfo CurrentFile in NewTextFiles)
            {
                AddLog("파일 작업중 : "+CurrentFile.Name);
                List<string> output = new List<string>();
                using (StreamReader sr = CurrentFile.OpenText())
                {
                    while (sr.Peek() >= 0)
                    {
                        string instText = sr.ReadLine();
                        int FindIndex = TPool.Find(instText);
                        if (FindIndex != -1)
                        {
                            output.Add(TPool.Trans_Text[FindIndex]);
                        }
                        else
                        {
                            output.Add(instText);
                        }
                    }
                }
                File.WriteAllText(CurrentFile.FullName,string.Join(Environment.NewLine,output.ToArray()));
                //MessageBox.Show(string.Join(Environment.NewLine, output.ToArray()));
            }
            AddLog("작업완료!!");
        }
    }
    #endregion

    public class TranslateElements
    {
        public List<TextMap> TMap = new List<TextMap>();
        public DirectoryInfo OldTextInfo, OldTranslatedInfo, NewTextInfo;
        public List<FileInfo> OldTextFiles, OldTranslatedFiles, NewTextFiles;


        public TranslateElements(string OTP, string OTransP, string NTP)
        {
            OldTextInfo = new DirectoryInfo(OTP);
            OldTranslatedInfo = new DirectoryInfo(OTransP);
            NewTextInfo = new DirectoryInfo(NTP);
            GetFiles();
        }

        public void GetFiles()
        {
            OldTextFiles = OldTextInfo.GetFiles("*.txt",SearchOption.AllDirectories).ToList();
            OldTranslatedFiles = OldTranslatedInfo.GetFiles("*.txt", SearchOption.AllDirectories).ToList();
            NewTextFiles = NewTextInfo.GetFiles("*.txt", SearchOption.AllDirectories).ToList();
        }

        public bool CompareFiles()
        {
            bool output = true;
            if (OldTextFiles.Count != OldTranslatedFiles.Count)
            {
                output = false;
            }
            else
            {
                int Proc = 0;
                foreach (FileInfo InstFile in OldTextFiles)
                {
                    if (InstFile.Name != OldTranslatedFiles[Proc].Name)
                    {
                        output = false;
                    }
                    Proc++;
                }
            }
            
            return output;
        }

        public void Mapping()
        {
            GetTexts();
        }

        public void Excute()
        {
            foreach (FileInfo InstFile in NewTextFiles) //각 파일 선회 코드
            {
                int Index = 0;
                foreach (TextMap inst in TMap)
                {
                    if (inst.Name == InstFile.Name)
                    {
                        break;
                    }
                    Index++;
                }
                using (StreamReader sr = InstFile.OpenText())
                {

                }
            }
        }

        public void GetTexts()
        {
            foreach (FileInfo InstFile in OldTextFiles) //각 파일 선회 코드
            {
                TextMap instTMap = new TextMap(InstFile.Name);
                instTMap.OldText = GetTextsFromFileInfo(InstFile);
                TMap.Add(instTMap);
            }

            foreach (FileInfo InstFile in OldTranslatedFiles)
            {
                int Index = 0;
                foreach (TextMap inst in TMap)
                {
                    if(inst.Name == InstFile.Name)
                    {
                        break;
                    }
                    Index++;
                }
                TMap[Index].OldTranslated = GetTextsFromFileInfo(InstFile);
            }
        }

        public List<string> GetTextsFromFileInfo(FileInfo InputFileInfo)
        {
            List<string> output = new List<string>();
            using (StreamReader sr = InputFileInfo.OpenText())
            {
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    output.Add(s);
                }
            }
            return output;
        }
    }

    public class TextMap
    {
        public string Name = String.Empty;
        public List<string> OldText = new List<string>();
        public List<string> OldTranslated = new List<string>();
        public List<string> NewText = new List<string>();

        public TextMap(string iName)
        {
            Name = iName;
        }
    }

}
