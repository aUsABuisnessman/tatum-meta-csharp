using Tatum.CSharp.Core.Model;
using Tatum.CSharp.Harmony.Clients;

namespace Tatum.CSharp.Demo.ExampleServices.Harmony;

public class GenerateAddressExampleService
{
    private readonly IHarmonyClient _harmonyClient;

    public GenerateAddressExampleService(IHarmonyClient harmonyClient)
    {
        _harmonyClient = harmonyClient;
    }
    
    public GeneratedAddressEth GenerateAddress(string xpub, int index)
    {
        //xpub = "xpub from your wallet"
        //index = index of the address you would like to generate
        
        GeneratedAddressEth address = _harmonyClient.Local.GenerateAddress(xpub, index);
     
        return address;
    }
}