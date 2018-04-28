using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAI
{
    class EnterMineAndDigForNugget:State<Miner>
    {
        private static EnterMineAndDigForNugget instance;
        public static EnterMineAndDigForNugget Instance
        {
            get {
                if (instance == null)
                    instance = new EnterMineAndDigForNugget();
                return instance;
            }
        
        }
        private EnterMineAndDigForNugget()
        { 
            
        }


        public void Enter(Miner miner)
        {
            if (miner.m_Location != LocationType.Mine)
            {
                Console.WriteLine(string.Format("Miner ID:{0} Walkin to the gold mine",miner.ID));
                miner.ChangeLocation(LocationType.Mine);
            }
        }

        public void Execute(Miner miner)
        {
            miner.AddToGoldCarried(1);
            miner.IncreaseFatigue();
            if (miner.PoeketsFull())
            {
                miner.ChangeState(VisitBankAndDepositGold.Instance);
            }

            if (miner.Thirsty())
            { 
                
            }
        }

        public void Exit(Miner miner)
        {
            Console.WriteLine(string.Format("Miner ID:{0} leave  the gold mine", miner.ID));
        }
    }
}
