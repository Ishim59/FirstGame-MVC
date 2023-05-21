using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinFormsApp1.PlayerView;

namespace WinFormsApp1
{
    public class PlayerController
    {
        private Player player = new Player();
        private PlayerView playerView;
        
        public PlayerController(Form form)
        {
            playerView = new PlayerView(player,form);
        }
        public void MouseMove(object sender, MouseEventArgs e)
        {
            playerView.MouseMove(sender, e);
        }
        public void Location(int dx,int dy)
        {
            playerView.ChangeLocation(dx,dy);
        }
        public PictureBox LocationPlayer => playerView.PicturePlayer;
    }
}


