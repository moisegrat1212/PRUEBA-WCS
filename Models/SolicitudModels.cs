using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using PRUEBA.Entities;

namespace PRUEBA.Models
{
    public interface ISolicitudModel
    {
        Dictionary<String, Object> GetSolicitudes();
        Dictionary<String, Object> SendToSolicitud(SendSolicitud sendSolicitud);
        Dictionary<String, Object> UpdateSolicitud(SendSolicitud sendSolicitud);
        Dictionary<String, Object> DeleteSolicitud(string idSolicitud);

    }


    public class SolicitudModel : ISolicitudModel
    {
        public SolicitudModel()
        {

        }

        public Dictionary<String, Object> GetSolicitudes()
        {
            Dictionary<String, Object> item = new Dictionary<String, Object>();
            try
            {
                string firstName = "Moises";
                string lastName = " Graterol";
                string identification = " 20051634";
                string age = " 28";
                string house = " Gryffindor";
                var txt = firstName + lastName + identification + age + house;
                item.Add("List of solicitude: ", txt);
                item.Add("codRespuesta", 0);
                Console.WriteLine(item);
            }
            catch (Exception error)
            {
                item.Add("codRespuesta", error.HResult);
                item.Add("tecn_msg", error.Message);
                return item;
            }
            return item;
        }

        public Dictionary<String, Object> SendToSolicitud(SendSolicitud sendSolicitud)
        {
            Dictionary<String, Object> item = new Dictionary<String, Object>();
            try
            {
                if (Regex.IsMatch(sendSolicitud.firstName, @"^[a-zA-Z]+$"))
                {
                    if (sendSolicitud.firstName.Length > 20)
                    {
                        throw new Exception("El Nombre no debe contener mas de 20 caracteres");
                    }
                }
                else
                {
                    throw new Exception("El Nombre solo debe contener letras");
                }
                if (Regex.IsMatch(sendSolicitud.lastName, @"^[a-zA-Z]+$"))
                {
                    if (sendSolicitud.lastName.Length > 20)
                    {
                        throw new Exception("El Apellido no debe contener mas de 20 caracteres");
                    }
                }
                else
                {
                    throw new Exception("El Apellido solo debe contener letras");
                }
                if (Regex.IsMatch(sendSolicitud.identification, "^[0-9]*$"))
                {
                    if (sendSolicitud.lastName.Length > 10)
                    {
                        throw new Exception("La identidicación no debe contener mas de 10 caracteres");
                    }
                }
                else
                {
                    throw new Exception("La identidicación solo debe contener números");
                }
                if (Regex.IsMatch(sendSolicitud.age, "^[0-9]*$"))
                {
                    if (sendSolicitud.age.Length > 2)
                    {
                        throw new Exception("La edad no debe contener mas de 2 caracteres");
                    }
                }
                else
                {
                    throw new Exception("La edad solo debe contener números");
                }

                if ((!sendSolicitud.house.Equals("Gryffindor")) && (!sendSolicitud.house.Equals("Hufflepuff")) && (!sendSolicitud.house.Equals("Ravenclaw")) && (!sendSolicitud.house.Equals("Slytherin")))
                {
                    throw new Exception("La Casa no es correcta");
                }
                /* Si tuviese una conexión a BD se pasaría los datos para el insert.
                Ejemplo: Solicitud SolicitudNew = new Solicitud();
                SolicitudNew.house = sendSolicitud.house;
                _context.Solicitud.Add(DescripcionNew); 
                _context.SaveChanges();*/
                item.Add("List of solicitude: ", sendSolicitud);
                item.Add("codRespuesta", 0);
                Console.WriteLine(item);
            }
            catch (Exception error)
            {
                item.Add("codRespuesta", error.HResult);
                item.Add("tecn_msg", error.Message);
                return item;
            }
            return item;
        }

        public Dictionary<String, Object> UpdateSolicitud(SendSolicitud sendSolicitud)
        {
            Dictionary<String, Object> item = new Dictionary<String, Object>();
            try
            {
                if (Regex.IsMatch(sendSolicitud.firstName, @"^[a-zA-Z]+$"))
                {
                    if (sendSolicitud.firstName.Length > 20)
                    {
                        throw new Exception("El Nombre no debe contener mas de 20 caracteres");
                    }
                }
                else
                {
                    throw new Exception("El Nombre solo debe contener letras");
                }
                if (Regex.IsMatch(sendSolicitud.lastName, @"^[a-zA-Z]+$"))
                {
                    if (sendSolicitud.lastName.Length > 20)
                    {
                        throw new Exception("El Apellido no debe contener mas de 20 caracteres");
                    }
                }
                else
                {
                    throw new Exception("El Apellido solo debe contener letras");
                }
                if (Regex.IsMatch(sendSolicitud.identification, "^[0-9]*$"))
                {
                    if (sendSolicitud.lastName.Length > 10)
                    {
                        throw new Exception("La identidicación no debe contener mas de 10 caracteres");
                    }
                }
                else
                {
                    throw new Exception("La identidicación solo debe contener números");
                }
                if (Regex.IsMatch(sendSolicitud.age, "^[0-9]*$"))
                {
                    if (sendSolicitud.age.Length > 2)
                    {
                        throw new Exception("La edad no debe contener mas de 2 caracteres");
                    }
                }
                else
                {
                    throw new Exception("La edad solo debe contener números");
                }

                if ((!sendSolicitud.house.Equals("Gryffindor")) && (!sendSolicitud.house.Equals("Hufflepuff")) && (!sendSolicitud.house.Equals("Ravenclaw")) && (!sendSolicitud.house.Equals("Slytherin")))
                {
                    throw new Exception("La Casa no es correcta");
                }
                /* Si tuviese una conexión a BD se pasaría los datos para el update.
                Ejemplo: Solicitud Solicitud_Actualizar = new Solicitud();
                Solicitud_Actualizar = _context.Solicitud.Where(x => x.NombreSolicitud == sendSolicitud.house).FirstOrDefault();
                Solicitud_Actualizar.Apellido = sendSolicitud.lastName;
                _context.Solicitud.Update(Solicitud_Actualizar); 
                _context.SaveChanges();*/
                item.Add("List of solicitude: ", sendSolicitud);
                item.Add("codRespuesta", 0);
                Console.WriteLine(item);
            }
            catch (Exception error)
            {
                item.Add("codRespuesta", error.HResult);
                item.Add("tecn_msg", error.Message);
                return item;
            }
            return item;
        }

        public Dictionary<String, Object> DeleteSolicitud(string idSolicitud)
        {
            Dictionary<String, Object> item = new Dictionary<String, Object>();
            try
            {            
                /* Si tuviese una conexión a BD se pasaría los datos para el delete.
                Ejemplo: Solicitud SolicitudEncontrada = new Solicitud();
                SolicitudEncontrada = _context.Solicitud.Where(x => x.idSolicitud == idSolicitud).FirstOrDefault();
                SolicitudEncontrada.FechaElimina = DateTime.Now;
                _context.Solicitud.Update(SolicitudEncontrada); 
                _context.SaveChanges();*/
                item.Add("idSolicitud: ", idSolicitud);
                item.Add("codRespuesta", 0);
                Console.WriteLine(item);
            }
            catch (Exception error)
            {
                item.Add("codRespuesta", error.HResult);
                item.Add("tecn_msg", error.Message);
                return item;
            }
            return item;
        }

    }
}