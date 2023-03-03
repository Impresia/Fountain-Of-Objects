


namespace Krazana.Game
{

    using Krazana.Colorize;
    using Krazana.Fountain;

    public class Game
    {



        public int _row { get; set; }
        public int _col { get; set; }

        public Game()
        {
            _row = 0;
            _col = 0;


        }


        public void move(string direction)
        {
            if (direction == "move north" && _row > 0)
            {
                _row--;
            }
            else if (direction == "move south" && _row < 3)
            {
                _row++;
            }
            else if (direction == "move west" && _col > 0)
            {
                _col--;
            }
            else if (direction == "move east" && _col < 3)
            {
                _col++;
            }
            else
            {
                Colorize.Coloring("can't go that path!", ConsoleColor.Red);
            }

        }

       

        public static void Run()
        {   
            Game room = new Game();

            Console.WriteLine($"you are in the room at (row={room._row} column= {room._col}).");

            Colorize.Coloring("You see light coming from the cavern entrance", ConsoleColor.Yellow);

            Colorize.Coloring2("what you want to do?", ConsoleColor.White);

            Console.ForegroundColor = ConsoleColor.Cyan;
            string? answer = Console.ReadLine();

            
            Colorize.Coloring("---------------------------------------------------------------------------------------------------", ConsoleColor.White);

            Fountain fountain = Fountain.disabled;


            while (true)
            {
                if ((room._row != 0 || room._col != 2) && answer == "enable fountain")
                {
                    Console.WriteLine("Command has no effect in this area!");
                    Colorize.Coloring2("what you want to do?", ConsoleColor.White);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    answer = Console.ReadLine();
                   
                    Colorize.Coloring("---------------------------------------------------------------------------------------------------", ConsoleColor.White);
                }



                if (answer == "move east")
                {
                    room.move(answer);

                }
                else if (answer == "move south")
                {
                    room.move(answer);

                }
                else if (answer == "move west")
                {
                    room.move(answer);

                }
                else if (answer == "move north")
                {
                    room.move(answer);

                }
                else
                    Colorize.Coloring("Invalid action, try again!", ConsoleColor.Red);


                if (fountain == Fountain.enabled && room._row == 0 && room._col == 0)
                {
                    Console.WriteLine($"you are in room at (row={room._row} column={room._col}).");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!");
                    Console.WriteLine("You are winner!");
                    break;


                }


                Console.WriteLine($"you are in room at (row={room._row} column={room._col}).");





                if (room._row == 0 && room._col == 2 && fountain == Fountain.disabled)
                {
              
                    Colorize.Coloring("You hear water dripping in this room. The Fountain of Objects is here!", ConsoleColor.Blue);
                }
                
                else if (room._row == 0 && room._col == 2 && fountain == Fountain.enabled)
                {
                    
                    Colorize.Coloring("You hear the rushing waters from the Fountain of Objects. It has been reactivated!", ConsoleColor.Blue);
                }


                Colorize.Coloring2("what do you want to do?", ConsoleColor.White);
                Console.ForegroundColor = ConsoleColor.Cyan;
                answer = Console.ReadLine();






                if (room._row == 0 && room._col == 2 && answer == "enable fountain")
                {
                    Colorize.Coloring("---------------------------------------------------------------------------------------------------", ConsoleColor.White);
                   
                    fountain = Fountain.enabled;
                    Console.WriteLine($"you are in room at (row={room._row} column={room._col}).");
                    
                    Colorize.Coloring("You hear the rushing waters from the Fountain of Objects. It has been reactivated!", ConsoleColor.Blue);

                    Colorize.Coloring2("what you want to do?", ConsoleColor.White);
                    
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    answer = Console.ReadLine();


                }

                Colorize.Coloring("---------------------------------------------------------------------------------------------------", ConsoleColor.White);
            }







        }






















    }
}