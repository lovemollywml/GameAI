using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAI
{
    class Miner:BaseGameEntity
    {
        public State<Miner> m_currentState;
        public LocationType m_Location;
        int m_iGoldCarried;
        int m_iMoneyInBank;
        int m_iThirst;
        int m_iFatigue;

        private int PacketMaxNum = 5;
        public Miner(int ID)
            : base(ID)
        { }
        public void Update()
        {
            m_iThirst++;
            if (m_currentState!=null)
            {
                m_currentState.Execute(this);
            }
        }
        public void ChangeState(State<Miner> newState)
        {
            m_currentState.Exit(this);
            m_currentState = newState;
            m_currentState.Enter(this);
        }
        public void ChangeLocation(LocationType locationType)
        {
            this.m_Location = locationType;
        }
        public void AddToGoldCarried(int num)
        {
            m_iGoldCarried += num;
        }
        public void IncreaseFatigue()
        {
            m_iFatigue++;
        }
        public bool PoeketsFull()
        {
            return m_iGoldCarried == PacketMaxNum;
        }
        public bool Thirsty()
        {
            return m_iThirst == 10;
        }
        public void MoneyInBank()
        {
            var num = m_iGoldCarried / PacketMaxNum;
            m_iMoneyInBank += num;
            m_iGoldCarried -= num * PacketMaxNum;
        }
    }
}
