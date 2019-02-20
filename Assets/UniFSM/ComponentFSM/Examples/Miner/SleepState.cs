using UnityEngine;
using UniFSM.ComponentBased;

namespace Miner {
    public class SleepState : StateBase {
        public override void Enter(IAgent agent) {
            Debug.Log("SleepState EnterS");
        }

        public override void Execute(IAgent agent) {
            Debug.Log("SleepState ExecS");
        }

        public override void Exit(IAgent agent) {
            Debug.Log("SleepState ExitS");
        }
    }
}
