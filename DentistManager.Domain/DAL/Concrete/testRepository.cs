using System.Collections.Generic;
using System.Linq;
using DentistManager.Domain.DAL.Abstract;

namespace DentistManager.Domain.DAL.Concrete
{
    public class testRepository :ItestRepository
    {
        public string GetTesting()
        {
            return "Hello ";
        }
    }
}
