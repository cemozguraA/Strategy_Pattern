using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Monster
    {
        IMovementType _movementType;
        float _speed = 10;
        float _health = 100;
        float _armor = 25;
        bool _ignoreWalls;
        public float Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }
        public float Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }
        public float Armor
        {
            get
            {
                return _armor;
            }
            set
            {
                _armor = value;
            }
        }
        public bool IgnoreWalls
        {
            get
            {
                return _ignoreWalls;
            }
            set
            {
                _ignoreWalls = value;
            }
        }
        public IMovementType MovementType
        {
            get
            {
                return _movementType;
            }
            set
            {
                _movementType = value;
                Speed = value.MovemntSpeed();
                IgnoreWalls = value.Ignore_Walls();
                Console.WriteLine("Monster Speed : " + Speed);
                Console.WriteLine("Monster can ignore walls? : " + IgnoreWalls);
            }
        }
        public void setMovemntType(IMovementType movementType)
        {
            MovementType = movementType;
        }

    }
}
