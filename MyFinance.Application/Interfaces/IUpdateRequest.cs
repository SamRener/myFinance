namespace MyFinance.Application;

public interface IUpdateRequest<in T> where  T : IDto
{
    void Handle(int id, T data);
}