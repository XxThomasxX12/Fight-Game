using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace group1
{
    [CreateAssetMenu(fileName = "New State", menuName = "Fightinggames/AbilityData/Landing")]
    public class Landing : StateData
    {
        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            animator.SetBool(TransitionsParameter.Jump.ToString(), false);
            animator.SetBool(TransitionsParameter.Move.ToString(), false);
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

        }
    }
}
