using AElf.Sdk.CSharp.State;

namespace AElf.Contracts.StackUpDAO
{
    // The state class is access the blockchain state
    public class StackUpDAOState : ContractState 
    {
        // A state that holds string value
        public StringState Message { get; set; }
    }
}