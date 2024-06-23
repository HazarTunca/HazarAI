namespace BehaviourTree.Scripts.Nodes.Leaf
{
    public interface IBTCustomAction
    {
        public BTNode.NodeState Execute();
    }
    
    public class BTCustomActionLeaf : BTNode
    {
        public IBTCustomAction btAction;
        
        public override NodeState Execute()
        {
            return btAction.Execute();
        }
    }
}