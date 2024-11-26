using Microsoft.Extensions.VectorData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fhi.Kompetanse.TestEmbeddings.EmbeddImageConsole
{
  
public class Image
{
    [VectorStoreRecordKey]
    public int Key {get;set;}

    [VectorStoreRecordData] 
    public string Title {get;set;}

    [VectorStoreRecordData]
    public string Description {get;set;}

    [VectorStoreRecordVector(384, DistanceFunction.CosineSimilarity)]
    public ReadOnlyMemory<float> Vector {get;set;}
}
}
