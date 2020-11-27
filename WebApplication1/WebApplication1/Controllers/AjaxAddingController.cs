using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class AjaxAddingController
    {
        [ApiController]
        [Route("api/Ajax")]
        public class AjaxAddingController : ControllerBase
        {
            public ItemModel Post(ItemModel item)
            {
                var receivedObject = new ItemModel()
                {
                    Name = item.Name,
                    Description = item.Description,
                    IsVisible = item.IsVisible
                };

                return receivedObject;
            }
        }
    }
}
        

