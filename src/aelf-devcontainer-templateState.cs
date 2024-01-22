using AElf.Sdk.CSharp.State;

namespace AElf.Contracts.aelf_devcontainer_template
{
    // The state class is access the blockchain state
    public class aelf_devcontainer_templateState : ContractState 
    {
        // A state that holds string value
        public StringState Message { get; set; }
    }
}