using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcPatronRepo.Services
{
  public interface Ibase <T> where T : class
    {
        //Este metodo es el que trae todos los clientes
        IEnumerable<T> GetAll();
        //Este metodo es el que se obtiene por el Id
        T GetById(int id);
        bool Add(T model);
        bool update(T model);
        bool Delete(int id);
    }
}
