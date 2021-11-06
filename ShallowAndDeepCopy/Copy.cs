using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ShallowAndDeepCopy
{
    public abstract class Copy<T>
    {
        public T  ShallowCopy()
        {
            return (T)this.MemberwiseClone();
        }
        public T DeepCopy()
        {
            var result = JsonConvert.SerializeObject(this);
            var T = JsonConvert.DeserializeObject<T>(result);
            return T;

        }
    }
}