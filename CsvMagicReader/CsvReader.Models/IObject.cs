// namespace CsvReader.Models{

//     public interface IObject
//     {
//         // public T ListToObject<T>(List<string> t) where T : new();
//         public IObject ListToObject<IObject>(List<string> t) where IObject : new();
//         public string Describe();
//     }
// }

namespace CsvReader.Models{

    public abstract class IObject
    {
        // public T ListToObject<T>(List<string> t) where T : new();
        // public abstract IObject ListToObject<IObject>(List<string> t) where IObject : new();
        public abstract IObject ListToObject(List<string> t);
        public abstract string Describe();
    }
}