using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace group1
{
    public class AttackManager : Singleton<AttackManager>
    {
        public List<AttackInfo> CurrentAttacks = new List<AttackInfo>();
    }
}


