using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAI
{
   public interface State<T> where T:class
    {
       void Enter(T miner);
       void Execute(T miner);
       void Exit(T miner);
    }
}
