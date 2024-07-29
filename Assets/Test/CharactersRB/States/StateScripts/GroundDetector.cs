using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace group1
{
    [CreateAssetMenu(fileName = "New State", menuName = "Fightinggames/AbilityData/GroundDetector")]
    public class GroundDetector : StateData
    {
        [Range(0.01f, 1f)]
        public float CheckTime;
        public float Distance;

        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            CharacterControl control = characterState.GetCharacterControl(animator);

            if (stateInfo.normalizedTime >= CheckTime)
            {
                if (IsGrounded(control))
                {
                    animator.SetBool(TransitionsParameter.Grounded.ToString(), true);
                }
                else
                {
                    animator.SetBool(TransitionsParameter.Grounded.ToString(), false);
                }
            }

        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

        }

        bool IsGrounded(CharacterControl control)
        {
            if (control.RIGID_BODY.velocity.y > -0.001f && control.RIGID_BODY.velocity.y <= 0)
            {
                return true;
            }

            if (control.RIGID_BODY.velocity.y < 0f)
            {
                foreach (GameObject o in control.BottomSpheres)
                {
                    RaycastHit hit;
                    if (Physics.Raycast(o.transform.position, -Vector3.up, out hit, Distance))
                    {
                        if (!control.RagdollParts.Contains(hit.collider))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
