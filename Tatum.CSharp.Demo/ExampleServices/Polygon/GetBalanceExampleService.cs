using System.Threading.Tasks;
using Tatum.CSharp.Polygon.Clients;
using Tatum.CSharp.Polygon.Core.Model;

namespace Tatum.CSharp.Demo.ExampleServices.Polygon;

public class GetBalanceExampleService
{
    private readonly IPolygonClient _polygonClient;

    public GetBalanceExampleService(IPolygonClient polygonClient)
    {
        _polygonClient = polygonClient;
    }
    
    public async Task<MaticBalance> GetBalance(string address)
    {
        MaticBalance balance = await _polygonClient.PolygonBlockchain.PolygonGetBalanceAsync(address);
        
        return balance;
    }
}