using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Action
{
    public class NextPosition
    {
        public static Posizione NextOne(MappaMarte mappa, Rover rover , char tipo)
        {
            if(tipo == 'F')
            {
                Posizione finale = new Posizione(); 
                int dimensioneMappa = Convert.ToInt32(Math.Sqrt(mappa.list_position.Length));

                switch (rover.Direction)
                {
                    case 'N':
                        if(rover.Position.Y - 1 > 0)
                        {
                            finale.X = rover.Position.X;
                            finale.Y = rover.Position.Y - 1; 
                            break; 
                        }
                        else
                        {
                            finale.X = rover.Position.X;
                            finale.Y = dimensioneMappa - 1 ;
                            break; 
                        }
                    case 'S':
                        if (rover.Position.X + 1 >= dimensioneMappa)
                        {
                            finale.X = rover.Position.X;
                            finale.Y = 0;
                            break;
                        }
                        else
                        {
                            finale.X = rover.Position.X; 
                            finale.Y = rover.Position.Y+1;
                            break;
                        }
                    case 'O':
                        if (rover.Position.X - 1 < 0)
                        {
                            finale.X = dimensioneMappa - 1;
                            finale.Y = rover.Position.Y;
                            break;
                        }
                        else
                        {
                            finale.X = rover.Position.X - 1;
                            finale.Y = rover.Position.Y;
                            break;
                        }
                    case 'E':
                        if (rover.Position.Y + 1 >= dimensioneMappa)
                        {
                            finale.X = 0;
                            finale.Y = rover.Position.Y;
                            break;
                        }
                        else
                        {
                            finale.X = rover.Position.X+1;
                            finale.Y = rover.Position.Y;
                            break;
                        }
                }
                return finale; 
                
            }

            if(tipo == 'B')
            {
                Posizione finale = new Posizione();
                int dimensioneMappa = Convert.ToInt32(Math.Sqrt(mappa.list_position.Length));

                switch (rover.Direction)
                {
                    case 'N': 
                        if(rover.Position.Y +1 >= dimensioneMappa)
                        {
                            finale.Y = 0;
                            finale.X = rover.Position.X;
                            break;
                        }
                        else
                        {
                            finale.Y = rover.Position.Y+1;
                            finale.X = rover.Position.X;
                            break; 
                        }
                    case 'S':
                        if(rover.Position.Y -1 < 0)
                        {
                            finale.Y = dimensioneMappa - 1;
                            finale.X = rover.Position.X;
                            break; 
                        }
                        else
                        {
                            finale.Y = rover.Position.Y - 1; 
                            finale.X = rover.Position.X;
                            break; 
                        }

                    case 'O':
                        if(rover.Position.X +1 >= dimensioneMappa)
                        {
                            finale.X = 0;
                            finale.Y = rover.Position.Y;
                            break;
                        }
                        else
                        {
                            finale.X = rover.Position.X + 1;
                            finale.Y = rover.Position.Y;
                            break;
                        }
                    case 'E':
                        if(rover.Position.X -1 < 0)
                        {
                            finale.Y = rover.Position.Y;
                            finale.X = dimensioneMappa - 1;
                            break; 
                        }
                        else
                        {
                            finale.Y = rover.Position.Y;
                            finale.X = rover.Position.X - 1;
                            break;
                        }
                }
                return finale; 
            }

            return null; 
        }
    }
}
