using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_simulation_application
{
    public class ToyRobot : IRobot
    {
        private const int TableWidth = 5;
        private const int TableHeight = 5;

        private Position _currentPosition;
        private Direction _currentDirection;

        public ToyRobot()
        {
            _currentPosition = new Position(-1, -1);
        }

        public void Place(int x, int y, Direction direction)
        {
            if (IsValidPosition(x, y))
            {
                _currentPosition = new Position(x, y);
                _currentDirection = direction;
            }
        }

        public void Move()
        {
            Position newPosition = CalculateNewPosition();
            if (IsValidPosition(newPosition.X, newPosition.Y))
            {
                _currentPosition = newPosition;
            }
        }

        public void TurnLeft()
        {
            _currentDirection = (Direction)(((int)_currentDirection + 3) % 4);
        }

        public void TurnRight()
        {
            _currentDirection = (Direction)(((int)_currentDirection + 1) % 4);
        }

        public string Report()
        {
            return $"{_currentPosition.X},{_currentPosition.Y},{_currentDirection}";
        }

        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < TableWidth && y >= 0 && y < TableHeight;
        }

        private Position CalculateNewPosition()
        {
            int newX = _currentPosition.X;
            int newY = _currentPosition.Y;

            switch (_currentDirection)
            {
                case Direction.NORTH:
                    newY++;
                    break;
                case Direction.SOUTH:
                    newY--;
                    break;
                case Direction.EAST:
                    newX++;
                    break;
                case Direction.WEST:
                    newX--;
                    break;
            }

            return new Position(newX, newY);
        }
    }

}
