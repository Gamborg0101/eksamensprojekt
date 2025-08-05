using Folk;

namespace eksamensprojekt.Folk
{
  public class Besøgende : Person
  {
    
    public override TimeSpan MaxMødeTid()
    {
      return BesøgendeFactory.besøgendeMødetid;
    }
  }
}