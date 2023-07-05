using LIbreriaComponentiBlazor.Models;

namespace LIbreriaComponentiBlazor.Interfaces;

public interface IReqResService
{
    Task<ReqResData?> GetData();
    void CancelRequest();
    Task<ReqResNewUserResponse?> PostNewUser(ReqResNewUser newUser);    
}
