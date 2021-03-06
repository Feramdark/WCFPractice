﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFejemplo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        string nulo = "";
        Alumno alumno = new Alumno();
        public string GetNumeroControl(int value) //Metodo 1
        {
            if (value==1703)
            {
                alumno.Nombre = "Fernando Vazquez";
                return string.Format("El nombre es "+ alumno.Nombre);    
            }
            else if (value==1999)
            {
                alumno.Nombre = "Aminadad Sandoval";
                return string.Format("El nombre es " + alumno.Nombre);
            }
            else if (value==2010)
            {
                alumno.Nombre= "Luis Vazquez";
                return string.Format("El nombre es " + alumno.Nombre);
            }
            return nulo;
        }
        public Alumno GetAlumno( Alumno alumno) //Metodo 2
        {
            return alumno;
        }
        public int calificaciones(int Parcial1, int parcial2,int parcial3)//Metodo 3
        {
            int resul = 0;
            int Semestre = 0;
            resul = Parcial1 + parcial2 + parcial3;
            Semestre = resul / 3;
            return Semestre;
        }
        public Alumno RegistrarAlumno()
        {
            Alumno datos = new Alumno();
            datos.NoControl = 40;
            datos.Nombre = "Fernando";
            datos.Carrera = "informatica";
            return datos;
        }
        public Alumno RegistrarAlumno2()
        {
            Alumno datos = new Alumno();
            datos.NoControl = 50;
            datos.Nombre = "Leonardo";
            datos.Carrera = "Mecatronica";
            return datos;
        }
    }
}
