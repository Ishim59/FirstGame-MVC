using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class GameController
    {
        private PlayerController playerController;
        private BulletController bulletController;

        public GameController(Form form)
        {
            playerController = new PlayerController(form);
            bulletController= new BulletController();

        }

    }
}
