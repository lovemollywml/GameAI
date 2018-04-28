using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAI
{
    class VisitBankAndDepositGold:State<Miner>
    {
        private static VisitBankAndDepositGold instance;
        private VisitBankAndDepositGold()
        { }
        public  static VisitBankAndDepositGold Instance
        {
            get {
                if (instance == null)
                    instance = new VisitBankAndDepositGold();
                return instance;
            }
        }

        public void Enter(Miner miner)
        {
            if (miner.m_Location != LocationType.Bank)
            {
                Console.WriteLine(string.Format("Miner ID:{0} Walkin to the bank", miner.ID));
                miner.ChangeLocation(LocationType.Bank);
            }
        }

        public void Execute(Miner miner)
        {
            miner.MoneyInBank();
            miner.ChangeState(EnterMineAndDigForNugget.Instance);
        }

        public void Exit(Miner miner)
        {
            Console.WriteLine(string.Format("Miner ID:{0} leave  the bank", miner.ID));
        }
    }
}
