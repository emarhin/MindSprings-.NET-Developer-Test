namespace MindSpringsTest.Models;
using System.ComponentModel.DataAnnotations;

public class storeResultModel
{
      [Key]
      public int Id { get; set; }
      public string? TextEntered { get; set; }
      public string?  translatedText{ get; set; }
}
