namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] map = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[,] matrix = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            //displayMap(map);
            displayBoard(matrix);
            int move = 0;
            int winner=-1;
            //do
            //{
            //    playerMove(map, move%2+1);
            //    move++;
            //    displayMap(map);
            //} while (move!=9);
            do
            {
                playerMove2(matrix, move % 2 + 1);
                
                displayBoard(matrix);
                if (checkWin(matrix))
                {
                    winner = move % 2 + 1;
                    break;
                }
                move++;
            } while (move != 9);
            if (winner == -1)
            {
                Console.WriteLine("Draw !");
            }
            else
                Console.WriteLine("Player "+ winner +" Win !");
        }
        //static void displayMap(string[] map)
        //{
        //    Console.WriteLine("   |   |   ");
        //    Console.WriteLine(" {0} | {1} | {2} ", map[0], map[1], map[2]);
        //    Console.WriteLine("___|___|___");
        //    Console.WriteLine("   |   |   ");
        //    Console.WriteLine(" {0} | {1} | {2} ", map[3], map[4], map[5]);
        //    Console.WriteLine("___|___|___");
        //    Console.WriteLine("   |   |   ");
        //    Console.WriteLine(" {0} | {1} | {2} ", map[6], map[7], map[8]);
        //    Console.WriteLine("   |   |   ");
        //}
        static void displayBoard(string[,] map)
        {
            Console.Clear();
            Console.WriteLine(" ___________");
            for (int i = 0; i < map.GetLength(0); i++)
            {
               
                Console.WriteLine("|   |   |   |");
                Console.WriteLine("| {0} | {1} | {2} |", map[i,0], map[i, 1], map[i, 2]);
                Console.WriteLine("|___|___|___|");
            }
        }
        static void playerMove2(string[,] map, int player)
        {
            int indexOfValue;
            string symbol = player == 1 ? "O" : "X";
            bool done=false;
            do
            {
                Console.WriteLine("Player {0}: Enter Your Field:", player);
                string input = Console.ReadLine();
                
                done= int.TryParse(input, out indexOfValue)&&map[(indexOfValue - 1) / 3, indexOfValue % 3 == 0 ? 2 : indexOfValue % 3 - 1] == indexOfValue.ToString();
            } while (!done);
            map[(indexOfValue-1) / 3, indexOfValue % 3 == 0 ? 2 : indexOfValue % 3-1] = symbol;
        }


        //static void playerMove(string[] map,int player)
        //{
        //    int indexOfValue;
        //    string symbol= player==1? "O":"X";
        //    do
        //    {
        //        Console.WriteLine("Player {0}: Enter Your Field:", player);
        //        string input = Console.ReadLine();
        //        indexOfValue = Array.IndexOf(map, input);
        //    } while (indexOfValue == -1);
        //    map[indexOfValue] = symbol;
        //}

        static bool checkWin(string[,] matrix)
        {
            string temp = "", temp2 = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                temp += matrix[i, i];
            }
            //Console.WriteLine(temp);
            //Console.WriteLine(checkLine(temp));
            if (checkLine(temp))
                return true;
            temp = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                temp += matrix[i, matrix.GetLength(0) - 1 - i];
            }
            //Console.WriteLine(temp);
            //Console.WriteLine(checkLine(temp));
            if (checkLine(temp))
                return true;
            temp = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    temp += matrix[i, j];
                    temp2 += matrix[j, i];
                }
                //Console.WriteLine(temp);
                //Console.WriteLine(checkLine(temp));
                if (checkLine(temp))
                    return true;
                //Console.WriteLine(temp2);
                //Console.WriteLine(checkLine(temp2));
                if (checkLine(temp2))
                    return true;
                temp = "";
                temp2 = "";
            }
            return false;
        }
        static bool checkLine(string line)
        {

            //return !(line.Contains("X")&&line.Contains("O")) && (line.Contains("X")|| line.Contains("O"));
            return line[0] == line[1] && line[1] == line[2];
        }
    }
}