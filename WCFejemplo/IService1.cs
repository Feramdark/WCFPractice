using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFejemplo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        //Aqui es donde se declaran los metodos con el contrato de operacion
        //SI NO SE DECLARAN CON OPERATION CONTRACT NO APARECERAN EN LA VENTANA DE CLIENTE PRUEBA.

        [OperationContract]
        string GetNumeroControl(int value);//Metodo uno

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);//Metodo ejemplo

        [OperationContract]
        Alumno GetAlumno(Alumno alumno);//Metodo dos
        [OperationContract]
        int calificaciones(int Parcial1, int parcial2, int parcial3);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue=value; }
        }
    }

    [DataContract]
    public class Alumno
    {
        bool bandera = true;
        int nc = 1997;
        string nombre = "Melisa";
        string carrera = "Informatica";

        [DataMember]
        public bool BoolValue
        {
            get { return bandera; }
            set { bandera = value; }
        }

        [DataMember]
        public int NoControl
        {
            get { return nc; }
            set { nc = value; }
        }

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [DataMember]
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
    }
}
