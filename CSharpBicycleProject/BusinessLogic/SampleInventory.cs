namespace CSharpBicycleProject;

internal class SampleInventory
{
    private SerialNumberGenerator generator;

    public List<Touring> TouringList { get; private set; }
    public List<Vintage> VintageList { get; private set; }
    public List<CrossCountry> CrossCountryList { get; private set; }
    public List<Downhill> DownHillList { get; private set; }

    public SampleInventory()
    {
        generator = SerialNumberGenerator.Instance;
        // building our bike lists
        TouringList = BuildTouringInventory();
        VintageList = BuildVintageInventory();
        CrossCountryList = BuildCrossCountryInventory();
        DownHillList = BuildDownHillInventory();
    }

    private List<Touring> BuildTouringInventory()
    {
        List<Touring> list = new List<Touring>();
        Touring touring = new Touring(new NormalWheel());
        generator.SetModelAndStart(touring.Model, touring.StartNumber);
        for(int i = 0; i < 10; i++)
        {
            touring = new Touring(new NormalWheel());
            touring.SerialNumber = generator.GetNextSerial();
            list.Add(touring);
        }
        return list;
    }

    private List<Vintage> BuildVintageInventory()
    {
        List<Vintage> list = new List<Vintage>();
        Vintage vintage = new Vintage(new NormalWheel());
        generator.SetModelAndStart(vintage.Model, vintage.StartNumber);
        for (int i = 0; i < 10; i++)
        {
            vintage = new Vintage(new NormalWheel());
            vintage.SerialNumber = generator.GetNextSerial();
            list.Add(vintage);
        }
        return list;
    }

    private List<CrossCountry> BuildCrossCountryInventory()
    {
        List<CrossCountry> list = new List<CrossCountry>();
        CrossCountry crossCountry = new CrossCountry(new WideWheel());
        generator.SetModelAndStart(crossCountry.Model, crossCountry.StartNumber);
        for (int i = 0; i < 10; i++)
        {
            crossCountry = new CrossCountry(new WideWheel());
            crossCountry.SerialNumber = generator.GetNextSerial();
            list.Add(crossCountry);
        }
        return list;
    }

    private List<Downhill> BuildDownHillInventory()
    {
        List<Downhill> list = new List<Downhill>();
        Downhill downHill = new Downhill(new WideWheel());
        generator.SetModelAndStart(downHill.Model, downHill.StartNumber);
        for (int i = 0; i < 10; i++)
        {
            downHill = new Downhill(new WideWheel());
            downHill.SerialNumber = generator.GetNextSerial();
            list.Add(downHill);
        }
        return list;
    }

}
