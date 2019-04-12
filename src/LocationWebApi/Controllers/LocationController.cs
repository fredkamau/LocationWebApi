using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LocationDataAccess;

namespace LocationWebApi.Controllers
{
    public class LocationController : ApiController
    {
        public IEnumerable<safaricom_regions> Get()
        {
            using (LocationDBEntities entities = new LocationDBEntities())
            {
                return entities.safaricom_regions.ToList();
            }
        }

    }
}
