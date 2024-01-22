using AElf.Cryptography.ECDSA;
using AElf.Testing.TestBase;

namespace AElf.Contracts.aelf_devcontainer_template
{
    // The Module class load the context required for unit testing
    public class Module : ContractTestModule<aelf_devcontainer_template>
    {
        
    }
    
    // The TestBase class inherit ContractTestBase class, it defines Stub classes and gets instances required for unit testing
    public class TestBase : ContractTestBase<Module>
    {
        // The Stub class for unit testing
        internal readonly aelf_devcontainer_templateContainer.aelf_devcontainer_templateStub aelf_devcontainer_templateStub;
        // A key pair that can be used to interact with the contract instance
        private ECKeyPair DefaultKeyPair => Accounts[0].KeyPair;

        public TestBase()
        {
            aelf_devcontainer_templateStub = Getaelf_devcontainer_templateContractStub(DefaultKeyPair);
        }

        private aelf_devcontainer_templateContainer.aelf_devcontainer_templateStub Getaelf_devcontainer_templateContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<aelf_devcontainer_templateContainer.aelf_devcontainer_templateStub>(ContractAddress, senderKeyPair);
        }
    }
    
}