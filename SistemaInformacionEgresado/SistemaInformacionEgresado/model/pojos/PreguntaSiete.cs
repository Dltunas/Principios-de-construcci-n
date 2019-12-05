using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/******************************************************************/
/* Asignación de programa:           Programa que lleva control de alumnos egresados */
/* Nombre del desarrollador:         Alfredo Delgado Santiago, Salomón Maldonado Navarro     */
/* Fecha :                           4 de diciembre de 2019   */
/* Descripción:                      Atributos de la pregunta numero siete del cuestionario  */
/******************************************************************/
namespace SistemaInformacionEgresado.model.pojos
{
    class PreguntaSiete
    {
        private int si = 0;
        private int no = 0;

        public int Si { get => si; set => si = value; }
        public int No { get => no; set => no = value; }
    }
}
