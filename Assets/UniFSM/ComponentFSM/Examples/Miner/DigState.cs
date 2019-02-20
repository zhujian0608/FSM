using UnityEngine;
using UniFSM.ComponentBased;
using System;

namespace Miner {
    public class DigState : StateBase {
        public override void Enter(IAgent agent) {
            Debug.Log("DigState EnterD");
        }

        public override void Execute(IAgent agent) {
            Debug.Log("DigState ExecD");
        }

        public override void Exit(IAgent agent) {
            Debug.Log("DigState ExitD");
        }
    }
}
