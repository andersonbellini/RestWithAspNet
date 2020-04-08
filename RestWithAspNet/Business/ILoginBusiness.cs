using RestWithAspNet.Model;

namespace RestWithAspNet.Business
{
    public interface ILoginBusiness
    {
        object FindByLogin(UserVO user);
    }
}
