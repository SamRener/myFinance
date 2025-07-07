namespace MyFinance.Application;

public interface IGetRequest<out T> where  T : IDto
{
    IEnumerable<T> Handle();
}