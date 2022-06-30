using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.My_Scripts.Interfaces
{
    interface IActions
    {   
        public void AnimationsMotion();
        public void AnimationsCrouch();
        public void AnimationsJump();

        public void JumpUp();
        public void HeavyMove();
        public void HeavyReaction();
        public void FlipUp();
        public void FlipBack();
        public void IdleSpeed();
        public void ResetTime();

     
        
    }
}
