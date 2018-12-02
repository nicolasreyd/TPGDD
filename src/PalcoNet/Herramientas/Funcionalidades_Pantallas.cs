using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Herramientas
{
    public class Funcionalidades_Pantallas
    {

        static public void Limpiar(Form form)
        {
            LimpiarControl(form);
        }

        static public bool esNumero(string cadena)
        {
            for (int lIndice = 0; lIndice <= cadena.Length - 1; lIndice++)
            {
                if (!char.IsNumber(cadena[lIndice]))
                {
                    return false;
                }
            }
            return true;
        }


        static public void LimpiarControl(Control controlToClean)
        { 
         foreach (var control in controlToClean.Controls)
            {


                if (control is TextBox)
                {
                    var textbox = control as TextBox;
                    if (!textbox.ReadOnly)
                        textbox.Text = string.Empty;
                }

                if (control is ComboBox)
                {
                    var combobox = control as ComboBox;
                    if (combobox.Visible)
                        ((ComboBox)control).SelectedIndex = -1;
                }

                if (control is DataGridView)
                {
                    ((DataGridView)control).DataSource = null;
                }

                if (control is ListBox)
                {
                    ((ListBox)control).ClearSelected();
                }

                if (control is CheckBox)
                {
                    var checkbox = control as CheckBox;
                    if (checkbox.AutoCheck)
                        checkbox.Checked = false;
                }

                LimpiarControl((Control)control);
            }
        }
    
        

    }

 
}
