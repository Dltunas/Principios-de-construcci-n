using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/******************************************************************/
/* Asignación de programa:           Programa que lleva control de alumnos egresados */
/* Nombre del desarrollador:         Alfredo Delgado Santiago, Salomón Maldonado Navarro     */
/* Fecha :                           4 de diciembre de 2019   */
/* Descripción:                      Atributos de la pregunta numero tres del cuestionario  */
/******************************************************************/
namespace SistemaInformacionEgresado.model.pojos
{
    class PreguntaTres
    {
        private int redes = 0;
        private int programacionDeSistemas = 0;
        private int lenguajesDeProgramacion = 0;
        private int softwareEspecializado = 0;
        private int ingenieriaDeSofware = 0;
        private int conocimientosAdministrativos = 0;
        private int dominioDeOtroIdioma = 0;
        private int paqueteria = 0;
        private int ortografiaYRedaccion = 0;
        private int resolucionDeProblemas = 0;
        private int otros = 0;

        private String lenguajesDeseados = null;
        private String otrasAreas = null;

        public int Redes { get => redes; set => redes = value; }
        public int ProgramacionDeSistemas { get => programacionDeSistemas; set => programacionDeSistemas = value; }
        public int LenguajesDeProgramacion { get => lenguajesDeProgramacion; set => lenguajesDeProgramacion = value; }
        public int SoftwareEspecializado { get => softwareEspecializado; set => softwareEspecializado = value; }
        public int IngenieriaDeSofware { get => ingenieriaDeSofware; set => ingenieriaDeSofware = value; }
        public int ConocimientosAdministrativos { get => conocimientosAdministrativos; set => conocimientosAdministrativos = value; }
        public int DominioDeOtroIdioma { get => dominioDeOtroIdioma; set => dominioDeOtroIdioma = value; }
        public int Paqueteria { get => paqueteria; set => paqueteria = value; }
        public int OrtografiaYRedaccion { get => ortografiaYRedaccion; set => ortografiaYRedaccion = value; }
        public int ResolucionDeProblemas { get => resolucionDeProblemas; set => resolucionDeProblemas = value; }
        public int Otros { get => otros; set => otros = value; }
        public string LenguajesDeseados { get => lenguajesDeseados; set => lenguajesDeseados = value; }
        public string OtrasAreas { get => otrasAreas; set => otrasAreas = value; }
    }
}
