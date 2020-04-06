using System.Collections.Generic;

namespace RestWithAspNet.Data.Converter
{
    public interface IParser<Origin, Destiny>
    {
        Destiny Parse(Origin origin);
        List<Destiny> ParseList(List<Origin> origin);
    }
}
