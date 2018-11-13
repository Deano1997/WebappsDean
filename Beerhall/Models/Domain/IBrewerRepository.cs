using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beerhall.Models.Domain {
    public interface IBrewerRepository {
        IEnumerable<Brewer> GetAll();
        Brewer GetById(int id);
        void Add(Brewer brewer);
        void Remove(int id);
        void SaveChanges();
    }
}
