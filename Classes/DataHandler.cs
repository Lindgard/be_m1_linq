namespace be_m1_linq.Classes;

public class DataHandler
{
    //* field for the pathing to the csv file
    private readonly string _path;

    //*grab data from csv-file in library-folder
    public getData(string path)
    {
        _path = path;

        if (!File.Exists(_path))
        {
            throw new FileNotFoundException($"CSV file not found at: {_path}");
        }
        else
        {
            File.ReadAllLines(_path); //TODO read file and make available for other methods
        }
    }

    //* lower amount of data to print in output
    //* Search for items containing the user-input
    //* use LINQ in searches and sorting
}