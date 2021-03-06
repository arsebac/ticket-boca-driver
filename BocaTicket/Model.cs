﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace BocaTicket
{
    public class Model
    {
        private static string modelContent = @"<NR><F2><RC95,1200><HW4,4>04.93.13.78.78
<RC100,700><HW4,3><F2>TAXI RIVIERA<F2>
<RC180,800><HW2,2>ALLO TAXI NICOIS 14-16 AVENUE MIRABEAU - 06000 NICE
<RC240,500><HW4,4><NR>{{entp}}
<F2><HW3,2>
<RC240,140>DATE
<RC340,125>MONTANT
<RC440,140>NOM
<RC850,100>BON N
<F9>
<RC900,100><HW4,4><F2>{{bonNum}}
<F2><HW2,2>
<RC350,500>LIEU DE DEPART : 
<RC450,500>LIEU D'ARRIVEE : 
<RC550,500><NR>PERSONNE TRANSPORTEE : 
<RC650,500>BON NO : 
<HW2,3>
<F2>
<RC350,1500>DATE : 
<RC450,1500>HEURE : 
<RC550,1500>TAXI NO : 
<HW3,3><F1>
<RC750,500> LE MONTANT DE LA COURSE DOIT OBLIGATOIREMENT APPARAITRE AU COMPTEUR HORO KILOMETRIQUE
<RC800,500> MAJORATIONS EN SUS. LE SERVICE EST LAISSE A L'APPRECIATION DE LA CLIENTELE
<RC850,500> CE CHEQUE EST VALABLE DANS LA LIMITE DES LIEUX DE DEPART DE D'ARRIVEE
<HW4,4><F2><RC650,630>{{bonNum}}	
<p>";
       private string data;
        public int Id { get
            {
                return Int32.Parse(ConfigurationManager.AppSettings["ID"]);
            }
            set
            {
                UpdateSetting("ID", "" + value);
            }
        }
       public Model()
        {
            string path = ConfigurationManager.AppSettings["Modele"];
            try
            {

                data = System.IO.File.ReadAllText(path);
            }catch(FileNotFoundException e)
            {
                System.IO.File.WriteAllText(path, modelContent);
                data = modelContent;
            }
            catch(Exception e)
            {
                data = modelContent;
            }
        }
        public string GenerateFGLModel(string company,int id)
        {
            return data.Replace("{{entp}}", company.ToUpper()).Replace("{{bonNum}}", String.Format("{0:000000}", id));
        }
        /// <summary>
        /// code from this thread : https://stackoverflow.com/questions/11149556/app-config-change-value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private static void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
