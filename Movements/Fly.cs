using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Movements
{
    public class Fly : IMovementType
    {
        bool _ignore_walls = true;
        public bool Ignore_Walls()
        {
            return _ignore_walls;
        }
        float _speed = 25;
        public float MovemntSpeed()
        {
            return _speed;
        }
    }
}
