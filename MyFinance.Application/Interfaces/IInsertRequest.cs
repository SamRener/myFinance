namespace MyFinance.Application;

public interface IInsertRequest<in T> where  T : IDto
{
    void Handle(T data);
}