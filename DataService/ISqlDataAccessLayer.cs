namespace Product.Order.DataService;

public interface ISqlDataAccessLayer
{
    Task <IEnumerable<T>> LoadData <T, U>(string storeProcedure, U parameters, string connectionId ="DefaultConnection");
    Task SaveData<T>(string storeProcedure, T parameters, string connectionId = "DefaultConnection");
}
