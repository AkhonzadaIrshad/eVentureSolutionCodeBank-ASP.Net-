using System.Collections.Generic;

namespace UpdateForiegnKeyResolverDemo.Models
{
    public interface ICRUD<T>
    {
        void Add(T t);

        List<T> Get();

        T Get(int id);

        void Update(T t);
    }
}