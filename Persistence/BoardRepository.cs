using SurfsUp.Models;
namespace SurfsUp.Persistence

{
    public class BoardRepository
    {
        //private List<Board> LoadCsvFile()
        //{
        //    //Name;Length(feet);Width(inches);Thickness(inches);Volume(L);Type;Price(€);Equipment
        //    string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

        //    string csvFilePath = System.IO.Path.Combine(appDirectory, "..", "..", "..", "Datasheet til surf.csv");

        //    List<Board> boards = new List<Board>();

        //    try
        //    {
        //        if (File.Exists(csvFilePath))
        //        {
        //            string[] lines = File.ReadAllLines(csvFilePath);

        //            for (int i = 1; i < lines.Length; i++)
        //            {
        //                string[] parts = lines[i].Split(';');

        //                if (parts.Length == 8)
        //                {
        //                    Board board = new Board
        //                    {
        //                        Name = parts[0],
        //                        Length = double.Parse(parts[1]),
        //                        Width = double.Parse(parts[2]),
        //                        Thickness = double.Parse(parts[3]),
        //                        Volume = double.Parse(parts[4]),
        //                        Type = parts[5],
        //                        Price = int.Parse(parts[6]),
        //                        Equipment = parts[7]
        //                    };

        //                    boards.Add(board);
        //                }
        //            }
        //        }
        //    }

        //    catch (Exception error)
        //    {
        //        Console.WriteLine(error); //error msg
        //    }

        //    return boards;
        //}

    }
}
