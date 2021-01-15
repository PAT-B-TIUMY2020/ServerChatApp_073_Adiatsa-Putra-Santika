﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerChatApp_073_Adiatsa_Putra_Santika
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostobjek = null;
            try
            {
                hostobjek = new ServiceHost(typeof(ServiceCallback));
                hostobjek.Open();
                Console.WriteLine("Server On, ready to use");
                Console.ReadLine();
                hostobjek.Close();
            }
            catch (Exception ex)
            {
                hostobjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();


            }
        }
}
