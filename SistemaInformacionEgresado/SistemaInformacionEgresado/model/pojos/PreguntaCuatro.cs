using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/******************************************************************/
/* Asignación de programa:           Programa que lleva control de alumnos egresados */
/* Nombre del desarrollador:         Alfredo Delgado Santiago, Salomón Maldonado Navarro     */
/* Fecha :                           4 de diciembre de 2019   */
/* Descripción:                      Atributos de la pregunta numero cuatro del cuestionario  */
/******************************************************************/
namespace SistemaInformacionEgresado.model.pojos
{
    class PreguntaCuatro
    {
        private int responsabilidad = 0;
        private int puntualidad = 0;
        private int trabajoEnEquipo = 0;
        private int liderazgo = 0;
        private int confiablidad = 0;
        private int discresion = 0;
        private int presentacion = 0;
        private int confianza = 0;
        private int lealtad = 0;
        private int otros = 0;

        public int Responsabilidad { get => responsabilidad; set => responsabilidad = value; }
        public int Puntualidad { get => puntualidad; set => puntualidad = value; }
        public int TrabajoEnEquipo { get => trabajoEnEquipo; set => trabajoEnEquipo = value; }
        public int Liderazgo { get => liderazgo; set => liderazgo = value; }
        public int Confiablidad { get => confiablidad; set => confiablidad = value; }
        public int Discresion { get => discresion; set => discresion = value; }
        public int Presentacion { get => presentacion; set => presentacion = value; }
        public int Confianza { get => confianza; set => confianza = value; }
        public int Lealtad { get => lealtad; set => lealtad = value; }
        public int Otros { get => otros; set => otros = value; }
    }
}
