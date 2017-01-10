using System.Collections.Specialized;
using System.Linq;

namespace bindr.NET4
{
    public class Bindr
    {
        public T Bind<T>(NameValueCollection nvc, T model)
        {
            var keys = nvc.AllKeys;
            var modelType = model.GetType();
            var modelProps = modelType.GetProperties();
            foreach (var key in keys)
            {
                if (modelProps.All(mp => mp.Name != key)) continue;
                var value = nvc[key];
                modelType.GetProperty(key).SetValue(model, value);
            }
            return model;
        }
    }
}
