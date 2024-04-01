using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TicTacToe_LogicSphere
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlayerPlayer_Click(object sender, EventArgs e)
        {
            var frmPlayerVsPlayer = new frmPlayerPlayer(true);
            Program.SwitchMainForm(frmPlayerVsPlayer);
        }

        private void btnPlayerAI_Click(object sender, EventArgs e)
        {
            var frmPlayerVsAi = new frmPlayerPlayer(false);
            Program.SwitchMainForm(frmPlayerVsAi);
        }

        private void pboInstagram_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.instagram.com/logic_sphere_studio/");
        }

        private void pboFacebook_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.facebook.com/LogisticSphereStudio");
        }

        private void pboYoutube_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.youtube.com/@LogicSphereStudio");
        }

        private void pboLogo_Click(object sender, EventArgs e)
        {
            OpenUrl("https://logicspherestudio.wordpress.com");
        }

        // This function is used to start a process which is opening a specified link given as parameter
        private void OpenUrl(string link)
        {
            Process.Start(link);
        }
    }
}
