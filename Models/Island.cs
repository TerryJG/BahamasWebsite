namespace BahamasWebsite.Models;

public class Island
{
  public String Name { get; set; } = "";
  public String Description { get; set; } = "";
  public String Image { get; set; } = "";
  public String Region { get; set; } = "";
  public String Capital { get; set; } = "";
  public String[] Attractions { get; set; } = [];
  public String[] Text { get; set; } = [];
}
