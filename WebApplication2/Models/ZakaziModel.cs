using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Entities;

namespace WebApplication2.Models
{
    public class ZakaziModel
    {
        public ZakaziModel (zakazi zakaz)
        {
            id_zakaza = zakaz.id_zakaza;
            user=zakaz.user;
            konfiguracia=zakaz.konfiguracia;
            zena = (int)zakaz.zena;
            Image = zakaz.Image;

        }
        public int id_zakaza { get; set; } 
        public string user { get; set; }
        public string konfiguracia { get; set; }
        public int zena { get; set; }
        public string Image { get; set; }
    }
}