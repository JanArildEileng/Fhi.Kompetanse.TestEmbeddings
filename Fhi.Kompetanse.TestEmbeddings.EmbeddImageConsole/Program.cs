using Fhi.Kompetanse.TestEmbeddings.EmbeddImageConsole;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.VectorData;
using Microsoft.SemanticKernel.Connectors.InMemory;
using Microsoft.SemanticKernel.Connectors.Qdrant;
using Qdrant.Client;

Console.WriteLine("Hello, Kompetansere!");

// The C# client uses Qdrant's gRPC interface
//var client = new QdrantClient("localhost", 6334);


// 1 Lag en 'Image' collection, basert på bilde-beskrivelser

var imageDataList = GetImageData.GetListImageData();

//var vectorStore = new InMemoryVectorStore();
var vectorStore = new QdrantVectorStore(new QdrantClient("localhost"));

var movies = vectorStore.GetCollection<ulong, Image>("images");

await movies.CreateCollectionIfNotExistsAsync();

//all-minilm  eller nomic-embed-text
IEmbeddingGenerator<string,Embedding<float>> generator = 
    new OllamaEmbeddingGenerator(new Uri("http://localhost:11434/"), "all-minilm");

foreach(var image in imageDataList)
{
    image.Vector = await generator.GenerateEmbeddingVectorAsync(image.Description);
    await movies.UpsertAsync(image);
}

// 2 La et query , vectoriser dette på samme måte som image-Description


var query = "A family friendly cat";

var queryEmbedding = await generator.GenerateEmbeddingVectorAsync(query);

// 3 søk for  image med  Description liggende til query-teksen (topp 3)

var searchOptions = new VectorSearchOptions()
{
    Top = 3,
    VectorPropertyName = "Vector"
};

var results = await movies.VectorizedSearchAsync(queryEmbedding, searchOptions);



// 4 skriv ut resultat

await foreach(var result in results.Results)
{
    Console.WriteLine($"Title: {result.Record.Title}");
    Console.WriteLine($"Description: {result.Record.Description}");
    Console.WriteLine($"Score: {result.Score}");
    Console.WriteLine();
}


Console.WriteLine("Goodbye!");