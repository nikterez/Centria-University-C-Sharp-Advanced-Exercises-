using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_herds
{
    public interface IMovable
    {
        void Move(int dx, int dy);
    }
}