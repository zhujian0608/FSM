using UnityEngine;
using UniFSM.ComponentBased;

namespace Miner {
    public class GlobalState : StateBase {
        public override void Enter(IAgent agent) {
            Debug.Log("GlobalState EnterG");
        }

        public override void Execute(IAgent agent) {
            Debug.Log("GlobalState ExecG");
        }

        public override void Exit(IAgent agent) {
            Debug.Log("GlobalState ExitG");
        }
    }

}
