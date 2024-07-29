using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace group1
{
    [CreateAssetMenu(fileName = "New State", menuName = "Fightinggames/AbilityData/ForceTransition")]
    public class ForceTransition : StateData
    {
        [Range(0.01f, 1f)]
        public float TransitionTiming;


        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            if (stateInfo.normalizedTime >= TransitionTiming)
            {
                animator.SetBool(TransitionsParameter.ForceTransition.ToString(), true);
            }
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            animator.SetBool(TransitionsParameter.ForceTransition.ToString(), false);
        }
    }
}
