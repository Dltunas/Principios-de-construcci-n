using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/******************************************************************/
/* Asignación de programa:           Programa que lleva control de alumnos egresados */
/* Nombre del desarrollador:         Alfredo Delgado Santiago, Salomón Maldonado Navarro     */
/* Fecha :                           4 de diciembre de 2019   */
/* Descripción:                      Atributos de la pregunta numero dos del cuestionario  */
/******************************************************************/
namespace SistemaInformacionEgresado.model.pojos
{
    class PreguntaDos
    {
        private int programacionDeSistemas = 0;
        private int manejoDeBasesDeDatos = 0;
        private int capuraDeDatos = 0;
        private int actividadesAdministrativas = 0;
        private int mantenimientoDeEquipo = 0;
        private int mantenimientoEInstalacionDeRedes;
        private int diseñoYMantenimientoDeWebsites = 0;
        private int productosMultimendia = 0;

        private String actividadesExtra = null;

        public int ProgramacionDeSistemas { get => programacionDeSistemas; set => programacionDeSistemas = value; }
        public int ManejoDeBasesDeDatos { get => manejoDeBasesDeDatos; set => manejoDeBasesDeDatos = value; }
        public int CapuraDeDatos { get => capuraDeDatos; set => capuraDeDatos = value; }
        public int ActividadesAdministrativas { get => actividadesAdministrativas; set => actividadesAdministrativas = value; }
        public int MantenimientoDeEquipo { get => mantenimientoDeEquipo; set => mantenimientoDeEquipo = value; }
        public int MantenimientoEInstalacionDeRedes { get => mantenimientoEInstalacionDeRedes; set => mantenimientoEInstalacionDeRedes = value; }
        public int DiseñoYMantenimientoDeWebsites { get => diseñoYMantenimientoDeWebsites; set => diseñoYMantenimientoDeWebsites = value; }
        public int ProductosMultimendia { get => productosMultimendia; set => productosMultimendia = value; }
        public string ActividadesExtra { get => actividadesExtra; set => actividadesExtra = value; }
    }
}
