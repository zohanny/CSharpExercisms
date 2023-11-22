﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    class QuestLogic
    {
        public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;
     

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
            => (knightIsAwake || archerIsAwake || prisonerIsAwake) ? true : false;


        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
            => (!archerIsAwake && prisonerIsAwake) ? true : false;

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            bool res;
            if (petDogIsPresent)
                res = !archerIsAwake;
            else
                res = (!knightIsAwake && !archerIsAwake && prisonerIsAwake);
            return res;
        }
    }
}
