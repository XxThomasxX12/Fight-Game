using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace group1
{
    public class DamageDetector : MonoBehaviour
    {
        CharacterControl control;
        public BoxCollider firstCollider;

        private void Awake()
        {
            control = GetComponent<CharacterControl>();
        }

        private void Update()
        {
            if (AttackManager.Instance.CurrentAttacks.Count > 0)
            {
                CheckAttack();
            }
        }

        private void CheckAttack()
        {
            foreach(AttackInfo info in AttackManager.Instance.CurrentAttacks)
            {
                if (info == null)
                {
                    continue;
                }

                if (!info.isRegistered)
                {
                    continue;
                }

                if (info.isFinished)
                {
                    continue;
                }

                if (info.CurrentHits >= info.MaxHits)
                {
                    continue;
                }

                if (info.Attacker == control)
                {
                    continue;
                }

                if (info.MustCollide)
                {
                    if (IsCollided(info))
                    {
                        TakeDamage(info);
                    }
                }
            }
        }

        private bool IsCollided(AttackInfo info)
        {
            foreach(Collider collider in control.CollidingParts)
            {
                foreach(string name in info.ColliderNames)
                {
                    if (name == collider.gameObject.name)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

        private void TakeDamage(AttackInfo info)
        {
            Debug.Log(info.Attacker.gameObject.name + " hits: " + this.gameObject.name);
            control.SkinnedMeshAnimator.runtimeAnimatorController = info.AttackAbility.GetDeathAnimator();
            info.CurrentHits++;

            control.GetComponent<BoxCollider>().enabled = false;
            control.RIGID_BODY.useGravity = false;
            firstCollider.GetComponent<BoxCollider>().enabled = false;
            Punkte.scoreCount += 1;

        }
    }
}


