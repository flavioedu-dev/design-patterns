namespace DesignPatterns.GoF.Creationals.AbstractFactory;

public class MySqlUserDAO() : UserDAO
{
    public string Get()
    {
        return "Obtendo usuário pelo MySql.";
    }

    public string Save()
    {
        return "Salvando usuário pelo MySql.";
    }
}

public class SqlServerUserDAO() : UserDAO
{
    public string Get()
    {
        return "Obtendo usuário pelo SqlServer.";
    }

    public string Save()
    {
        return "Salvando usuário pelo SqlServer.";
    }
}

public class MongoUserDAO() : UserDAO
{
    public string Get()
    {
        return "Obtendo usuário pelo Mongo.";
    }

    public string Save()
    {
        return "Salvando usuário pelo Mongo.";
    }
}