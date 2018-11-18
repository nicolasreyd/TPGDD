using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalcoNet
{
    public class AdminApp
    {


        public AdminApp() { 
        
        }

        public void cerrar_sesion() {
            App.currentUser = null;
            App.currentRol = null;

            Login.Login login = new Login.Login();
            login.Show();
        }
    }
}
