using System;
using AracYonetim.Entities.Models;

namespace AracYonetim.BLL.Repository
{
    public class MarkaRepo : RepositoryBase<Marka, int> { }

    public class AracRepo : RepositoryBase<Arac, Guid>
    {
        //ekstra method yazılması gerekiyorsa her sınıfın içersine tanımlanmalıdır!
    }
}
