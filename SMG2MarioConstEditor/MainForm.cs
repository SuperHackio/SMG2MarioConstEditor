using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMG2PlayerConstEditor
{
    public partial class MainForm : Form
    {
        private PlayerConst _currentconst;
        private PlayerConst CurrentConst
        {
            get => _currentconst;
            set
            {
                _currentconst = value;
                PlayerConstPropertyGrid.SelectedObject = value;
            }
        }

        private string Filename { get; set; } = null;
        private const string Filter = "Constants|*.bin";
        readonly OpenFileDialog OFD = new() { Filter = Filter };
        readonly SaveFileDialog SFD = new() { Filter = Filter };

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            CurrentConst = null;
            PlayerConstPropertyGrid.UseCompatibleTextRendering = true;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentConst = new PlayerConst();
            Filename = null;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() != DialogResult.OK)
                return;

            FileStream FS = new(OFD.FileName, FileMode.Open);

            PlayerConst temp = new();
            temp.Read(FS);
            CurrentConst = temp;
            FS.Close();
            Filename = OFD.FileName;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentConst is null)
                return;
            if (Filename is null)
            {
                SaveAsToolStripMenuItem_Click(sender, e);
                return;
            }

            FileStream FS = new(Filename, FileMode.Create);

            CurrentConst.Write(FS);
            FS.Close();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentConst is null)
                return;
            if (SFD.ShowDialog() != DialogResult.OK)
                return;

            Filename = SFD.FileName;
            SaveToolStripMenuItem_Click(sender, e);
        }
    }
}
