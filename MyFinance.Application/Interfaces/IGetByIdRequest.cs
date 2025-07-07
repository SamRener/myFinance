namespace MyFinance.Application;

public interface IGetByIdRequest<out T> where  T : IDto
{
    T Handle(int id);
}