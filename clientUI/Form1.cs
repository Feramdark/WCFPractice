using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace clientUI
{
    public partial class Form1 : Form
    {
        ServiceMethods.Service1Client Alumno = new ServiceMethods.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            var createAlumno = Alumno.RegistrarAlumno();// -> Crear metodo.
            var data = Alumno.GetAlumno(createAlumno);// -> Guarda los datos.

            var createAlumn2 = Alumno.RegistrarAlumno2();
            var data2 = Alumno.GetAlumno(createAlumn2);

            string name = data.Nombre;
            string carrer = data.Carrera;

            string nombre = data2.Nombre;
            string carrera = data2.Carrera;


            listBox1.Items.Add("Alumno: "+ name + " " + carrer);
            listBox1.Items.Add("Alumno: " + nombre + " " + carrera);

        }

        public void promedio(int FstPar,int secoPar,int thrdPar)
        {
            var getGrade = Alumno.calificaciones(FstPar, secoPar, thrdPar);

            listBox2.Items.Add("Tu calificación es: " + getGrade);
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);


            promedio(a, b, c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nuevo = Alumno.GetNumeroControl(Convert.ToInt32(textBox4.Text));
            nomCode.Text = nuevo;
        }
    }
}
