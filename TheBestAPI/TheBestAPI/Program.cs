using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using NHentaiSharp.Core;
using NHentaiSharp.Search;

string[] tags = new[] { // Tags for the upcoming searches
  "loli", // We add the tag loli
  NHentaiSharp.Core.SearchClient.GetExcludeTag("rape"), // We exclude the tag rape
  NHentaiSharp.Core.SearchClient.GetCategoryTag("kantai collection", NHentaiSharp.Search.TagType.Parody)
  // We search doujinshi of the anime/game Kantai Collection
};

Random r = new Random();
// We do a search with the tags
var result = await NHentaiSharp.Core.SearchClient.SearchWithTagsAsync(tags);
int page = r.Next(0, result.numPages) + 1; // Page count begin at 1
// We do a new search at a random page
result = await NHentaiSharp.Core.SearchClient.SearchWithTagsAsync(tags, page);
var doujinshi = result.elements[r.Next(0, result.elements.Length)]; // We get a random doujinshi

Console.WriteLine("Random doujinshi: " + doujinshi.prettyTitle + Environment.NewLine +
  "URL: " + doujinshi.url);