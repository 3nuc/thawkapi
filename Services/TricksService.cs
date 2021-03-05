using System;
using System.IO;
using Newtonsoft.Json;
namespace thawkapi.Services
{
  public class TricksService
  {
    public TricksService()
    {
      this.tricks = this.readTricksFromJson();
    }
    private Random generator = new Random();
    private string[] tricks;

    private string[] readTricksFromJson() {
      var tricksRawJson = File.ReadAllText("./Databases/TonyHawkTricks.json");
      return JsonConvert.DeserializeObject<string[]>(tricksRawJson);
    }
    public string[] GetAllTricks() {
      return this.tricks;
    }
    public string GetRandomTrick() {
      int trickIndex = this.generator.Next(0, tricks.Length);
      return this.tricks[trickIndex];
    }
  }
}
