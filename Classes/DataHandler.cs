namespace be_m1_linq.Classes;

public class DataHandler
{
    //*grab data from csv-file in library-folder
    private readonly string _path;

    //* Metode så man faktisk kan lage if-statements osv...
    public DataHandler(string path)
    {
        _path = path;

        if (!File.Exists(_path))
        {
            throw new FileNotFoundException($"CSV file not found at: {_path}");
        }
        //TODO read file and make available for other methods
    }

    //* lower amount of data to print in output
    //* Search for items containing the user-input
    //* use LINQ in searches and sorting
}