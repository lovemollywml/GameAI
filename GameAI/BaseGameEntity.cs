using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAI
{
     class BaseGameEntity
    {
         private int m_ID;
         private int m_iNextValidID;
         void SetID(int val)
         {
             m_ID = val;
         }
         public BaseGameEntity(int id)
         {
             SetID(id);
         }
         public virtual void Update()
         { 
            
         }
         public int ID
         {
             get { return m_ID; }
         }
    }
}
