class Array
{
    //1D
    byte[] ages = new byte[100];
    string[] names = { "Bishnu", "Ram", "Hari" };

    //2D or Multi D
    string[,] chessBoard1 = new string[8, 8];
    string[,] chessBoard2 = {
        {"A1","A2","A3","A4","A5","A6","A7","A8"},
        {"B1","B2","A3","A4","A5","A6","A7","A8"},
        {"A1","A2","A3","A4","A5","A6","A7","A8"},
        {"A1","A2","A3","A4","A5","A6","A7","A8"},
        {"A1","A2","A3","A4","A5","A6","A7","A8"},
        {"A1","A2","A3","A4","A5","A6","A7","A8"},
        {"A1","A2","A3","A4","A5","A6","A7","A8"},
        {"A1","A2","A3","A4","A5","A6","A7","A8"}
    };

    //Jagged Array
    bool[][] data = new bool[5][];

    void AssignVariables()
    {
        data[0] = new bool[3] { true, false, false};
        data[1] = new bool[2] { true, false };
    }
}
