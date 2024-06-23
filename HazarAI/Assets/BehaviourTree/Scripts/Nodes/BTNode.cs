namespace BehaviourTree.Scripts.Nodes
{
    public abstract class BTNode
    {
        public enum NodeState
        {
            Running, Success, Failure
        }
        public NodeState nodeState;
        
        public abstract NodeState Execute();
    }
}