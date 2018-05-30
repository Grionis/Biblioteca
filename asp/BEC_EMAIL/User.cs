﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEC_EMAIL
{
   public class User
    {
        string nombre { get; set; }
        string pass   { get; set; }

        public User()
        {
            this.Init();
        }

        private void Init()
        {
            nombre = string.Empty;
            pass = string.Empty;
        }


        public string CrearUser(string u)
        {
            char delimiter = ' ';
            string[] us = new string[5];
            string[] substr = u.Split(delimiter);
            foreach (var item in substr)
            {
                us = substr;
            }
            nombre = us[0].Substring(0, 2) + "." + us[1];            

            return nombre;
        }

        public  string formatearRut(string rut)
        {
            try
            {

            
            int cont = 0;
            string format;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "." + format;
                        cont = 0;
                    }
                }
                return format;
            }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  bool validarRut(string rut)
        {
            
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

    }
}
