using Microsoft.AspNetCore.Mvc.Filters;

namespace eHospitalServer.WebAPI;

public class FurkanAuthorize : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        throw new NotImplementedException();
    }
}
