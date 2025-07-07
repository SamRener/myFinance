namespace MyFinance.Application;

public interface IDeleteRequest<out T> where  T : IDto
{
    void Handle(int id);
}