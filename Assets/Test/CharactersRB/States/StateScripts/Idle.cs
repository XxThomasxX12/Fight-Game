using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace group1
{
    [CreateAssetMenu(fileName = "New State", menuName = "Fightinggames/AbilityData/Idle")]
    public class Idle : StateData
    {
        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            animator.SetBool(TransitionsParameter.Jump.ToString(), false);
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            CharacterControl control = characterState.GetCharacterControl(animator);

            if (control.Attack)
            {
                animator.SetBool(TransitionsParameter.Attack.ToString(), true);
            }

            if (control.Jump)
            {
                animator.SetBool(TransitionsParameter.Jump.ToString(), true);
            }

            if (control.MoveRight)
            {
                animator.SetBool(TransitionsParameter.Move.ToString(), true);
            }

            if (control.MoveLeft)
            {
                animator.SetBool(TransitionsParameter.Move.ToString(), true);
            }
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
        
        }
    }
}

