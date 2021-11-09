using MarsRover.Action;
using MarsRover.Model;
using System;

namespace MarsRover.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageMars m = new ManageMars();
            m.CreateMap(4);
            Posizione p = new Posizione();
            var random = new Random();

            p.X = random.Next(0,3);
            p.Y = random.Next(0,3);

            Rover r = new Rover(p, 'S');
            m.AddRover(r);

            StampaMappa(m.MapMars, r);

            ActionRover rotateL = new RotateLeft();
            ActionRover rotateR = new RotateRight();
            ActionRover movement = new MoveMarsRover();
            rotateL.SetSuccessor(rotateR);
            rotateR.SetSuccessor(movement);
            Posizione vecchiaposizione = r.Position; 
            Rover nuovo = rotateL.GetAction(m.MapMars, r, 'F');
            MappaMarte m2 = UpdateMarsMaps.UpdateMappa(m.MapMars, vecchiaposizione, nuovo.Position);
            
            StampaMappa(m2, r);


        }

        private static void StampaMappa(MappaMarte m, Rover r)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (m.list_position[i, j])
                    {
                        Console.Write(" - ");
                    }
                    else
                    {
                        Console.Write(" X ");
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine($"{r.Position.X+1} {r.Position.Y+1} {r.Direction}");
        }
    }
}
