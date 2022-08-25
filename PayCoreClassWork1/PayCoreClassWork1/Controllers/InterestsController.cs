/*---------------------*/
/* Made By The Greamer */
/*---------------------*/

using Microsoft.AspNetCore.Mvc;
using PayCoreClassWork1.Classes; // Faiz sınıfına ulaşabilmek için gerekli tanımlama.

namespace PayCoreClassWork1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestsController : ControllerBase
    {
        // Basit ve bileşik faiz hesabı yapan metod. Ödevden farklı olarak bakiye, faiz oranı ve vade yılı parametrelerinin yanında ekstra olarak 4. parametre bulunmaktadır. Bu parametre faiz türüdür ve varsayılan değeri basit faizdir.
        [HttpGet("GetInterest")]
        public Interest GetInterest(double balance, double rate, int expiration, InterestType interestType = InterestType.Simple)
        {
            double totalBalance = interestType == InterestType.Simple // Eğer parametreden gelen faiz tipi basit faiz ise,
                                ? balance * (1 + expiration * rate) // Vade sonu toplam bakiye değeri basit faiz formülüne göre hesaplanır.
                                : balance * Math.Pow(1.0 + rate, expiration); // Ancak parametreden gelen faiz tipi bileşik faiz ise, vade sonu toplam bakiye değeri bileşik faiz formülüne göre hesaplanır.

            return new Interest(totalBalance, rate); // Cevap olarak faiz sınıfına ait vade sonu bakiye ve faiz oranı döndürülür.
        }
    }
}