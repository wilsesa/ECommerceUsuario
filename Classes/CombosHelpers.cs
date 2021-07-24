using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Classes
{
    public class CombosHelpers : IDisposable
    {
        private static EcommerceContext db = new EcommerceContext();
        public static List<Departaments> GetDepartments()
        {
            var dep = db.Departaments.ToList();
            dep.Add(new Departaments
            {
                DepartamentsId = 0,
                Name = "[Seleccione um Departamento]"
            });

            return  dep = dep.OrderBy(d => d.Name).ToList();
        }

        public static List<City> GetCities()
        {
            var cit = db.Cities.ToList();
            cit.Add(new City
            {
                CityId = 0,
                Name = "[Seleccione uma Cidade]"
            });

            return cit = cit.OrderBy(d => d.Name).ToList();
        }

        public static List<Company> GetCompanys ()
        {
            var comp = db.Companies.ToList();
            comp.Add(new Company
            {
                CompanyId = 0,
                Name = "[Seleccione uma Companhia]"
            });

            return comp = comp.OrderBy(c => c.Name).ToList();
        }


        public void Dispose()
        {
            db.Dispose();
        }
    }
}