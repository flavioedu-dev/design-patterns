namespace DesignPatterns.GoF.Creationals.AbstractFactory;

public interface UserDAO
{
    string Get();
    string Save();
}

public interface DAOFactory
{
    UserDAO CreateUserDAO { get; }

    public static DAOFactory? SetFactory(string dbType)
    {
        return dbType.ToLower() switch
        {
            "mysql" => new MySqlDAO(),
            "sqlserver" => new SqlServerDAO(),
            "mongo" => new MongoDAO(),
            _ => null
        };
    }
}

public class MySqlDAO() : DAOFactory
{
    public UserDAO CreateUserDAO => new MySqlUserDAO();
}

public class SqlServerDAO() : DAOFactory
{
    public UserDAO CreateUserDAO => new SqlServerUserDAO();
}

public class MongoDAO() : DAOFactory
{
    public UserDAO CreateUserDAO => new MongoUserDAO();
}