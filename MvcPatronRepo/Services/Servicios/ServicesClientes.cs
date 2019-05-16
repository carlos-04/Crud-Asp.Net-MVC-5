using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcPatronRepo.Models;
using MvcPatronRepo.Persisten;

namespace MvcPatronRepo.Services.Servicios
{
    public class ServicesClientes : Iclientes
    {
        private readonly SystemDbContext _systemDb;

        public ServicesClientes()
        {
            SystemDbContext dbContext = new SystemDbContext();
            _systemDb = dbContext;
        }
        public bool Add(Clientes model)
        {

            try
            {

                _systemDb.cliente.Add(model);
                _systemDb.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;

        }

        public bool Delete(int id)
        {
            try
            {
                var obj = _systemDb.cliente.Find(id);
                _systemDb.cliente.Remove(obj);
                _systemDb.SaveChanges();
            }
            catch (Exception)
            {

                return false;

            }

            return true;

        }

        public IEnumerable<Clientes> GetAll()
        {

            var all = new List<Clientes>();

            try
            {
                all = _systemDb.cliente.ToList();
            }
            catch (Exception)
            {


            }

            return all;

        }

        public Clientes GetById(int id)
        {
            var model = new Clientes();

            try
            {
                model = _systemDb.cliente.Single(e => e.Id == id);

            }
            catch (Exception)
            {

                throw;
            }

            return model;
        }



        public bool update(Clientes model)
        {
            try
            {
                _systemDb.Entry(model).State = System.Data.Entity.EntityState.Modified;
                _systemDb.SaveChanges();

            }
            catch (Exception)
            {

                return false;
            }

            return true;


        }
    }
}