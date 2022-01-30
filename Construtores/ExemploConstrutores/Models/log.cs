namespace ExemploConstrutores.Models
{
  public class log
  {
    private static log _log;
    public string Propriedadelog { get; set; }

    private log()
    {

    }
    public static log GetInstance()
    {
      if (_log == null)
      {
        _log = new log();
      }
      return _log;

    }
  }
}