using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SistemaInformacionEgresado.model.pojos;

namespace SistemaInformacionEgresado.Vistas
{
    /// <summary>
    /// Lógica de interacción para EncuestaEmpleador.xaml
    /// </summary>
    public partial class EncuestaEmpleador : Window
    {
        public EncuestaEmpleador()
        {
            InitializeComponent();
        }

        private void Pregunta1(object sender, RoutedEventArgs e)
        {
            PreguntaUno p1 = new PreguntaUno();

            String cuantos = " ";
            String porque = " ";
            if (rb_P1_1.IsChecked == true)
            {
                p1.Si = 1;
                p1.No = 0;
            }
            else if (rb_P1_2.IsChecked == true)
            {
                p1.Si = 0;
                p1.No = 1;
                txt_P1_Cuantos.IsEnabled = false;
            }
            if (p1.Si == 1)
            {
                cuantos = txt_P1_Cuantos.Text;
                int num;
                if (!int.TryParse(cuantos, out num))
                {
                    MessageBox.Show("introduce un numero no caracteres...");
                    try
                    {
                        num = int.Parse(cuantos);
                    }
                    catch (SystemException ex)
                    {
                        Console.Write(ex);
                    }

                }
                p1.Cuantos = cuantos;
            }
            porque = txt_Pregunta1.Text;
            p1.Porque = porque;
        }
    }
       
    }
